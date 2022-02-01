using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Media;

namespace Fenced
{
    public partial class MainForm : Form
    {
        struct Area
        {
            public int nOccupant;
            public PictureBox pb;
        };

        int nBoardWidth = 0;
        int nBoardHeight = 0;

        int nPlayerTurn = 0;

        int nPlayer1Count = -1;
        int nPlayer2Count = -1;

        bool bFillBorder = true;

        string strNamePlayer1 = "";
        string strNamePlayer2 = "";

        Color cPlayer1 = new Color();
        Color cPlayer2 = new Color();

        List<Tuple<Point, Point>> listEdge;
        Area[,] mapArea;

        SoundPlayer spLine, spArea;

        public MainForm()
        {
            listEdge = new List<Tuple<Point, Point>>();

            spLine = new SoundPlayer(Properties.Resources.sfxDrewLine);
            spArea = new SoundPlayer(Properties.Resources.sfxFilledArea);

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadGame();
        }

        void LoadGame()
        {
            StartForm startForm;

            if (strNamePlayer1 != "" && strNamePlayer2 != "")
            {
                startForm = new StartForm(nBoardWidth, nBoardHeight, bFillBorder, strNamePlayer1, strNamePlayer2, cPlayer1, cPlayer2);
            }
            else
            {
                startForm = new StartForm();
            }

            if (startForm.ShowDialog() == DialogResult.OK)
            {
                nBoardWidth = startForm.boardWidth;
                nBoardHeight = startForm.boardHeight;
                bFillBorder = startForm.fillBorder;

                strNamePlayer1 = startForm.namePlayer1;
                strNamePlayer2 = startForm.namePlayer2;

                cPlayer1 = startForm.colorPlayer1;
                cPlayer2 = startForm.colorPlayer2;

                nPlayerTurn = (startForm.firstPlayer == 1 ? 2 : 1);
                ChangeTurn();
            }
            else
            {
                this.Close();
            }

            Init();
        }

        void ChangeTurn()
        {
            if (nPlayerTurn == 1)
            {
                nPlayerTurn = 2;
                labelPlayer1.Font = new Font(Label.DefaultFont, FontStyle.Regular);
                labelPlayer2.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            }
            else
            {
                nPlayerTurn = 1;
                labelPlayer1.Font = new Font(Label.DefaultFont, FontStyle.Bold);
                labelPlayer2.Font = new Font(Label.DefaultFont, FontStyle.Regular);
            }
        }

        void Init()
        {
            this.Size = new Size(8+(48 * nBoardWidth), 52 + 16 + 24 + (48 * nBoardHeight));

            mapArea = new Area[nBoardHeight - 1, nBoardWidth - 1];
            for (int row = 0; row < nBoardHeight - 1; row++)
            {
                for (int col = 0; col < nBoardWidth - 1; col++)
                {
                    mapArea[row, col].nOccupant = 0;
                }
            }

            listEdge.Clear();

            nPlayer1Count = 0;
            nPlayer2Count = 0;
            DrawPlayerScore();

            labelPlayer1.ForeColor = cPlayer1;
            labelPlayer1.BackColor = GetBrightness(cPlayer1) > 130 ? Color.Black : Color.White;
            labelPlayer2.ForeColor = cPlayer2;
            labelPlayer2.BackColor = GetBrightness(cPlayer2) > 130 ? Color.Black : Color.White;

            List<Control> listControls = new List<Control>();
            foreach (Control c in Controls)
            {
                if (c.Name.Contains("pictureBox"))
                    listControls.Add(c);
            }

            foreach (Control c in listControls)
                this.Controls.Remove(c);

            for (int row = 0; row < nBoardHeight; row++)
            {
                for (int col = 0; col < nBoardWidth; col++)
                {
                    PictureBox pb = new PictureBox()
                    {
                        Name = $"pictureBox_Dot_{row}_{col}",
                        Image = Properties.Resources.imgDot,
                        Location = new Point(15 + (48 * col), 52 + (48 * row)),
                        Size = new Size(10, 10)
                    };
                    this.Controls.Add(pb);
                }
            }

            for (int row = 0; row < nBoardHeight; row++)
            {
                for (int col = 0; col < nBoardWidth - 1; col++)
                {
                    PictureBox pb = new PictureBox()
                    {
                        Name = $"pictureBox_LineHR_{row}_{col}",
                        Image = Properties.Resources.imgLineHR,
                        Location = new Point(26 + (48 * col), 55 + (48 * row)),
                        Size = new Size(36, 10)
                    };
                    pb.Click += LineClicked;

                    if (bFillBorder && (row == 0 || row == nBoardHeight - 1))
                    {
                        pb.Image = Properties.Resources.imgLineClickedHR;
                        pb.Enabled = false;
                        listEdge.Add(new Tuple<Point, Point>(new Point(col, row), new Point(col + 1, row)));
                    }

                    this.Controls.Add(pb);
                }
            }

            for (int row = 0; row < nBoardHeight - 1; row++)
            {
                for (int col = 0; col < nBoardWidth; col++)
                {
                    PictureBox pb = new PictureBox()
                    {
                        Name = $"pictureBox_LineVR_{row}_{col}",
                        Image = Properties.Resources.imgLineVR,
                        Location = new Point(18 + (48 * col), 63 + (48 * row)),
                        Size = new Size(10, 36)
                    };
                    pb.Click += LineClicked;

                    if (bFillBorder && (col == 0 || col == nBoardWidth - 1))
                    {
                        pb.Image = Properties.Resources.imgLineClickedVR;
                        pb.Enabled = false;
                        listEdge.Add(new Tuple<Point, Point>(new Point(col, row), new Point(col, row + 1)));
                    }

                    this.Controls.Add(pb);
                }
            }
        }

