namespace HiyoDotter.View
{
    partial class frmTweetSend
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
            this.txtTweetForm = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.rdoRep = new System.Windows.Forms.RadioButton();
            this.rdoReTweet = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtTweetForm
            // 
            this.txtTweetForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTweetForm.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTweetForm.HideSelection = false;
            this.txtTweetForm.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.txtTweetForm.Location = new System.Drawing.Point(10, 50);
            this.txtTweetForm.MaxLength = 140;
            this.txtTweetForm.Multiline = true;
            this.txtTweetForm.Name = "txtTweetForm";
            this.txtTweetForm.Size = new System.Drawing.Size(420, 100);
            this.txtTweetForm.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(10, 161);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 31);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSend.Location = new System.Drawing.Point(347, 161);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(83, 31);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Tweet";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rdoRep
            // 
            this.rdoRep.AutoSize = true;
            this.rdoRep.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdoRep.Location = new System.Drawing.Point(12, 12);
            this.rdoRep.Name = "rdoRep";
            this.rdoRep.Size = new System.Drawing.Size(88, 27);
            this.rdoRep.TabIndex = 3;
            this.rdoRep.TabStop = true;
            this.rdoRep.Text = "リプライ";
            this.rdoRep.UseVisualStyleBackColor = true;
            this.rdoRep.Visible = false;
            // 
            // rdoReTweet
            // 
            this.rdoReTweet.AutoSize = true;
            this.rdoReTweet.Font = new System.Drawing.Font("メイリオ", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdoReTweet.Location = new System.Drawing.Point(106, 12);
            this.rdoReTweet.Name = "rdoReTweet";
            this.rdoReTweet.Size = new System.Drawing.Size(103, 27);
            this.rdoReTweet.TabIndex = 4;
            this.rdoReTweet.TabStop = true;
            this.rdoReTweet.Text = "リツイート";
            this.rdoReTweet.UseVisualStyleBackColor = true;
            this.rdoReTweet.Visible = false;
            // 
            // frmTweetSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(440, 200);
            this.Controls.Add(this.rdoReTweet);
            this.Controls.Add(this.rdoRep);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtTweetForm);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTweetSend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TweetSendForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmTweetSend_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmTweetSend_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTweetForm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RadioButton rdoRep;
        private System.Windows.Forms.RadioButton rdoReTweet;
    }
}