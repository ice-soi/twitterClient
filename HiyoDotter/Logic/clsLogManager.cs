using System.IO;
using System.Configuration;
using System;

namespace HiyoDotter.Logic
{
    class clsLogManager
    {
        //****************************************************
        #region " '出力処理"
        /// <summary>
        /// ﾛｸﾞ出力処理
        /// </summary>
        /// <param name="sFilePathTag"></param>
        /// <param name="ex"></param>
        public void fWriteLog(string sFilePathTag, Exception ex)
        {
            // ｶﾚﾝﾄﾃﾞｨﾚｸﾄﾘ取得
            DirectoryInfo dCurrentDirectory = new DirectoryInfo(Directory.GetCurrentDirectory());
            // ﾌｧｲﾙﾊﾟｽ
            string sFullPath = dCurrentDirectory.FullName + ConfigurationManager.AppSettings[sFilePathTag];
            // 出力
            using (StreamWriter lStreamWriter = new StreamWriter(string.Format(sFullPath, DateTime.Today.ToString("yyyyMMdd")), true))
            {
                // ﾛｸﾞ出力
                lStreamWriter.WriteLine(DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss") + ex.Message + ex.StackTrace + ex.Source);
            }
        }
        #endregion 
        //****************************************************
    }
}
