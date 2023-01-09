using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.BL
{
    class MenuItems
    {
        private string name;
        private string type;
        private int price;
        public MenuItems(string Name,string type,int price)
        {
            this.name = Name;
            this.type = type;
            this.price = price;
        }
        public void setName(string Name)
        {
            this.name = Name;
        }
        public void setType(string Type)
        {
            this.type = Type;
        }
        public void setPrice(int Price)
        {
            this.price = Price;
        }
        public string getName()
        {
            return name;
        }
        public string getType()
        {
            return type;
        }
        public int getPrice()
        {
            return price;
        }
    }
}
