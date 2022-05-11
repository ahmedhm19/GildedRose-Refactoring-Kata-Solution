using Kata.Model;

namespace Kata.Domain
{
    public abstract class ItemManager
    {
        public void Update(Item item)
        {
            UpdateSellIn(item);

            UpdateQuality(item);

            ValidateQuality(item);
        }

        protected virtual void UpdateSellIn(Item item)
        {
            item.SellIn--;
        }

        protected abstract void UpdateQuality(Item item);

        protected virtual void ValidateQuality(Item item)
        {
            if (item.Quality > Constants.MAXQUALITY)
            {
                item.Quality = Constants.MAXQUALITY;
            }
            else if (item.Quality < Constants.MINQUALITY)
            {
                item.Quality = Constants.MINQUALITY;
            }
        }

    }
}
