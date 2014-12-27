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

namespace Kizuna.Plus.PdfLocker.Models
{
    [Serializable]
    [DataContract]
    [KnownType(typeof(UserSettingData))]
    [KnownType(typeof(List<UserData>))]
    [KnownType(typeof(UserData))]
    class UserSettingData : AbstractModel
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
        public static UserSettingData Current
        {
            get;
            set;
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
        public UserSettingData()
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
