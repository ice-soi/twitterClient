using HiyoDotter.Data;
using HiyoDotter.Logic;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HiyoDotter.View
{
    public partial class frmTweetSend : Form
    {
        //****************************************************
        #region "' ｸﾗｽ変数"
            /// <summary>
            /// ﾏｳｽのｸﾘｯｸ位置
            /// </summary>
            private Point mousePoint;
            /// <summary>
            /// ﾂｲｰﾄ
            /// </summary>
            private clsTweetLogic oTweetLogic = new clsTweetLogic();
            /// <summary>
            /// ﾘﾂｲｰﾄ用ID
            /// </summary>
            private string sReTweetId = "";
            /// <summary>
            /// ﾘﾌﾟﾗｲ用ID
            /// </summary>
            private string sRepTweetId = "";
        #endregion
        //****************************************************

        //****************************************************
        #region "' ｺﾝｽﾄﾗｸﾀ"
        /// <summary>
        /// 新規ﾂｲｰﾄ時ｺﾝｽﾄﾗｸﾀ
        /// </summary>
        public frmTweetSend()
            {
                InitializeComponent();
                // 色設定
                setColorSetting();
            }
            /// <summary>
            /// ﾘﾌﾟﾗｲ・ﾘﾂｲｰﾄ時ｺﾝｽﾄﾗｸﾀ
            /// </summary>
            /// <param name="sTweetId"></param>
            public frmTweetSend(string sReId, string sRepId)
            {
                InitializeComponent();
                // 色設定
                setColorSetting();
                // 画面設定
                setFormSetting(sReId, sRepId);
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' ｺﾝﾄﾛｰﾙ処理"
        private void btnClose_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' ﾌｫｰﾑ移動"
        /// <summary>
        /// ﾏｳｽが押された場合のｲﾍﾞﾝﾄ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmTweetSend_MouseDown(object sender,System.Windows.Forms.MouseEventArgs e)
            {
                if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                {
                    mousePoint = new Point(e.X, e.Y);
                }
            }
            /// <summary>
            /// ﾏｳｽが移動した場合のｲﾍﾞﾝﾄ
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void frmTweetSend_MouseMove(object sender,System.Windows.Forms.MouseEventArgs e)
            {
                if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                {
                    this.Left += e.X - mousePoint.X;
                    this.Top += e.Y - mousePoint.Y;
                }
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' ﾂｲｰﾄ"
            /// <summary>
            /// 送信ﾎﾞﾀﾝ押下
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnSend_Click(object sender, EventArgs e)
            {
                // ﾘﾂｲｰﾄにﾁｪｯｸ
                if (this.rdoReTweet.Checked)
                {
                    if (!string.IsNullOrEmpty(sReTweetId))
                    {
                        // ﾘﾂｲｰﾄ
                        oTweetLogic.sendUserReTweet(this.txtTweetForm.Text, sReTweetId);
                    }
                    else
                    { 
                        MessageBox.Show("既にリツイートされています");
                    }    
                }
                else if (this.rdoRep.Checked)
                {
                    // ﾂｲｰﾄ送信
                    oTweetLogic.sendRepTweet(this.txtTweetForm.Text, sRepTweetId);
                }
                else
                {
                    // ﾂｲｰﾄ送信
                    oTweetLogic.sendUserTweet(this.txtTweetForm.Text);
                }
                // 送信完了 
                this.DialogResult = DialogResult.OK;
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
                // 送信ﾎﾞﾀﾝ
                this.btnSend.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSend);

                // 閉じるﾎﾞﾀﾝ
                this.btnClose.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnCancel);

                // ﾂｲｰﾄ画面の背景色
                this.BackColor = ColorTranslator.FromHtml(SettingsData.sTweetBackColor);
            }
            /// <summary>
            /// 画面背景色設定
            /// </summary>
            private void setFormSetting(string sReId, string sRepId)
            {
                // ﾂｲｰﾄ用ID設定
                sReTweetId = sReId;
                // ﾘﾌﾟﾗｲ用ID設定
                sRepTweetId = sRepId;
                // ﾘﾌﾟﾗｲ・ﾘﾂｲｰﾄ選択表示
                this.rdoRep.Visible = true;
                this.rdoReTweet.Visible = true;
                // 選択設定
                this.rdoRep.Checked = true;
            }
        #endregion 
        //****************************************************
    }
}
