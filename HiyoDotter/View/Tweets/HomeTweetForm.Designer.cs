namespace HiyoDotter.View
{
    partial class HomeTweetForm
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
            this.picTweetIcon = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblTimeStamp = new System.Windows.Forms.Label();
            this.lblVia = new System.Windows.Forms.Label();
            this.lblTweet = new System.Windows.Forms.Label();
            this.lblRepId = new System.Windows.Forms.Label();
            this.lblRetweetId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picTweetIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // picTweetIcon
            // 
            this.picTweetIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTweetIcon.Location = new System.Drawing.Point(12, 9);
            this.picTweetIcon.Name = "picTweetIcon";
            this.picTweetIcon.Size = new System.Drawing.Size(65, 56);
            this.picTweetIcon.TabIndex = 0;
            this.picTweetIcon.TabStop = false;
            this.picTweetIcon.Click += new System.EventHandler(this.picTweetIcon_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblUserName.Location = new System.Drawing.Point(92, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(90, 23);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "西木野 真姫";
            // 
            // lblTimeStamp
            // 
            this.lblTimeStamp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTimeStamp.AutoSize = true;
            this.lblTimeStamp.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTimeStamp.Location = new System.Drawing.Point(12, 79);
            this.lblTimeStamp.Name = "lblTimeStamp";
            this.lblTimeStamp.Size = new System.Drawing.Size(176, 20);
            this.lblTimeStamp.TabIndex = 2;
            this.lblTimeStamp.Text = "2016年01月31日 10:10:00";
            // 
            // lblVia
            // 
            this.lblVia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVia.AutoSize = true;
            this.lblVia.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblVia.Location = new System.Drawing.Point(540, 79);
            this.lblVia.Name = "lblVia";
            this.lblVia.Size = new System.Drawing.Size(106, 20);
            this.lblVia.TabIndex = 3;
            this.lblVia.Text = "Tweer For Web";
            // 
            // lblTweet
            // 
            this.lblTweet.AutoSize = true;
            this.lblTweet.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTweet.Location = new System.Drawing.Point(95, 30);
            this.lblTweet.MaximumSize = new System.Drawing.Size(550, 0);
            this.lblTweet.Name = "lblTweet";
            this.lblTweet.Size = new System.Drawing.Size(54, 23);
            this.lblTweet.TabIndex = 5;
            this.lblTweet.Text = "label1";
            // 
            // lblRepId
            // 
            this.lblRepId.AutoSize = true;
            this.lblRepId.Location = new System.Drawing.Point(252, 9);
            this.lblRepId.Name = "lblRepId";
            this.lblRepId.Size = new System.Drawing.Size(0, 12);
            this.lblRepId.TabIndex = 6;
            this.lblRepId.Visible = false;
            // 
            // lblRetweetId
            // 
            this.lblRetweetId.AutoSize = true;
            this.lblRetweetId.Location = new System.Drawing.Point(296, 11);
            this.lblRetweetId.Name = "lblRetweetId";
            this.lblRetweetId.Size = new System.Drawing.Size(0, 12);
            this.lblRetweetId.TabIndex = 7;
            this.lblRetweetId.Visible = false;
            // 
            // HomeTweetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(663, 100);
            this.Controls.Add(this.lblRetweetId);
            this.Controls.Add(this.lblRepId);
            this.Controls.Add(this.lblTweet);
            this.Controls.Add(this.lblVia);
            this.Controls.Add(this.lblTimeStamp);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.picTweetIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeTweetForm";
            this.Text = "RepTweetForm";
            ((System.ComponentModel.ISupportInitialize)(this.picTweetIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTweetIcon;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblTimeStamp;
        private System.Windows.Forms.Label lblVia;
        private System.Windows.Forms.Label lblTweet;
        private System.Windows.Forms.Label lblRepId;
        private System.Windows.Forms.Label lblRetweetId;
    }
}