using HiyoDotter.Data;
using HiyoDotter.Logic;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

namespace HiyoDotter.View
{
    public partial class frmTweet : Form
    {
        //****************************************************
        #region"' ｸﾗｽ変数"
            /// <summary>
            /// ﾂｲｰﾄﾛｼﾞｯｸ
            /// </summary>
            private clsTweetLogic oTweetLogic = new clsTweetLogic();
            /// <summary>
            /// ﾀｲﾏｰ
            /// </summary>
            private Timer tTimeLine = new Timer();
        #endregion
        //****************************************************

        //****************************************************
        #region "' ｺﾝｽﾄﾗｸﾀ"
            /// <summary>
            /// ｺﾝｽﾄﾗｸﾀ
            /// </summary>
            public frmTweet()
            {
                // 画面ｺﾝﾎﾟｰﾈﾝﾄ
                InitializeComponent();
                // 画面設定
                setColorSetting();
                // ﾀｲﾑﾗｲﾝのﾀｲﾏｰ設定
                setTimeLineTimer();
            }
        #endregion
        //****************************************************       

        //****************************************************
        #region "' ｺﾝﾄﾛｰﾙｲﾍﾞﾝﾄ"
            /// <summary>
            /// ﾂｲｰﾄ画面表示
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void frmTweet_Load(object sender, EventArgs e)
            {
                // ﾀｲﾑﾗｲﾝの取得
                var oTweetData = oTweetLogic.getTimeLine();
                // ﾕｰｻﾞ情報の設定
                setUserInfo(oTweetData[0]);
                // ﾀｲﾑﾗｲﾝの取得
                setTimeLine(oTweetData);
            }
            /// <summary>
            /// ﾂｲｰﾄﾎﾞﾀﾝｸﾘｯｸ
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnTweet_Click(object sender, EventArgs e)
            {
                // ﾂｲｰﾄ画面
                using (frmTweetSend frmtweetSend = new frmTweetSend())
                {
                    // ﾂｲｰﾄﾎﾞﾀﾝ押下時
                    if (frmtweetSend.ShowDialog() == DialogResult.OK)
                    {
                        // 画面の初期化
                        DisposeForm();
                        // ﾀｲﾑﾗｲﾝの取得
                        var oTweetData = oTweetLogic.getTimeLine();
                        // ﾀｲﾑﾗｲﾝの取得
                        setTimeLine(oTweetData);
                    }
                }    
            }
         #endregion
        //****************************************************

        //****************************************************
        #region "' ﾒｿｯﾄﾞ"
            /// <summary>
            /// ﾂｲｰﾄ画面設定
            /// </summary>
            /// <param name="frmTop"></param>
            /// <param name="oTweet"></param>
            /// <param name="iCnt"></param>
            /// <returns>画面位置</returns>
            private void setRepForm(ref int frmTop,JsonData oTweet,string iCnt) 
            {
                // ﾀｲﾑﾗｲﾝ
                HomeTweetForm repform = new HomeTweetForm(oTweet, iCnt);
                repform.TopLevel = false;
                repform.Top = frmTop;
                pnTweetForm.Controls.Add(repform);
                repform.Show();
                frmTop += repform.Height + 5;       
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
                // TWEETﾎﾞﾀﾝの背景色
                this.btnTweet.BackColor = ColorTranslator.FromHtml(SettingsData.sBtnTweet);

                // ﾀｲﾑﾗｲﾝの背景色
                this.BackColor = ColorTranslator.FromHtml(SettingsData.sTweetListBackColor);
            }
            /// <summary>
            /// ﾕｰｻﾞ情報設定
            /// </summary>
            /// <param name="oJsonData"></param>
            private void setUserInfo(JsonData oTweetData)
            {
                // ﾕｰｻﾞ名の設定
                this.lblTweetUser.Text = oTweetData.user.name;
                // ﾕｰｻﾞIDの設定
                this.lblTweetUserId.Text = oTweetData.user.id_str;
                this.lblTweetUserId.Left = this.lblTweetUser.Right + 5;
            }
            /// <summary>
            /// ﾀｲﾑﾗｲﾝ取得
            /// </summary>
            /// <param name="oTweetData"></param>
            private void setTimeLine(JsonData[] oTweetData)
            {
                // 画面位置
                int frmTop = 0;
                // 画面ｽｸﾛｰﾙ位置退避
                int frmScrollPosi = pnTweetForm.AutoScrollPosition.Y;
                // 画面設定のため一旦ｽｸﾛｰﾙを頂点に設定
                pnTweetForm.AutoScrollPosition = new Point(0, 0);
                // 画面の初期化
                DisposeForm();
                // ﾀｲﾑﾗｲﾝの取得
                for (int i = 0; i <= oTweetData.Length - 1; i++)
                {
                    // 画面設定
                    setRepForm(ref frmTop, oTweetData[i], i.ToString());
                }
                // 画面ｽｸﾛｰﾙ位置再設定
                pnTweetForm.AutoScrollPosition = new Point(0, frmScrollPosi * -1);
        }
        #endregion
        //****************************************************

        //****************************************************
        #region "' ﾀｲﾏｰ"
            /// <summary>
            /// ﾀｲﾏｰ設定
            /// </summary>
            private void setTimeLineTimer()
            {
                // ﾀｲﾏｰｲﾍﾞﾝﾄ
                tTimeLine.Tick += new EventHandler(this.tmTimeLine_Tick);
                // 10秒毎にﾘﾛｰﾄﾞ
                tTimeLine.Interval = int.Parse(ConfigurationManager.AppSettings["TIMER_INTERVAL"]);
                // ﾀｲﾏｰｽﾀｰﾄ
                tTimeLine.Start();
            }
            /// <summary>
            /// ﾀｲﾏｰｲﾍﾞﾝﾄ
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void tmTimeLine_Tick(object sender, EventArgs e)
            {
                // ﾀｲﾑﾗｲﾝの取得
                var oTweetData = oTweetLogic.getTimeLine();
                // ﾀｲﾑﾗｲﾝの取得
                setTimeLine(oTweetData);
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
                for (int iCnt = 0; iCnt <= pnTweetForm.Controls.Count - 1; iCnt++)
                {
                    pnTweetForm.Controls[iCnt].Dispose();
                }
            }
        #endregion
        //****************************************************
    }
}
