using HiyoDotter.Data;
using HiyoDotter.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiyoDotter.View.Config
{
    public partial class frmConfig : Form
    {
        //****************************************************
        #region "' ｸﾗｽ変数"
            /// <summary>
            /// XML処理
            /// </summary>
            private clsXMLProcess oXMLProcess = new clsXMLProcess();
        #endregion 
        //****************************************************

        //****************************************************
        #region "' ｺﾝｽﾄﾗｸﾀ"
        /// <summary>
        /// ｺﾝｽﾄﾗｸﾀ
        /// </summary>
        public frmConfig()
            {
                InitializeComponent();
                // 画面設定
                setConfigSetting();
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' 画面設定"
            /// <summary>
            /// ｺﾝﾌｨｸﾞ画面設定
            /// </summary>
            private void setConfigSetting()
            {
                // ｺﾝﾌｨｸﾞ画面の背景色
                this.BackColor = ColorTranslator.FromHtml(SettingsData.sConfigBackColor);

                // ﾒﾆｭｰ位置設定
                setMnuRdo();
            }
            /// <summary>
            /// ﾒﾆｭｰ初期設定
            /// </summary>
            private void setMnuRdo()
            {
                // ﾒﾆｭｰ位置
                switch (ConfigData.sMenuPosition)
                {
                    case "L":
                        this.rdoLeft.Checked = true;
                        break;
                    case "T":
                        this.rdoTop.Checked = true;
                        break;
                    case "R":
                        this.rdoRight.Checked = true;
                        break;
                    case "B":
                        this.rdoBottom.Checked = true;
                        break;
                    default:
                        break;
                }
            }
            /// <summary>
            /// 既定値ﾎﾞﾀﾝ押下
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnDefalt_Click(object sender, EventArgs e)
            {
                // 初期化
                ConfigXML oConfigData = new ConfigXML();
                // 設定値初期化
                oConfigData.setDefaultData();
                // 背景色再設定
                oConfigData.setSettingData();
                // 設定XML出力
                oXMLProcess.fStreamXML("CONFIG", oXMLProcess.outConfigXml);
                // 設定反映ﾒｯｾｰｼﾞ
                MessageBox.Show("設定が反映されました。");
            }
            /// <summary>
            /// 反映ﾎﾞﾀﾝ押下
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnConfigReg_Click(object sender, EventArgs e)
            {
                // 画面に反映した設定を取得
                setConfig();
                // 設定XML出力
                oXMLProcess.fStreamXML("CONFIG", oXMLProcess.outConfigXml);
                // 設定反映ﾒｯｾｰｼﾞ
                MessageBox.Show("設定が反映されました。");
            }
            /// <summary>
            /// 選択内容を取得
            /// </summary>
            private void setConfig()
            {
                // ﾒﾆｭｰ位置(左)
                if (this.rdoLeft.Checked)
                {
                    ConfigData.sMenuPosition = "L";
                    return;
                }

                // ﾒﾆｭｰ位置(上)
                if (this.rdoTop.Checked)
                {
                    ConfigData.sMenuPosition = "T";
                    return;
                }

                // ﾒﾆｭｰ位置(右)
                if (this.rdoRight.Checked)
                {
                    ConfigData.sMenuPosition = "R";
                    return;
                }

                // ﾒﾆｭｰ位置(下)
                if (this.rdoBottom.Checked)
                {
                    ConfigData.sMenuPosition = "B";
                    return;
                }
            }
        #endregion
        //****************************************************
    }
}
