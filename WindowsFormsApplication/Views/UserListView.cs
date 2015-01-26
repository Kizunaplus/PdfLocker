using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kizuna.Plus.PdfLocker.Models;
using Kizuna.Plus.PdfLocker.Controllers.Commands;
using System.IO;
using Kizuna.Plus.PdfLocker.Models.EventArg;
using WindowsFormsApplication.Models;
using Kizuna.Plus.WinMvcForm.Framework.Controllers.State;
using Kizuna.Plus.WinMvcForm.Framework.Views;

namespace Kizuna.Plus.PdfLocker.Views
{
    public partial class UserListView : ViewControl
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public UserListView()
        {
            InitializeComponent();

            this.UserData.AutoGenerateColumns = false;

            this.HelpGuide.Add(new Tuple<Control, string>(this.FilePath, "PDFの出力ファイルパスを入力します。"));
            this.HelpGuide.Add(new Tuple<Control, string>(this.folderSelectbutton, "また、隣の「...」ボタンでフォルダを選択する事もできます。"));
            this.HelpGuide.Add(new Tuple<Control, string>(this.UserData, "パスワードを設定するユーザの情報を入力してください。"));
            this.HelpGuide.Add(new Tuple<Control, string>(this.UserData, "空欄の行に入力すれば行が追加されます。"));
            this.HelpGuide.Add(new Tuple<Control, string>(this.UserData, "この設定は、終了時に保存されるため安心してご使用ください。"));
            this.HelpGuide.Add(new Tuple<Control, string>(this.applyButton, "設定が正しくできている場合に押すことができます。\nこのボタンを押下すると、PDFにパスワードが設定されます。"));
        }

        /// <summary>
        /// 適用ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void applyButton_Click(object sender, EventArgs e)
        {
            var command = new PdfConvertCommand();
            command.Execute(new NonState(this)
                , new PdfConvertEventArgs() { FilePath = this.FilePath.Text, UserData = new List<UserData>(UserListModel.Current.UserData) });
        }

        private void folderSelectbutton_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            dialog.SelectedPath = this.FilePath.Text;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.FilePath.Text = dialog.SelectedPath;
            }
        }
    }
}
