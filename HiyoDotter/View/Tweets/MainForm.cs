using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiyoDotter.View
{
    public partial class frmMain : Form
    {
        //****************************************************
        #region "' ｺﾝｽﾄﾗｸﾀ"
            /// <summary>
            /// ﾒｲﾝ画面ｺﾝｽﾄﾗｸﾀ
            /// </summary>
            public frmMain()
            {
                // 画面ｺﾝｽﾄﾗｸﾀ
                InitializeComponent();
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
            private void frmMain_Load(object sender, EventArgs e)
            {
                // ﾂｲｰﾄﾘｽﾄ設定
                frmTweet frmtweet = new frmTweet();
                frmtweet.TopLevel = false;
                pnTweetForm.Controls.Add(frmtweet);
                frmtweet.Show();   
            }
        #endregion
        //****************************************************
    }
}
