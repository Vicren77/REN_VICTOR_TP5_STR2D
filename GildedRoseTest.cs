using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void ItemSellinShouldDropByOneEachDay()
        {
            var item = new Item { Name = "Normal item", SellIn = 3, Quality = 5 };
            IList<Item> Items = new List<Item> { item };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(item.SellIn, 2);
        }

        [Test]
        public void ItemQualityShouldDropByOneEachDay()
        {
            var item = new Item { Name = "Normal item", SellIn = 3, Quality = 5 };
            IList<Item> Items = new List<Item> { item };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(item.Quality, 4);
        }
    }
}
