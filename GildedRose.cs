using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality() // we do a switch do break into different case , cheese,sulfura,backstage and classic item
        {
            for (var i = 0; i < Items.Count; i++)
            {

                var item_switched = Items[i].Name;


                switch (item_switched)
                {
                    case "Aged Brie":
                        Items[i] = UpdatingCheese(Items[i]);
                        break;
                    case "Sulfuras, Hand of Ragnaros":
                        break;

                    case "Backstage passes to a TAFKAL80ETC concert":
                        Items[i] = UpdatingQuality(Items[i]);
                        break;
                    case "Conjured Mana Cake":
                        Items[i] = UpdatingConjuredItem(Items[i]);
                        break;

                    default:
                        Items[i] = UpdatingClassicItem(Items[i]);
                        break;
                }

            }
        }

        public Item UpdatingCheese(Item Cheese)
        {
            if (Cheese.SellIn > 0 && Cheese.Quality < 50)
            {
                Cheese.Quality += 1;
            }
            else if (Cheese.Quality < 49)
            {
                Cheese.Quality += 2;
            }
            Cheese.SellIn -= 1;
            return Cheese;
        }
        public Item UpdatingQuality(Item concert)
        {
            if (concert.SellIn <= 0 && concert.Quality >= 0)
            {
                concert.Quality = 0;
            }
            else
            {
                if (concert.SellIn > 10 && concert.Quality < 50)
                {
                    concert.Quality += 1;
                }
                else if (concert.SellIn > 5 && concert.Quality < 49)
                {
                    concert.Quality += 2;
                }
                else if (concert.SellIn > 0 && concert.Quality < 48)
                {
                    concert.Quality += 3;
                }
                else
                {
                    concert.Quality = 50;
                }
            }
            concert.SellIn -= 1;

            return concert;
        }

  

        public Item UpdatingClassicItem(Item item)
        {           
            if (item.Quality > 1)
            {
                if (item.SellIn > 0)
                {
                    item.Quality -= 1;
                }
                else
                {
                    item.Quality -= 2;
                }
            }
            else
            {
                item.Quality = 0;
            }
            item.SellIn -= 1;

            return item;
        }
        public Item UpdatingConjuredItem(Item conjuredItem)
        {

            if (conjuredItem.Quality == 1 || conjuredItem.Quality <= 0)
            {
                conjuredItem.Quality = 0;
            }
            else
            {
                conjuredItem.Quality -= 2;
            }
            conjuredItem.SellIn -= 1;

            return conjuredItem;
        }
    }
}