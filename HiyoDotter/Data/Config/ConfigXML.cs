
namespace HiyoDotter.Data
{
    public class ConfigXML
    {
        //****************************************************
        #region "' ｸﾗｽ変数"
            /// <summary>
            /// ﾒﾆｭｰ位置
            /// </summary>
            private string _sMenuPosition;
        #endregion
        //****************************************************

        //****************************************************
        #region "' ｺﾝｽﾄﾗｸﾀ"
        /// <summary>
        /// ｺﾝｽﾄﾗｸﾀ
        /// </summary>
        public ConfigXML()
            {
                MenuPosition = ConfigData.sMenuPosition;
        }
        #endregion
        //****************************************************

        //****************************************************
        #region "' ﾌﾟﾛﾊﾟﾃｨ"
            /// <summary>
            /// ﾒﾆｭｰ位置
            /// </summary>
            public string MenuPosition
            {
                get { return _sMenuPosition; }
                set { _sMenuPosition = value; }
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
                ConfigData.sMenuPosition = MenuPosition;
            }
            /// <summary>
            /// 設定値初期化
            /// </summary>
            public void setDefaultData()
            {
                MenuPosition = "L";
        }
        #endregion
        //****************************************************
    }
}
