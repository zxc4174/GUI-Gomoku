namespace GUI_Gomoku
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.player1 = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.Label();
            this.nameBox1 = new System.Windows.Forms.TextBox();
            this.nameBox2 = new System.Windows.Forms.TextBox();
            this.firstPlayerName = new System.Windows.Forms.Label();
            this.firstRadioButton = new System.Windows.Forms.RadioButton();
            this.afterRadioButton = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            this.cleanButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.AllowDrop = true;
            this.player1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.player1.AutoSize = true;
            this.player1.Location = new System.Drawing.Point(19, 52);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(59, 12);
            this.player1.TabIndex = 0;
            this.player1.Text = "プレーヤー1";
            // 
            // player2
            // 
            this.player2.AllowDrop = true;
            this.player2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.player2.AutoSize = true;
            this.player2.Location = new System.Drawing.Point(19, 75);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(59, 12);
            this.player2.TabIndex = 1;
            this.player2.Text = "プレーヤー2";
            // 
            // nameBox1
            // 
            this.nameBox1.AllowDrop = true;
            this.nameBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameBox1.Location = new System.Drawing.Point(94, 49);
            this.nameBox1.Name = "nameBox1";
            this.nameBox1.Size = new System.Drawing.Size(124, 19);
            this.nameBox1.TabIndex = 2;
            this.nameBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameBox1_KeyPress);
            this.nameBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nameBox1_KeyUp);
            // 
            // nameBox2
            // 
            this.nameBox2.AllowDrop = true;
            this.nameBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameBox2.Location = new System.Drawing.Point(94, 72);
            this.nameBox2.Name = "nameBox2";
            this.nameBox2.Size = new System.Drawing.Size(124, 19);
            this.nameBox2.TabIndex = 3;
            this.nameBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameBox2_KeyPress);
            // 
            // firstPlayerName
            // 
            this.firstPlayerName.AllowDrop = true;
            this.firstPlayerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstPlayerName.AutoSize = true;
            this.firstPlayerName.Location = new System.Drawing.Point(19, 136);
            this.firstPlayerName.MaximumSize = new System.Drawing.Size(100, 0);
            this.firstPlayerName.Name = "firstPlayerName";
            this.firstPlayerName.Size = new System.Drawing.Size(59, 12);
            this.firstPlayerName.TabIndex = 4;
            this.firstPlayerName.Text = "プレーヤー1";
            // 
            // firstRadioButton
            // 
            this.firstRadioButton.AllowDrop = true;
            this.firstRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstRadioButton.AutoSize = true;
            this.firstRadioButton.Location = new System.Drawing.Point(122, 134);
            this.firstRadioButton.Name = "firstRadioButton";
            this.firstRadioButton.Size = new System.Drawing.Size(47, 16);
            this.firstRadioButton.TabIndex = 5;
            this.firstRadioButton.TabStop = true;
            this.firstRadioButton.Text = "先攻";
            this.firstRadioButton.UseVisualStyleBackColor = true;
            // 
            // afterRadioButton
            // 
            this.afterRadioButton.AllowDrop = true;
            this.afterRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.afterRadioButton.AutoSize = true;
            this.afterRadioButton.Location = new System.Drawing.Point(197, 134);
            this.afterRadioButton.Name = "afterRadioButton";
            this.afterRadioButton.Size = new System.Drawing.Size(47, 16);
            this.afterRadioButton.TabIndex = 6;
            this.afterRadioButton.TabStop = true;
            this.afterRadioButton.Text = "後攻";
            this.afterRadioButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.AllowDrop = true;
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startButton.Location = new System.Drawing.Point(94, 191);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "開始";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // cleanButton
            // 
            this.cleanButton.AllowDrop = true;
            this.cleanButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cleanButton.Location = new System.Drawing.Point(94, 220);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(75, 23);
            this.cleanButton.TabIndex = 8;
            this.cleanButton.Text = "クリア";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(12, 133);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(92, 23);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "プレーヤー1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 290);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.afterRadioButton);
            this.Controls.Add(this.firstRadioButton);
            this.Controls.Add(this.firstPlayerName);
            this.Controls.Add(this.nameBox2);
            this.Controls.Add(this.nameBox1);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(277, 329);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GOMOKU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player1;
        private System.Windows.Forms.Label player2;
        private System.Windows.Forms.TextBox nameBox1;
        private System.Windows.Forms.TextBox nameBox2;
        private System.Windows.Forms.Label firstPlayerName;
        private System.Windows.Forms.RadioButton firstRadioButton;
        private System.Windows.Forms.RadioButton afterRadioButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

