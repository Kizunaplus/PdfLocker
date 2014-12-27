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
using Kizuna.Plus.PdfLocker.Controllers.State;
using System.IO;
using Kizuna.Plus.PdfLocker.Models.EventArg;

namespace Kizuna.Plus.PdfLocker.Views
{
    public partial class UserListView : ViewControl
    {
        /// <summary>
        /// データバインド
        /// </summary>
        private BindingSource bs; 

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public UserListView()
        {
            InitializeComponent();

            bs = new BindingSource();
            bs.CurrentItemChanged += new EventHandler(bs_CurrentItemChanged);
            InitBindData();

            this.dataGridView.DataSource = bs;


            this.filePathTextBox.Text = ConfigurationData.Current.TargetFolder;


            this.HelpGuide.Add(new Tuple<Control, string>(this.filePathTextBox, "PDFの出力ファイルパスを入力します。"));
            this.HelpGuide.Add(new Tuple<Control, string>(this.folderSelectbutton, "また、隣の「...」ボタンでフォルダを選択する事もできます。"));
            this.HelpGuide.Add(new Tuple<Control, string>(this.dataGridView, "パスワードを設定するユーザの情報を入力してください。"));
            this.HelpGuide.Add(new Tuple<Control, string>(this.dataGridView, "空欄の行に入力すれば行が追加されます。"));
            this.HelpGuide.Add(new Tuple<Control, string>(this.dataGridView, "この設定は、終了時に保存されるため安心してご使用ください。"));
            this.HelpGuide.Add(new Tuple<Control, string>(this.applyButton, "設定が正しくできている場合に押すことができます。\nこのボタンを押下すると、PDFにパスワードが設定されます。"));
        }

        /// <summary>
        /// バインドデータの設定
        /// </summary>
        public override void InitBindData()
        {
            if (UserSettingData.Current == null)
            {
                return;
            }

            bs.DataSource = UserSettingData.Current.UserData;
        }

        /// <summary>
        /// 適用ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void applyButton_Click(object sender, EventArgs e)
        {
            var data = UserSettingData.Current.UserData;
            if (data.Count <= 0)
            {
                MessageBox.Show("ユーザの設定をしてください。");
                return;
            }

            foreach (var user in data)
            {
                if (string.IsNullOrEmpty(user.Password)
                    || string.IsNullOrEmpty(user.Id))
                {
                    MessageBox.Show(String.Format("パスワードとIDは入力必須です。ユーザ名:{0}", user.Name));
                    return;
                }
            }

            var command = new PdfConvertCommand();
            command.Execute(new NonState(this)
                , new PdfConvertEventArgs() { FilePath = this.filePathTextBox.Text, UserData = new List<UserData>(UserSettingData.Current.UserData) });
        }

        private void folderSelectButton_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            dialog.SelectedPath = this.filePathTextBox.Text;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.filePathTextBox.Text = dialog.SelectedPath;
            }
        }

        /// <summary>
        /// ファイルパス変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filePathTextBox_TextChanged(object sender, EventArgs e)
        {
            String filePath = this.filePathTextBox.Text;
            ConfigurationData.Current.TargetFolder = filePath;

            if (string.IsNullOrEmpty(filePath) == true 
                || Directory.Exists(filePath) == false)
            {
                // ファイルパスが無効な場合はボタンを無効化
                this.applyButton.Enabled = false;
                return;
            }

            if (UserSettingData.Current.UserData.Count <= 0)
            {
                // ユーザ譲歩が未設定の場合は、無効化
                this.applyButton.Enabled = false;
                return;
            }

            this.applyButton.Enabled = true;
        }

        /// <summary>
        /// カレントアイテム変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void bs_CurrentItemChanged(object sender, EventArgs e)
        {
            String filePath = this.filePathTextBox.Text;
            if (string.IsNullOrEmpty(filePath) == true
                || Directory.Exists(filePath) == false)
            {
                // ファイルパスが無効な場合はボタンを無効化
                this.applyButton.Enabled = false;
                return;
            }

            if (bs.List == null || bs.List.Count <= 0)
            {
                // ユーザ譲歩が未設定の場合は、無効化
                this.applyButton.Enabled = false;
                return;
            }

            this.applyButton.Enabled = true;
        }

    }
}
