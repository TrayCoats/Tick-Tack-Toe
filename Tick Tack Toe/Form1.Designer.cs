namespace Tick_Tack_Toe
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Oscore = new System.Windows.Forms.Label();
            this.Xscore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Check9 = new System.Windows.Forms.Button();
            this.Check8 = new System.Windows.Forms.Button();
            this.Check7 = new System.Windows.Forms.Button();
            this.Check6 = new System.Windows.Forms.Button();
            this.Check5 = new System.Windows.Forms.Button();
            this.Check4 = new System.Windows.Forms.Button();
            this.Check3 = new System.Windows.Forms.Button();
            this.Check2 = new System.Windows.Forms.Button();
            this.Check1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Brush Script MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(418, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(457, 61);
            this.label5.TabIndex = 30;
            this.label5.Text = "Welcome To Tick Tack Toe";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1346, 516);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.Oscore);
            this.panel4.Controls.Add(this.Xscore);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.button12);
            this.panel4.Controls.Add(this.button11);
            this.panel4.Controls.Add(this.button10);
            this.panel4.Location = new System.Drawing.Point(688, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(636, 488);
            this.panel4.TabIndex = 4;
            // 
            // Oscore
            // 
            this.Oscore.AutoSize = true;
            this.Oscore.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Oscore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Oscore.Font = new System.Drawing.Font("Brush Script MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Oscore.Location = new System.Drawing.Point(326, 95);
            this.Oscore.Name = "Oscore";
            this.Oscore.Size = new System.Drawing.Size(48, 61);
            this.Oscore.TabIndex = 29;
            this.Oscore.Text = "0";
            this.Oscore.Click += new System.EventHandler(this.label3_Click);
            // 
            // Xscore
            // 
            this.Xscore.AutoSize = true;
            this.Xscore.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Xscore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Xscore.Font = new System.Drawing.Font("Brush Script MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xscore.Location = new System.Drawing.Point(328, 16);
            this.Xscore.Name = "Xscore";
            this.Xscore.Size = new System.Drawing.Size(48, 61);
            this.Xscore.TabIndex = 28;
            this.Xscore.Text = "0";
            this.Xscore.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Brush Script MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 61);
            this.label2.TabIndex = 27;
            this.label2.Text = "Player O Score";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 61);
            this.label1.TabIndex = 26;
            this.label1.Text = "Player X Score";
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button12.Font = new System.Drawing.Font("Brush Script MT", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(21, 172);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(594, 140);
            this.button12.TabIndex = 25;
            this.button12.Text = "New Game";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button11.Font = new System.Drawing.Font("Brush Script MT", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(328, 329);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(287, 140);
            this.button11.TabIndex = 24;
            this.button11.Text = "Exit";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.Info;
            this.button10.Font = new System.Drawing.Font("Brush Script MT", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(21, 329);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(287, 140);
            this.button10.TabIndex = 23;
            this.button10.Text = "Reset";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.Check9);
            this.panel3.Controls.Add(this.Check8);
            this.panel3.Controls.Add(this.Check7);
            this.panel3.Controls.Add(this.Check6);
            this.panel3.Controls.Add(this.Check5);
            this.panel3.Controls.Add(this.Check4);
            this.panel3.Controls.Add(this.Check3);
            this.panel3.Controls.Add(this.Check2);
            this.panel3.Controls.Add(this.Check1);
            this.panel3.Location = new System.Drawing.Point(22, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(627, 488);
            this.panel3.TabIndex = 3;
            // 
            // Check9
            // 
            this.Check9.Font = new System.Drawing.Font("Brush Script MT", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check9.Location = new System.Drawing.Point(418, 329);
            this.Check9.Name = "Check9";
            this.Check9.Size = new System.Drawing.Size(177, 140);
            this.Check9.TabIndex = 22;
            this.Check9.UseVisualStyleBackColor = true;
            this.Check9.Click += new System.EventHandler(this.Check9_Click);
            // 
            // Check8
            // 
            this.Check8.Font = new System.Drawing.Font("Brush Script MT", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check8.Location = new System.Drawing.Point(223, 329);
            this.Check8.Name = "Check8";
            this.Check8.Size = new System.Drawing.Size(177, 140);
            this.Check8.TabIndex = 21;
            this.Check8.UseVisualStyleBackColor = true;
            this.Check8.Click += new System.EventHandler(this.Check8_Click);
            // 
            // Check7
            // 
            this.Check7.Font = new System.Drawing.Font("Brush Script MT", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check7.Location = new System.Drawing.Point(28, 329);
            this.Check7.Name = "Check7";
            this.Check7.Size = new System.Drawing.Size(177, 140);
            this.Check7.TabIndex = 20;
            this.Check7.UseVisualStyleBackColor = true;
            this.Check7.Click += new System.EventHandler(this.Check7_Click);
            // 
            // Check6
            // 
            this.Check6.Font = new System.Drawing.Font("Brush Script MT", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check6.Location = new System.Drawing.Point(418, 172);
            this.Check6.Name = "Check6";
            this.Check6.Size = new System.Drawing.Size(177, 140);
            this.Check6.TabIndex = 19;
            this.Check6.UseVisualStyleBackColor = true;
            this.Check6.Click += new System.EventHandler(this.button7_Click);
            // 
            // Check5
            // 
            this.Check5.Font = new System.Drawing.Font("Brush Script MT", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check5.Location = new System.Drawing.Point(223, 172);
            this.Check5.Name = "Check5";
            this.Check5.Size = new System.Drawing.Size(177, 140);
            this.Check5.TabIndex = 18;
            this.Check5.UseVisualStyleBackColor = true;
            this.Check5.Click += new System.EventHandler(this.Check5_Click);
            // 
            // Check4
            // 
            this.Check4.Font = new System.Drawing.Font("Brush Script MT", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check4.Location = new System.Drawing.Point(28, 172);
            this.Check4.Name = "Check4";
            this.Check4.Size = new System.Drawing.Size(177, 140);
            this.Check4.TabIndex = 17;
            this.Check4.UseVisualStyleBackColor = true;
            this.Check4.Click += new System.EventHandler(this.Check4_Click);
            // 
            // Check3
            // 
            this.Check3.Font = new System.Drawing.Font("Brush Script MT", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check3.Location = new System.Drawing.Point(418, 16);
            this.Check3.Name = "Check3";
            this.Check3.Size = new System.Drawing.Size(177, 140);
            this.Check3.TabIndex = 16;
            this.Check3.UseVisualStyleBackColor = true;
            this.Check3.Click += new System.EventHandler(this.Check3_Click);
            // 
            // Check2
            // 
            this.Check2.Font = new System.Drawing.Font("Brush Script MT", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check2.Location = new System.Drawing.Point(223, 16);
            this.Check2.Name = "Check2";
            this.Check2.Size = new System.Drawing.Size(177, 140);
            this.Check2.TabIndex = 15;
            this.Check2.UseVisualStyleBackColor = true;
            this.Check2.Click += new System.EventHandler(this.Check2_Click);
            // 
            // Check1
            // 
            this.Check1.Font = new System.Drawing.Font("Brush Script MT", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check1.Location = new System.Drawing.Point(28, 16);
            this.Check1.Name = "Check1";
            this.Check1.Size = new System.Drawing.Size(177, 140);
            this.Check1.TabIndex = 12;
            this.Check1.UseVisualStyleBackColor = true;
            this.Check1.Click += new System.EventHandler(this.Check1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Check9;
        private System.Windows.Forms.Button Check8;
        private System.Windows.Forms.Button Check7;
        private System.Windows.Forms.Button Check6;
        private System.Windows.Forms.Button Check5;
        private System.Windows.Forms.Button Check4;
        private System.Windows.Forms.Button Check3;
        private System.Windows.Forms.Button Check2;
        private System.Windows.Forms.Button Check1;
        private System.Windows.Forms.Label Oscore;
        private System.Windows.Forms.Label Xscore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label5;
    }
}

