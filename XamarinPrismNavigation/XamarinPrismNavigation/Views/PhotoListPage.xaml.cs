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
using Microsoft.Practices.Prism.Mvvm;
using Xamarin.Forms;

namespace XamarinPrismNavigation.Views
{
    /// <summary>
    /// 写真リスト画面
    /// </summary>
    public partial class PhotoListPage : ContentPage, IView
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public PhotoListPage()
        {
            this.InitializeComponent();
        }

        #region IView

        /// <summary>
        /// データソース
        /// </summary>
        public object DataContext
        {
            get { return this.BindingContext; }
            set { this.BindingContext = value; }
        }

        #endregion //IView
    }
}