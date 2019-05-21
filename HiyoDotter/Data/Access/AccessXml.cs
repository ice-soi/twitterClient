using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiyoDotter.Data
{
    public class AccessXml : IDisposable
    {
        //****************************************************
        #region "' ｸﾗｽ変数"
        /// <summary>
        /// ｱｸｾｽﾄｰｸﾝ
        /// </summary>
        private string _sAccessToken = "";
        /// <summary>
        /// ｱｸｾｽﾄｰｸﾝ(秘密鍵)
        /// </summary>
        private string _sAccessTokenSecret = "";
        /// <summary>
        /// ﾕｰｻﾞID
        /// </summary>
        private string _sUserId;
        /// <summary>
        /// 表示名称
        /// </summary>
        private string _sScreenName;
        #endregion
        //****************************************************

        //****************************************************
        #region "' Dispose"
            public void Dispose()
            {
                GC.SuppressFinalize(this);
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' ｺﾝｽﾄﾗｸﾀ"
        /// <summary>
        /// ｺﾝｽﾄﾗｸﾀ
        /// </summary>
        public AccessXml()
            {
                // ｱｸｾｽﾄｰｸﾝ
                AccessToken = AccessData.sAccessToken;
                // ｱｸｾｽﾄｰｸﾝ秘密鍵
                AccessTokenSecret = AccessData.sAccessTokenSecret;
                // ﾕｰｻﾞID
                UserId = AccessData.sUserId;
                // 表示名
                ScreenName = AccessData.sScreenName;
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' ﾌﾟﾛﾊﾟﾃｨ"
            /// <summary>
            /// ｱｸｾｽﾄｰｸﾝ
            /// </summary>
            public string AccessToken
            {
                get { return _sAccessToken; }
                set { _sAccessToken = value; }
            }
            /// <summary>
            /// ｱｸｾｽﾄｰｸﾝ(秘密鍵)
            /// </summary>
            public string AccessTokenSecret
            {
                get { return _sAccessTokenSecret; }
                set { _sAccessTokenSecret = value; }
            }
            /// <summary>
            /// ﾕｰｻﾞID
            /// </summary>
            public string UserId
            {
                get { return _sUserId; }
                set { _sUserId = value; }
            }
            /// <summary>
            /// 表示名称
            /// </summary>
            public string ScreenName
            {
                get { return _sScreenName; }
                set { _sScreenName = value; }
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' ﾒｿｯﾄﾞ"
            /// <summary>
            /// 設定値の設定
            /// </summary>
            public void setAccessData()
            {
                AccessData.sAccessToken = AccessToken;
                AccessData.sAccessTokenSecret = AccessTokenSecret;
                AccessData.sUserId = UserId;
                AccessData.sScreenName = ScreenName;
            }
        #endregion
        //****************************************************
    }
}
