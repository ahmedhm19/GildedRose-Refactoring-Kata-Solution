using Kata.Domain;
using Kata.Domain.Helpers;
using Kata.Model;
using NUnit.Framework;
using System;

namespace Kata.Testing.UnitTests.Domain
{
    [TestFixture]
    public class ItemManagerTester
    {

        [SetUp]
        public void Setup()
        {
           
        }


        [Test]
        [TestCase("+ 5 Dexterity Vest", 10, 20, 02, ExpectedResult = 18, Description = "StandardItem : When SellIn not elapsed")]
        [TestCase("+ 5 Dexterity Vest", 10, 20, 10, ExpectedResult = 10, Description = "StandardItem : When Sellin equals to numberOfDays")]
        [TestCase("+ 5 Dexterity Vest", 10, 20, 12, ExpectedResult = 06, Description = "StandardItem : When Sellin elapsed")]
        [TestCase("Aged Brie", 02, 00, 01, ExpectedResult = 01, Description = "AgedBrieItem : When SellIn not elapsed")]
        [TestCase("Aged Brie", 02, 00, 02, ExpectedResult = 02, Description = "AgedBrieItem : When Sellin equals to numberOfDays")]
        [TestCase("Aged Brie", 02, 00, 04, ExpectedResult = 04, Description = "AgedBrieItem : When Sellin elapsed")]
        [TestCase("Backstage passes to a TAFKAL80ETC concert", 15, 20, 02, ExpectedResult = 22, Description = "BackstagePassesItem : When SellIn not elapsed")]
        [TestCase("Backstage passes to a TAFKAL80ETC concert", 15, 20, 15, ExpectedResult = 50, Description = "BackstagePassesItem : When Sellin equals to numberOfDays")]
        [TestCase("Backstage passes to a TAFKAL80ETC concert", 15, 20, 18, ExpectedResult = 00, Description = "BackstagePassesItem : When Sellin elapsed")]
        [TestCase("Sulfuras, Hand of Ragnaros", 00, 80, -9, ExpectedResult = 80, Description = "SulfurasItem : When SellIn not elapsed")]
        [TestCase("Sulfuras, Hand of Ragnaros", 00, 80, 00, ExpectedResult = 80, Description = "SulfurasItem : When Sellin equals to numberOfDays")]
        [TestCase("Sulfuras, Hand of Ragnaros", 00, 80, 06, ExpectedResult = 80, Description = "SulfurasItem : When Sellin elapsed")]
        [TestCase("Conjured Mana Cake", 03, 06, 01, ExpectedResult = 04, Description = "ConjuredItem : When SellIn not elapsed")]
        [TestCase("Conjured Mana Cake", 03, 06, 03, ExpectedResult = 00, Description = "ConjuredItem : When Sellin equals to numberOfDays")]
        [TestCase("Conjured Mana Cake", 03, 06, 15, ExpectedResult = 00, Description = "ConjuredItem : When Sellin elapsed")]
        public int CheckQualityCalculation(string itemName, int sellIn, int initialQuality, int numberOfDays)
        {
            var item = new Item { Name = itemName, SellIn = sellIn, Quality = initialQuality };
            var manager = ItemManagerFactory.Create(item.Name);

            for (int i = 0; i < numberOfDays; i++)
            {
                manager.Update(item);
            }

            return item.Quality;
    
        }


        [Test]
        [TestCase("+ 5 Dexterity Vest", 10, 02, ExpectedResult = 08)]
        [TestCase("Conjured Mana Cake", 10, 10, ExpectedResult = 00)]
        [TestCase("Aged Brie", 10, 12, ExpectedResult = -2)]
        public int CheckIfSellinIsDecreasing(string itemName, int sellIn, int numberOfDays)
        {
            var item = new Item { Name = itemName, SellIn = sellIn, Quality = 10 };
            var manager = ItemManagerFactory.Create(item.Name);

            for (int i = 0; i < numberOfDays; i++)
            {
                manager.Update(item);
            }

            return item.SellIn;

        }


    }
}
