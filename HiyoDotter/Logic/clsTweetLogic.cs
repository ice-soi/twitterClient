using System.Collections.Generic;
using System.Text;
using HiyoDotter.Data;
using System.IO;
using System.Runtime.Serialization.Json;
using HiyoDotter.Data.Json;
using System;

namespace HiyoDotter.Logic
{
    class clsTweetLogic
    {
        //****************************************************
        #region "' ｸﾗｽ変数"
            /// <summary>
            /// OAuth認証
            /// </summary>
            private clsOAuth poOAuthInfo = null;
            /// <summary>
            /// ﾛｸﾞﾏﾈｰｼﾞｬｰ
            /// </summary>
            private clsLogManager poLogManager = new clsLogManager();
        #endregion
        //****************************************************

        //****************************************************
        #region "' ｺﾝｽﾄﾗｸﾀ"
        public clsTweetLogic()
            {
                poOAuthInfo = new clsOAuth(AccessData.sAccessToken, AccessData.sAccessTokenSecret,AccessData.sUserId, AccessData.sScreenName);
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' ﾀｲﾑﾗｲﾝ取得"
            public JsonData[] getTimeLine()
            {
                try
                {
                    // ﾊﾟﾗﾒｰﾀ変数
                    Dictionary<string, string> parameters = new Dictionary<string, string>();

                    // GetでJSONﾃﾞｰﾀを取得
                    var lJson = poOAuthInfo.Get("https://api.twitter.com/1.1/statuses/user_timeline.json", parameters);
                    // ﾊﾞｲﾄｴﾝｺｰﾄﾞをかけてﾒﾓﾘに展開
                    var lStream = new MemoryStream(Encoding.Unicode.GetBytes(lJson));
                    // ﾃﾞｼﾘｱﾗｲｽﾞ
                    var lSerializer = new DataContractJsonSerializer(typeof(JsonData[]));
                    // JSONﾃﾞｰﾀを展開
                    var oJsonData = (JsonData[])lSerializer.ReadObject(lStream);

                    // ﾘﾀｰﾝ
                    return oJsonData;
                }
                catch (Exception ex)
                {
                    // ﾛｸﾞ出力
                    poLogManager.fWriteLog("LOG", ex);
                    return null;
                }    
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' ﾂｲｰﾄ送信"
            public void sendUserTweet(string sTweet)
            {
                try
                {
                    // ﾊﾟﾗﾒｰﾀ変数
                    Dictionary<string, string> parameters = new Dictionary<string, string>();

                    // ﾊﾟﾗﾒｰﾀを設定
                    parameters.Add("status", poOAuthInfo.UrlEncode(sTweet));

                    // ﾂｲｰﾄをPOSTする
                    poOAuthInfo.Post("https://api.twitter.com/1.1/statuses/update.json", parameters);
                }
                catch (Exception ex)
                {
                    // ﾛｸﾞ出力
                    poLogManager.fWriteLog("LOG", ex);
                }
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' ﾘﾌﾟﾗｲ送信"
        public void sendRepTweet(string sTweet, string sRepId)
        {
            try
            {
                // ﾊﾟﾗﾒｰﾀ変数
                Dictionary<string, string> parameters = new Dictionary<string, string>();

                // ﾊﾟﾗﾒｰﾀを設定
                parameters.Add("status", poOAuthInfo.UrlEncode(sTweet));
                parameters.Add("in_reply_to_status_id", poOAuthInfo.UrlEncode(sRepId));
                
                // ﾂｲｰﾄをPOSTする
                poOAuthInfo.Post("https://api.twitter.com/1.1/statuses/update.json", parameters);
            }
            catch (Exception ex)
            {
                // ﾛｸﾞ出力
                poLogManager.fWriteLog("LOG", ex);
            }
        }
        #endregion
        //****************************************************

        //****************************************************
        #region "' ﾘﾂｲｰﾄ送信"
        public void sendUserReTweet(string sTweet, string sReId)
            {
                try
                {
                    // ﾊﾟﾗﾒｰﾀ変数
                    Dictionary<string, string> parameters = new Dictionary<string, string>();

                    // ﾊﾟﾗﾒｰﾀを設定
                    parameters.Add("id", poOAuthInfo.UrlEncode(sReId));
                    //parameters.Add("status", poOAuthInfo.UrlEncode(sTweet));

                    // ﾂｲｰﾄをPOSTする
                    poOAuthInfo.Post(string.Format("https://api.twitter.com/1.1/statuses/retweet/{0}.json", sReId), parameters);
                }
                catch (Exception ex)
                {
                    // ﾛｸﾞ出力
                    poLogManager.fWriteLog("LOG", ex);
                }
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' ﾀﾞｲﾚｸﾄﾒｯｾｰｼﾞ送信"
            public void sendDirectMessages(string sUserId,string sTweet)
            {
                try
                {
                    // ﾊﾟﾗﾒｰﾀ変数
                    Dictionary<string, string> parameters = new Dictionary<string, string>();

                    // ﾊﾟﾗﾒｰﾀを設定
                    parameters.Add("user_id", poOAuthInfo.UrlEncode(sUserId));
                    parameters.Add("text", poOAuthInfo.UrlEncode(sTweet));

                    // ﾂｲｰﾄをPOSTする
                    poOAuthInfo.Post("https://api.twitter.com/1.1/direct_messages/new.json", parameters);
                }
                catch (Exception ex)
                {
                    // ﾛｸﾞ出力
                    poLogManager.fWriteLog("LOG", ex);
                }
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' ﾂｲｰﾄ検索"
            public JsonTweetSearchData getSearchTweet(string sSearchTxt)
            {
                try
                {
                    // ﾊﾟﾗﾒｰﾀ変数
                    Dictionary<string, string> parameters = new Dictionary<string, string>();

                    // ﾊﾟﾗﾒｰﾀ追加
                    parameters.Add("q", System.Web.HttpUtility.UrlEncode(sSearchTxt, System.Text.Encoding.UTF8).ToUpper());


                    // GetでJSONﾃﾞｰﾀを取得
                    var lJson = poOAuthInfo.Get("https://api.twitter.com/1.1/search/tweets.json", parameters);
                    // ﾊﾞｲﾄｴﾝｺｰﾄﾞをかけてﾒﾓﾘに展開
                    var lStream = new MemoryStream(Encoding.Unicode.GetBytes(lJson));
                    // ﾃﾞｼﾘｱﾗｲｽﾞ
                    var lSerializer = new DataContractJsonSerializer(typeof(JsonTweetSearchData));
                    // JSONﾃﾞｰﾀを展開
                    var oJsonData = (JsonTweetSearchData)lSerializer.ReadObject(lStream);

                    // ﾘﾀｰﾝ
                    return oJsonData;
                }
                catch (Exception ex)
                {
                    // ﾛｸﾞ出力
                    poLogManager.fWriteLog("LOG", ex);
                    return null;
                }    
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' ﾕｰｻﾞ検索"
            public JsonUserSearchData[] getSearchUser(string sSearchTxt)
            {
                try
                {
                    // ﾊﾟﾗﾒｰﾀ変数
                    Dictionary<string, string> parameters = new Dictionary<string, string>();

                    // ﾊﾟﾗﾒｰﾀ追加
                    parameters.Add("q", System.Web.HttpUtility.UrlEncode(sSearchTxt, System.Text.Encoding.UTF8).ToUpper());

                    // GetでJSONﾃﾞｰﾀを取得
                    var lJson = poOAuthInfo.Get("https://api.twitter.com/1.1/users/search.json", parameters);
                    // ﾊﾞｲﾄｴﾝｺｰﾄﾞをかけてﾒﾓﾘに展開
                    var lStream = new MemoryStream(Encoding.Unicode.GetBytes(lJson));
                    // ﾃﾞｼﾘｱﾗｲｽﾞ
                    var lSerializer = new DataContractJsonSerializer(typeof(JsonUserSearchData[]));
                    // JSONﾃﾞｰﾀを展開
                    var oJsonData = (JsonUserSearchData[])lSerializer.ReadObject(lStream);

                    // ﾘﾀｰﾝ
                    return oJsonData;
                }
                catch (Exception ex)
                {
                    // ﾛｸﾞ出力
                    poLogManager.fWriteLog("LOG", ex);
                    return null;
                }
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' ﾕｰｻﾞﾌﾟﾛﾌｨｰﾙ取得"
            /// <summary>
            /// ﾕｰｻﾞﾌﾟﾛﾌｨｰﾙ取得
            /// </summary>
            /// <param name="sUserId"></param>
            /// <returns>ﾕｰｻﾞﾌﾟﾛﾌｨｰﾙ取得</returns>
            public JsonUserProfData getUserProf(string sUserId)
            {
                try
                {
                    // ﾊﾟﾗﾒｰﾀ変数
                    Dictionary<string, string> parameters = new Dictionary<string, string>();

                    // ﾊﾟﾗﾒｰﾀ追加
                    parameters.Add("user_id", System.Web.HttpUtility.UrlEncode(sUserId, System.Text.Encoding.UTF8).ToUpper());

                    // GetでJSONﾃﾞｰﾀを取得
                    var lJson = poOAuthInfo.Get("https://api.twitter.com/1.1/users/show.json", parameters);
                    // ﾊﾞｲﾄｴﾝｺｰﾄﾞをかけてﾒﾓﾘに展開
                    var lStream = new MemoryStream(Encoding.Unicode.GetBytes(lJson));
                    // ﾃﾞｼﾘｱﾗｲｽﾞ
                    var lSerializer = new DataContractJsonSerializer(typeof(JsonUserProfData));
                    // JSONﾃﾞｰﾀを展開
                    var oJsonData = (JsonUserProfData)lSerializer.ReadObject(lStream);

                    // ﾘﾀｰﾝ
                    return oJsonData;
                }
                catch (Exception ex)
                {
                    // ﾛｸﾞ出力
                    poLogManager.fWriteLog("LOG", ex);
                    return null;
                }
            }
        #endregion
        //****************************************************

    }
}
