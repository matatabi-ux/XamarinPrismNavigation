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
using Prism.Xamarin.ViewModels;
using Xamarin.Forms;
using XamarinPrismNavigation.Models;

namespace XamarinPrismNavigation.ViewModels
{
    /// <summary>
    /// 原産国アイテム
    /// </summary>
    public class NationViewModel : ViewModelBase
    {
        /// <summary>
        /// ID
        /// </summary>
        public int UniqueId { get; private set; }

        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// 画像パス
        /// </summary>
        public ImageSource ImageSource { get; private set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="item">写真アイテム</param>
        public NationViewModel(NationItem item)
        {
            this.UniqueId = item.UniqueId;
            this.Name = item.Name;
            this.ImageSource = ImageSource.FromResource(item.ImageUri);
        }
    }
}
