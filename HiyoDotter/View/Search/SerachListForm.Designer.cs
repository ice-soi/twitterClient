namespace HiyoDotter.View
{
    partial class SerachListForm
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
            this.pnSearchList = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnSearchList
            // 
            this.pnSearchList.AutoScroll = true;
            this.pnSearchList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnSearchList.Location = new System.Drawing.Point(10, 10);
            this.pnSearchList.Name = "pnSearchList";
            this.pnSearchList.Size = new System.Drawing.Size(704, 431);
            this.pnSearchList.TabIndex = 0;
            // 
            // SerachListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(722, 451);
            this.Controls.Add(this.pnSearchList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SerachListForm";
            this.Text = "SerachListForm";
            this.Load += new System.EventHandler(this.SerachListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSearchList;
    }
}