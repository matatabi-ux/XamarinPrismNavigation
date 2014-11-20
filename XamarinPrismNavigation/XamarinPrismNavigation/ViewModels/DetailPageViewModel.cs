using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Prism.Xamarin;
using Prism.Xamarin.ViewModels;
using XamarinPrismNavigation.Models;

namespace XamarinPrismNavigation.ViewModels
{
    /// <summary>
    /// 詳細画面の ViewModel
    /// </summary>
    public class DetailPageViewModel : ViewModelBase
    {
        #region Privates

        /// <summary>
        /// リポジトリ
        /// </summary>
        private PhotoRepository repository;

        #endregion //Privates

        #region SelectedItem

        /// <summary>
        /// 選択アイテム
        /// </summary>
        private PhotoViewModel selectedItem = null;

        /// <summary>
        /// 選択アイテム の取得と設定
        /// </summary>
        public PhotoViewModel SelectedItem
        {
            get { return this.selectedItem; }
            set { this.SetProperty<PhotoViewModel>(ref this.selectedItem, value); }
        }

        #endregion //SelectedItem

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="repository">リポジトリ（DI コンテナにより自動注入される）</param>
        [InjectionConstructor]
        public DetailPageViewModel(PhotoRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// 画面に遷移したときの処理
        /// </summary>
        /// <param name="navigationParameter">遷移パラメータ</param>
        /// <param name="navigationMode">遷移モード</param>
        public override void OnNavigatedTo(object navigationParameter, NavigationMode navigationMode)
        {
            base.OnNavigatedTo(navigationParameter, navigationMode);

            if (navigationParameter is int && navigationMode == NavigationMode.Pushed)
            {
                var itemId = (int) navigationParameter;
                this.SelectedItem = new PhotoViewModel(repository.Items.FirstOrDefault(p => p.UniqueId == itemId));
            }
        }
    }
}
