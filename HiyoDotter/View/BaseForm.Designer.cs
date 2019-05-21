namespace HiyoDotter.View
{
    partial class frmBase
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
            this.pnFrmArea = new System.Windows.Forms.Panel();
            this.pnMene = new System.Windows.Forms.Panel();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.pnMene.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnFrmArea
            // 
            this.pnFrmArea.Location = new System.Drawing.Point(60, 0);
            this.pnFrmArea.Name = "pnFrmArea";
            this.pnFrmArea.Size = new System.Drawing.Size(725, 563);
            this.pnFrmArea.TabIndex = 1;
            this.pnFrmArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmBase_MouseDown);
            this.pnFrmArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmBase_MouseMove);
            // 
            // pnMene
            // 
            this.pnMene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(122)))));
            this.pnMene.Controls.Add(this.btnConfig);
            this.pnMene.Controls.Add(this.btnClose);
            this.pnMene.Controls.Add(this.btnSetting);
            this.pnMene.Controls.Add(this.btnSearch);
            this.pnMene.Controls.Add(this.btnMain);
            this.pnMene.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnMene.Location = new System.Drawing.Point(0, 0);
            this.pnMene.Name = "pnMene";
            this.pnMene.Size = new System.Drawing.Size(60, 563);
            this.pnMene.TabIndex = 2;
            this.pnMene.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmBase_MouseDown);
            this.pnMene.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmBase_MouseMove);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Location = new System.Drawing.Point(10, 160);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(40, 40);
            this.btnConfig.TabIndex = 4;
            this.btnConfig.Text = "Config";
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(10, 510);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Location = new System.Drawing.Point(10, 110);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(40, 40);
            this.btnSetting.TabIndex = 2;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(10, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMain.FlatAppearance.BorderSize = 0;
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Location = new System.Drawing.Point(10, 10);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(40, 40);
            this.btnMain.TabIndex = 0;
            this.btnMain.Text = "Main";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pnMene);
            this.Controls.Add(this.pnFrmArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmBase";
            this.ShowIcon = false;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmBase_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmBase_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmBase_MouseMove);
            this.pnMene.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnFrmArea;
        private System.Windows.Forms.Panel pnMene;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnConfig;
    }
}