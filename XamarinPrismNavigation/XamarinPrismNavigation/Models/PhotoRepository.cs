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
    /// 写真リポジトリ
    /// </summary>
    public class PhotoRepository
    {
        /// <summary>
        /// 原産国アイテム
        /// </summary>
        public IList<NationItem> Nations { get; private set; }

        /// <summary>
        /// 写真アイテム
        /// </summary>
        public IList<PhotoItem> Items { get; private set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public PhotoRepository()
        {
        }

        /// <summary>
        /// データ読み込み
        /// </summary>
        public void Load()
        {
            this.Nations = new List<NationItem>()
            {
                new NationItem(0, "エチオピア", @"XamarinPrismNavigation.Assets.nation01.png"),
                new NationItem(1, "アメリカ合衆国", @"XamarinPrismNavigation.Assets.nation02.png"),
                new NationItem(2, "エジプト", @"XamarinPrismNavigation.Assets.nation03.png"),
                new NationItem(3, "イギリス", @"XamarinPrismNavigation.Assets.nation04.png"),
                new NationItem(4, "ロシア", @"XamarinPrismNavigation.Assets.nation05.png"),
                new NationItem(5, "日本", @"XamarinPrismNavigation.Assets.nation06.png"),
                new NationItem(6, "タイ", @"XamarinPrismNavigation.Assets.nation07.png"),
                new NationItem(7, "トルコ", @"XamarinPrismNavigation.Assets.nation08.png"),
                new NationItem(8, "ノルウェー", @"XamarinPrismNavigation.Assets.nation09.png"),
                new NationItem(9, "アフガニスタン", @"XamarinPrismNavigation.Assets.nation10.png"),
            };

            this.Items = new List<PhotoItem>()
            {
                new PhotoItem(0, 0, "アビシニアン", @"XamarinPrismNavigation.Assets.cat01.png"), 
                new PhotoItem(1, 1, "アメリカンカール", @"XamarinPrismNavigation.Assets.cat02.png"), 
                new PhotoItem(2, 1, "アメリカンショートヘア", @"XamarinPrismNavigation.Assets.cat03.png"), 
                new PhotoItem(3, 1, "アメリカンボブテイル", @"XamarinPrismNavigation.Assets.cat04.png"), 
                new PhotoItem(4, 1, "アメリカンワイヤーヘア", @"XamarinPrismNavigation.Assets.cat05.png"), 
                new PhotoItem(5, 1, "エキゾチックショートヘア", @"XamarinPrismNavigation.Assets.cat06.png"), 
                new PhotoItem(6, 2, "エジプシャンマウ", @"XamarinPrismNavigation.Assets.cat07.png"), 
                new PhotoItem(7, 1, "オシキャット", @"XamarinPrismNavigation.Assets.cat08.png"), 
                new PhotoItem(8, 3, "オリエンタルショートヘア", @"XamarinPrismNavigation.Assets.cat09.png"), 
                new PhotoItem(9, 4, "サイベリアン", @"XamarinPrismNavigation.Assets.cat10.png"), 
                new PhotoItem(10, 5, "ジャパニーズボブテイル", @"XamarinPrismNavigation.Assets.cat11.png"), 
                new PhotoItem(11, 6, "シャム", @"XamarinPrismNavigation.Assets.cat12.png"), 
                new PhotoItem(12, 7, "ターキッシュアンゴラ", @"XamarinPrismNavigation.Assets.cat13.png"), 
                new PhotoItem(13, 8, "ノルウェージャンフォレストキャット", @"XamarinPrismNavigation.Assets.cat14.png"), 
                new PhotoItem(14, 9, "ペルシャ", @"XamarinPrismNavigation.Assets.cat15.png"), 
                new PhotoItem(15, 1, "メインクーン", @"XamarinPrismNavigation.Assets.cat16.png"), 
                new PhotoItem(16, 1, "ラグドール", @"XamarinPrismNavigation.Assets.cat17.png"), 
                new PhotoItem(17, 1, "マンチカン", @"XamarinPrismNavigation.Assets.cat18.png"), 
                new PhotoItem(18, 3, "ブリティッシュショートヘア", @"XamarinPrismNavigation.Assets.cat19.png"), 
                new PhotoItem(19, 1, "スコティッシュフォールド", @"XamarinPrismNavigation.Assets.cat20.png"), 
            };
        }
    }
}
