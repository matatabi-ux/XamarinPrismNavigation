#region License
//-----------------------------------------------------------------------
// <copyright>
//     Copyright matatabi-ux 2014.
// </copyright>
//-----------------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinPrismNavigation.iOS.Events
{
    /// <summary>
    /// iOS アプリケーション実行状態
    /// </summary>
    public enum AppStateIOS
    {
        /// <summary>
        /// 未起動
        /// </summary>
        NotRunning = 0,

        /// <summary>
        /// 非表示中
        /// </summary>
        InActive = 5,

        /// <summary>
        /// 利用中
        /// </summary>
        Active = 10,

        /// <summary>
        /// バックグラウンド実行中
        /// </summary>
        Background = 20,

        /// <summary>
        /// 停止中
        /// </summary>
        Suspended = 30,
    }
}
