﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kizuna.Plus.WinMvcForm.Framework.Controllers.State
{
    /// <summary>
    /// ステート抽象クラス
    /// </summary>
    class AbstractState : IState
    {
        #region メンバー変数
        /// <summary>
        /// 呼び出し元
        /// </summary>
        protected object source;

        /// <summary>
        /// 処理状態
        /// </summary>
        protected StateMode mode;
        #endregion

        #region 初期化処理
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="source">呼び出し元</param>
        public AbstractState(object source)
        {
            if (source == null)
            {
                this.source = typeof(Application);
            }
            else
            {
                this.source = source;
            }
        }
        #endregion

        #region 取得
        /// <summary>
        /// 呼び出し元の取得
        /// </summary>
        /// <returns>呼び出し元のクラス</returns>
        public object GetSource()
        {
            return source;
        }

        /// <summary>
        /// 処理状態の取得
        /// </summary>
        /// <returns>処理状態</returns>
        public virtual StateMode GetMode()
        {
            return mode;
        }
        #endregion
    }
}
