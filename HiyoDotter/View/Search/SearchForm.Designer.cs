namespace HiyoDotter.View
{
    partial class frmSearch
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
            this.rdoSearch1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rdoSearch2 = new System.Windows.Forms.RadioButton();
            this.pnResultList = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoSearch1
            // 
            this.rdoSearch1.AutoSize = true;
            this.rdoSearch1.Checked = true;
            this.rdoSearch1.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdoSearch1.Location = new System.Drawing.Point(3, 3);
            this.rdoSearch1.Name = "rdoSearch1";
            this.rdoSearch1.Size = new System.Drawing.Size(92, 28);
            this.rdoSearch1.TabIndex = 2;
            this.rdoSearch1.TabStop = true;
            this.rdoSearch1.Text = "ユーザ名";
            this.rdoSearch1.UseVisualStyleBackColor = true;
            this.rdoSearch1.CheckedChanged += new System.EventHandler(this.rdoSearch1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.rdoSearch2);
            this.panel1.Controls.Add(this.rdoSearch1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 76);
            this.panel1.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSearch.Location = new System.Drawing.Point(215, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 29);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSearch.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtSearch.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtSearch.Location = new System.Drawing.Point(3, 37);
            this.txtSearch.MaxLength = 200;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 29);
            this.txtSearch.TabIndex = 4;
            // 
            // rdoSearch2
            // 
            this.rdoSearch2.AutoSize = true;
            this.rdoSearch2.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdoSearch2.Location = new System.Drawing.Point(100, 3);
            this.rdoSearch2.Name = "rdoSearch2";
            this.rdoSearch2.Size = new System.Drawing.Size(92, 28);
            this.rdoSearch2.TabIndex = 3;
            this.rdoSearch2.Text = "ツイート";
            this.rdoSearch2.UseVisualStyleBackColor = true;
            this.rdoSearch2.CheckedChanged += new System.EventHandler(this.rdoSearch2_CheckedChanged);
            // 
            // pnResultList
            // 
            this.pnResultList.AutoScroll = true;
            this.pnResultList.Location = new System.Drawing.Point(0, 94);
            this.pnResultList.Name = "pnResultList";
            this.pnResultList.Size = new System.Drawing.Size(722, 469);
            this.pnResultList.TabIndex = 6;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(724, 563);
            this.Controls.Add(this.pnResultList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearch";
            this.Text = "SearchForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rdoSearch1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoSearch2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnResultList;
    }
}