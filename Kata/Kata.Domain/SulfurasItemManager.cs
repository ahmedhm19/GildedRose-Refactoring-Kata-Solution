using Kata.Model;

namespace Kata.Domain
{
    public class SulfurasItemManager : ItemManager
    {

        protected override void UpdateSellIn(Item item)
        {
            return;
        }
        protected override void UpdateQuality(Item item)
        {
            item.Quality = Constants.LEGENDARYMAXQUALITY;
        }
        protected override void ValidateQuality(Item item)
        {
            if (item.Quality != Constants.LEGENDARYMAXQUALITY)
            {
                item.Quality = Constants.LEGENDARYMAXQUALITY;
            }           
        }
    }
}
