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
using Kizuna.Plus.WinMvcForm.Framework.Models.Validation;
using Kizuna.Plus.WinMvcForm.Framework.Utility;

namespace Kizuna.Plus.PdfLocker.Models
{
    [Serializable]
    [DataContract]
    class UserData : AbstractModel
    {
        #region プロパティ
        [DataMemberAttribute]
        /// <summary>
        /// ユーザ名
        /// </summary>
        public String Name
        {
            get;
            set;
        }

        [RequiresInput]
        [XmlIgnore]
        /// <summary>
        /// ユーザパスワード
        /// </summary>
        public String Password
        {
            get;
            set;
        }

        [DataMemberAttribute(Name = "Password")]
        /// <summary>
        /// ユーザパスワード
        /// </summary>
        public String PasswordCrypt
        {
            get
            {
                return CryptUtility.encrypt(this.Password);
            }
            set
            {
                try
                {
                    this.Password = CryptUtility.decrypt(value);
                }
                catch { }
            }
        }

        [RequiresInput]
        [DataMemberAttribute]
        /// <summary>
        /// ユーザID
        /// </summary>
        public String Id
        {
            get;
            set;
        }


        [DataMemberAttribute]
        /// <summary>
        /// 備考
        /// </summary>
        public String Descript
        {
            get;
            set;
        }
        #endregion
    }
}
