using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fenced
{
    public partial class StartForm : Form
    {
        int nBoardWidth = 0;
        int nBoardHeight = 0;
        bool bFillBorder;
        string strNamePlayer1;
        string strNamePlayer2;
        Color cPlayer1;
        Color cPlayer2;
        int nFirstPlayer;

        public int boardWidth { get { return nBoardWidth; } }
        public int boardHeight { get { return nBoardHeight; } }
        public bool fillBorder { get { return bFillBorder; } }
        public string namePlayer1 { get { return strNamePlayer1; } }
        public string namePlayer2 { get { return strNamePlayer2; } }
        public Color colorPlayer1 { get { return cPlayer1; } }
        public Color colorPlayer2 { get { return cPlayer2; } }
        public int firstPlayer { get { return nFirstPlayer; } }

        public StartForm()
        {
            InitializeComponent();
        }

        public StartForm(int width, int height, bool border, string name1, string name2, Color c1, Color c2)
        {
            nBoardWidth = width;
            nBoardHeight = height;
            bFillBorder = border;
            strNamePlayer1 = name1;
            strNamePlayer2 = name2;
            cPlayer1 = c1;
            cPlayer2 = c2;

            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            if (nBoardWidth > 0 && nBoardHeight > 0)
            {
                numericUpDownWidth.Value = nBoardWidth;
                numericUpDownHeight.Value = nBoardHeight;
                checkBoxBorder.Checked = bFillBorder;
                textBoxPlayer1.Text = strNamePlayer1;
                textBoxPlayer2.Text = strNamePlayer2;
                pictureBoxColorPlayer1.BackColor = cPlayer1;
                pictureBoxColorPlayer2.BackColor = cPlayer2;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            nBoardWidth = (int)numericUpDownWidth.Value;
            nBoardHeight = (int)numericUpDownHeight.Value;
            bFillBorder = checkBoxBorder.Checked;

            if (textBoxPlayer1.Text == "")
            {
                MessageBox.Show("Player 1의 이름을 입력해주세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPlayer1.Focus();
                return;
            }
            else strNamePlayer1 = textBoxPlayer1.Text;
            if (textBoxPlayer2.Text == "")
            {
                MessageBox.Show("Player 2의 이름을 입력해주세요!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPlayer2.Focus();
                return;
            }
            else strNamePlayer2 = textBoxPlayer2.Text;
            cPlayer1 = pictureBoxColorPlayer1.BackColor;
            cPlayer2 = pictureBoxColorPlayer2.BackColor;

            if (radioButtonFirstPlayer1.Checked) nFirstPlayer = 1;
            else nFirstPlayer = 2;

            this.DialogResult = DialogResult.OK;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void pictureBoxColorPlayer1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxColorPlayer1.BackColor = cd.Color;
            }
        }

        private void pictureBoxColorPlayer2_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxColorPlayer2.BackColor = cd.Color;
            }
        }
    }
}
