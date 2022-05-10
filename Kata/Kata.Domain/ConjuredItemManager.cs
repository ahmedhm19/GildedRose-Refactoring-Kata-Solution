using Kata.Model;

namespace Kata.Domain
{
    public class ConjuredItemManager : ItemManager
    {
        protected override void UpdateQuality(Item item)
        {
            item.Quality -= 2;

            if (item.SellIn <= 0)
                item.Quality -= 2;
        }
    }
}
