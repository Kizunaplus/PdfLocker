﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Kizuna.Plus.WinMvcForm.Framework.Controllers.Commands;
using Kizuna.Plus.WinMvcForm.Framework.Models.Enums;
using Kizuna.Plus.PdfLocker.Framework.Message;

namespace Kizuna.Plus.WinMvcForm.Framework.Utility
{
    /// <summary>
    /// コマンドラインデータのサービス提供クラス
    /// </summary>
    class CommandLineUtility<T> where T : new()
    {
        #region 定数
        /// <summary>
        /// プロパティのみの変数名
        /// </summary>
        private const string MODEL_PROPERTY_ONLY_VALUE = "_value";
        #endregion

        #region 変換
        /// <summary>
        /// コマンドラインデータをデータクラスに変換します。
        /// 
        /// 変換に失敗した内容は、例外のMessageに設定されます。
        /// </summary>
        /// <param name="commandLine">コマンドラインデータ</param>
        /// <returns>データクラス</returns>
        public T Parse(string[] commandLine)
        {
            Exception ex;
            // 変換処理
            T data = Parse(commandLine, out ex);
            if (ex != null)
            {
                throw ex;
            }

            return data;
        }

        /// <summary>
        /// コマンドラインデータをデータクラスに変換します。
        /// 
        /// 変換に失敗した内容は、例外のMessageに設定されます。
        /// </summary>
        /// <param name="commandLine">コマンドラインデータ</param>
        /// <param name="ex">エラー内容</param>
        /// <returns>データクラス</returns>
        private T Parse(string[] commandLine, out Exception ex)
        {
            T data = new T();
            StringBuilder message = new StringBuilder();

            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties();

            for (int argIndex = 1; argIndex < commandLine.Length; argIndex++)
            {
                PropertyInfo foundProperty = null;
                foreach (PropertyInfo property in properties)
                {
                    if (commandLine[argIndex].Equals("/" + property.Name, StringComparison.CurrentCultureIgnoreCase) == true)
                    {
                        // プロパティ名と一致する引数を発見
                        foundProperty = property;
                        break;
                    }
                }
                if (foundProperty == null)
                {
                    if (commandLine[argIndex].StartsWith("/") == false)
                    {
                        // key名が存在していないが
                        // プロパティ[_value]が存在する場合はそのプロパティに設定する
                        foreach (PropertyInfo property in properties)
                        {
                            if (property.Name.Equals(MODEL_PROPERTY_ONLY_VALUE, StringComparison.CurrentCultureIgnoreCase) == true)
                            {
                                foundProperty = property;
                                break;
                            }
                        }
                    }

                    if (foundProperty == null)
                    {
                        message.AppendFormat(FrameworkValidationMessage.CommandLineIllegalArg, commandLine[argIndex]);
                        continue;
                    }
                }
                // 論理型
                if (foundProperty.PropertyType == typeof(bool))
                {
                    // boolの場合は定義が存在するだけでtrueを設定
                    foundProperty.SetValue(data, true, null);
                    continue;
                }

                // その他は、ConvertChangeTypeによって変換する。
                if (foundProperty.Name.Equals(MODEL_PROPERTY_ONLY_VALUE, StringComparison.CurrentCultureIgnoreCase) == false)
                {
                    argIndex++;
                }
                if (commandLine.Length <= argIndex)
                {
                    continue;
                }

                try
                {
                    // プロパティに値を設定する。
                    foundProperty.SetValue(data, Convert.ChangeType(commandLine[argIndex], foundProperty.PropertyType, CultureInfo.CurrentCulture), null);
                }
                catch
                {
                    message.AppendFormat(FrameworkValidationMessage.CommandLineIllegalType, commandLine[argIndex - 1], commandLine[argIndex]);
                    argIndex--;
                }
            }

            ex = null;
            if (0 < message.Length)
            {
                // エラーメッセージが設定されている場合は例外を設定
                ex = new ArgumentException(message.ToString());
            }

            return data;
        }

        /// <summary>
        /// コマンドラインデータをデータクラスに変換します。
        /// </summary>
        /// <param name="commandLine">コマンドラインデータ</param>
        /// <param name="data">データクラス</param>
        /// <returns>true: 成功, false: 失敗</returns>
        public bool TryParse(string[] commandLine, out T data)
        {
            Exception ex;
            // 変換処理
            data = Parse(commandLine, out ex);

            if (ex != null)
            {
                var logCommand = new LogCommand();
                logCommand.Execute(LogType.Exception, FrameworkMessage.ExceptionMessage, ex, MethodBase.GetCurrentMethod().Name, commandLine, data);
            }

            return ex == null;
        }
        #endregion
    }
}
