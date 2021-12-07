
namespace TicTacToeWinForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button33 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button33);
            this.panel1.Controls.Add(this.button32);
            this.panel1.Controls.Add(this.button23);
            this.panel1.Controls.Add(this.button22);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button31);
            this.panel1.Controls.Add(this.button21);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 312);
            this.panel1.TabIndex = 9;
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(212, 212);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(100, 100);
            this.button33.TabIndex = 17;
            this.button33.Text = "-";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button_Click);
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(212, 106);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(100, 100);
            this.button32.TabIndex = 16;
            this.button32.Text = "-";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(106, 212);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(100, 100);
            this.button23.TabIndex = 15;
            this.button23.Text = "-";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(106, 106);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(100, 100);
            this.button22.TabIndex = 14;
            this.button22.Text = "-";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(0, 212);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(100, 100);
            this.button13.TabIndex = 13;
            this.button13.Text = "-";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(0, 106);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 100);
            this.button12.TabIndex = 12;
            this.button12.Text = "-";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button_Click);
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(212, 0);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(100, 100);
            this.button31.TabIndex = 11;
            this.button31.Text = "-";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(106, 0);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(100, 100);
            this.button21.TabIndex = 10;
            this.button21.Text = "-";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(0, 0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 100);
            this.button11.TabIndex = 9;
            this.button11.Text = "-";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "X\'s Turn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 359);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label1;
    }
}

