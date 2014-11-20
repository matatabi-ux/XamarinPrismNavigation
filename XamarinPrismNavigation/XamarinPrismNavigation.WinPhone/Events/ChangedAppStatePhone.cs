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
using Prism.Xamarin.Events;

namespace XamarinPrismNavigation.WinPhone.Events
{
    /// <summary>
    /// Windows Phone アプリケーション実行状態の変更イベント引数
    /// </summary>
    public class ChangedAppStatePhone : ChangedAppState
    {
        /// <summary>
        /// AppState の変換表
        /// </summary>
        private static readonly Dictionary<AppStatePhone, AppState> ConvertToAppState = new Dictionary<AppStatePhone, AppState>()
        {
            {AppStatePhone.NotRunning, AppState.NotRunning},
            {AppStatePhone.Running, AppState.Running},
            {AppStatePhone.Dormant, AppState.Suspended},
            {AppStatePhone.Tombstoned, AppState.Terminated},
        };

        /// <summary>
        /// 新しい実行状態
        /// </summary>
        public AppStatePhone NativeAppState { get; protected set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="state">アプリケーション実行状態</param>
        public ChangedAppStatePhone(AppStatePhone state)
            : base(ConvertToAppState[state])
        {
            this.NativeAppState = state;
        }
    }
}
