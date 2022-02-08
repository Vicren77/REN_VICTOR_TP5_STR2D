using System;
using System.Collections.Generic;
using System.Text;


using NUnit.Framework;

namespace csharp
{
    [TestFixture]
    public class SulfuraQualityStayNoExpirationDate
    {

        [Test]
        public void SulfuraQualityEighty()
        {

            var item = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 5, Quality = 80 };
            IList<Item> Items = new List<Item> { item };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(item.Quality, 80);
        }


        [Test]
        public void SulfuraSellInAlwaysZero()
        {

            var item = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 7, Quality = 80 };
            IList<Item> Items = new List<Item> { item };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(item.SellIn, 7);
        }



    }
}
