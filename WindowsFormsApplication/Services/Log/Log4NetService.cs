﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kizuna.Plus.PdfLocker.Services.Log
{
    class Log4NetService : ILogService
    {
        #region メンバー変数
        /// <summary>
        /// Log4Netインスタンス
        /// </summary>
        private static readonly log4net.ILog log =
        log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        #region 出力処理
        /// <summary>
        /// デバッグメッセージの出力
        /// </summary>
        /// <param name="message">メッセージ</param>
        public void Debug(string message)
        {
            log.Debug(message);
        }

        /// <summary>
        /// 情報メッセージの出力
        /// </summary>
        /// <param name="message">メッセージ</param>
        public void Info(string message)
        {
            log.Info(message);
        }

        /// <summary>
        /// 警告メッセージの出力
        /// </summary>
        /// <param name="message">メッセージ</param>
        public void Warn(string message)
        {
            log.Warn(message);
        }

        /// <summary>
        /// エラーメッセージの出力
        /// </summary>
        /// <param name="message">メッセージ</param>
        public void Error(string message)
        {
            log.Error(message);
        }

        /// <summary>
        /// 致命的な障害メッセージの出力
        /// </summary>
        /// <param name="message">メッセージ</param>
        public void Fatal(string message)
        {
            log.Fatal(message);
        }

        /// <summary>
        /// 致命的な障害メッセージの出力
        /// </summary>
        /// <param name="message">メッセージ</param>
        public void Fatal(Exception ex)
        {
            log.Fatal("", ex);
        }
        #endregion
    }
}
