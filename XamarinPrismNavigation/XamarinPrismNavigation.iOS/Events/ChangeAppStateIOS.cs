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
using Prism.Xamarin.Events;

namespace XamarinPrismNavigation.iOS.Events
{
    /// <summary>
    /// iOS アプリケーション実行状態の変更イベント引数
    /// </summary>
    public class ChangedAppStateIOS : ChangedAppState
    {
        /// <summary>
        /// AppState の変換表
        /// </summary>
        private static readonly Dictionary<AppStateIOS, AppState> ConvertToAppState = new Dictionary<AppStateIOS, AppState>()
        {
            {AppStateIOS.NotRunning, AppState.NotRunning},
            {AppStateIOS.InActive, AppState.Running},
            {AppStateIOS.Active, AppState.Running},
            {AppStateIOS.Background, AppState.Suspended},
            {AppStateIOS.Suspended, AppState.Terminated},
        };

        /// <summary>
        /// 新しい実行状態
        /// </summary>
        public AppStateIOS NativeAppState { get; protected set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="state">アプリケーション実行状態</param>
        public ChangedAppStateIOS(AppStateIOS state)
            : base(ConvertToAppState[state])
        {
            this.NativeAppState = state;
        }
    }
}