        int GetBrightness(Color c)
        {
            return (int)Math.Sqrt(c.R * c.R * 0.241 + c.G * c.G * 0.691 + c.B * c.B * 0.068);
        }

        private void labelPlayer1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                cPlayer1 = colorDialog.Color;
                labelPlayer1.ForeColor = cPlayer1;
                labelPlayer1.BackColor = GetBrightness(cPlayer1) > 130 ? Color.Black : Color.White;
                SetAreaColor();
            }
        }

        private void labelPlayer2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                cPlayer2 = colorDialog.Color;
                labelPlayer2.ForeColor = cPlayer2;
                labelPlayer2.BackColor = GetBrightness(cPlayer2) > 130 ? Color.Black : Color.White;
                SetAreaColor();
            }
        }

        void LineClicked(object sender, EventArgs e)
        {
            bool bFilled = false;

            PictureBox pictureBox = (PictureBox)sender;

            string[] split = pictureBox.Name.Split('_');
            int row = -1, col = -1;
            int.TryParse(split[2], out row);
            int.TryParse(split[3], out col);

            if (row == -1 || col == -1)
            {
                return;
            }

            if (pictureBox.Name.Contains("HR"))
            {
                pictureBox.Image = Properties.Resources.imgLineClickedHR;

                listEdge.Add(new Tuple<Point, Point>(new Point(col, row), new Point(col + 1, row)));
            }
            else if (pictureBox.Name.Contains("VR"))
            {
                pictureBox.Image = Properties.Resources.imgLineClickedVR;

                listEdge.Add(new Tuple<Point, Point>(new Point(col, row), new Point(col, row + 1)));
            }

            ((PictureBox)sender).Enabled = false;
            spLine.Play();

            // Check
            for (row = 0; row < nBoardHeight - 1; row++)
            {
                for (col = 0; col < nBoardWidth - 1; col++)
                {
                    if (mapArea[row, col].nOccupant == 0)
                    {
                        List<Tuple<Point, Point>> tmp = new List<Tuple<Point, Point>>();

                        foreach (Tuple<Point, Point> edge in listEdge)
                        {
                            if ((edge.Item1.X == col && edge.Item1.Y == row) || (edge.Item2.X == col + 1 && edge.Item2.Y == row + 1))
                            {
                                tmp.Add(edge);
                            }
                        }

                        if (tmp.Count >= 4)
                        {
                            bFilled = true;

                            mapArea[row, col].nOccupant = nPlayerTurn;
                            mapArea[row, col].pb = new PictureBox()
                            {
                                Name = $"pictureBox_Occured_{row}_{col}",
                                BorderStyle = BorderStyle.FixedSingle,
                                Location = new Point(24 + (48 * col), 61 + (48 * row)),
                                Size = new Size(40, 40)
                            };

                            this.Controls.Add(mapArea[row, col].pb);
                            spArea.Play();

                            SetAreaColor();
                        }
                    }
                }
            }

            if (!bFilled)
                ChangeTurn();
        }

        void SetAreaColor()
        {
            nPlayer1Count = nPlayer2Count = 0;

            for (int row = 0; row < nBoardHeight - 1; row++)
            {
                for (int col = 0; col < nBoardWidth - 1; col++)
                {
                    if (mapArea[row, col].nOccupant == 1)
                    {
                        nPlayer1Count++;

                        mapArea[row, col].pb.BackColor = cPlayer1;
                        mapArea[row, col].pb.BringToFront();
                    }
                    else if (mapArea[row, col].nOccupant == 2)
                    {
                        nPlayer2Count++;

                        mapArea[row, col].pb.BackColor = cPlayer2;
                        mapArea[row, col].pb.BringToFront();
                    }
                }
            }

            DrawPlayerScore();

            if (nPlayer1Count + nPlayer2Count >= (nBoardHeight - 1) * (nBoardWidth - 1))
                GameOver();
        }

        void DrawPlayerScore()
        {
            labelPlayer1.Text = $"● {strNamePlayer1} ({nPlayer1Count})";
            labelPlayer2.Text = $"● {strNamePlayer2} ({nPlayer2Count})";
        }

        void GameOver()
        {
            DialogResult result;

            SoundPlayer sp = new SoundPlayer(Properties.Resources.sfxGameOver);
            sp.Play();

            if (nPlayer1Count > nPlayer2Count)
            {
                result = MessageBox.Show($"{strNamePlayer1}이(가) 승리하였습니다!\n다시 플레이하시겠습니까?", "게임 오버", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            else if (nPlayer2Count > nPlayer1Count)
            {
                result = MessageBox.Show($"{strNamePlayer1}이(가) 승리하였습니다!\n다시 플레이하시겠습니까?", "게임 오버", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            else
            {
                result = MessageBox.Show("비겼습니다!\n다시 플레이하시겠습니까?", "게임 오버", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }

            if (result == DialogResult.Yes)
            {
                LoadGame();
            }
            else
            {
                this.Close();
            }
        }
    }
}
