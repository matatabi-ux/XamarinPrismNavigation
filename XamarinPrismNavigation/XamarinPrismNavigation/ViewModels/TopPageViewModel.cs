#region License
//-----------------------------------------------------------------------
// <copyright>
//     Copyright matatabi-ux 2014.
// </copyright>
//-----------------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Unity;
using Prism.Mvvm.Interfaces;
using Prism.Xamarin.ViewModels;
using Xamarin.Forms;
using XamarinPrismNavigation.Models;
using XamarinPrismNavigation.ViewModels;
using XamarinPrismNavigation.Views;

namespace XamarinPrismNavigation.ViewModels
{
    /// <summary>
    /// 最初の画面の ViewModel
    /// </summary>
    public class TopPageViewModel : ViewModelBase
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
        private IList<NationViewModel> items = new ObservableCollection<NationViewModel>();

        /// <summary>
        /// リストアイテム の取得と設定
        /// </summary>
        public IList<NationViewModel> Items
        {
            get { return this.items; }
            set { this.SetProperty<IList<NationViewModel>>(ref this.items, value); }
        }

        #endregion //Items プロパティ

        #region SelectedItem

        /// <summary>
        /// 選択アイテム
        /// </summary>
        private NationViewModel selectedItem = null;

        /// <summary>
        /// 選択アイテム の取得と設定
        /// </summary>
        public NationViewModel SelectedItem
        {
            get { return this.selectedItem; }
            set
            {
                this.SetProperty<NationViewModel>(ref this.selectedItem, value);
                if (this.selectedItem == null)
                {
                    return;
                }
                this.navigationService.NavigateAsync(typeof(PhotoListPage), this.selectedItem.UniqueId);
            }
        }

        #endregion //SelectedItem プロパティ

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="navigationService">画面遷移サービス（DI コンテナにより自動注入される）</param>
        /// <param name="repository">リポジトリ（DI コンテナにより自動注入される）</param>
        [InjectionConstructor]
        public TopPageViewModel(INavigationService navigationService, PhotoRepository repository)
        {
            this.navigationService = navigationService;
            this.repository = repository;

            foreach (var nation in this.repository.Nations)
            {
                this.Items.Add(new NationViewModel(nation));
            }
        }
    }
}
