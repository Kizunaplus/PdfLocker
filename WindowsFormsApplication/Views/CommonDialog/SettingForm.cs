using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kizuna.Plus.PdfLocker.Models;

namespace Kizuna.Plus.PdfLocker.Views.CommonDialog
{
    public partial class SettingForm : Form
    {
        #region 初期化処理
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SettingForm()
        {
            InitializeComponent();

            this.textBox1.Text = ConfigurationData.Current.PdfOwnerPassword;
            if (string.IsNullOrEmpty(ConfigurationData.Current.DestFileNameFormat) == true)
            {
                ConfigurationData.Current.DestFileNameFormat = "{0}_locked.pdf";
            }
        
            this.textBox2.Text = ConfigurationData.Current.DestFileNameFormat;


            if (string.IsNullOrEmpty(ConfigurationData.Current.DestDateFormat) == true)
            {
                ConfigurationData.Current.DestDateFormat = "yyMM";
            }

            this.textBox3.Text = ConfigurationData.Current.DestDateFormat;
        }
        #endregion

        /// <summary>
        /// OKボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void oKButton_Click(object sender, EventArgs e)
        {
            ConfigurationData.Current.PdfOwnerPassword = this.textBox1.Text;
            ConfigurationData.Current.DestFileNameFormat = this.textBox2.Text;
            ConfigurationData.Current.DestDateFormat = this.textBox3.Text;
        }

        /// <summary>
        /// 適用ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void applyButton_Click(object sender, EventArgs e)
        {
            ConfigurationData.Current.PdfOwnerPassword = this.textBox1.Text;
            ConfigurationData.Current.DestFileNameFormat = this.textBox2.Text;
            ConfigurationData.Current.DestDateFormat = this.textBox3.Text;

        }
    }
}
