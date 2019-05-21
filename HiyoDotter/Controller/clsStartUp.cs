using System;
using HiyoDotter.Logic;
using HiyoDotter.View;
using System.Windows.Forms;
using System.IO;

namespace HiyoDotter.Controller
{
    class clsStartUp
    {
        //****************************************************
        #region "' 画面処理"
            [STAThread]
            public static void Main()
            {
                DirectoryInfo dCurrentDirectory = new DirectoryInfo(Directory.GetCurrentDirectory());
                clsXMLProcess poXMLProcess = new clsXMLProcess();
                // ｶﾚﾝﾄﾃﾞｨﾚｸﾄﾘにXMLﾌｫﾙﾀﾞが存在しない場合
                if (!Directory.Exists(dCurrentDirectory.FullName + "\\XML"))
                {
                    // ｶﾚﾝﾄにXMLﾌｫﾙﾀﾞを作成
                    dCurrentDirectory.CreateSubdirectory("XML");
                    // ｶﾚﾝﾄにLOGﾌｫﾙﾀﾞを作成
                    dCurrentDirectory.CreateSubdirectory("LOG");

                    // 設定情報がないため認証画面を起動
                    using (frmLogin fLogin = new frmLogin())
                    {
                        // 認証画面の表示
                        if (fLogin.ShowDialog() == DialogResult.Cancel)
                        {
                            // ｷｬﾝｾﾙﾎﾞﾀﾝを押下時は何もしない
                            return;
                        }
                    }
                }
                else
                {
                    // ｱｸｾｽ用XML読込
                    poXMLProcess.fStreamXML("ACCESS", poXMLProcess.redAccessXml);
                    // 設定用XML読込
                    poXMLProcess.fStreamXML("SETTING", poXMLProcess.redSettingXml);
                    // ｺﾝﾌｨｸﾞ用XML読込
                    poXMLProcess.fStreamXML("CONFIG", poXMLProcess.redConfigXml);
                }
                // ﾒｲﾝ画面を起動
                using (frmBase fBase = new frmBase())
                {
                    // ﾒｲﾝ画面表示
                    fBase.ShowDialog();

                }
                
            }
        #endregion
        //****************************************************
    }
}
