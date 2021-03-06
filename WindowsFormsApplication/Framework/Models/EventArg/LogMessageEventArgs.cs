﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kizuna.Plus.WinMvcForm.Framework.Models.EventArg
{
    /// <summary>
    /// ログ出力コマンド引数
    /// </summary>
    class LogMessageEventArgs : AbstractEventArgs
    {
        #region プロパティ
        /// <summary>
        /// ログ出力内容
        /// </summary>
        public string Message
        {
            get;
            set;
        }
        #endregion
    }
}
