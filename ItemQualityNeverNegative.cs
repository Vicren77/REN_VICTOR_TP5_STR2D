using System;
using System.Collections.Generic;
using System.Text;



using NUnit.Framework;

namespace csharp
{
    [TestFixture]
    public class ItemQualityNeverNegative
    {

        [Test]
        public void ItemQualityNeverNegativeValue()
        {

            var item = new Item { Name = "Random noob Item", SellIn = 5, Quality = 0 };
            IList<Item> Items = new List<Item> { item };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(item.Quality, 0);
        }


    }
}
