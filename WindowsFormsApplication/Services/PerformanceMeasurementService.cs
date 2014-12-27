using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kizuna.Plus.PdfLocker.Controllers.Commands;
using Kizuna.Plus.PdfLocker.Controllers.State;
using Kizuna.Plus.PdfLocker.Models.EventArg;

namespace Kizuna.Plus.PdfLocker.Services
{
    class PerformanceMeasurementService : IService
    {
        /// <summary>
        /// 実行
        /// </summary>
        public static object Execute(Delegate delegateMethod, object[] parameters)
        {
#if PERFORMANCE_CHECK
            // 計測開始
            Stopwatch watch = new Stopwatch();
            watch.Start();
#endif
            // メソッドの呼び出し
            object retValue = delegateMethod.Method.Invoke(delegateMethod.Target, parameters);

#if PERFORMANCE_CHECK
            // 計測終了
            watch.Stop();

            // ログに出力
            var logCommand = new LogCommand();
            logCommand.Execute(new DebugState(typeof(Application)), new LogMessageEventArgs() { Message = string.Format("{0} Method Execute Time : {1}", delegateMethod.Method.Name, watch.Elapsed) });
#endif
            return retValue;
        }
    }
}
