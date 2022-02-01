
namespace Fenced
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.checkBoxBorder = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.textBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.pictureBoxColorPlayer1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxColorPlayer2 = new System.Windows.Forms.PictureBox();
            this.radioButtonFirstPlayer1 = new System.Windows.Forms.RadioButton();
            this.radioButtonFirstPlayer2 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "가로 울타리 수";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(105, 20);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDownWidth.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(57, 21);
            this.numericUpDownWidth.TabIndex = 1;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Location = new System.Drawing.Point(105, 47);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericUpDownHeight.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(57, 21);
            this.numericUpDownHeight.TabIndex = 3;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "세로 울타리 수";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(13, 122);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(441, 36);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "시작";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(13, 164);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(441, 36);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "종료";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // checkBoxBorder
            // 
            this.checkBoxBorder.AutoSize = true;
            this.checkBoxBorder.Checked = true;
            this.checkBoxBorder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBorder.Location = new System.Drawing.Point(16, 74);
            this.checkBoxBorder.Name = "checkBoxBorder";
            this.checkBoxBorder.Size = new System.Drawing.Size(140, 16);
            this.checkBoxBorder.TabIndex = 6;
            this.checkBoxBorder.Text = "경계면 울타리 채우기";
            this.checkBoxBorder.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBoxBorder);
            this.groupBox1.Controls.Add(this.numericUpDownWidth);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDownHeight);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 103);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "게임 설정";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.radioButtonFirstPlayer2);
            this.groupBox2.Controls.Add(this.radioButtonFirstPlayer1);
            this.groupBox2.Controls.Add(this.pictureBoxColorPlayer2);
            this.groupBox2.Controls.Add(this.pictureBoxColorPlayer1);
            this.groupBox2.Controls.Add(this.textBoxPlayer2);
            this.groupBox2.Controls.Add(this.textBoxPlayer1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(198, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 103);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "플레이어 설정";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "플레이어 1 이름";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "플레이어 2 이름";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxPlayer1
            // 
            this.textBoxPlayer1.Location = new System.Drawing.Point(110, 19);
            this.textBoxPlayer1.Name = "textBoxPlayer1";
            this.textBoxPlayer1.Size = new System.Drawing.Size(105, 21);
            this.textBoxPlayer1.TabIndex = 7;
            this.textBoxPlayer1.Text = "Player 1";
            // 
            // textBoxPlayer2
            // 
            this.textBoxPlayer2.Location = new System.Drawing.Point(110, 45);
            this.textBoxPlayer2.Name = "textBoxPlayer2";
            this.textBoxPlayer2.Size = new System.Drawing.Size(105, 21);
            this.textBoxPlayer2.TabIndex = 9;
            this.textBoxPlayer2.Text = "Player 2";
            // 
            // pictureBoxColorPlayer1
            // 
            this.pictureBoxColorPlayer1.BackColor = System.Drawing.Color.Red;
            this.pictureBoxColorPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxColorPlayer1.Location = new System.Drawing.Point(218, 19);
            this.pictureBoxColorPlayer1.Name = "pictureBoxColorPlayer1";
            this.pictureBoxColorPlayer1.Size = new System.Drawing.Size(22, 22);
            this.pictureBoxColorPlayer1.TabIndex = 10;
            this.pictureBoxColorPlayer1.TabStop = false;
            this.pictureBoxColorPlayer1.Click += new System.EventHandler(this.pictureBoxColorPlayer1_Click);
            // 
            // pictureBoxColorPlayer2
            // 
            this.pictureBoxColorPlayer2.BackColor = System.Drawing.Color.Blue;
            this.pictureBoxColorPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxColorPlayer2.Location = new System.Drawing.Point(218, 44);
            this.pictureBoxColorPlayer2.Name = "pictureBoxColorPlayer2";
            this.pictureBoxColorPlayer2.Size = new System.Drawing.Size(22, 22);
            this.pictureBoxColorPlayer2.TabIndex = 11;
            this.pictureBoxColorPlayer2.TabStop = false;
            this.pictureBoxColorPlayer2.Click += new System.EventHandler(this.pictureBoxColorPlayer2_Click);
            // 
            // radioButtonFirstPlayer1
            // 
            this.radioButtonFirstPlayer1.AutoSize = true;
            this.radioButtonFirstPlayer1.Checked = true;
            this.radioButtonFirstPlayer1.Location = new System.Drawing.Point(101, 74);
            this.radioButtonFirstPlayer1.Name = "radioButtonFirstPlayer1";
            this.radioButtonFirstPlayer1.Size = new System.Drawing.Size(69, 16);
            this.radioButtonFirstPlayer1.TabIndex = 7;
            this.radioButtonFirstPlayer1.TabStop = true;
            this.radioButtonFirstPlayer1.Text = "Player 1";
            this.radioButtonFirstPlayer1.UseVisualStyleBackColor = true;
            // 
            // radioButtonFirstPlayer2
            // 
            this.radioButtonFirstPlayer2.AutoSize = true;
            this.radioButtonFirstPlayer2.Location = new System.Drawing.Point(176, 74);
            this.radioButtonFirstPlayer2.Name = "radioButtonFirstPlayer2";
            this.radioButtonFirstPlayer2.Size = new System.Drawing.Size(69, 16);
            this.radioButtonFirstPlayer2.TabIndex = 12;
            this.radioButtonFirstPlayer2.Text = "Player 2";
            this.radioButtonFirstPlayer2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "선공";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 210);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StartForm";
            this.Text = "Fenced :: Setting";
            this.Load += new System.EventHandler(this.StartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorPlayer2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.CheckBox checkBoxBorder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonFirstPlayer2;
        private System.Windows.Forms.RadioButton radioButtonFirstPlayer1;
        private System.Windows.Forms.PictureBox pictureBoxColorPlayer2;
        private System.Windows.Forms.PictureBox pictureBoxColorPlayer1;
        private System.Windows.Forms.TextBox textBoxPlayer2;
        private System.Windows.Forms.TextBox textBoxPlayer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}