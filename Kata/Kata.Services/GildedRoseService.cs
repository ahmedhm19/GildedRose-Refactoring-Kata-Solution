using Kata.Domain.Helpers;
using Kata.Model;
using System.Collections.Generic;

namespace Kata.Services
{
    public class GildedRoseService
    {       
        public void UpdateItems(IList<Item> items)
        {
            foreach (var item in items)
            {
                var manager = ItemManagerFactory.Create(item.Name);
                manager.Update(item);              
            }
        }

    }
}
