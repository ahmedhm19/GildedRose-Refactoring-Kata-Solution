using Kata.Domain;
using Kata.Domain.Helpers;
using Kata.Model;
using NUnit.Framework;
using System;

namespace Kata.Testing.UnitTests.Domain
{

    [TestFixture]
    public class ItemManagerFactoryTester
    {

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        [TestCase("Other", ExpectedResult = typeof(StandardItemManager))]
        [TestCase("+ 5 Dexterity Vest", ExpectedResult = typeof(StandardItemManager))]
        [TestCase("Aged Brie", ExpectedResult = typeof(AgedBrieItemManager))]
        [TestCase("Backstage passes to a TAFKAL80ETC concert", ExpectedResult = typeof(BackStagePassesItemManager))]
        [TestCase("Sulfuras, Hand of Ragnaros", ExpectedResult = typeof(SulfurasItemManager))]
        [TestCase("Conjured Mana Cake", ExpectedResult = typeof(ConjuredItemManager))]
        public Type ShouldCreateTheRightItemManagerBasedOnItemName(string itemName)
        {
            var item = new Item { Name = itemName, SellIn = 10, Quality = 10 };
            var manager = ItemManagerFactory.Create(item.Name);

            return manager.GetType();
        }


        [Test]
        public void ShouldThrowExceptionWhenItemNameIsNotProvided()
        {
            Assert.Throws<ArgumentNullException>(() => { ItemManagerFactory.Create(""); });
        }



    }
}
