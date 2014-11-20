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

namespace XamarinPrismNavigation.Models
{
    /// <summary>
    /// 原産国アイテム
    /// </summary>
    public class NationItem
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
        public string ImageUri { get; private set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="name">名前</param>
        /// <param name="imageUri">画像パス</param>
        public NationItem(int id, string name, string imageUri)
        {
            this.UniqueId = id;
            this.Name = name;
            this.ImageUri = imageUri;
        }
    }
}
