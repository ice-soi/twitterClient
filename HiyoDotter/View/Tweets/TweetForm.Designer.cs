namespace HiyoDotter.View
{
    partial class frmTweet
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
            this.components = new System.ComponentModel.Container();
            this.lblTweetUser = new System.Windows.Forms.Label();
            this.pnTweetForm = new System.Windows.Forms.Panel();
            this.btnTweet = new System.Windows.Forms.Button();
            this.lblTweetUserId = new System.Windows.Forms.Label();
            this.tmTimeLine = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTweetUser
            // 
            this.lblTweetUser.AutoSize = true;
            this.lblTweetUser.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTweetUser.Location = new System.Drawing.Point(8, 9);
            this.lblTweetUser.Name = "lblTweetUser";
            this.lblTweetUser.Size = new System.Drawing.Size(90, 23);
            this.lblTweetUser.TabIndex = 1;
            this.lblTweetUser.Text = "西木野 真姫";
            // 
            // pnTweetForm
            // 
            this.pnTweetForm.AutoScroll = true;
            this.pnTweetForm.Location = new System.Drawing.Point(10, 40);
            this.pnTweetForm.Name = "pnTweetForm";
            this.pnTweetForm.Size = new System.Drawing.Size(680, 490);
            this.pnTweetForm.TabIndex = 2;
            // 
            // btnTweet
            // 
            this.btnTweet.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTweet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTweet.FlatAppearance.BorderSize = 0;
            this.btnTweet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTweet.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnTweet.Location = new System.Drawing.Point(603, 9);
            this.btnTweet.Name = "btnTweet";
            this.btnTweet.Size = new System.Drawing.Size(86, 25);
            this.btnTweet.TabIndex = 3;
            this.btnTweet.Text = "Tweet";
            this.btnTweet.UseVisualStyleBackColor = false;
            this.btnTweet.Click += new System.EventHandler(this.btnTweet_Click);
            // 
            // lblTweetUserId
            // 
            this.lblTweetUserId.AutoSize = true;
            this.lblTweetUserId.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTweetUserId.Location = new System.Drawing.Point(117, 12);
            this.lblTweetUserId.Name = "lblTweetUserId";
            this.lblTweetUserId.Size = new System.Drawing.Size(72, 18);
            this.lblTweetUserId.TabIndex = 4;
            this.lblTweetUserId.Text = "西木野 真姫";
            // 
            // tmTimeLine
            // 
            this.tmTimeLine.Interval = 1000;
            this.tmTimeLine.Tick += new System.EventHandler(this.tmTimeLine_Tick);
            // 
            // frmTweet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(700, 540);
            this.Controls.Add(this.lblTweetUserId);
            this.Controls.Add(this.btnTweet);
            this.Controls.Add(this.pnTweetForm);
            this.Controls.Add(this.lblTweetUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTweet";
            this.Text = "TweetForm";
            this.Load += new System.EventHandler(this.frmTweet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTweetUser;
        private System.Windows.Forms.Panel pnTweetForm;
        private System.Windows.Forms.Button btnTweet;
        private System.Windows.Forms.Label lblTweetUserId;
        private System.Windows.Forms.Timer tmTimeLine;
    }
}