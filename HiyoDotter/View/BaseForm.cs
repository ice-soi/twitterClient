using System;
using System.Drawing;
using System.Windows.Forms;
using HiyoDotter.Data;
using HiyoDotter.View.Config;

namespace HiyoDotter.View
{
    public partial class frmBase : Form
    {
        //****************************************************
        #region"' ｸﾗｽ変数"
            /// <summary>
            /// ﾏｳｽのｸﾘｯｸ位置
            /// </summary>
            private Point mousePoint;
        #endregion
        //****************************************************

        //****************************************************
        #region "' ｺﾝｽﾄﾗｸﾀ"
        /// <summary>
        /// ｺﾝｽﾄﾗｸﾀ
        /// </summary>
        public frmBase()
            {
                // 画面ｺﾝﾎﾟｰﾈﾝﾄ
                InitializeComponent();
                // 画面設定
                setColorSetting();
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
            private void frmBase_Load(object sender, EventArgs e)
            {
                // ﾒｲﾝ画面呼び出し
                setControlMainView();
            }
            /// <summary>
            /// ﾒｲﾝﾎﾞﾀﾝ押下
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnMain_Click(object sender, EventArgs e)
            {
                pnFrmArea.Controls[0].Dispose();
                // ﾒｲﾝ画面呼び出し
                setControlMainView(); 
            }
            /// <summary>
            /// 検索ﾎﾞﾀﾝ押下
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnSearch_Click(object sender, EventArgs e)
            {
                pnFrmArea.Controls[0].Dispose();
                // 検索画面呼び出し
                setControlSearchView();
            }
            /// <summary>
            /// 設定ﾎﾞﾀﾝ押下
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnSetting_Click(object sender, EventArgs e)
            {
                pnFrmArea.Controls[0].Dispose();
                // 設定画面呼び出し
                setControlSettingView();
            }
            /// <summary>
            /// ｺﾝﾌｨｸﾞﾎﾞﾀﾝ押下
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnConfig_Click(object sender, EventArgs e)
            {
                pnFrmArea.Controls[0].Dispose();
                // 設定画面呼び出し
                setControlConfigView();
            }
        /// <summary>
        /// ｸﾛｰｽﾞﾎﾞﾀﾝ押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
            {
                this.Close();
            }
            /// <summary>
            /// ﾏｳｽが押された場合のｲﾍﾞﾝﾄ
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void frmBase_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
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
            private void frmBase_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
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
        #region "' ﾊﾟﾈﾙ設定"
            /// <summary>
            /// ﾒｲﾝ画面呼び出し
            /// </summary>
            public void setControlMainView()
            {
                // ﾒｲﾝ画面起動
                frmMain frmMainView = new frmMain();
                frmMainView.TopLevel = false;
                pnFrmArea.Controls.Add(frmMainView);
                frmMainView.BackColor = ColorTranslator.FromHtml(SettingsData.sMainBackColor);
                frmMainView.Show();
            }
            /// <summary>
            /// 検索画面呼び出し
            /// </summary>
            public void setControlSearchView()
            {
                // 検索画面起動
                frmSearch frmSearchView = new frmSearch();
                frmSearchView.TopLevel = false;
                pnFrmArea.Controls.Add(frmSearchView);
                frmSearchView.BackColor = ColorTranslator.FromHtml(SettingsData.sSearchBackColor);
                frmSearchView.Show();        
            }
            /// <summary>
            /// 設定画面呼び出し
            /// </summary>
            public void setControlSettingView()
            {
                // 設定画面起動
                frmSetting frmSettingView = new frmSetting();
                frmSettingView.TopLevel = false;
                pnFrmArea.Controls.Add(frmSettingView);
                frmSettingView.BackColor = ColorTranslator.FromHtml(SettingsData.sSettingBackColor);
                frmSettingView.Show();    
            }
            /// <summary>
            /// ｺﾝﾌｨｸﾞ画面呼び出し
            /// </summary>
            public void setControlConfigView()
            {
                // ｺﾝﾌｨｸﾞ画面起動
                frmConfig frmConfigView = new frmConfig();
                frmConfigView.TopLevel = false;
                pnFrmArea.Controls.Add(frmConfigView);
                frmConfigView.BackColor = ColorTranslator.FromHtml(SettingsData.sSettingBackColor);
                frmConfigView.Show();
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
                    // 画面の配置
                    setFormPosition();
                    // ﾒﾆｭｰの背景色
                    this.pnMene.BackColor = ColorTranslator.FromHtml(SettingsData.sMenuBackColor);
                    // 背景の背景色
                    this.pnFrmArea.BackColor = ColorTranslator.FromHtml(SettingsData.sMainBackColor);
                    // ﾒｲﾝﾎﾞﾀﾝの背景色
                    this.btnMain.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnMain);
                    // 検索ﾎﾞﾀﾝの背景色
                    this.btnSearch.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSearch);
                    // 設定ﾎﾞﾀﾝの背景色
                    this.btnSetting.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnSetting);
                    // ｺﾝﾌｨｸﾞﾎﾞﾀﾝの背景色
                    this.btnConfig.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnConfig);
                    // 閉じるﾎﾞﾀﾝの背景色
                    this.btnClose.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnClose);
            }
            /// <summary>
            /// ﾒﾆｭｰ位置設定
            /// </summary>
            private void setFormPosition()
            {
                switch (ConfigData.sMenuPosition)
                {
                    case "L":
                        setFormPositionLeft();
                        break;
                    case "T":
                        setFormPositionTop();
                        break;
                    case "R":
                        setFormPositionRight();
                        break;
                    case "B":
                        setFormPositionBottom();
                        break;
                    default:
                        break;
                }
            }
            /// <summary>
            /// ﾒﾆｭｰ設定(左側)
            /// </summary>
            private void setFormPositionLeft()
            {
                this.Height = 562;
                this.Width = 784;

                this.pnMene.Height = 563;
                this.pnMene.Width = 60;
                this.pnMene.Top = 0;
                this.pnMene.Left = 0;

                this.pnFrmArea.Height = 563;
                this.pnFrmArea.Width = 725;
                this.pnFrmArea.Top = 0;
                this.pnFrmArea.Left = 60;

                this.btnMain.Top = 10;
                this.btnMain.Left = 10;

                this.btnSearch.Top = 60;
                this.btnSearch.Left = 10;

                this.btnSetting.Top = 110;
                this.btnSetting.Left = 10;

                this.btnConfig.Top = 160;
                this.btnConfig.Left = 10;

                this.btnClose.Top = 510;
                this.btnClose.Left = 10;
            }
            /// <summary>
            /// ﾒﾆｭｰ設定(上側)
            /// </summary>
            private void setFormPositionTop()
            {
                this.Height = 622;
                this.Width = 724;

                this.pnMene.Height = 60;
                this.pnMene.Width = 725;
                this.pnMene.Top = 0;
                this.pnMene.Left = 0;

                this.pnFrmArea.Height = 563;
                this.pnFrmArea.Width = 725;
                this.pnFrmArea.Top = 60;
                this.pnFrmArea.Left = 0;

                this.btnMain.Top = 10;
                this.btnMain.Left = 10;

                this.btnSearch.Top = 10;
                this.btnSearch.Left = 60;

                this.btnSetting.Top = 10;
                this.btnSetting.Left = 110;

                this.btnConfig.Top = 10;
                this.btnConfig.Left = 160;

                this.btnClose.Top = 10;
                this.btnClose.Left = 675;
            }
            /// <summary>
            /// ﾒﾆｭｰ設定(右側)
            /// </summary>
            private void setFormPositionRight()
            {
                this.Height = 562;
                this.Width = 784;

                this.pnMene.Height = 563;
                this.pnMene.Width = 60;
                this.pnMene.Top = 0;
                this.pnMene.Left = 725;

                this.pnFrmArea.Height = 563;
                this.pnFrmArea.Width = 725;
                this.pnFrmArea.Top = 0;
                this.pnFrmArea.Left = 0;

                this.btnMain.Top = 10;
                this.btnMain.Left = 10;

                this.btnSearch.Top = 60;
                this.btnSearch.Left = 10;

                this.btnSetting.Top = 110;
                this.btnSetting.Left = 10;

                this.btnConfig.Top = 160;
                this.btnConfig.Left = 10;

                this.btnClose.Top = 510;
                this.btnClose.Left = 10;
            }
            /// <summary>
            /// ﾒﾆｭｰ設定(左側)
            /// </summary>
            private void setFormPositionBottom()
            {
                this.Height = 622;
                this.Width = 724;

                this.pnMene.Height = 60;
                this.pnMene.Width = 725;
                this.pnMene.Top = 563;
                this.pnMene.Left = 0;

                this.pnFrmArea.Height = 563;
                this.pnFrmArea.Width = 725;
                this.pnFrmArea.Top = 0;
                this.pnFrmArea.Left = 0;

                this.btnMain.Top = 10;
                this.btnMain.Left = 10;

                this.btnSearch.Top = 10;
                this.btnSearch.Left = 60;

                this.btnSetting.Top = 10;
                this.btnSetting.Left = 110;

                this.btnConfig.Top = 10;
                this.btnConfig.Left = 160;

                this.btnClose.Top = 10;
                this.btnClose.Left = 675;
            }
        #endregion
        //****************************************************
    }
}
