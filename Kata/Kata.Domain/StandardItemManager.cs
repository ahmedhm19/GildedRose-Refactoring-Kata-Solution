using Kata.Model;

namespace Kata.Domain
{
    public class StandardItemManager : ItemManager
    {
        protected override void UpdateQuality(Item item)
        {
            item.Quality--;

            if (item.SellIn < 0)
                item.Quality--;
        }
    }
}
