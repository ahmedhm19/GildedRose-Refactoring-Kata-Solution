using Kata.Model;

namespace Kata.Domain
{
    public class AgedBrieItemManager : ItemManager
    {
        protected override void UpdateQuality(Item item)
        {
            item.Quality++;
        }
    }
}
