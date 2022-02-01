
namespace Fenced
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.pictureBoxDotStandard = new System.Windows.Forms.PictureBox();
            this.pictureBoxAreaStandard = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDotStandard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAreaStandard)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.BackColor = System.Drawing.Color.White;
            this.labelPlayer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelPlayer1.ForeColor = System.Drawing.Color.Red;
            this.labelPlayer1.Location = new System.Drawing.Point(12, 10);
            this.labelPlayer1.Margin = new System.Windows.Forms.Padding(3);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Padding = new System.Windows.Forms.Padding(8);
            this.labelPlayer1.Size = new System.Drawing.Size(67, 28);
            this.labelPlayer1.TabIndex = 0;
            this.labelPlayer1.Text = "Player 1";
            this.labelPlayer1.Click += new System.EventHandler(this.labelPlayer1_Click);
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.BackColor = System.Drawing.Color.White;
            this.labelPlayer2.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelPlayer2.ForeColor = System.Drawing.Color.Blue;
            this.labelPlayer2.Location = new System.Drawing.Point(721, 10);
            this.labelPlayer2.Margin = new System.Windows.Forms.Padding(3);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Padding = new System.Windows.Forms.Padding(8);
            this.labelPlayer2.Size = new System.Drawing.Size(67, 28);
            this.labelPlayer2.TabIndex = 1;
            this.labelPlayer2.Text = "Player 2";
            this.labelPlayer2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelPlayer2.Click += new System.EventHandler(this.labelPlayer2_Click);
            // 
            // pictureBoxDotStandard
            // 
            this.pictureBoxDotStandard.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDotStandard.Image")));
            this.pictureBoxDotStandard.Location = new System.Drawing.Point(15, 52);
            this.pictureBoxDotStandard.Name = "pictureBoxDotStandard";
            this.pictureBoxDotStandard.Size = new System.Drawing.Size(10, 10);
            this.pictureBoxDotStandard.TabIndex = 2;
            this.pictureBoxDotStandard.TabStop = false;
            this.pictureBoxDotStandard.Visible = false;
            // 
            // pictureBoxAreaStandard
            // 
            this.pictureBoxAreaStandard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBoxAreaStandard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAreaStandard.Location = new System.Drawing.Point(24, 61);
            this.pictureBoxAreaStandard.Name = "pictureBoxAreaStandard";
            this.pictureBoxAreaStandard.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxAreaStandard.TabIndex = 4;
            this.pictureBoxAreaStandard.TabStop = false;
            this.pictureBoxAreaStandard.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 10);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(12, 450);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(788, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(12, 450);
            this.panel3.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPlayer2);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxAreaStandard);
            this.Controls.Add(this.pictureBoxDotStandard);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Fenced";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDotStandard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAreaStandard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.Label labelPlayer2;
        private System.Windows.Forms.PictureBox pictureBoxDotStandard;
        private System.Windows.Forms.PictureBox pictureBoxAreaStandard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

