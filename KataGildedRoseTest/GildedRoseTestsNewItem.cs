using KataGildedRose;
using System.Collections;

namespace KataGildedRoseTest
{
    [TestClass]
    public class GildedRoseTestsNewItem
    {
        [TestMethod]
        public void testConjuredDecrementQuality()
        {
            // Contexto
            GildedRose.Items = new List<Item>();
            int inputQuality = 20;
            Item item = new Item("Conjured Mana Cake", 15, inputQuality);

            GildedRose.Items.Add(item);
            GildedRose.updateQuality();

            int expectedQuality = inputQuality - 2;

            Assert.AreEqual(expectedQuality, item.GetQuality());
        }

        [TestMethod]
        public void testConjuredNonZeroQuality()
        {
            // Contexto
            GildedRose.Items = new List<Item>();
            int inputQuality = 0;
            Item item = new Item("Conjured Mana Cake", 15, inputQuality);

            GildedRose.Items.Add(item);
            GildedRose.updateQuality();

            int expectedQuality = 0;

            Assert.AreEqual(expectedQuality, item.GetQuality());
        }

        [TestMethod]
        public void testConjuredAlternativeNonZeroQuality()
        {
            // Contexto
            GildedRose.Items = new List<Item>();
            int inputQuality = 1;
            Item item = new Item("Conjured Mana Cake", 15, inputQuality);

            GildedRose.Items.Add(item);
            GildedRose.updateQuality();

            int expectedQuality = 0;

            Assert.AreEqual(expectedQuality, item.GetQuality());
        }


        [TestMethod]
        public void testConjuredQualityWhenSellInZero()
        {
            // Contexto
            GildedRose.Items = new List<Item>();
            int inputQuality = 10;
            Item item = new Item("Conjured Mana Cake", 0, inputQuality);

            GildedRose.Items.Add(item);
            GildedRose.updateQuality();

            int expectedQuality = inputQuality - 4;

            Assert.AreEqual(expectedQuality, item.GetQuality());
        }

        [TestMethod]
        public void testConjuredAlternativeQualityWhenSellInZero()
        {
            // Contexto
            GildedRose.Items = new List<Item>();
            int inputQuality = 3;
            Item item = new Item("Conjured Mana Cake", 0, inputQuality);

            GildedRose.Items.Add(item);
            GildedRose.updateQuality();

            int expectedQuality = 0;

            Assert.AreEqual(expectedQuality, item.GetQuality());
        }
    }
}