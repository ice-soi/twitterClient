
namespace HiyoDotter.Data
{
    public class SettingsXML
    {
        //****************************************************
        #region "' ｸﾗｽ変数"
            /// <summary>
            /// ﾒﾆｭｰの背景色
            /// </summary>
            private string _sMenuBackColor;
            /// <summary>
            /// ﾒｲﾝ画面の背景色
            /// </summary>
            private string _sMainBackColor;
            /// <summary>
            /// ﾂｲｰﾄ画面の背景色
            /// </summary>
            private string _sTweetBackColor;
            /// <summary>
            /// 検索画面の背景色
            /// </summary>
            private string _sSearchBackColor;
            /// <summary>
            /// 設定画面の背景色
            /// </summary>
            private string _sSettingBackColor;
            /// <summary>
            /// ﾕｰｻﾞﾌﾟﾛﾌｨｰﾙ画面の背景色
            /// </summary>
            private string _sUserProfBackColor;
            /// <summary>
            /// 認証画面の背景色
            /// </summary>
            private string _sConfigBackColor;
            /// <summary>
            /// ﾀｲﾑﾗｲﾝの背景色
            /// </summary>
            private string _sTweetListBackColor;
            /// <summary>
            /// 自分のﾂｲｰﾄの文字色
            /// </summary>
            private string _sMyTweetColor;
            /// <summary>
            /// ﾘﾌﾟﾗｲの文字色
            /// </summary>
            private string _sRepColor;
            /// <summary>
            /// 自分のﾂｲｰﾄの背景色 
            /// </summary>
            private string _sMyTweetBackColor;
            /// <summary>
            /// 自分へのﾘﾌﾟﾗｲの背景色
            /// </summary>
            private string _sRepBackColor;
            /// <summary>
            /// ﾒｲﾝ画面ﾎﾞﾀﾝ
            /// </summary>
            private string _sBtnMain;
            /// <summary>
            /// 検索画面ﾎﾞﾀﾝ
            /// </summary>
            private string _sBtnSearch;
            /// <summary>
            /// 設定画面ﾎﾞﾀﾝ
            /// </summary>
            private string _sBtnSetting;
            /// <summary>
            /// ｺﾝﾌｨｸﾞ画面ﾎﾞﾀﾝ
            /// </summary>
            private string _sBtnConfig;
            /// <summary>
            /// ﾂｲｰﾄ画面ﾎﾞﾀﾝ
            /// </summary>
            private string _sBtnTweet;
            /// <summary>
            /// 送信画面ﾎﾞﾀﾝ
            /// </summary>
            private string _sBtnSend;
            /// <summary>
            /// ｷｬﾝｾﾙﾎﾞﾀﾝ
            /// </summary>
            private string _sBtnCancel;
            /// <summary>
            /// 選択ﾎﾞﾀﾝ
            /// </summary>
            private string _sBtnSelect;
            /// <summary>
            /// 初期化ﾎﾞﾀﾝ
            /// </summary>
            private string _sBtnDefault;
            /// <summary>
            /// 反映ﾎﾞﾀﾝ
            /// </summary>
            private string _sBtnSet;
            /// <summary>
            /// 検索ﾎﾞﾀﾝ
            /// </summary>
            private string _sBtnSearchList;
            /// <summary>
            /// 閉じるﾎﾞﾀﾝ
            /// </summary>
            private string _sBtnClose;
        #endregion
        //****************************************************

        //****************************************************
        #region "' ｺﾝｽﾄﾗｸﾀ"
        /// <summary>
        /// ｺﾝｽﾄﾗｸﾀ
        /// </summary>
        public SettingsXML()
            {
                MenuBackColor = SettingsData.sMenuBackColor;
                MainBackColor = SettingsData.sMainBackColor;
                TweetBackColor = SettingsData.sTweetBackColor;
                SearchBackColor = SettingsData.sSearchBackColor;
                SettingBackColor = SettingsData.sSettingBackColor;
                ConfigBackColor = SettingsData.sConfigBackColor;
                UserProfBackColor = SettingsData.sUserProfBackColor;
                TweetListBackColor = SettingsData.sTweetListBackColor;
                MyTweetColor = SettingsData.sMyTweetColor;
                RepColor = SettingsData.sRepColor;
                MyTweetBackColor = SettingsData.sMyTweetBackColor;
                RepBackColor = SettingsData.sRepBackColor;
                BtnMain = SettingsData.sBtnMain;
                BtnSearch = SettingsData.sBtnSearch;
                BtnSetting = SettingsData.sBtnSetting;
                BtnConfig = SettingsData.sBtnConfig;
                BtnTweet = SettingsData.sBtnTweet;
                BtnSend = SettingsData.sBtnSend;
                BtnCancel = SettingsData.sBtnCancel;
                BtnSelect = SettingsData.sBtnSelect;
                BtnDefault = SettingsData.sBtnDefault;
                BtnSet = SettingsData.sBtnSet;
                BtnSearchList = SettingsData.sBtnSearchList;
                BtnClose = SettingsData.sBtnClose;

        }
        #endregion
        //****************************************************

