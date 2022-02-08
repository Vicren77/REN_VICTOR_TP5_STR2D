using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

namespace csharp
{
    [TestFixture]
    public class NegativeSellInShouldUpQualityTwoTimes
    {

        [Test]
        public void NegativeSellInPlusTwoOrMinusTwoQuality()
        {

            var item = new Item { Name = "Random noob Item", SellIn = -1, Quality = 41 };
            IList<Item> Items = new List<Item> { item };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(item.Quality, 39);
        }
        [Test]
        public void CheeseNegativeSellInQualityPlusTwo()
        {

            var item = new Item { Name = "Aged Brie", SellIn = -7, Quality = 14 };
            IList<Item> Items = new List<Item> { item };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(item.Quality, 16);
        }

    }
}

