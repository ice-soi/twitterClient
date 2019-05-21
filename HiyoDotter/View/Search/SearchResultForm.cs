using System;
using System.Drawing;
using System.Windows.Forms;
using HiyoDotter.Data;
using HiyoDotter.View.Search;

namespace HiyoDotter.View
{
    public partial class SearchResultForm : Form
    {
        //****************************************************
        #region "' ｺﾝｽﾄﾗｸﾀ"
            /// <summary>
            /// ｺﾝｽﾄﾗｸﾀ
            /// </summary>
            public SearchResultForm(JsonUserSearchData oJsonData, string sTweetCnt)
            {
                // 画面ｺﾝﾎﾟｰﾈﾝﾄ
                InitializeComponent();
                // 取得ﾂｲｰﾄ作成
                InitView(oJsonData, sTweetCnt);
            }
            /// <summary>
            /// ｺﾝｽﾄﾗｸﾀ
            /// </summary>
            public SearchResultForm(Statuses oJsonData, string sTweetCnt)
            {
                // 画面ｺﾝﾎﾟｰﾈﾝﾄ
                InitializeComponent();
                // 取得ﾂｲｰﾄ作成
                InitView(oJsonData, sTweetCnt);
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' Initialize"
            /// <summary>
            /// 画面初期化
            /// </summary>
            private void InitView(JsonUserSearchData oJsonData, string sTweetCnt)
            {
                string sForeColor = "";
                string sBackColor = "";

                // ﾂｲｰﾄの背景色設定
                setTweetColor(ref sForeColor, ref sBackColor);
                // 画面本体設定
                setBackColor(sForeColor, sBackColor);
                // 検索ﾕｰｻﾞ内容設定
                setUserResultInfo(oJsonData, sTweetCnt);
            }
            /// <summary>
            /// 画面初期化
            /// </summary>
            private void InitView(Statuses oJsonData, string sTweetCnt)
            {
                string sForeColor = "";
                string sBackColor = "";

                // ﾂｲｰﾄの背景色設定
                setTweetColor(ref sForeColor, ref sBackColor);
                // 画面本体設定
                setBackColor(sForeColor, sBackColor);
                // 検索結果内容設定
                setTweetResultInfo(oJsonData, sTweetCnt);
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' ｺﾝﾄﾛｰﾙｲﾍﾞﾝﾄ"
        /// <summary>
        /// ｱｲｺﾝｸﾘｯｸ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picSearchIcon_Click(object sender, EventArgs e)
            {
                // ﾕｰｻﾞﾌﾟﾛﾌｨｰﾙ画面
                using (SearchUserProfForm frmUserProf = new SearchUserProfForm(this.lblSearchUserId.Text))
                {
                    // ﾂｲｰﾄﾎﾞﾀﾝ押下時
                    if (frmUserProf.ShowDialog() == DialogResult.OK)
                    {
              
                    }
                }

            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' 画面設定"
            /// <summary>
            /// ﾂｲｰﾄ色の設定
            /// </summary>
            /// <param name="sForeColor"></param>
            /// <param name="sBackColor"></param>
            /// <param name="sRepId"></param>
            private void setTweetColor(ref string sForeColor, ref string sBackColor)
            {
                // ﾂｲｰﾄの背景色の設定
                sForeColor = SettingsData.sMyTweetColor;
                sBackColor = SettingsData.sMyTweetBackColor;
            }
            /// <summary>
            /// 画面本体設定
            /// </summary>
            /// <param name="sForeColor"></param>
            /// <param name="sBackColor"></param>
            private void setBackColor(string sForeColor, string sBackColor)
            {
                // 画面幅の設定
                this.Width = 686;
                // 画面高さの設定
                this.Height = 80;
                // 背景色の設定
                this.BackColor = ColorTranslator.FromHtml(sBackColor);
                // 文字色の設定
                this.lblSearchUserName.ForeColor = ColorTranslator.FromHtml(sForeColor);
            }
            /// <summary>
            /// ﾕｰｻﾞ検索内容設定
            /// </summary>
            /// <param name="oJsonData"></param>
            /// <param name="sTweetCnt"></param>
            private void setUserResultInfo(JsonUserSearchData oJsonData, string sTweetCnt)
            {
                // ﾕｰｻﾞId
                this.lblSearchUserId.Name = "lblSearchUserId" + sTweetCnt;
                this.lblSearchUserId.Text = oJsonData.id_str;

                // ﾕｰｻﾞ名
                this.lblSearchUserName.Name = "lblUserName" + sTweetCnt;
                this.lblSearchUserName.Text = oJsonData.screen_name;
                this.lblSearchUserId.Left = this.lblSearchUserName.Right + 5;

                // ﾂｲｰﾄ内容取得
                this.lblTweets.Text = "";

                // ｱｲｺﾝ
                this.picSearchIcon.ImageLocation = oJsonData.profile_image_url;
            }
            /// <summary>
            /// ﾂｲｰﾄ検索内容設定
            /// </summary>
            /// <param name="oJsonData"></param>
            /// <param name="sTweetCnt"></param>
            private void setTweetResultInfo(Statuses oJsonData, string sTweetCnt)
            {
                // ﾕｰｻﾞID
                this.lblSearchUserId.Name = "lblSearchUserId" + sTweetCnt;
                this.lblSearchUserId.Text = oJsonData.user.id_str;

                // ﾕｰｻﾞ名
                this.lblSearchUserName.Name = "lblUserName" + sTweetCnt;
                this.lblSearchUserName.Text = oJsonData.user.screen_name;
                this.lblSearchUserId.Left = this.lblSearchUserName.Right + 5;

                // ｱｲｺﾝ
                this.picSearchIcon.ImageLocation = oJsonData.user.profile_image_url;

                // ﾂｲｰﾄ内容取得
                this.lblTweets.Text = oJsonData.text;

                // 画面ｻｲｽﾞ再設定
                this.Height = this.lblTweets.Height + 50;
            }
        #endregion
        //****************************************************
    }
}
