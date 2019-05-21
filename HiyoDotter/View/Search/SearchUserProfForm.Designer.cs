namespace HiyoDotter.View.Search
{
    partial class SearchUserProfForm
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
            this.lblSearchUserId = new System.Windows.Forms.Label();
            this.lblSearchUserName = new System.Windows.Forms.Label();
            this.picSearchIcon = new System.Windows.Forms.PictureBox();
            this.lblProf = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtTweetForm = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchUserId
            // 
            this.lblSearchUserId.AutoSize = true;
            this.lblSearchUserId.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSearchUserId.Location = new System.Drawing.Point(84, 12);
            this.lblSearchUserId.Name = "lblSearchUserId";
            this.lblSearchUserId.Size = new System.Drawing.Size(72, 18);
            this.lblSearchUserId.TabIndex = 8;
            this.lblSearchUserId.Text = "西木野 真姫";
            // 
            // lblSearchUserName
            // 
            this.lblSearchUserName.AutoSize = true;
            this.lblSearchUserName.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSearchUserName.Location = new System.Drawing.Point(83, 27);
            this.lblSearchUserName.Name = "lblSearchUserName";
            this.lblSearchUserName.Size = new System.Drawing.Size(90, 23);
            this.lblSearchUserName.TabIndex = 7;
            this.lblSearchUserName.Text = "西木野 真姫";
            // 
            // picSearchIcon
            // 
            this.picSearchIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSearchIcon.Location = new System.Drawing.Point(12, 15);
            this.picSearchIcon.Name = "picSearchIcon";
            this.picSearchIcon.Size = new System.Drawing.Size(53, 53);
            this.picSearchIcon.TabIndex = 6;
            this.picSearchIcon.TabStop = false;
            // 
            // lblProf
            // 
            this.lblProf.AutoSize = true;
            this.lblProf.Font = new System.Drawing.Font("メイリオ", 10F);
            this.lblProf.Location = new System.Drawing.Point(10, 80);
            this.lblProf.MaximumSize = new System.Drawing.Size(420, 200);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(52, 21);
            this.lblProf.TabIndex = 10;
            this.lblProf.Text = "ヴぇえ";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSend.Location = new System.Drawing.Point(349, 215);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(83, 31);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Tweet";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(12, 215);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 31);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtTweetForm
            // 
            this.txtTweetForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTweetForm.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTweetForm.HideSelection = false;
            this.txtTweetForm.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.txtTweetForm.Location = new System.Drawing.Point(12, 104);
            this.txtTweetForm.MaxLength = 140;
            this.txtTweetForm.Multiline = true;
            this.txtTweetForm.Name = "txtTweetForm";
            this.txtTweetForm.Size = new System.Drawing.Size(420, 100);
            this.txtTweetForm.TabIndex = 11;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblLocation.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblLocation.Location = new System.Drawing.Point(84, 50);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(56, 18);
            this.lblLocation.TabIndex = 14;
            this.lblLocation.Text = "音ノ木坂";
            // 
            // SearchUserProfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(444, 255);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblSearchUserName);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtTweetForm);
            this.Controls.Add(this.lblProf);
            this.Controls.Add(this.lblSearchUserId);
            this.Controls.Add(this.picSearchIcon);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchUserProfForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SearchUserProfForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SearchUserProfForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SearchUserProfForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchUserId;
        private System.Windows.Forms.Label lblSearchUserName;
        private System.Windows.Forms.PictureBox picSearchIcon;
        private System.Windows.Forms.Label lblProf;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtTweetForm;
        private System.Windows.Forms.Label lblLocation;
    }
}