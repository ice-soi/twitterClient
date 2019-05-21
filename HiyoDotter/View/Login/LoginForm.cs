using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HiyoDotter.Controller;
using HiyoDotter.Logic;
using HiyoDotter.Data;

namespace HiyoDotter
{
    public partial class frmLogin: Form
    {
        //****************************************************
        #region"' ｸﾗｽ変数"
            /// <summary>
            /// XML処理ｵﾌﾞｼﾞｪｸﾄ
            /// </summary>
            clsXMLProcess poXMLProcess = new clsXMLProcess();
            /// <summary>
            /// OAuth情報
            /// </summary>
            clsOAuth poOAuthInfo = new clsOAuth();
        #endregion
        //****************************************************

        //****************************************************
        #region "' ｺﾝｽﾄﾗｸﾀ"
            // <summary>
            // ｺﾝｽﾄﾗｸﾀ
            // </summary>
            public frmLogin()
            {
                // 画面ｺﾝﾎﾟｰﾈﾝﾄInitialize
                InitializeComponent();
                // 設定のInitialize
                InitializeSetting();
                // ｺﾝﾌｨｸﾞのInitialize
                InitializeConfig();
            }
            /// <summary>
            /// 設定XML生成
            /// </summary>
            private void InitializeSetting()
            {
                // 設定ｲﾝｽﾀﾝｽ
                SettingsXML oSettingsXML = new SettingsXML();
                // 画面初期化
                oSettingsXML.setDefaultData();
                // 画面設定値設定
                oSettingsXML.setSettingData();
            }
            /// <summary>
            /// 設定XML生成
            /// </summary>
            private void InitializeConfig()
            {
                // 設定ｲﾝｽﾀﾝｽ
                ConfigXML oConfigXML = new ConfigXML();
                // 画面初期化
                oConfigXML.setDefaultData();
                // 画面設定値設定
                oConfigXML.setSettingData();
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' ｺﾝﾄﾛｰﾙｲﾍﾞﾝﾄ"
        /// <summary>
        /// ﾌｫｰﾑﾛｰﾄﾞ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogin_Load(object sender, EventArgs e)
            {
                // ﾘｸｴｽﾄﾄｰｸﾝを取得する
                poOAuthInfo.GetRequestToken();

                // RequestToken認証するURLを表示
                this.lblURL.Text = poOAuthInfo.GetAuthorizeUrl();
            }
            /// <summary>
            /// ﾘﾝｸﾗﾍﾞﾙｸﾘｯｸ
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void lblURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                System.Diagnostics.Process.Start(lblURL.Text.ToString());
            }
            /// <summary>
            /// OKﾎﾞﾀﾝｸﾘｯｸ
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnOk_Click(object sender, EventArgs e)
                {
                    // 入力したPINｺｰﾄﾞを取得
                    string pin = this.txtPinCode.Text;

                    // PINｺｰﾄﾞの入力内容をﾁｪｯｸ
                    if (String.IsNullOrEmpty(pin))
                    {
                        // 入力を促す
                        MessageBox.Show("PINｺｰﾄﾞを入力してください");
                        return;
                    }

                    // ｱｸｾｽﾄｰｸﾝを取得
                    poOAuthInfo.GetAccessToken(pin);

                    // ｱｸｾｽﾄｰｸﾝを設定
                    AccessData.sAccessToken = poOAuthInfo.AccessToken;
                    AccessData.sAccessTokenSecret = poOAuthInfo.AccessTokenSecret;
                    AccessData.sUserId = poOAuthInfo.UserId;
                    AccessData.sScreenName = poOAuthInfo.ScreenName;

                    // ｱｸｾｽ用XML出力
                    poXMLProcess.fStreamXML("ACCESS", poXMLProcess.outAccessXml);

                    // ｱｸｾｽ用XML出力
                    poXMLProcess.fStreamXML("SETTING", poXMLProcess.outSettingXml);

                    // ｱｸｾｽ用XML出力
                    poXMLProcess.fStreamXML("CONFIG", poXMLProcess.outConfigXml);

                    // OKを返す
                    DialogResult = DialogResult.OK;
                }
            /// <summary>
            /// ｷｬﾝｾﾙﾎﾞﾀﾝ押下
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnCancel_Click(object sender, EventArgs e)
            {
                // Cancelを返す
                DialogResult = DialogResult.Cancel;
            }
        #endregion
        //****************************************************
    }
}
