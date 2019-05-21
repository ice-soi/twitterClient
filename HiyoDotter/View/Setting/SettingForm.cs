using System;
using System.Drawing;
using System.Windows.Forms;
using HiyoDotter.Data;
using HiyoDotter.Logic;

namespace HiyoDotter.View
{
    public partial class frmSetting : Form
    {
        //****************************************************
        #region "' ｸﾗｽ変数"
            /// <summary>
            /// XML処理
            /// </summary>
            private clsXMLProcess oXMLProcess = new clsXMLProcess();
            /// <summary>
            /// ｶﾗｰﾀﾞｲｱﾛｸﾞ
            /// </summary>
            private ColorDialog clrDialog = new ColorDialog();
        #endregion
        //****************************************************

        //****************************************************
        #region "' ｺﾝｽﾄﾗｸﾀ"
            /// <summary>
            /// 設定画面ｺﾝｽﾄﾗｸﾀ
            /// </summary>
            public frmSetting()
            {
                // 画面ｺﾝﾎﾟｰﾈﾝﾄ初期化
                InitializeComponent();
                // 色設定
                setColorSetting();
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' 設定共通"
            /// <summary>
            /// ﾃﾞﾘｹﾞｰﾄ
            /// </summary>
            delegate void setBackColor();
            /// <summary>
            /// 選択色設定
            /// </summary>
            /// <param name="oBacColor"></param>
            private void setColorDialog(setBackColor oBacColor)
            {
                if (clrDialog.ShowDialog() == DialogResult.OK)
                {
                    // 背景色設定
                    oBacColor();
                }
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' 背景色"

        //****************************************************
        #region "' 背景色設定処理"
        /// <summary>
        /// ﾒﾆｭｰ背景色
        /// </summary>
        private void fMnuColor()
            {
                txtMnuColor.BackColor = Color.FromArgb(clrDialog.Color.R, clrDialog.Color.G, clrDialog.Color.B);
            }
            /// <summary>
            /// ﾒｲﾝ背景色
            /// </summary>
            private void fMainColor()
            {
                txtMainColor.BackColor = Color.FromArgb(clrDialog.Color.R, clrDialog.Color.G, clrDialog.Color.B);
            }
            /// <summary>
            /// 検索背景色
            /// </summary>
            private void fSearchColor()
            {
                txtSearch.BackColor = Color.FromArgb(clrDialog.Color.R, clrDialog.Color.G, clrDialog.Color.B);
            }
            /// <summary>
            /// 設定背景色
            /// </summary>
            private void fSettingColor()
            {
                txtSetting.BackColor = Color.FromArgb(clrDialog.Color.R, clrDialog.Color.G, clrDialog.Color.B);
            }
            /// <summary>
            /// ｺﾝﾌｨｸﾞ背景色
            /// </summary>
            private void fConfigColor()
            {
                txtConfig.BackColor = Color.FromArgb(clrDialog.Color.R, clrDialog.Color.G, clrDialog.Color.B);
            }
            /// <summary>
            /// ﾂｲｰﾄ背景色
            /// </summary>
            private void fTweetColor()
            {
                txtTweet.BackColor = Color.FromArgb(clrDialog.Color.R, clrDialog.Color.G, clrDialog.Color.B);
            }
            /// <summary>
            /// ﾂｲｰﾄﾘｽﾄ背景色
            /// </summary>
            private void fTweetListColor()
            {
                txtTweetList.BackColor = Color.FromArgb(clrDialog.Color.R, clrDialog.Color.G, clrDialog.Color.B);
            }
            /// <summary>
            /// ﾕｰｻﾞﾌﾟﾛﾌｨｰﾙ背景色
            /// </summary>
            private void fUserProfColor()
            {
                txtUserProf.BackColor = Color.FromArgb(clrDialog.Color.R, clrDialog.Color.G, clrDialog.Color.B);
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' 背景色ｺﾝﾄﾛｰﾙｲﾍﾞﾝﾄ"
        /// <summary>
        /// ﾒﾆｭｰの背景色選択
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMnuColor_Click(object sender, EventArgs e)
            {
                // 色選択
                setColorDialog(fMnuColor);
            }
            /// <summary>
            /// 全体の背景色選択
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnMainColor_Click(object sender, EventArgs e)
            {
                // 色選択
                setColorDialog(fMainColor);
            }
            /// <summary>
            /// 検索画面の背景色設定
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnSearch_Click(object sender, EventArgs e)
            {
                // 色選択
                setColorDialog(fSearchColor);
            }
            /// <summary>
            /// 設定画面の背景色設定
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnSetting_Click(object sender, EventArgs e)
            {
                // 色選択
                setColorDialog(fSettingColor);
            }
            /// <summary>
            /// ﾕｰｻﾞﾌﾟﾛﾌｨｰﾙの背景色設定
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnUserProf_Click(object sender, EventArgs e)
            {
                // 色選択
                setColorDialog(fUserProfColor);
            }
            /// <summary>
            /// ｺﾝﾌｨｸﾞ画面の背景色設定
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnConfig_Click(object sender, EventArgs e)
            {
                // 色選択
                setColorDialog(fConfigColor);
            }
            /// <summary>
            /// ﾂｲｰﾄ画面の背景色設定
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnTweet_Click(object sender, EventArgs e)
            {
                // 色選択
                setColorDialog(fTweetColor);
            }
            /// <summary>
            /// ﾀｲﾑﾗｲﾝの背景色設定
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnTweetList_Click(object sender, EventArgs e)
            {
                // 色選択
                setColorDialog(fTweetListColor);
            }
        #endregion
        //****************************************************

        #endregion
        //****************************************************

        //****************************************************
        #region "' ﾂｲｰﾄ"

        //****************************************************
        #region "' ﾂｲｰﾄ設定処理"
        /// <summary>
        /// 自分のﾂｲｰﾄの文字色
        /// </summary>
        private void fMyTweetColor()
            {
                txtMyTweetColor.BackColor = Color.FromArgb(clrDialog.Color.R, clrDialog.Color.G, clrDialog.Color.B);
            }
            /// <summary>
            /// ﾘﾌﾟﾗｲの文字色
            /// </summary>
            private void fRepColor()
            {
                txtRepColor.BackColor = Color.FromArgb(clrDialog.Color.R, clrDialog.Color.G, clrDialog.Color.B);
            }
            /// <summary>
            /// 自分のﾂｲｰﾄの背景色
            /// </summary>
            private void fMyTweetBackColor()
            {
                txtMyTweetBackColor.BackColor = Color.FromArgb(clrDialog.Color.R, clrDialog.Color.G, clrDialog.Color.B);
            }
            /// <summary>
            /// ﾘﾌﾟﾗｲ背景色
            /// </summary>
            private void fRepBackColor()
            {
                txtRepBackColor.BackColor = Color.FromArgb(clrDialog.Color.R, clrDialog.Color.G, clrDialog.Color.B);
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' ﾂｲｰﾄｺﾝﾄﾛｰﾙｲﾍﾞﾝﾄ"
            /// <summary>
            /// 自分のﾂｲｰﾄの文字色選択
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnMyTweetColor_Click(object sender, EventArgs e)
            {
                // 色選択
                setColorDialog(fMyTweetColor);
            }
            /// <summary>
            /// 自分へのﾘﾌﾟﾗｲの背景色選択
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnRepColor_Click(object sender, EventArgs e)
            {
                // 色選択
                setColorDialog(fRepColor);
            }
            /// <summary>
            /// 自分のﾂｲｰﾄの背景色選択
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnMyTweetBackColor_Click(object sender, EventArgs e)
            {
                // 色選択
                setColorDialog(fMyTweetBackColor);

            }
            /// <summary>
            /// 自分へのﾘﾌﾟﾗｲの背景色選択
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnRepBackColor_Click(object sender, EventArgs e)
            {
                // 色選択
                setColorDialog(fRepBackColor);
            }
        #endregion
        //****************************************************

        #endregion
        //****************************************************

        //****************************************************
        #region "' ﾎﾞﾀﾝ"

        //****************************************************
        #region "' ﾎﾞﾀﾝ背景色設定処理"
        /// <summary>
        /// ﾒｲﾝﾎﾞﾀﾝ背景色
        /// </summary>
        private void fBtnMainColor()
            {
                txtBtnMain.BackColor = Color.FromArgb(clrDialog.Color.R, clrDialog.Color.G, clrDialog.Color.B);
            }
            /// <summary>
            /// 検索ﾎﾞﾀﾝ背景色
            /// </summary>
            private void fBtnSearchColor()
            {
                txtBtnSearch.BackColor = Color.FromArgb(clrDialog.Color.R, clrDialog.Color.G, clrDialog.Color.B);
            }
            /// <summary>
            /// 設定ﾎﾞﾀﾝ背景色
            /// </summary>
            private void fBtnConfigColor()
            {
                txtBtnSetting.BackColor = Color.FromArgb(clrDialog.Color.R, clrDialog.Color.G, clrDialog.Color.B);
            }
            /// <summary>
            /// ｺﾝﾌｨｸﾞﾎﾞﾀﾝ背景色
            /// </summary>
            private void fBtnConfig()
            {
                txtBtnConfig.BackColor = Color.FromArgb(clrDialog.Color.R, clrDialog.Color.G, clrDialog.Color.B);
            }
            /// <summary>
            /// ﾂｲｰﾄﾎﾞﾀﾝ背景色
            /// </summary>
            private void fBtnTweetColor()
            {
                txtBtnTweet.BackColor = Color.FromArgb(clrDialog.Color.R, clrDialog.Color.G, clrDialog.Color.B);
            }
            /// <summary>
            /// 送信ﾎﾞﾀﾝ背景色
            /// </summary>
            private void fBtnSendColor()
            {
                txtBtnSend.BackColor = Color.FromArgb(clrDialog.Color.R, clrDialog.Color.G, clrDialog.Color.B);
            }
            /// <summary>
            /// ｷｬﾝｾﾙﾎﾞﾀﾝ背景色
            /// </summary>
            private void fBtnCancelColor()
            {
                txtBtnCancel.BackColor = Color.FromArgb(clrDialog.Color.R, clrDialog.Color.G, clrDialog.Color.B);
            }
            /// <summary>
            /// 選択ﾎﾞﾀﾝ背景色
            /// </summary>
            private void fBtnSelectColor()
            {
                txtBtnSelect.BackColor = Color.FromArgb(clrDialog.Color.R, clrDialog.Color.G, clrDialog.Color.B);
            }
            /// <summary>
            /// 既定ﾎﾞﾀﾝ背景色
            /// </summary>
            private void fBtnDefaultColor()
            {
                txtBtnDefault.BackColor = Color.FromArgb(clrDialog.Color.R, clrDialog.Color.G, clrDialog.Color.B);
            }
            /// <summary>
            /// 反映ﾎﾞﾀﾝ背景色
            /// </summary>
            private void fBtnSetColor()
            {
                txtBtnSet.BackColor = Color.FromArgb(clrDialog.Color.R, clrDialog.Color.G, clrDialog.Color.B);
            }
            /// <summary>
            /// 検索ﾎﾞﾀﾝ背景色
            /// </summary>
            private void fBtnSearchList()
            {
                txtBtnSearchList.BackColor = Color.FromArgb(clrDialog.Color.R, clrDialog.Color.G, clrDialog.Color.B);
            }
            /// <summary>
            /// 閉じるﾎﾞﾀﾝ背景色
            /// </summary>
            private void fBtnClose()
            {
                txtBtnClose.BackColor = Color.FromArgb(clrDialog.Color.R, clrDialog.Color.G, clrDialog.Color.B);
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' ﾎﾞﾀﾝｺﾝﾄﾛｰﾙｲﾍﾞﾝﾄ"
        /// <summary>
        /// ﾒｲﾝﾎﾞﾀﾝの背景色設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBtnMain_Click(object sender, EventArgs e)
            {
                // 色選択
                setColorDialog(fBtnMainColor);
            }
            /// <summary>
            /// 検索ﾎﾞﾀﾝの背景色設定
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnBtnSearch_Click(object sender, EventArgs e)
            {
                // 色選択
                setColorDialog(fBtnSearchColor);
            }
            /// <summary>
            /// 設定ﾎﾞﾀﾝの背景色設定
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnBtnSetting_Click(object sender, EventArgs e)
            {
                // 色選択
                setColorDialog(fBtnConfigColor);
            }
            /// <summary>
            /// ｺﾝﾌｨｸﾞﾎﾞﾀﾝの背景色設定
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnBtnConfig_Click(object sender, EventArgs e)
            {
                // 色選択
                setColorDialog(fBtnConfigColor);
            }
            /// <summary>
            /// ﾂｲｰﾄﾎﾞﾀﾝの背景色設定
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnBtnTweet_Click(object sender, EventArgs e)
            {
                // 色選択
                setColorDialog(fBtnTweetColor);
            }
            /// <summary>
            /// 送信ﾎﾞﾀﾝの背景色設定
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnBtnSend_Click(object sender, EventArgs e)
            {
                // 色選択
                setColorDialog(fBtnSendColor);
            }
            /// <summary>
            /// 閉じるﾎﾞﾀﾝの背景色設定
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnBtnCancel_Click(object sender, EventArgs e)
            {
                // 色選択
                setColorDialog(fBtnCancelColor);
            }
            /// <summary>
            /// 選択ﾎﾞﾀﾝの背景色設定
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnBtnSelect_Click(object sender, EventArgs e)
            {
                // 色選択
                setColorDialog(fBtnSelectColor);
            }
            /// <summary>
            /// 規定値ﾎﾞﾀﾝの背景色設定
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnBtnDefault_Click(object sender, EventArgs e)
            {
                // 色選択
                setColorDialog(fBtnDefaultColor);
            }
            /// <summary>
            /// 反映ﾎﾞﾀﾝの背景色設定
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnBtnSet_Click(object sender, EventArgs e)
            {
                // 色選択
                setColorDialog(fBtnSetColor);
            }
            /// <summary>
            /// 検索ﾎﾞﾀﾝの背景色設定
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnBtnSearchList_Click(object sender, EventArgs e)
            {
                // 色選択
                setColorDialog(fBtnSearchList);
            }
            /// <summary>
            /// 閉じるﾎﾞﾀﾝの背景色設定
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnBtnClose_Click(object sender, EventArgs e)
            {
                // 色選択
                setColorDialog(fBtnClose);
            }
        #endregion
        //****************************************************

        #endregion
        //****************************************************

        //****************************************************
        #region "' 確定処理"
            /// <summary>
            /// 反映ﾎﾞﾀﾝ押下
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnSettingReg_Click(object sender, EventArgs e)
            {
                // 画面に反映した設定を取得
                setSettings();
                // 設定XML出力
                oXMLProcess.fStreamXML("SETTING", oXMLProcess.outSettingXml);
                // 設定反映ﾒｯｾｰｼﾞ
                MessageBox.Show("設定が反映されました。");
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnDefalt_Click(object sender, EventArgs e)
            {
                // 初期化
                SettingsXML oSettingData = new SettingsXML();
                // 設定値初期化
                oSettingData.setDefaultData();
                // 背景色再設定
                oSettingData.setSettingData();
                // 設定XML出力
                oXMLProcess.fStreamXML("SETTING", oXMLProcess.outSettingXml);
                // 設定反映ﾒｯｾｰｼﾞ
                MessageBox.Show("設定が反映されました。");
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' 色設定"
            /// <summary>
            /// 色設定
            /// </summary>
            private void setSettings()
            {
                // 背景色設定
                setSettingBackColor();
                // ﾂｲｰﾄ色設定
                setSettingTweetColor();
                // ﾎﾞﾀﾝ色設定
                setSettingBtnColor();
            }
            /// <summary>
            /// 色設定
            /// </summary>
            /// <param name="sR"></param>
            /// <param name="sG"></param>
            /// <param name="sB"></param>
            /// <returns></returns>
            private string setSettingColor(byte sR,byte sG,byte sB)
            {
                return string.Format("{0},{1},{2}",sR.ToString(), sG.ToString(), sB.ToString());
            }
            /// <summary>
            /// 背景色設定
            /// </summary>
            private void setSettingBackColor()
            {
                // ﾒﾆｭｰ背景色
                SettingsData.sMenuBackColor = setSettingColor(txtMnuColor.BackColor.R, txtMnuColor.BackColor.G, txtMnuColor.BackColor.B);
                // 本体背景色
                SettingsData.sMainBackColor = setSettingColor(txtMainColor.BackColor.R, txtMainColor.BackColor.G, txtMainColor.BackColor.B);
                // 検索画面背景色
                SettingsData.sSearchBackColor = setSettingColor(txtSearch.BackColor.R, txtSearch.BackColor.G, txtSearch.BackColor.B);
                // 設定画面背景色
                SettingsData.sSettingBackColor = setSettingColor(txtSetting.BackColor.R, txtSetting.BackColor.G, txtSetting.BackColor.B);
                // 設定画面背景色
                SettingsData.sUserProfBackColor = setSettingColor(txtUserProf.BackColor.R, txtUserProf.BackColor.G, txtUserProf.BackColor.B);
                // ﾂｲｰﾄ画面背景色
                SettingsData.sTweetBackColor = setSettingColor(txtTweet.BackColor.R, txtTweet.BackColor.G, txtTweet.BackColor.B);
                // ｺﾝﾌｨｸﾞ画面背景色
                SettingsData.sConfigBackColor = setSettingColor(txtConfig.BackColor.R, txtConfig.BackColor.G, txtConfig.BackColor.B);
                // ﾀｲﾑﾗｲﾝ背景色
                SettingsData.sTweetListBackColor = setSettingColor(txtTweetList.BackColor.R, txtTweetList.BackColor.G, txtTweetList.BackColor.B);
            }
            /// <summary>
            /// ﾂｲｰﾄ色設定
            /// </summary>
            private void setSettingTweetColor()
            {
                // 自分のﾂｲｰﾄの文字色
                SettingsData.sMyTweetColor = setSettingColor(txtMyTweetColor.BackColor.R, txtMyTweetColor.BackColor.G, txtMyTweetColor.BackColor.B);
                // ﾘﾌﾟﾗｲの文字色
                SettingsData.sRepColor = setSettingColor(txtRepColor.BackColor.R, txtRepColor.BackColor.G, txtRepColor.BackColor.B);
                // 自分のﾂｲｰﾄの背景色
                SettingsData.sMyTweetBackColor = setSettingColor(txtMyTweetBackColor.BackColor.R, txtMyTweetBackColor.BackColor.G, txtMyTweetBackColor.BackColor.B);
                // ﾘﾌﾟﾗｲの背景色
                SettingsData.sRepBackColor = setSettingColor(txtRepBackColor.BackColor.R, txtRepBackColor.BackColor.G, txtRepBackColor.BackColor.B);
            }
            /// <summary>
            /// ﾎﾞﾀﾝ色設定
            /// </summary>
            private void setSettingBtnColor()
            {
                // ﾒｲﾝ画面ﾎﾞﾀﾝ
                SettingsData.sBtnMain = setSettingColor(txtBtnMain.BackColor.R, txtBtnMain.BackColor.G, txtBtnMain.BackColor.B);
                // 検索画面ﾎﾞﾀﾝ
                SettingsData.sBtnSearch = setSettingColor(txtBtnSearch.BackColor.R, txtBtnSearch.BackColor.G, txtBtnSearch.BackColor.B);
                // 設定画面ﾎﾞﾀﾝ
                SettingsData.sBtnSetting = setSettingColor(txtBtnSetting.BackColor.R, txtBtnSetting.BackColor.G, txtBtnSetting.BackColor.B);
                // ｺﾝﾌｨｸﾞ画面ﾎﾞﾀﾝ
                SettingsData.sBtnConfig = setSettingColor(txtBtnConfig.BackColor.R, txtBtnConfig.BackColor.G, txtBtnConfig.BackColor.B);
                // TWEETﾎﾞﾀﾝ
                SettingsData.sBtnTweet = setSettingColor(txtBtnTweet.BackColor.R, txtBtnTweet.BackColor.G, txtBtnTweet.BackColor.B);
                // 送信ﾎﾞﾀﾝ
                SettingsData.sBtnSend = setSettingColor(txtBtnSend.BackColor.R, txtBtnSend.BackColor.G, txtBtnSend.BackColor.B);
                // 閉じるﾎﾞﾀﾝ
                SettingsData.sBtnCancel = setSettingColor(txtBtnCancel.BackColor.R, txtBtnCancel.BackColor.G, txtBtnCancel.BackColor.B);
                // 選択ﾎﾞﾀﾝ
                SettingsData.sBtnSelect = setSettingColor(txtBtnSelect.BackColor.R, txtBtnSelect.BackColor.G, txtBtnSelect.BackColor.B);
                // 規定値ﾎﾞﾀﾝ
                SettingsData.sBtnDefault = setSettingColor(txtBtnDefault.BackColor.R, txtBtnDefault.BackColor.G, txtBtnDefault.BackColor.B);
                // 反映ﾎﾞﾀﾝ
                SettingsData.sBtnSet = setSettingColor(txtBtnSet.BackColor.R, txtBtnSet.BackColor.G, txtBtnSet.BackColor.B);
                // 検索ﾎﾞﾀﾝ
                SettingsData.sBtnSearchList = setSettingColor(txtBtnSearchList.BackColor.R, txtBtnSearchList.BackColor.G, txtBtnSearchList.BackColor.B);
                // 閉じるﾎﾞﾀﾝ
                SettingsData.sBtnClose = setSettingColor(txtBtnClose.BackColor.R, txtBtnClose.BackColor.G, txtBtnClose.BackColor.B);
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' 画面設定"
        /// <summary>
        /// 設定画面設定
        /// </summary>
        private void setColorSetting()
            {
                // 選択ﾎﾞﾀﾝ設定
                setSettingBtnBackColor();
                // 設定画面設定
                setSettingColor();
                // 選択設定色設定
                setSelectSettingColor();
            }
            /// <summary>
            /// 選択ﾎﾞﾀﾝ背景色設定
            /// </summary>
            private void setSettingBtnBackColor()
            {
                // 選択ﾎﾞﾀﾝ
                this.btnBtnSelect.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSelect);
                this.btnBtnCancel.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSelect);
                this.btnConfig.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSelect);
                this.btnBtnClose.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSelect);
                this.btnBtnDefault.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSelect);
                this.btnBtnMain.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSelect);
                this.btnBtnSearch.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSelect);
                this.btnBtnSearchList.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSelect);
                this.btnBtnSend.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSelect);
                this.btnBtnSetting.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSelect);
                this.btnBtnTweet.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSelect);
                this.btnMainColor.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSelect);
                this.btnMnuColor.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSelect);
                this.btnMyTweetBackColor.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSelect);
                this.btnMyTweetColor.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSelect);
                this.btnRepBackColor.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSelect);
                this.btnRepColor.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSelect);
                this.btnSearch.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSelect);
                this.btnSetting.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSelect);
                this.btnBtnSet.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSelect);
                this.btnTweet.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSelect);
                this.btnTweetList.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSelect);

            }
            /// <summary>
            /// 設定画面設定
            /// </summary>
            private void setSettingColor()
            {
                // 規定値ﾎﾞﾀﾝの背景色
                this.btnDefalt.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnDefault);

                // 反映ﾎﾞﾀﾝの背景色
                this.btnSettingReg.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSet);

                // 設定画面の背景色
                this.BackColor = ColorTranslator.FromHtml(SettingsData.sSettingBackColor);
            }
            /// <summary>
            /// 選択設定色設定
            /// </summary>
            private void setSelectSettingColor()
            {
                // 背景色
                txtMnuColor.BackColor = ColorTranslator.FromHtml(SettingsData.sMenuBackColor);
                txtMainColor.BackColor = ColorTranslator.FromHtml(SettingsData.sMainBackColor);
                txtSearch.BackColor = ColorTranslator.FromHtml(SettingsData.sSearchBackColor);
                txtSetting.BackColor = ColorTranslator.FromHtml(SettingsData.sSettingBackColor);
                txtUserProf.BackColor = ColorTranslator.FromHtml(SettingsData.sUserProfBackColor);
                txtTweet.BackColor = ColorTranslator.FromHtml(SettingsData.sTweetBackColor);
                txtConfig.BackColor = ColorTranslator.FromHtml(SettingsData.sConfigBackColor);
                txtTweetList.BackColor = ColorTranslator.FromHtml(SettingsData.sTweetListBackColor);
                // ﾂｲｰﾄ
                txtMyTweetColor.BackColor = ColorTranslator.FromHtml(SettingsData.sMyTweetColor);
                txtRepColor.BackColor = ColorTranslator.FromHtml(SettingsData.sRepColor);
                txtMyTweetBackColor.BackColor = ColorTranslator.FromHtml(SettingsData.sMyTweetBackColor);
                txtRepBackColor.BackColor = ColorTranslator.FromHtml(SettingsData.sRepBackColor);
                // ﾎﾞﾀﾝ
                txtBtnMain.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnMain);
                txtBtnSearch.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSearch);
                txtBtnSetting.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSetting);
                txtBtnTweet.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnTweet);
                txtBtnSend.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSend);
                txtBtnCancel.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnCancel);
                txtBtnSelect.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSelect);
                txtBtnDefault.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnDefault);
                txtBtnSet.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSet);
                txtBtnSearchList.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSearchList);
                txtBtnClose.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnClose);
            }

        #endregion
        //****************************************************
    }
}
