namespace GUI_Gomoku
{
    partial class Form2
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
            this.playerFirst = new System.Windows.Forms.Label();
            this.playerAfter = new System.Windows.Forms.Label();
            this.color1 = new System.Windows.Forms.Label();
            this.color2 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.first = new System.Windows.Forms.Label();
            this.after = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // playerFirst
            // 
            this.playerFirst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerFirst.AutoSize = true;
            this.playerFirst.Location = new System.Drawing.Point(18, 24);
            this.playerFirst.Name = "playerFirst";
            this.playerFirst.Size = new System.Drawing.Size(29, 12);
            this.playerFirst.TabIndex = 4;
            this.playerFirst.Text = "先攻";
            // 
            // playerAfter
            // 
            this.playerAfter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerAfter.AutoSize = true;
            this.playerAfter.Location = new System.Drawing.Point(18, 47);
            this.playerAfter.Name = "playerAfter";
            this.playerAfter.Size = new System.Drawing.Size(29, 12);
            this.playerAfter.TabIndex = 5;
            this.playerAfter.Text = "後攻";
            // 
            // color1
            // 
            this.color1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.color1.AutoEllipsis = true;
            this.color1.AutoSize = true;
            this.color1.Location = new System.Drawing.Point(53, 24);
            this.color1.Name = "color1";
            this.color1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.color1.Size = new System.Drawing.Size(37, 12);
            this.color1.TabIndex = 8;
            this.color1.Text = "(黒石)";
            // 
            // color2
            // 
            this.color2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.color2.AutoEllipsis = true;
            this.color2.AutoSize = true;
            this.color2.Location = new System.Drawing.Point(53, 47);
            this.color2.Name = "color2";
            this.color2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.color2.Size = new System.Drawing.Size(37, 12);
            this.color2.TabIndex = 9;
            this.color2.Text = "(白石)";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBox1.Location = new System.Drawing.Point(211, 78);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(310, 310);
            this.PictureBox1.TabIndex = 10;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
            this.PictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "黒石は先攻の方";
            // 
            // first
            // 
            this.first.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.first.AutoEllipsis = true;
            this.first.AutoSize = true;
            this.first.Location = new System.Drawing.Point(105, 24);
            this.first.MaximumSize = new System.Drawing.Size(500, 0);
            this.first.Name = "first";
            this.first.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.first.Size = new System.Drawing.Size(0, 12);
            this.first.TabIndex = 12;
            // 
            // after
            // 
            this.after.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.after.AutoEllipsis = true;
            this.after.AutoSize = true;
            this.after.Location = new System.Drawing.Point(105, 47);
            this.after.MaximumSize = new System.Drawing.Size(500, 0);
            this.after.Name = "after";
            this.after.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.after.Size = new System.Drawing.Size(0, 12);
            this.after.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 438);
            this.Controls.Add(this.after);
            this.Controls.Add(this.first);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.color2);
            this.Controls.Add(this.color1);
            this.Controls.Add(this.playerAfter);
            this.Controls.Add(this.playerFirst);
            this.Controls.Add(this.PictureBox1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(634, 477);
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GOMOKU";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label playerFirst;
        private System.Windows.Forms.Label playerAfter;
        private System.Windows.Forms.Label color1;
        private System.Windows.Forms.Label color2;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label first;
        private System.Windows.Forms.Label after;
    }
}