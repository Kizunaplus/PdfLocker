﻿using System;
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
    class ConfigurationData : AbstractModel
    {
        #region 定数
        /// <summary>
        /// 設定ファイル名
        /// </summary>
        private const string CONFIG_FILE_NAMME = "setting.config";
        #endregion

        #region プロパティ
        [XmlIgnoreAttribute]
        /// <summary>
        /// 現在の設定インスタンス
        /// </summary>
        public static ConfigurationData Current
        {
            get;
            set;
        }

        [DataMemberAttribute]
        /// <summary>
        /// フォームの位置、サイズ情報
        /// </summary>
        public Rectangle? FormBounds
        {
            get;
            set;
        }

        [DataMemberAttribute]
        /// <summary>
        /// 対象フォルダ
        /// </summary>
        public String TargetFolder
        {
            get;
            set;
        }

        [DataMemberAttribute]
        /// <summary>
        /// ユーザ設定ファイルパス
        /// </summary>
        public String UserSettingPath
        {
            get;
            set;
        }

        [DataMemberAttribute]
        /// <summary>
        /// 対象PDFのオーナパスワード
        /// </summary>
        public String PdfOwnerPassword
        {
            get;
            set;
        }

        [DataMemberAttribute]
        /// <summary>
        /// 出力ファイルパスフォーマット
        /// </summary>
        public String DestFileNameFormat
        {
            get;
            set;
        }

        [DataMemberAttribute]
        /// <summary>
        /// 出力日付フォーマット
        /// </summary>
        public String DestDateFormat
        {
            get;
            set;
        }
        #endregion

        #region 取得
        /// <summary>
        /// 設定ファイルパスの取得
        /// </summary>
        /// <returns></returns>
        public static string GetConfigurationFilePath()
        {
            return Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), CONFIG_FILE_NAMME);
        }
        #endregion
    }
}