        //****************************************************
        #region "' ﾌﾟﾛﾊﾟﾃｨ"
            /// <summary>
            /// ﾒﾆｭｰの背景色
            /// </summary>
            public string MenuBackColor
            {
                get { return _sMenuBackColor; }
                set { _sMenuBackColor = value; }
            }
            /// <summary>
            /// ﾒｲﾝ画面の背景色
            /// </summary>
            public string MainBackColor
            {
                get { return _sMainBackColor; }
                set { _sMainBackColor = value; }
            }
            /// <summary>
            /// ﾂｲｰﾄ画面の背景色
            /// </summary>
            public string TweetBackColor
            {
                get { return _sTweetBackColor; }
                set { _sTweetBackColor = value; }
            }
            /// <summary>
            /// 検索画面の背景色
            /// </summary>
            public string SearchBackColor
            {
                get { return _sSearchBackColor; }
                set { _sSearchBackColor = value; }
            }
            /// <summary>
            /// 設定画面の背景色
            /// </summary>
            public string SettingBackColor
            {
                get { return _sSettingBackColor; }
                set { _sSettingBackColor = value; }
            }
            /// <summary>
            /// ﾕｰｻﾞﾌﾟﾛﾌｨｰﾙ画面の背景色
            /// </summary>
            public string UserProfBackColor
            {
                get { return _sUserProfBackColor; }
                set { _sUserProfBackColor = value; }
            }
            /// <summary>
            /// 認証画面の背景色
            /// </summary>
            public string ConfigBackColor
            {
                get { return _sConfigBackColor; }
                set { _sConfigBackColor = value; }
            }
            /// <summary>
            /// ﾀｲﾑﾗｲﾝの背景色
            /// </summary>
            public string TweetListBackColor
            {
                get { return _sTweetListBackColor; }
                set { _sTweetListBackColor = value; }
            }
            /// <summary>
            /// ﾕｰｻﾞﾂｲｰﾄの文字色
            /// </summary>
            public string MyTweetColor
            {
                get { return _sMyTweetColor; }
                set { _sMyTweetColor = value; }
            }
            /// <summary>
            /// ﾘﾌﾟﾗｲの文字色
            /// </summary>
            public string RepColor
            {
                get { return _sRepColor; }
                set { _sRepColor = value; }
            }
            /// <summary>
            /// ﾕｰｻﾞﾂｲｰﾄの背景色
            /// </summary>
            public string MyTweetBackColor
            {
                get { return _sMyTweetBackColor; }
                set { _sMyTweetBackColor = value; }
            }
            /// <summary>
            /// ﾘﾌﾟﾗｲの背景色
            /// </summary>
            public string RepBackColor
            {
                get { return _sRepBackColor; }
                set { _sRepBackColor = value; }
            }
            /// <summary>
            /// ﾒｲﾝ画面ﾎﾞﾀﾝ
            /// </summary>
            public string BtnMain
            {
                get { return _sBtnMain; }
                set { _sBtnMain = value; }
            }
            /// <summary>
            /// 検索画面ﾎﾞﾀﾝ
            /// </summary>
            public string BtnSearch
            {
                get { return _sBtnSearch; }
                set { _sBtnSearch = value; }
            }
            /// <summary>
            /// 設定画面ﾎﾞﾀﾝ
            /// </summary>
            public string BtnSetting
            {
                get { return _sBtnSetting; }
                set { _sBtnSetting = value; }
            }
            /// <summary>
            /// ｺﾝﾌｨｸﾞ画面ﾎﾞﾀﾝ
            /// </summary>
            public string BtnConfig
            {
                get { return _sBtnConfig; }
                set { _sBtnConfig = value; }
            }
            /// <summary>
            /// ﾂｲｰﾄ画面ﾎﾞﾀﾝ
            /// </summary>
            public string BtnTweet
            {
                get { return _sBtnTweet; }
                set { _sBtnTweet = value; }
            }
            /// <summary>
            /// 送信画面ﾎﾞﾀﾝ
            /// </summary>
            public string BtnSend
            {
                get { return _sBtnSend; }
                set { _sBtnSend = value; }
            }
            /// <summary>
            /// ｷｬﾝｾﾙﾎﾞﾀﾝ
            /// </summary>
            public string BtnCancel
            {
                get { return _sBtnCancel; }
                set { _sBtnCancel = value; }
            }
            /// <summary>
            /// 選択ﾎﾞﾀﾝ
            /// </summary>
            public string BtnSelect
            {
                get { return _sBtnSelect; }
                set { _sBtnSelect = value; }
            }
            /// <summary>
            /// 初期化ﾎﾞﾀﾝ
            /// </summary>
            public string BtnDefault
            {
                get { return _sBtnDefault; }
                set { _sBtnDefault = value; }
            }
            /// <summary>
            /// 反映ﾎﾞﾀﾝ
            /// </summary>
            public string BtnSet
            {
                get { return _sBtnSet; }
                set { _sBtnSet = value; }
            }
            /// <summary>
            /// 検索ﾎﾞﾀﾝ
            /// </summary>
            public string BtnSearchList
            {
                get { return _sBtnSearchList; }
                set { _sBtnSearchList = value; }
            }
            /// <summary>
            /// 閉じるﾎﾞﾀﾝ
            /// </summary>
            public string BtnClose
            {
                get { return _sBtnClose; }
                set { _sBtnClose = value; }
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' ﾒｿｯﾄﾞ"
        /// <summary>
        /// 設定値の設定
        /// </summary>
        /// <param name="oSettingsXML"></param>
        public void setSettingData()
            {
                SettingsData.sMenuBackColor = MenuBackColor;
                SettingsData.sMainBackColor = MainBackColor;
                SettingsData.sTweetBackColor = TweetBackColor;
                SettingsData.sSearchBackColor = SearchBackColor;
                SettingsData.sSettingBackColor = SearchBackColor;
                SettingsData.sUserProfBackColor = UserProfBackColor;
                SettingsData.sConfigBackColor = ConfigBackColor;
                SettingsData.sTweetListBackColor = TweetListBackColor;
                SettingsData.sMyTweetColor = MyTweetColor;
                SettingsData.sRepColor = RepColor;
                SettingsData.sMyTweetBackColor = MyTweetBackColor;
                SettingsData.sRepBackColor = RepBackColor;
                SettingsData.sBtnMain = BtnMain;
                SettingsData.sBtnSearch = BtnSearch;
                SettingsData.sBtnSetting = BtnSetting;
                SettingsData.sBtnConfig = BtnConfig;
                SettingsData.sBtnTweet = BtnTweet;
                SettingsData.sBtnSend = BtnSend;
                SettingsData.sBtnCancel = BtnCancel;
                SettingsData.sBtnSelect = BtnSelect;
                SettingsData.sBtnDefault = BtnDefault;
                SettingsData.sBtnSet = BtnSet;
                SettingsData.sBtnSearchList = BtnSearchList;
                SettingsData.sBtnClose = BtnClose;
            }
            /// <summary>
            /// 設定値初期化
            /// </summary>
            public void setDefaultData()
            {
                MenuBackColor = "255, 188, 122";
                MainBackColor = "255, 235, 213";
                TweetBackColor = "255, 255, 192";
                SearchBackColor = "255, 235, 213";
                SettingBackColor = "255, 235, 213";
                ConfigBackColor = "255, 235, 213";
                UserProfBackColor = "192, 255, 192";
                TweetListBackColor = "255, 188, 122";
                MyTweetColor = "0, 0, 0";
                RepColor = "0, 0, 0";
                MyTweetBackColor = "226, 239, 255";
                RepBackColor = "226, 219, 255";
                BtnMain = "30, 144, 255";
                BtnSearch = "30, 144, 255";
                BtnSetting = "30, 144, 255";
                BtnConfig = "30, 144, 255";
                BtnTweet = "30, 144, 255";
                BtnSend = "30, 144, 255";
                BtnCancel = "255, 192, 192";
                BtnSelect = "30, 144, 255";
                BtnDefault = "30, 144, 255";
                BtnSet = "30, 144, 255";
                BtnSearchList = "30, 144, 255";
                BtnClose = "30, 144, 255";
        }
        #endregion
        //****************************************************
    }
}
