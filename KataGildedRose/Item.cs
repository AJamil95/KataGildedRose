using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataGildedRose
{
    public class Item
    {
        public string Name;
        public int SellIn;
        public int Quality;

        public Item(string Name, int SellIn, int Quality)
        {
            SetName(Name);
            SetSellIn(SellIn);
            SetQuality(Quality);
        }

        /* Generated getter and setter code */
        public string GetName()
        {
            return Name;
        }
        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public int GetSellIn()
        {
            return SellIn;
        }
        public void SetSellIn(int SellIn)
        {
            this.SellIn = SellIn;
        }
        public int GetQuality()
        {
            return Quality;
        }
        public void SetQuality(int Quality)
        {
            this.Quality = Quality;
        }

        override public string ToString()
        {
            return "Item{" +
                "name='" + Name + '\'' +
                ", sellIn=" + SellIn +
                ", quality=" + Quality +
                '}';
        }
    }
}
