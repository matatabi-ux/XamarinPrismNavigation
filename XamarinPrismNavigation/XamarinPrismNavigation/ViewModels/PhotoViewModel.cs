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
using Prism.Xamarin.ViewModels;
using Xamarin.Forms;
using XamarinPrismNavigation.Models;

namespace XamarinPrismNavigation.ViewModels
{
    /// <summary>
    /// 写真アイテム
    /// </summary>
    public class PhotoViewModel : ViewModelBase
    {
        /// <summary>
        /// ID
        /// </summary>
        public int UniqueId { get; private set; }

        /// <summary>
        /// タイトル
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// 画像パス
        /// </summary>
        public ImageSource ImageSource { get; private set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="item">写真アイテム</param>
        public PhotoViewModel(PhotoItem item)
        {
            this.UniqueId = item.UniqueId;
            this.Title = item.Title;
            this.ImageSource = ImageSource.FromResource(item.ImageUri);
        }
    }
}
