using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kizuna.Plus.PdfLocker.Controllers.Commands;
using Kizuna.Plus.PdfLocker.Models;
using Kizuna.Plus.PdfLocker.Controllers.State;
using Kizuna.Plus.PdfLocker.Models.EventArg;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using PdfSharp.Pdf;
using PdfSharp.Pdf.Security;
using PdfSharp.Pdf.IO;
using Kizuna.Plus.PdfLocker.Services.File;

namespace Kizuna.Plus.PdfLocker.Controllers
{
    class UserListController : Controller
    {
        #region 初期化処理
        /// <summary>
        /// 初期化処理
        /// </summary>
        public override void Initialize()
        {
            var register = CommandRegister.Current;

            // ステータス更新イベントの登録
            var eventData = new CommandEventData(GetDefaultView(), typeof(PdfConvertCommand), StateMode.None, delegate(object sender, EventArgs args)
            {
                var pdfEventArgs = args as PdfConvertEventArgs;
                if (pdfEventArgs != null)
                {
                    if (Directory.Exists(pdfEventArgs.FilePath) == false)
                    {
                        // フォルダが存在しない
                        return;
                    }

                    if (pdfEventArgs.UserData.Count <= 0)
                    {
                        // ユーザデータの設定がない
                        return;
                    }

                    try
                    {
                        int convertCount = 0;
                        foreach (UserData user in pdfEventArgs.UserData)
                        {
                            var fileList = Directory.GetFiles(pdfEventArgs.FilePath, "*" + user.Id + "*.pdf", SearchOption.TopDirectoryOnly);
                            foreach (var fileName in fileList)
                            {
                                String ownerPassword = ConfigurationData.Current.PdfOwnerPassword;
                                if (string.IsNullOrEmpty(ownerPassword) == true)
                                {
                                    ownerPassword = "";
                                }

                                string fileNameFormat = ConfigurationData.Current.DestFileNameFormat;

                                // 暗号化後のPDFファイル
                                if (string.IsNullOrEmpty(fileNameFormat) == true)
                                {
                                    fileNameFormat = "{0}_locked.pdf";
                                }
                                String dateFormat = ConfigurationData.Current.DestDateFormat;
                                if (string.IsNullOrEmpty(dateFormat) == true)
                                {
                                    dateFormat = "yyMM";
                                }


                                String newFileName = Path.Combine(Path.GetDirectoryName(fileName), string.Format(fileNameFormat, user.Id, user.Name, DateTime.Today.ToString(dateFormat)));
                                if (newFileName == fileName)
                                {
                                    // 同じ名称のファイルは無視
                                    continue;
                                }

                                var document = PdfReader.Open(fileName, ownerPassword);


                                PdfSecuritySettings securitySettings = document.SecuritySettings;
                                securitySettings.UserPassword = user.Password;
                                if (Directory.Exists(Path.GetDirectoryName(newFileName)) == false) {
                                    // フォルダがない場合は作成
                                    Directory.CreateDirectory(Path.GetDirectoryName(newFileName));
                                }

                                if (File.Exists(newFileName) == true)
                                {
                                    // ファイルが存在する場合は削除
                                    File.Delete(newFileName);
                                }
                                document.Save(newFileName);
                                convertCount++;
                            }
                        }
                        if (0 <= convertCount)
                        {
                            MessageBox.Show("パスワード設定が完了しました。");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("PDFにパスワードの設定でエラーが発生しました。");
                    }
                }
            });
            register.Regist(eventData);

            // ファイルオープン時の処理
            eventData = new CommandEventData(typeof(Application), typeof(FileOpenCommand), StateMode.Process, delegate(object sender, EventArgs args)
            {
                var fileEventArgs = args as FileEventArgs;
                if (fileEventArgs != null)
                {
                    if (File.Exists(fileEventArgs.FilePath) == false)
                    {
                        // フォルダが存在しない
                        return;
                    }

                    var data = new UserSettingData().Load(UserSettingData.GetConfigurationFilePath()) as UserSettingData;

                    // 設定情報を作成
                    if (UserSettingData.Current != null)
                    {
                        ConfigurationData.Current.UserSettingPath = fileEventArgs.FilePath;
                        UserSettingData.Current = data;
                        GetDefaultView().Refresh();
                    }
                }
            });
            register.Regist(eventData);

            // ファイル保存時の処理
            eventData = new CommandEventData(typeof(Application), typeof(FileSaveCommand), StateMode.Process, delegate(object sender, EventArgs args)
            {
                var fileEventArgs = args as FileEventArgs;
                if (fileEventArgs != null)
                {
                    var data = UserSettingData.Current;
                    if (data != null)
                    {
                        var service = new BackupFileService();
                        if (service.BackupWriteFile(UserSettingData.GetConfigurationFilePath(), data) == false)
                        {
                            MessageBox.Show("ファイルの保存に失敗しました。");
                            return;
                        }
                    }


                }
            });
            register.Regist(eventData);


            // ファイル保存時の処理
            eventData = new CommandEventData(typeof(Application), typeof(FileSaveAsCommand), StateMode.Process, delegate(object sender, EventArgs args)
            {
                var fileEventArgs = args as FileEventArgs;
                if (fileEventArgs != null)
                {
                    var data = UserSettingData.Current;
                    if (data != null)
                    {
                        var service = new BackupFileService();
                        if (service.BackupWriteFile(fileEventArgs.FilePath, data) == false)
                        {
                            MessageBox.Show("ファイルの保存に失敗しました。");
                            return;
                        }
                        ConfigurationData.Current.UserSettingPath = fileEventArgs.FilePath;
                    }


                }
            });
            register.Regist(eventData);

        }
        #endregion

        #region 破棄処理
        /// <summary>
        /// 破棄処理
        /// </summary>
        /// <param name="isDispose"></param>
        protected virtual void Dispose(bool isDispose)
        {
            var register = CommandRegister.Current;
            register.UnregistOfSource(GetDefaultView());
        }
        #endregion
    }
}
