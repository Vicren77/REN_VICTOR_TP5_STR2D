using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace csharp
{
    [TestFixture]
    public class CheeseOrBackstageQualityUpOneOrTwo
    {

        [Test]
        public void BackStagePasseQualityPlusOne()
        {

            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 12 };
            IList<Item> Items = new List<Item> { item };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(item.Quality, 13);
        }


        [Test]
        public void CheeseQualityPlusOne()
        {

            var item = new Item { Name = "Aged Brie", SellIn = 5, Quality = 17 };
            IList<Item> Items = new List<Item> { item };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(item.Quality, 18);
        }



    }
}
