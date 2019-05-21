namespace HiyoDotter.View
{
    partial class SearchResultForm
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
            this.lblSearchUserName = new System.Windows.Forms.Label();
            this.picSearchIcon = new System.Windows.Forms.PictureBox();
            this.lblSearchUserId = new System.Windows.Forms.Label();
            this.lblTweets = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchUserName
            // 
            this.lblSearchUserName.AutoSize = true;
            this.lblSearchUserName.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSearchUserName.Location = new System.Drawing.Point(92, 12);
            this.lblSearchUserName.Name = "lblSearchUserName";
            this.lblSearchUserName.Size = new System.Drawing.Size(90, 23);
            this.lblSearchUserName.TabIndex = 3;
            this.lblSearchUserName.Text = "西木野 真姫";
            // 
            // picSearchIcon
            // 
            this.picSearchIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSearchIcon.Location = new System.Drawing.Point(12, 12);
            this.picSearchIcon.Name = "picSearchIcon";
            this.picSearchIcon.Size = new System.Drawing.Size(65, 56);
            this.picSearchIcon.TabIndex = 2;
            this.picSearchIcon.TabStop = false;
            this.picSearchIcon.Click += new System.EventHandler(this.picSearchIcon_Click);
            // 
            // lblSearchUserId
            // 
            this.lblSearchUserId.AutoSize = true;
            this.lblSearchUserId.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSearchUserId.Location = new System.Drawing.Point(188, 15);
            this.lblSearchUserId.Name = "lblSearchUserId";
            this.lblSearchUserId.Size = new System.Drawing.Size(72, 18);
            this.lblSearchUserId.TabIndex = 5;
            this.lblSearchUserId.Text = "西木野 真姫";
            // 
            // lblTweets
            // 
            this.lblTweets.AutoSize = true;
            this.lblTweets.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTweets.Location = new System.Drawing.Point(92, 45);
            this.lblTweets.MaximumSize = new System.Drawing.Size(550, 600);
            this.lblTweets.Name = "lblTweets";
            this.lblTweets.Size = new System.Drawing.Size(55, 23);
            this.lblTweets.TabIndex = 6;
            this.lblTweets.Text = "ヴぇえ";
            // 
            // SearchResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(704, 80);
            this.Controls.Add(this.lblTweets);
            this.Controls.Add(this.lblSearchUserId);
            this.Controls.Add(this.lblSearchUserName);
            this.Controls.Add(this.picSearchIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchResultForm";
            this.Text = "SearchResultForm";
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchUserName;
        private System.Windows.Forms.PictureBox picSearchIcon;
        private System.Windows.Forms.Label lblSearchUserId;
        private System.Windows.Forms.Label lblTweets;
    }
}