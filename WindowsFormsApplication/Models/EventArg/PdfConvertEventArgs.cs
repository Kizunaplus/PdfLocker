using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kizuna.Plus.PdfLocker.Models.EventArg
{
    /// <summary>
    /// PDF変換イベント引数
    /// </summary>
    class PdfConvertEventArgs : EventArgs
    {
        #region プロパティ
        /// <summary>
        /// PDF格納フォルダ
        /// </summary>
        public string FilePath
        {
            get;
            set;
        }

        /// <summary>
        /// PDF格納フォルダ
        /// </summary>
        public List<UserData> UserData
        {
            get;
            set;
        }
        #endregion
    }
}
