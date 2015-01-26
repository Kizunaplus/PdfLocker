using System;
using System.IO;
using System.Windows.Forms;
using Kizuna.Plus.WinMvcForm.Framework.Controllers;
using Kizuna.Plus.WinMvcForm.Framework.Controllers.Commands;
using Kizuna.Plus.WinMvcForm.Framework.Controllers.State;
using Kizuna.Plus.WinMvcForm.Framework.Models;
using Kizuna.Plus.WinMvcForm.Framework.Models.EventArg;
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf.Security;
using Kizuna.Plus.PdfLocker.Controllers.Commands;
using Kizuna.Plus.PdfLocker.Models.EventArg;
using Kizuna.Plus.PdfLocker.Models;
using WindowsFormsApplication.Models;
using Kizuna.Plus.WinMvcForm.Framework.Utility;
using Kizuna.Plus.WinMvcForm.Framework.Views;
using Kizuna.Plus.WinMvcForm.Framework.Models.Enums;
using Kizuna.Plus.PdfLocker.Framework.Message;

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
                    catch (Exception ex)
                    {
                        var logCommand = new LogCommand();
                        logCommand.Execute(LogType.Exception, FrameworkMessage.ExceptionMessage, ex);
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

                    var data = new UserListModel().Load(UserListModel.GetConfigurationFilePath()) as UserListModel;

                    // 設定情報を作成
                    if (UserListModel.Current != null)
                    {
                        ConfigurationData.Current.UserSettingPath = fileEventArgs.FilePath;
                        UserListModel.Current = data;
                        GetDefaultView().InitBindData();
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
                    var data = UserListModel.Current;
                    if (data != null)
                    {
                        var service = new BackupFileUtility();
                        if (service.BackupWriteFile(UserListModel.GetConfigurationFilePath(), data) == false)
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
                    var data = UserListModel.Current;
                    if (data != null)
                    {
                        var service = new BackupFileUtility();
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

        public override IView Index()
        {
            ViewStateData.CurrentThread.Items["Model"] = UserListModel.Current;

            return base.Index();
        }

        #region 破棄処理
        /// <summary>
        /// 破棄処理
        /// </summary>
        /// <param name="isDispose"></param>
        protected override void Dispose(bool isDispose)
        {
            var register = CommandRegister.Current;
            register.UnregistOfSource(GetDefaultView());
        }
        #endregion
    }
}
