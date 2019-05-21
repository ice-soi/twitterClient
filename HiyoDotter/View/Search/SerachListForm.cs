using HiyoDotter.Data;
using HiyoDotter.Logic;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HiyoDotter.View
{
    public partial class SerachListForm : Form
    {
        //****************************************************
        #region"' ｸﾗｽ変数"
            /// <summary>
            /// ﾂｲｰﾄﾛｼﾞｯｸ
            /// </summary>
            private clsTweetLogic oTweetLogic = new clsTweetLogic();
            /// <summary>
            /// 検索ﾀｲﾌﾟ
            /// </summary>
            private Boolean SearchType;
            /// <summary>
            /// 検索ﾜｰﾄﾞ
            /// </summary>
            private string SearchWord;
        #endregion
        //****************************************************

        //****************************************************
        #region "' ｺﾝｽﾄﾗｸﾀ"
            /// <summary>
            /// ｺﾝｽﾄﾗｸﾀ
            /// </summary>
            public SerachListForm(Boolean sSearchType,string sSearchWord)
            {
                // 画面ｺﾝﾎﾟｰﾈﾝﾄ
                InitializeComponent();
                // 色設定
                setColorSetting();
                // 検索ﾀｲﾌﾟ
                SearchType = sSearchType;
                // 検索ﾜｰﾄﾞ
                SearchWord = sSearchWord;
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' ｺﾝﾄﾛｰﾙｲﾍﾞﾝﾄ"
            /// <summary>
            /// 画面起動
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void SerachListForm_Load(object sender, EventArgs e)
            {
                // 検索ﾀｲﾌﾟ
                if (SearchType)
                {
                    // ﾕｰｻﾞ検索
                    setSearchUserResult();
                }
                else
                {
                    // ﾂｲｰﾄ検索
                    setSearchTweetResult();
                }       
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' ﾕｰｻﾞ検索"
            /// <summary>
            /// ﾕｰｻﾞ検索
            /// </summary>
            private void setSearchUserResult()
            {
                int frmTop = 0;
                // 検索画面ｸﾘｱ
                DisposeForm();
                // ﾕｰｻﾞ検索
                var oSearchUser = oTweetLogic.getSearchUser(SearchWord);
                // ﾕｰｻﾞﾘｽﾄ
                for (int i = 0; i <= oSearchUser.Length - 1; i++)
                {
                    // 画面設定
                    setUserForm(ref frmTop, oSearchUser[i], i.ToString());
                }
            }
            /// <summary>
            /// ﾕｰｻﾞ検索面設定
            /// </summary>
            /// <param name="frmTop"></param>
            /// <param name="oTweet"></param>
            /// <param name="iCnt"></param>
            private void setUserForm(ref int frmTop, JsonUserSearchData oTweet, string iCnt)
            {
                // ﾕｰｻﾞ検索表示
                SearchResultForm frmResult = new SearchResultForm(oTweet, iCnt);
                frmResult.TopLevel = false;
                frmResult.Top = frmTop;
                pnSearchList.Controls.Add(frmResult);
                frmResult.Show();
                frmTop += frmResult.Height + 5;
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' ﾂｲｰﾄ検索"
            /// <summary>
            /// ﾂｲｰﾄ検索
            /// </summary>
            private void setSearchTweetResult()
            {
                int frmTop = 0;
                // 検索画面ｸﾘｱ
                DisposeForm();
                // ﾂｲｰﾄ検索
                var oSearchTweet = oTweetLogic.getSearchTweet(SearchWord);
                // ﾂｲｰﾄﾘｽﾄ
                for (int i = 0; i <= oSearchTweet.statuses.Length - 1; i++)
                {
                    // 画面設定
                    setTweetForm(ref frmTop, oSearchTweet.statuses[i], i.ToString());
                }    
            }
            /// <summary>
            /// ﾂｲｰﾄ画面設定
            /// </summary>
            /// <param name="frmTop"></param>
            /// <param name="oTweet"></param>
            /// <param name="iCnt"></param>
            private void setTweetForm(ref int frmTop, Statuses oTweet, string iCnt)
            {
                // ﾂｲｰﾄ画面設定
                SearchResultForm frmResult = new SearchResultForm(oTweet, iCnt);
                frmResult.TopLevel = false;
                frmResult.Top = frmTop;
                pnSearchList.Controls.Add(frmResult);
                frmResult.Show();
                frmTop += frmResult.Height + 5;
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
                // 検索画面の背景色
                this.BackColor = ColorTranslator.FromHtml(SettingsData.sSearchBackColor);
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
            for (int iCnt = 0; iCnt <= pnSearchList.Controls.Count - 1; iCnt++)
            {
                pnSearchList.Controls[iCnt].Dispose();
            }
        }
        #endregion
        //****************************************************
    }
}
