using HiyoDotter.Data;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HiyoDotter.View
{
    public partial class frmSearch : Form
    {

        //****************************************************
        #region "' ｺﾝｽﾄﾗｸﾀ"
        /// <summary>
        /// 検索画面ｺﾝｽﾄﾗｸﾀ
        /// </summary>
        public frmSearch()
            {
                // 画面ｺﾝﾎﾟｰﾈﾝﾄ
                InitializeComponent();
                // 色設定
                setColorSetting();
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' 検索"
            /// <summary>
            /// 検索ﾎﾞﾀﾝｸﾘｯｸ
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnSearch_Click(object sender, EventArgs e)
            {
                // 検索ﾜｰﾄﾞが入力されている
                if (this.txtSearch.Text != "")
                {
                    // 検索処理
                    SerachListForm frmSerachListForm = new SerachListForm(this.rdoSearch1.Checked, this.txtSearch.Text);
                    frmSerachListForm.TopLevel = false;
                    DisposeForm();
                    pnResultList.Controls.Add(frmSerachListForm);
                    frmSerachListForm.Show();
                }    
            }
            /// <summary>
            /// ﾕｰｻﾞID検索時
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void rdoSearch1_CheckedChanged(object sender, EventArgs e)
            {
                this.txtSearch.ImeMode = ImeMode.Off;
            }
            /// <summary>
            /// ﾂｲｰﾄ検索時
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void rdoSearch2_CheckedChanged(object sender, EventArgs e)
            {
                this.txtSearch.ImeMode = ImeMode.On;
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' 画面設定"
        /// <summary>
        /// 画面背景色設定
        /// </summary>
        private void setColorSetting()
            {
                // 検索ﾎﾞﾀﾝ
                this.btnSearch.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSearchList);

                // 検索画面の背景色
                this.BackColor = ColorTranslator.FromHtml(SettingsData.sSearchBackColor);
            }


        #endregion
        //****************************************************

        //****************************************************
        #region "' Dispose"
            /// <summary>
            /// Dispose
            /// </summary>
            private void DisposeForm()
            {
                // ｺﾝﾄﾛｰﾙに表示したFormをDispose
                for (int iCnt = 0; iCnt <= pnResultList.Controls.Count - 1; iCnt++)
                {
                    pnResultList.Controls[iCnt].Dispose();
                }
            }
        #endregion
        //****************************************************

    }
}
