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
        int nBoardWidth;
        int nBoardHeight;
        bool bFillBorder;

        public int boardWidth { get { return nBoardWidth; } }
        public int boardHeight { get { return nBoardHeight; } }
        public bool fillBorder { get { return bFillBorder; } }

        public StartForm()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            nBoardWidth = (int)numericUpDownWidth.Value;
            nBoardHeight = (int)numericUpDownHeight.Value;
            bFillBorder = checkBoxBorder.Checked;

            this.DialogResult = DialogResult.OK;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
