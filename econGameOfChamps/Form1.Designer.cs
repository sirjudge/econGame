namespace econGameOfChamps
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
            this.nameEnterBox = new System.Windows.Forms.TextBox();
            this.teamEnterBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.teamLabel = new System.Windows.Forms.Label();
            this.addPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameEnterBox
            // 
            this.nameEnterBox.Location = new System.Drawing.Point(64, 76);
            this.nameEnterBox.Name = "nameEnterBox";
            this.nameEnterBox.Size = new System.Drawing.Size(378, 26);
            this.nameEnterBox.TabIndex = 0;
            // 
            // teamEnterBox
            // 
            this.teamEnterBox.Location = new System.Drawing.Point(64, 160);
            this.teamEnterBox.Name = "teamEnterBox";
            this.teamEnterBox.Size = new System.Drawing.Size(377, 26);
            this.teamEnterBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(60, 53);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 20);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "name";
            // 
            // teamLabel
            // 
            this.teamLabel.AutoSize = true;
            this.teamLabel.Location = new System.Drawing.Point(60, 137);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(49, 20);
            this.teamLabel.TabIndex = 3;
            this.teamLabel.Text = "Team";
            // 
            // addPlayer
            // 
            this.addPlayer.Location = new System.Drawing.Point(166, 242);
            this.addPlayer.Name = "addPlayer";
            this.addPlayer.Size = new System.Drawing.Size(171, 50);
            this.addPlayer.TabIndex = 4;
            this.addPlayer.Text = "add player";
            this.addPlayer.UseVisualStyleBackColor = true;
            this.addPlayer.Click += new System.EventHandler(this.AddPlayer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 323);
            this.Controls.Add(this.addPlayer);
            this.Controls.Add(this.teamLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.teamEnterBox);
            this.Controls.Add(this.nameEnterBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameEnterBox;
        private System.Windows.Forms.TextBox teamEnterBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label teamLabel;
        private System.Windows.Forms.Button addPlayer;
    }
}