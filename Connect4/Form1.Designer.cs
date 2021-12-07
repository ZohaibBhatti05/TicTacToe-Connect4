
namespace Connect4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RedWinsLabel = new System.Windows.Forms.Label();
            this.YellowWinsLabel = new System.Windows.Forms.Label();
            this.TurnLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.FirstToBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ConnectCount = new System.Windows.Forms.TextBox();
            this.ResetGameButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RedWinsLabel
            // 
            this.RedWinsLabel.AutoSize = true;
            this.RedWinsLabel.Location = new System.Drawing.Point(12, 9);
            this.RedWinsLabel.Name = "RedWinsLabel";
            this.RedWinsLabel.Size = new System.Drawing.Size(83, 20);
            this.RedWinsLabel.TabIndex = 1;
            this.RedWinsLabel.Text = "Red wins: 0";
            // 
            // YellowWinsLabel
            // 
            this.YellowWinsLabel.AutoSize = true;
            this.YellowWinsLabel.Location = new System.Drawing.Point(128, 9);
            this.YellowWinsLabel.Margin = new System.Windows.Forms.Padding(3, 0, 20, 0);
            this.YellowWinsLabel.Name = "YellowWinsLabel";
            this.YellowWinsLabel.Size = new System.Drawing.Size(103, 20);
            this.YellowWinsLabel.TabIndex = 2;
            this.YellowWinsLabel.Text = "Yellow Wins: 0";
            // 
            // TurnLabel
            // 
            this.TurnLabel.AutoSize = true;
            this.TurnLabel.Location = new System.Drawing.Point(263, 9);
            this.TurnLabel.Name = "TurnLabel";
            this.TurnLabel.Size = new System.Drawing.Size(77, 20);
            this.TurnLabel.TabIndex = 3;
            this.TurnLabel.Text = "Red\'s Turn";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(12, 590);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(94, 51);
            this.ResetButton.TabIndex = 4;
            this.ResetButton.Text = "Reset\r\nGames";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // FirstToBox
            // 
            this.FirstToBox.Location = new System.Drawing.Point(442, 7);
            this.FirstToBox.Name = "FirstToBox";
            this.FirstToBox.Size = new System.Drawing.Size(28, 27);
            this.FirstToBox.TabIndex = 6;
            this.FirstToBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FirstToBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FirstToBox_KeyDown);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(362, 8);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 24);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "First to:";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "(Will Reset games)";
            // 
            // WidthBox
            // 
            this.WidthBox.Location = new System.Drawing.Point(67, 67);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(28, 27);
            this.WidthBox.TabIndex = 9;
            this.WidthBox.Text = "7";
            this.WidthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WidthBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WidthBox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Height";
            // 
            // HeightBox
            // 
            this.HeightBox.Location = new System.Drawing.Point(67, 100);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(28, 27);
            this.HeightBox.TabIndex = 11;
            this.HeightBox.Text = "6";
            this.HeightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HeightBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HeightBox_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Connect:";
            // 
            // ConnectCount
            // 
            this.ConnectCount.Location = new System.Drawing.Point(78, 177);
            this.ConnectCount.Name = "ConnectCount";
            this.ConnectCount.Size = new System.Drawing.Size(28, 27);
            this.ConnectCount.TabIndex = 13;
            this.ConnectCount.Text = "4";
            this.ConnectCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ConnectCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConnectCount_KeyDown);
            // 
            // ResetGameButton
            // 
            this.ResetGameButton.Location = new System.Drawing.Point(12, 240);
            this.ResetGameButton.Name = "ResetGameButton";
            this.ResetGameButton.Size = new System.Drawing.Size(106, 78);
            this.ResetGameButton.TabIndex = 15;
            this.ResetGameButton.Text = "Reset Current Game";
            this.ResetGameButton.UseVisualStyleBackColor = true;
            this.ResetGameButton.Click += new System.EventHandler(this.ResetGameButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 600);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(133, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 600);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(922, 651);
            this.Controls.Add(this.ResetGameButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConnectCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HeightBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WidthBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.FirstToBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.TurnLabel);
            this.Controls.Add(this.YellowWinsLabel);
            this.Controls.Add(this.RedWinsLabel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect 4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label RedWinsLabel;
        private System.Windows.Forms.Label YellowWinsLabel;
        private System.Windows.Forms.Label TurnLabel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox FirstToBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WidthBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ConnectCount;
        private System.Windows.Forms.Button ResetGameButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}

