using KataGildedRose;
using System.Collections;

namespace KataGildedRoseTest
{
    [TestClass]
    public class GildedRoseTests
    {
        [TestMethod]
        public void TestNormalItemDecrementQuality()
        {
            // Contexto
            GildedRose.Items = new List<Item>();
            int inputQuality = 20;
            Item item = new Item("+5 Dexterity Vest", 10, inputQuality);

            GildedRose.Items.Add(item);
            GildedRose.updateQuality();

            int expectedQuality = inputQuality - 1;

            Assert.AreEqual(expectedQuality, item.GetQuality());
        }

        [TestMethod]
        public void TestNormalItemDoubleDecrementQuality()
        {
            // Contexto
            GildedRose.Items = new List<Item>();
            int inputQuality = 20;
            Item item = new Item("+5 Dexterity Vest", 0, inputQuality);

            GildedRose.Items.Add(item);
            GildedRose.updateQuality();

            int expectedQuality = inputQuality - 2;

            Assert.AreEqual(expectedQuality, item.GetQuality());
        }


        [TestMethod]
        public void TestNormalItemZeroQuality()
        {
            // Contexto
            GildedRose.Items = new List<Item>();
            int inputQuality = 0;
            Item item = new Item("+5 Dexterity Vest", 0, inputQuality);

            GildedRose.Items.Add(item);
            GildedRose.updateQuality();

            int expectedQuality = 0;

            Assert.AreEqual(expectedQuality, item.GetQuality());
        }

        [TestMethod]
        public void TestItemsufurasLegendary()
        {
            // Contexto
            GildedRose.Items = new List<Item>();
            int inputQuality = 80;
            Item item = new Item("Sulfuras, Hand of Ragnaros", 15, inputQuality);

            GildedRose.Items.Add(item);
            GildedRose.updateQuality();

            int expectedQuality = 80;

            Assert.AreEqual(expectedQuality, item.GetQuality());
        }

        [TestMethod]
        public void TestItemNoMayor50()
        {
            // Contexto
            GildedRose.Items = new List<Item>();
            int inputQuality = 50;
            Item item = new Item("Aged Brie", 20, inputQuality);

            GildedRose.Items.Add(item);
            GildedRose.updateQuality();

            int expectedQuality = 50;

            Assert.AreEqual(expectedQuality, item.GetQuality());
        }

        [TestMethod]
        public void TestbackstageIncrementsQuality()
        {
            // Contexto
            GildedRose.Items = new List<Item>();
            int inputQuality = 20;
            Item item = new Item("Backstage passes to a TAFKAL80ETC concert", 15, inputQuality);

            GildedRose.Items.Add(item);
            GildedRose.updateQuality();

            int expectedQuality = inputQuality + 1;

            Assert.AreEqual(expectedQuality, item.GetQuality());
        }

        [TestMethod]
        public void TestbackstageDoubleIncrementQuality()
        {
            // Contexto
            GildedRose.Items = new List<Item>();
            int inputQuality = 20;
            Item item = new Item("Backstage passes to a TAFKAL80ETC concert", 10, inputQuality);

            GildedRose.Items.Add(item);
            GildedRose.updateQuality();

            int expectedQuality = inputQuality + 2;

            Assert.AreEqual(expectedQuality, item.GetQuality());
        }

        [TestMethod]
        public void TestBackstageTripleIncrementQuality()
        {
            // Contexto
            GildedRose.Items = new List<Item>();
            int inputQuality = 20;
            Item item = new Item("Backstage passes to a TAFKAL80ETC concert", 5, inputQuality);

            GildedRose.Items.Add(item);
            GildedRose.updateQuality();

            int expectedQuality = inputQuality + 3;

            Assert.AreEqual(expectedQuality, item.GetQuality());
        }

        [TestMethod]
        public void TestBackstageZeroQuality()
        {
            // Contexto
            GildedRose.Items = new List<Item>();
            int inputQuality = 20;
            Item item = new Item("Backstage passes to a TAFKAL80ETC concert", 0, inputQuality);

            GildedRose.Items.Add(item);
            GildedRose.updateQuality();

            int expectedQuality = 0;

            Assert.AreEqual(expectedQuality, item.GetQuality());
        }
    }
}