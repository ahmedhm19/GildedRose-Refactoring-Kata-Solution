using Kata.Domain.Helpers;
using Kata.Services.Helpers;
using System;

namespace Kata.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            var gildedRoseService = ServiceFactory.CreateGildedRoseService();

            var items = gildedRoseService.GetItems();

            int days = 2;
            if (args.Length > 0)
            {
                days = int.Parse(args[0]) + 1;
            }

            for (var i = 0; i < days; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
              
                for (var j = 0; j < items.Count; j++)
                {
                    var itemManager = ItemManagerFactory.Create(items[j].Name);         
                    itemManager.Update(items[j]);

                    Console.WriteLine(items[j].Name + ", " + items[j].SellIn + ", " + items[j].Quality);
                }
               
                Console.WriteLine("");    
            }

        }
    }
}
