using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Kizuna.Plus.WinMvcForm.Framework.Models;
using WindowsFormsApplication.Models;
using Kizuna.Plus.WinMvcForm.Framework.Models.Validation;

namespace Kizuna.Plus.PdfLocker.Models
{
    [Serializable]
    [DataContract]
    [KnownType(typeof(UserListModel))]
    [KnownType(typeof(List<UserData>))]
    [KnownType(typeof(UserData))]
    class UserListModel : AbstractModel
    {
        #region 定数
        /// <summary>
        /// 設定ファイル名
        /// </summary>
        private const string CONFIG_FILE_NAMME = "user-setting.config";
        #endregion

        #region プロパティ
        [XmlIgnoreAttribute]
        /// <summary>
        /// 現在の設定インスタンス
        /// </summary>
        public static UserListModel Current
        {
            get;
            set;
        }

        [RequiresInput]
        [FilePathCheckAttribute]
        [DirectoryExistCheck(true)]
        [XmlIgnoreAttribute]
        /// <summary>
        /// 備考
        /// </summary>
        public String FilePath
        {
            get { return ConfigurationData.Current.TargetFolder; }
            set { ConfigurationData.Current.TargetFolder = value; }
        }

        [DataMember]
        /// <summary>
        /// 備考
        /// </summary>
        public List<UserData> UserData
        {
            get;
            set;
        }
        #endregion

        #region 初期化
        public UserListModel()
        {
            UserData = new List<UserData>();
        }
        #endregion

        #region 取得
        /// <summary>
        /// 設定ファイルパスの取得
        /// </summary>
        /// <returns></returns>
        public static string GetConfigurationFilePath()
        {
            String filePath = ConfigurationData.Current.UserSettingPath;
            if (String.IsNullOrEmpty(filePath) == false)
            {
                return filePath;
            }

            return Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), CONFIG_FILE_NAMME);
        }
        #endregion
    }
}
