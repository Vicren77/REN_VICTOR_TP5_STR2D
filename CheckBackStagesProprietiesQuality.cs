using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace csharp
{
    [TestFixture]
    public class CheckBackStagesProprietiesQuality
    {

        [Test]
        public void BackStagePasseQualityPlusTwoWhenBetweenTenAndFour()
        {

            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 6, Quality = 12 };
            IList<Item> Items = new List<Item> { item };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(item.Quality, 14);
        }


        [Test]
        public void BackStagePasseQualityPlusThreeWhenBetweenOneAndThree()
        {

            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 2, Quality = 12 };
            IList<Item> Items = new List<Item> { item };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(item.Quality, 15);
        }
        [Test]
        public void BackStagePasseQualityZeroWhenSellInZero()
        {

            var item = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 15 };
            IList<Item> Items = new List<Item> { item };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(item.Quality, 0);
        }


    }
}
