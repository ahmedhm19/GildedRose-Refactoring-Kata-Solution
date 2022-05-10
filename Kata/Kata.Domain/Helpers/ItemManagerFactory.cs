using System;

namespace Kata.Domain.Helpers
{
    public class ItemManagerFactory
    {
        public static ItemManager Create(string itemName)
        {
            if (string.IsNullOrEmpty(itemName))
                throw new ArgumentNullException(nameof(itemName));          

            switch (itemName)
            {
                case "Aged Brie":
                    return new AgedBrieItemManager();
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new BackStagePassesItemManager();
                case "Sulfuras, Hand of Ragnaros":
                    return new SulfurasItemManager();
                case "Conjured Mana Cake":
                    return new ConjuredItemManager();
                default:
                    return new StandardItemManager();
            }
        }
    }
}
