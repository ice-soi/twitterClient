namespace HiyoDotter.View.Config
{
    partial class frmConfig
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
            this.rdoLeft = new System.Windows.Forms.RadioButton();
            this.rdoBottom = new System.Windows.Forms.RadioButton();
            this.rdoRight = new System.Windows.Forms.RadioButton();
            this.rdoTop = new System.Windows.Forms.RadioButton();
            this.grpMnuPosition = new System.Windows.Forms.GroupBox();
            this.btnDefalt = new System.Windows.Forms.Button();
            this.btnConfigReg = new System.Windows.Forms.Button();
            this.grpMnuPosition.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoLeft
            // 
            this.rdoLeft.AutoSize = true;
            this.rdoLeft.Font = new System.Drawing.Font("メイリオ", 11F);
            this.rdoLeft.Location = new System.Drawing.Point(16, 25);
            this.rdoLeft.Name = "rdoLeft";
            this.rdoLeft.Size = new System.Drawing.Size(43, 27);
            this.rdoLeft.TabIndex = 2;
            this.rdoLeft.TabStop = true;
            this.rdoLeft.Text = "左";
            this.rdoLeft.UseVisualStyleBackColor = true;
            // 
            // rdoBottom
            // 
            this.rdoBottom.AutoSize = true;
            this.rdoBottom.Font = new System.Drawing.Font("メイリオ", 11F);
            this.rdoBottom.Location = new System.Drawing.Point(163, 25);
            this.rdoBottom.Name = "rdoBottom";
            this.rdoBottom.Size = new System.Drawing.Size(43, 27);
            this.rdoBottom.TabIndex = 3;
            this.rdoBottom.TabStop = true;
            this.rdoBottom.Text = "下";
            this.rdoBottom.UseVisualStyleBackColor = true;
            // 
            // rdoRight
            // 
            this.rdoRight.AutoSize = true;
            this.rdoRight.Font = new System.Drawing.Font("メイリオ", 11F);
            this.rdoRight.Location = new System.Drawing.Point(114, 25);
            this.rdoRight.Name = "rdoRight";
            this.rdoRight.Size = new System.Drawing.Size(43, 27);
            this.rdoRight.TabIndex = 4;
            this.rdoRight.TabStop = true;
            this.rdoRight.Text = "右";
            this.rdoRight.UseVisualStyleBackColor = true;
            // 
            // rdoTop
            // 
            this.rdoTop.AutoSize = true;
            this.rdoTop.Font = new System.Drawing.Font("メイリオ", 11F);
            this.rdoTop.Location = new System.Drawing.Point(65, 25);
            this.rdoTop.Name = "rdoTop";
            this.rdoTop.Size = new System.Drawing.Size(43, 27);
            this.rdoTop.TabIndex = 5;
            this.rdoTop.TabStop = true;
            this.rdoTop.Text = "上";
            this.rdoTop.UseVisualStyleBackColor = true;
            // 
            // grpMnuPosition
            // 
            this.grpMnuPosition.Controls.Add(this.rdoTop);
            this.grpMnuPosition.Controls.Add(this.rdoLeft);
            this.grpMnuPosition.Controls.Add(this.rdoRight);
            this.grpMnuPosition.Controls.Add(this.rdoBottom);
            this.grpMnuPosition.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.grpMnuPosition.Location = new System.Drawing.Point(12, 12);
            this.grpMnuPosition.Name = "grpMnuPosition";
            this.grpMnuPosition.Size = new System.Drawing.Size(235, 64);
            this.grpMnuPosition.TabIndex = 6;
            this.grpMnuPosition.TabStop = false;
            this.grpMnuPosition.Text = "メニューバー";
            // 
            // btnDefalt
            // 
            this.btnDefalt.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDefalt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDefalt.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnDefalt.FlatAppearance.BorderSize = 0;
            this.btnDefalt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefalt.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDefalt.Location = new System.Drawing.Point(568, 462);
            this.btnDefalt.Name = "btnDefalt";
            this.btnDefalt.Size = new System.Drawing.Size(40, 29);
            this.btnDefalt.TabIndex = 79;
            this.btnDefalt.Text = "初期";
            this.btnDefalt.UseVisualStyleBackColor = false;
            this.btnDefalt.Click += new System.EventHandler(this.btnDefalt_Click);
            // 
            // btnConfigReg
            // 
            this.btnConfigReg.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConfigReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfigReg.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnConfigReg.FlatAppearance.BorderSize = 0;
            this.btnConfigReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigReg.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnConfigReg.Location = new System.Drawing.Point(624, 462);
            this.btnConfigReg.Name = "btnConfigReg";
            this.btnConfigReg.Size = new System.Drawing.Size(40, 29);
            this.btnConfigReg.TabIndex = 78;
            this.btnConfigReg.Text = "反映";
            this.btnConfigReg.UseVisualStyleBackColor = false;
            this.btnConfigReg.Click += new System.EventHandler(this.btnConfigReg_Click);
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(724, 563);
            this.Controls.Add(this.btnDefalt);
            this.Controls.Add(this.btnConfigReg);
            this.Controls.Add(this.grpMnuPosition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConfig";
            this.Text = "ConfigForm";
            this.grpMnuPosition.ResumeLayout(false);
            this.grpMnuPosition.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rdoLeft;
        private System.Windows.Forms.RadioButton rdoBottom;
        private System.Windows.Forms.RadioButton rdoRight;
        private System.Windows.Forms.RadioButton rdoTop;
        private System.Windows.Forms.GroupBox grpMnuPosition;
        private System.Windows.Forms.Button btnDefalt;
        private System.Windows.Forms.Button btnConfigReg;
    }
}