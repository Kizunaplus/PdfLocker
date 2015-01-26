using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Kizuna.Plus.PdfLocker.Framework.Message;

namespace Kizuna.Plus.WinMvcForm.Framework.Models.Validation
{
    /// <summary>
    /// Htmlタグ存在チェッククラス
    /// </summary>
    class HtmlValueCheckAttribute : ValueCheckAttribute
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public HtmlValueCheckAttribute()
            : base("<[\\/a-zA-Z]+>$", FrameworkValidationMessage.HtmlValueCheckMessage, true)
        {

        }
    }
}
