using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Prism.Mvvm.Interfaces;
using Prism.Xamarin;
using Prism.Xamarin.ViewModels;
using XamarinPrismNavigation.Models;
using XamarinPrismNavigation.Views;

namespace XamarinPrismNavigation.ViewModels
{
    /// <summary>
    /// 写真リスト画面の ViewModel
    /// </summary>
    public class PhotoListPageViewModel : ViewModelBase
    {
        #region Privates

        /// <summary>
        /// 画面遷移サービス
        /// </summary>
        private INavigationService navigationService;

        /// <summary>
        /// リポジトリ
        /// </summary>
        private PhotoRepository repository;

        #endregion //Privates

        #region Items プロパティ

        /// <summary>
        /// リストアイテム
        /// </summary>
        private IList<PhotoViewModel> items = new ObservableCollection<PhotoViewModel>();

        /// <summary>
        /// リストアイテム の取得と設定
        /// </summary>
        public IList<PhotoViewModel> Items
        {
            get { return this.items; }
            set { this.SetProperty<IList<PhotoViewModel>>(ref this.items, value); }
        }

        #endregion //Items プロパティ

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
            set
            {
                this.SetProperty<PhotoViewModel>(ref this.selectedItem, value);
                if (this.selectedItem == null)
                {
                    return;
                }
                this.navigationService.NavigateAsync(typeof(DetailPage), this.selectedItem.UniqueId);
            }
        }

        #endregion //SelectedItem プロパティ

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="navigationService">画面遷移サービス（DI コンテナにより自動注入される）</param>
        /// <param name="repository">リポジトリ（DI コンテナにより自動注入される）</param>
        [InjectionConstructor]
        public PhotoListPageViewModel(INavigationService navigationService, PhotoRepository repository)
        {
            this.navigationService = navigationService;
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
                this.Items.Clear();

                var nationId = (int) navigationParameter;
                foreach (var item in this.repository.Items.Where(p => p.NationId == nationId))
                {
                    this.Items.Add(new PhotoViewModel(item));
                }
            }
        }
    }
}
