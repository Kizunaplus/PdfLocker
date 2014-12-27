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

        [DataMemberAttribute]
        /// <summary>
        /// ユーザパスワード
        /// </summary>
        public String Password
        {
            get;
            set;
        }

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
