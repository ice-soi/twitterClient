using HiyoDotter.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiyoDotter.View
{
    public partial class HomeTweetForm : Form
    {
        //****************************************************
        #region "' ｺﾝｽﾄﾗｸﾀ"
            /// <summary>
            /// ｺﾝｽﾄﾗｸﾀ
            /// </summary>
            public HomeTweetForm(JsonData oJsonData, string sTweetCnt)
            {
                // 画面ｺﾝﾎﾟｰﾈﾝﾄ
                InitializeComponent();
                // 取得ﾂｲｰﾄ作成
                InitView(oJsonData, sTweetCnt);
            }

            /// <summary>
            /// 画面初期化
            /// </summary>
            private void InitView(JsonData oJsonData, string sTweetCnt)
            {
                string sForeColor = "";
                string sBackColor = "";

                // ﾂｲｰﾄ色の取得
                setTweetColor(ref sForeColor, ref sBackColor, oJsonData.in_reply_to_status_id);

                // 背景色の設定
                setBackColor(sForeColor, sBackColor);

                // ﾂｲｰﾄ内容設定
                setTweetInfo(oJsonData, sTweetCnt);
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
            private void setTweetColor(ref string sForeColor, ref string sBackColor, object sRepId)
            {
                // ﾘﾌﾟﾗｲの画面設定
                if (sRepId != null)
                {
                    sForeColor = SettingsData.sRepColor;
                    sBackColor = SettingsData.sRepBackColor;
                    // 設定したら処理を抜ける
                    return;
                }
                // 自分のﾂｲｰﾄの背景色
                sForeColor = SettingsData.sMyTweetColor;
                sBackColor = SettingsData.sMyTweetBackColor;
            }
            /// <summary>
            /// 画面本体設定
            /// </summary>
            /// <param name="sBackColor"></param>
            private void setBackColor(string sForeColor, string sBackColor)
            {
                // 画面幅の設定
                this.Width = 663;
                // 画面高さの設定
                this.Height = 300;
                // 背景色の設定
                this.BackColor = ColorTranslator.FromHtml(sBackColor);

                // 文字色の設定
                this.lblTweet.ForeColor = ColorTranslator.FromHtml(sForeColor);
                this.lblTimeStamp.ForeColor = ColorTranslator.FromHtml(sForeColor);
                this.lblVia.ForeColor = ColorTranslator.FromHtml(sForeColor);
                this.lblUserName.ForeColor = ColorTranslator.FromHtml(sForeColor);
            }
            /// <summary>
            /// ﾂｲｰﾄ内容設定
            /// </summary>
            /// <param name="oJsonData"></param>
            /// <param name="sTweetCnt"></param>
            private void setTweetInfo(JsonData oJsonData,string sTweetCnt)
            {
                // ﾕｰｻﾞ名
                this.lblUserName.Name = "lblUserName" + sTweetCnt;
                this.lblUserName.Text = oJsonData.user.screen_name;
            
                // ﾂｲｰﾄ内容
                this.lblTweet.Name = "txtTweet" + sTweetCnt;
                this.lblTweet.Text = oJsonData.text;
                // 画面の高さを再設定
                this.Height = this.lblTweet.Height + 50;

                // 投稿時間
                this.lblTimeStamp.Name = "lblTimeStamp" + sTweetCnt;
                this.lblTimeStamp.Text = DateTime.ParseExact(oJsonData.created_at, "ddd MMM dd HH:mm:ss zzz yyyy",
                                                             System.Globalization.DateTimeFormatInfo.InvariantInfo,
                                                             System.Globalization.DateTimeStyles.None).ToString();
                // Via
                this.lblVia.Name = "lblVia" + sTweetCnt;
                this.lblVia.Text = Regex.Replace(oJsonData.source, "<.*?>", string.Empty);
                // ｱｲｺﾝ
                this.picTweetIcon.ImageLocation = oJsonData.user.profile_image_url;
                // ﾘﾌﾟﾗｲ用ID
                this.lblRepId.Text = oJsonData.id_str;
                // ﾘﾂｲｰﾄ用ID
                if (oJsonData.retweeted)
                {
                    this.lblRetweetId.Text = oJsonData.id_str;
                }
        }
        #endregion
        //****************************************************

        //****************************************************
        #region "' ｲﾍﾞﾝﾄ"
            private void picTweetIcon_Click(object sender, EventArgs e)
            {
                // ﾂｲｰﾄ画面
                using (frmTweetSend frmtweetSend = new frmTweetSend(this.lblRetweetId.Text,this.lblRepId.Text))
                {
                    // ﾂｲｰﾄﾎﾞﾀﾝ押下時
                    if (frmtweetSend.ShowDialog() == DialogResult.OK)
                    {
                    }
                }
        }
        #endregion 
        //****************************************************
    }
}
