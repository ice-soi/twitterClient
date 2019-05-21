using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HiyoDotter.Logic;
using HiyoDotter.Data;

namespace HiyoDotter.View.Search
{
    public partial class SearchUserProfForm : Form
    {
        //****************************************************
        #region"' ｸﾗｽ変数"
            /// <summary>
            /// ﾏｳｽのｸﾘｯｸ位置
            /// </summary>
            private Point mousePoint;
            /// <summary>
            /// ﾂｲｰﾄﾛｼﾞｯｸ
            /// </summary>
            private clsTweetLogic oTweetLogic = new clsTweetLogic();
        #endregion
        //****************************************************

        //****************************************************
        #region "' ｺﾝｽﾄﾗｸﾀ"
            /// <summary>
            /// ｺﾝｽﾄﾗｸﾀ
            /// </summary>
            /// <param name="sUserId">ﾕｰｻﾞID</param>
            public SearchUserProfForm(string sUserId)
            {
                InitializeComponent();

                // ﾕｰｻﾞﾌﾟﾛﾌｨｰﾙの設定
                setUserProf(sUserId);
                // 画面設定
                setColorSetting();
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' ﾕｰｻﾞﾌﾟﾛﾌｨｰﾙ取得"
        /// <summary>
        /// ﾕｰｻﾞﾌﾟﾛﾌｨｰﾙの取得/設定
        /// </summary>
        /// <param name="sUserId">ﾕｰｻﾞID</param>
        private void setUserProf(string sUserId)
            {
                // ﾕｰｻﾞﾌﾟﾛﾌｨｰﾙの取得
                var oUserProf = oTweetLogic.getUserProf(sUserId);

                // ﾌﾟﾛﾌｨｰﾙ設定
                this.lblSearchUserId.Text = oUserProf.id_str;                       // ﾕｰｻﾞID
                this.lblSearchUserName.Text = oUserProf.screen_name;                // ﾕｰｻﾞ名
                this.picSearchIcon.ImageLocation = oUserProf.profile_image_url;     // ｱｲｺﾝ
                this.lblLocation.Text = oUserProf.location;                         // 場所
                this.lblProf.Text = oUserProf.description;                          // 自己紹介

                // ﾂｲｰﾄ入力ﾃｷｽﾄｴﾘｱを修正
                this.txtTweetForm.Top = this.lblProf.Bottom + 5;
                this.btnSend.Top = this.txtTweetForm.Bottom + 15;
                this.btnClose.Top = this.txtTweetForm.Bottom + 15;

                // ﾌｫｰﾑのｻｲｽﾞを再設定
                this.Height = this.btnSend.Bottom + 10;
        }
        #endregion
        //****************************************************

        //****************************************************
        #region "' ｲﾍﾞﾝﾄ"
            /// <summary>
            /// 送信ﾎﾞﾀﾝ押下
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnSend_Click(object sender, EventArgs e)
            {
                // ﾀﾞｲﾚｸﾄﾒｯｾｰｼﾞ送信
                oTweetLogic.sendDirectMessages(this.lblSearchUserId.Text,this.txtTweetForm.Text);
                this.DialogResult = DialogResult.OK;
            }
            /// <summary>
            /// 閉じるﾎﾞﾀﾝ押下
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
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
        private void SearchUserProfForm_MouseDown(object sender, MouseEventArgs e)
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
        private void SearchUserProfForm_MouseMove(object sender, MouseEventArgs e)
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
        #region "' 画面設定"
            private void setColorSetting()
            {
                this.BackColor = ColorTranslator.FromHtml(SettingsData.sUserProfBackColor);
            } 
        #endregion
        //****************************************************
    }
}
