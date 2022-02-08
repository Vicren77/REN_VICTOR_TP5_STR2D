using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

namespace csharp
{
    [TestFixture]
    public class ConjuringItemQualityDropsByTwo
    {
        [Test]
        public void ConjuringQualityDropsByTwo()
        {

            var item = new Item { Name = "Conjured Mana Cake", SellIn = 5, Quality = 35 };
            IList <Item> Items = new List<Item> { item };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(item.Quality, 33);
        }
    }
}
