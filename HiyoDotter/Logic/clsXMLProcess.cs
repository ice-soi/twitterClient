using HiyoDotter.Data;
using System.IO;
using System.Xml.Serialization;
using System.Configuration;
using System.Text;

namespace HiyoDotter.Logic
{
    class clsXMLProcess
    {
        //****************************************************
        #region "' ｺﾝｽﾄﾗｸﾀ"
            /// <summary>
            /// ｺﾝｽﾄﾗｸﾀ
            /// </summary>
            public clsXMLProcess()
            {
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' XML共通"
            /// <summary>
            /// ﾃﾞﾘｹﾞｰﾄ
            /// </summary>
            /// <param name="sFullPath"></param>
            public delegate void outXmlFile(string sFullPath);
            /// <summary>
            /// XML共通処理
            /// </summary>
            /// <param name="sFilePathTag"></param>
            /// <param name="fXmlFile"></param>
            public void fStreamXML(string sFilePathTag, outXmlFile fXmlFile)
            {
                // ｶﾚﾝﾄﾃﾞｨﾚｸﾄﾘ取得
                DirectoryInfo dCurrentDirectory = new DirectoryInfo(Directory.GetCurrentDirectory());
                // ﾌｧｲﾙﾊﾟｽ
                string sFullPath = dCurrentDirectory.FullName + ConfigurationManager.AppSettings[sFilePathTag];
                // 出力
                fXmlFile(sFullPath);
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' XML出力"
            /// <summary>
            /// ｱｸｾｽXML出力
            /// </summary>
            /// <param name="sFullPath"></param>
            public void outAccessXml(string sFullPath)
            {
                // ｱｸｾｽ設定情報を設定
                AccessXml oAccess = new AccessXml();
                // ﾌｧｲﾙを開く
                using (StreamWriter lStreamWriter = new StreamWriter(sFullPath, false, new UTF8Encoding(false)))
                {
                    // ｱｸｾｽ用のXmlSirializerの作成
                    XmlSerializer lXMLSerializer = new XmlSerializer(typeof(AccessXml));
                    // ｱｸｾｽ情報をｼﾘｱﾙ化してXMLに出力
                    lXMLSerializer.Serialize(lStreamWriter, oAccess);
                }
            }
            /// <summary>
            /// 設定XML出力
            /// </summary>
            /// <param name="sFullPath"></param>
            public void outSettingXml(string sFullPath)
            {
                // ｱｸｾｽ設定情報を設定
                SettingsXML oSetting = new SettingsXML();
                // ﾌｧｲﾙを開く
                using (StreamWriter lStreamWriter = new StreamWriter(sFullPath, false, new UTF8Encoding(false)))
                {
                    // ｱｸｾｽ用のXmlSirializerの作成
                    XmlSerializer lXMLSerializer = new XmlSerializer(typeof(SettingsXML));
                    // ｱｸｾｽ情報をｼﾘｱﾙ化してXMLに出力
                    lXMLSerializer.Serialize(lStreamWriter, oSetting);
                }
            }
            /// <summary>
            /// ｺﾝﾌｨｸﾞXML出力
            /// </summary>
            /// <param name="sFullPath"></param>
            public void outConfigXml(string sFullPath)
            {
                // ｱｸｾｽ設定情報を設定
                ConfigXML oConfig = new ConfigXML();
                // ﾌｧｲﾙを開く
                using (StreamWriter lStreamWriter = new StreamWriter(sFullPath, false, new UTF8Encoding(false)))
                {
                    // ｱｸｾｽ用のXmlSirializerの作成
                    XmlSerializer lXMLSerializer = new XmlSerializer(typeof(ConfigXML));
                    // ｱｸｾｽ情報をｼﾘｱﾙ化してXMLに出力
                    lXMLSerializer.Serialize(lStreamWriter, oConfig);
                }
            }
        #endregion
        //****************************************************

        //****************************************************
        #region "' XML読込"
        /// <summary>
        /// ｱｸｾｽXML読込
        /// </summary>
        /// <param name="sFullPath"></param>
        public void redAccessXml(string sFullPath)
            {
                // ｱｸｾｽ設定情報を設定
                AccessXml oAccess = new AccessXml();
                // ﾌｧｲﾙを開く
                using (StreamReader lStreamReader = new StreamReader(sFullPath, new UTF8Encoding(false)))
                {
                    // ｱｸｾｽ用のXmlSirializerの作成
                    XmlSerializer lXMLSerializer = new XmlSerializer(typeof(AccessXml));
                    // ｱｸｾｽ情報をｼﾘｱﾙ化してXMLに出力
                    oAccess = (AccessXml)lXMLSerializer.Deserialize(lStreamReader);
                    // 設定値の設定
                    oAccess.setAccessData();
                }
            }
            /// <summary>
            /// 設定XML読込
            /// </summary>
            /// <param name="sFullPath"></param>
            public void redSettingXml(string sFullPath)
            {
            // 画面設定情報を設定
            SettingsXML oSetting = new SettingsXML();
                // ﾌｧｲﾙを開く
                using (StreamReader lStreamReader = new StreamReader(sFullPath, new UTF8Encoding(false)))
                {
                    // 画面設定のXmlSirializerの作成
                    XmlSerializer lXMLSerializer = new XmlSerializer(typeof(SettingsXML));
                    // 画面設定情報をﾃﾞｼﾘｱﾗｲｽﾞ
                    oSetting = (SettingsXML)lXMLSerializer.Deserialize(lStreamReader);
                    // 設定値の設定
                    oSetting.setSettingData();
                }
            }
            /// <summary>
            /// ｺﾝﾌｨｸﾞXML読込
            /// </summary>
            /// <param name="sFullPath"></param>
            public void redConfigXml(string sFullPath)
            {
                // 画面設定情報を設定
                ConfigXML oConfig = new ConfigXML();
                // ﾌｧｲﾙを開く
                using (StreamReader lStreamReader = new StreamReader(sFullPath, new UTF8Encoding(false)))
                {
                    // 画面設定のXmlSirializerの作成
                    XmlSerializer lXMLSerializer = new XmlSerializer(typeof(ConfigXML));
                    // 画面設定情報をﾃﾞｼﾘｱﾗｲｽﾞ
                    oConfig = (ConfigXML)lXMLSerializer.Deserialize(lStreamReader);
                    // 設定値の設定
                    oConfig.setSettingData();
                }
            }
        #endregion
        //****************************************************
    }
}
