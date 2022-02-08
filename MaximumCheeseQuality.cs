using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

namespace csharp
{
    [TestFixture]
    public class MaximumCheeseQuality
    {

        [Test]
        public void MaximumCheeseSellInMinus1()
        {

            var item = new Item { Name = "Aged Brie", SellIn = 2, Quality = 50 };
            IList<Item> Items = new List<Item> { item };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(item.SellIn, 1);
        }


        [Test]
        public void MaximumCheeseQualityFifty()
        {

            var item = new Item { Name = "Aged Brie", SellIn = 2, Quality = 50 };
            IList<Item> Items = new List<Item> { item };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(item.Quality, 50);
        }



    }
}
