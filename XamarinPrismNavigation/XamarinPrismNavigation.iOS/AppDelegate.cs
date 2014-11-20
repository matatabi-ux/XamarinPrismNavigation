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
using Microsoft.Practices.Prism.PubSubEvents;
using Microsoft.Practices.Unity;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Prism.Xamarin.Events;
using Xamarin.Forms;
using XamarinPrismNavigation.iOS.Events;

namespace XamarinPrismNavigation.iOS
{
    /// <summary>
    /// アプリケーション代理クラス
    /// </summary>
    [Register("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        /// <summary>
        /// ウィンドウ
        /// </summary>
        protected UIWindow window;

        /// <summary>
        /// 起動完了時の処理
        /// </summary>
        /// <param name="app">アプリケーション</param>
        /// <param name="options">オプション指定</param>
        /// <returns></returns>
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Forms.Init();

            window = new UIWindow(UIScreen.MainScreen.Bounds);

            window.RootViewController = App.GetMainPage().CreateViewController();

            window.MakeKeyAndVisible();

            return true;
        }

        /// <summary>
        /// Active に移行した際の処理
        /// </summary>
        /// <param name="application">アプリケーションクラス</param>
        public override void WillEnterForeground(UIApplication application)
        {
            App.Container.Resolve<IEventAggregator>().GetEvent<AppStateChangedEvent>()
                .Publish(new ChangedAppStateIOS(AppStateIOS.Active));
        }

        /// <summary>
        /// Backgroud に移行した際の処理
        /// </summary>
        /// <param name="application">アプリケーションクラス</param>
        public override void DidEnterBackground(UIApplication application)
        {
            App.Container.Resolve<IEventAggregator>().GetEvent<AppStateChangedEvent>()
                .Publish(new ChangedAppStateIOS(AppStateIOS.Background));
        }
    }
}
