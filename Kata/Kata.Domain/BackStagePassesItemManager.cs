using Kata.Model;

namespace Kata.Domain
{
    public class BackStagePassesItemManager : ItemManager
    {
        protected override void UpdateQuality(Item item)
        {
            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
            else if (item.SellIn <= 5)
            {
                item.Quality += 3;
            }
            else if (item.SellIn <= 10)
            {
                item.Quality += 2;
            }
            else
            {
                item.Quality++;
            }
        }
    }
}
