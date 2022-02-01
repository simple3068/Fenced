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

        int nBoardWidth;
        int nBoardHeight;

        int nPlayerTurn;

        int nPlayer1Count;
        int nPlayer2Count;

        bool bFillBorder;

        List<Tuple<Point, Point>> listEdge;
        Area[,] mapArea;

        SoundPlayer spLine, spArea;

        public MainForm()
        {
            listEdge = new List<Tuple<Point, Point>>();

            spLine = new SoundPlayer(Properties.Resources.LineDrawn);
            spArea = new SoundPlayer(Properties.Resources.AreaFilled);

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            DialogResult result = startForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                nBoardWidth = startForm.boardWidth;
                nBoardHeight = startForm.boardHeight;
                bFillBorder = startForm.fillBorder;
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

            nPlayer1Count = 0;
            nPlayer2Count = 0;
            DrawPlayerScore();

            nPlayerTurn = 1;
            labelPlayer1.Font = new Font(Label.DefaultFont, FontStyle.Bold);

            for (int row = 0; row < nBoardHeight; row++)
            {
                for (int col = 0; col < nBoardWidth; col++)
                {
                    PictureBox pb = new PictureBox()
                    {
                        Name = $"pictureBox_Dot_{row}_{col}",
                        Image = Properties.Resources.Dot,
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
                        Image = Properties.Resources.LineHR,
                        Location = new Point(26 + (48 * col), 55 + (48 * row)),
                        Size = new Size(36, 10)
                    };
                    pb.Click += LineClicked;

                    if (bFillBorder && (row == 0 || row == nBoardHeight - 1))
                    {
                        pb.Image = Properties.Resources.LineClickedHR;
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
                        Image = Properties.Resources.LineVR,
                        Location = new Point(18 + (48 * col), 63 + (48 * row)),
                        Size = new Size(10, 36)
                    };
                    pb.Click += LineClicked;

                    if (bFillBorder && (col == 0 || col == nBoardWidth - 1))
                    {
                        pb.Image = Properties.Resources.LineClickedVR;
                        pb.Enabled = false;
                        listEdge.Add(new Tuple<Point, Point>(new Point(col, row), new Point(col, row + 1)));
                    }

                    this.Controls.Add(pb);
                }
            }
        }

        private void labelPlayer1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                labelPlayer1.ForeColor = colorDialog.Color;
                SetAreaColor();
            }
        }

        private void labelPlayer2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                labelPlayer2.ForeColor = colorDialog.Color;
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
                pictureBox.Image = Properties.Resources.LineClickedHR;

                listEdge.Add(new Tuple<Point, Point>(new Point(col, row), new Point(col + 1, row)));
            }
            else if (pictureBox.Name.Contains("VR"))
            {
                pictureBox.Image = Properties.Resources.LineClickedVR;

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

                        mapArea[row, col].pb.BackColor = labelPlayer1.ForeColor;
                        mapArea[row, col].pb.BringToFront();
                    }
                    else if (mapArea[row, col].nOccupant == 2)
                    {
                        nPlayer2Count++;

                        mapArea[row, col].pb.BackColor = labelPlayer2.ForeColor;
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
            labelPlayer1.Text = $"Player 1 ({nPlayer1Count})";
            labelPlayer2.Text = $"Player 2 ({nPlayer2Count})";
        }

        void GameOver()
        {
            DialogResult result;

            SoundPlayer sp = new SoundPlayer(Properties.Resources.GameOver);
            sp.Play();

            if (nPlayer1Count > nPlayer2Count)
            {
                result = MessageBox.Show("Player 1이 승리하였습니다!", "게임 오버", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            else if (nPlayer2Count > nPlayer1Count)
            {
                result = MessageBox.Show("Player 2이 승리하였습니다!", "게임 오버", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            else
            {
                result = MessageBox.Show("비겼습니다!", "게임 오버", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
