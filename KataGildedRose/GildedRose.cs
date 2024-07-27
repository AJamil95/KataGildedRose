using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataGildedRose
{
    public class GildedRose
    {
        public static List<Item> Items = null;

        public static void main(string[] args)
        {

            Console.WriteLine("OMGHAI!");

            Items.Add(new Item("+5 Dexterity Vest", 10, 20));
            Items.Add(new Item("Aged Brie", 2, 0));
            Items.Add(new Item("Elixir of the Mongoose", 5, 7));
            Items.Add(new Item("Sulfuras, Hand of Ragnaros", 0, 80));
            Items.Add(new Item("Backstage passes to a TAFKAL80ETC concert", 15, 20));
            Items.Add(new Item("Conjured Mana Cake", 3, 6));

            updateQuality();

            Console.WriteLine(Items);
        }

        public static void updateQuality()
        {
            foreach (var item in Items)
            {
                for (int i = 0; i < Items.Count(); i++)
                {
                    if ((!"Aged Brie".Equals(Items.ElementAt(i).GetName()))
                        && !"Backstage passes to a TAFKAL80ETC concert".Equals(Items.ElementAt(i).GetName()))
                    {
                        if (Items.ElementAt(i).GetQuality() > 0)
                        {
                            if (!"Sulfuras, Hand of Ragnaros".Equals(Items.ElementAt(i).GetName()))
                            {
                                Items.ElementAt(i).SetQuality(Items.ElementAt(i).GetQuality() - 1);
                            }
                        }
                    }
                    else
                    {
                        if (Items.ElementAt(i).GetQuality() < 50)
                        {
                            Items.ElementAt(i).SetQuality(Items.ElementAt(i).GetQuality() + 1);

                            if ("Backstage passes to a TAFKAL80ETC concert".Equals(Items.ElementAt(i).GetName()))
                            {
                                if (Items.ElementAt(i).GetSellIn() < 11)
                                {
                                    if (Items.ElementAt(i).GetQuality() < 50)
                                    {
                                        Items.ElementAt(i).SetQuality(Items.ElementAt(i).GetQuality() + 1);
                                    }
                                }

                                if (Items.ElementAt(i).GetSellIn() < 6)
                                {
                                    if (Items.ElementAt(i).GetQuality() < 50)
                                    {
                                        Items.ElementAt(i).SetQuality(Items.ElementAt(i).GetQuality() + 1);
                                    }
                                }
                            }
                        }
                    }

                    if (!"Sulfuras, Hand of Ragnaros".Equals(Items.ElementAt(i).GetName()))
                    {
                        Items.ElementAt(i).SetSellIn(Items.ElementAt(i).GetSellIn() - 1);
                    }

                    if (Items.ElementAt(i).GetSellIn() < 0)
                    {
                        if (!"Aged Brie".Equals(Items.ElementAt(i).GetName()))
                        {
                            if (!"Backstage passes to a TAFKAL80ETC concert".Equals(Items.ElementAt(i).GetName()))
                            {
                                if (Items.ElementAt(i).GetQuality() > 0)
                                {
                                    if (!"Sulfuras, Hand of Ragnaros".Equals(Items.ElementAt(i).GetName()))
                                    {
                                        Items.ElementAt(i).SetQuality(Items.ElementAt(i).GetQuality() - 1);
                                    }
                                }
                            }
                            else
                            {
                                Items.ElementAt(i).SetQuality(Items.ElementAt(i).GetQuality() - Items.ElementAt(i).GetQuality());
                            }
                        }
                        else
                        {
                            if (Items.ElementAt(i).GetQuality() < 50)
                            {
                                Items.ElementAt(i).SetQuality(Items.ElementAt(i).GetQuality() + 1);
                            }
                        }
                    }

                    if (Items.ElementAt(i).GetName().Equals("Conjured Mana Cake"))
                    {
                        if (Items.ElementAt(i).GetQuality() > 0)
                        {
                            Items.ElementAt(i).SetQuality(Items.ElementAt(i).GetQuality() - 1);
                            if (Items.ElementAt(i).GetSellIn() < 0)
                            {
                                Items.ElementAt(i).SetQuality(Items.ElementAt(i).GetQuality() - 1);
                            }
                        }
                    }
                }
            }
        }
    }
}
