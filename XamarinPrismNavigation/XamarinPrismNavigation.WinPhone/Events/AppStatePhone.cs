#region License
//-----------------------------------------------------------------------
// <copyright>
//     Copyright matatabi-ux 2014.
// </copyright>
//-----------------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinPrismNavigation.WinPhone.Events
{
    /// <summary>
    /// Windows Phone アプリケーション実行状態
    /// </summary>
    public enum AppStatePhone
    {
        /// <summary>
        /// 未起動
        /// </summary>
        NotRunning = 0,

        /// <summary>
        /// 実行中
        /// </summary>
        Running = 10,

        /// <summary>
        /// 中断中
        /// </summary>
        Dormant = 20,

        /// <summary>
        /// シャットダウン
        /// </summary>
        Tombstoned = 30,
    }
}
