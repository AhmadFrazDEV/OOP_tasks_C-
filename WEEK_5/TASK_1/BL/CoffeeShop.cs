using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.BL
{
    class CoffeeShop
    {
        private string Name;
        public CoffeeShop(string Name)
        {
            this.Name = Name;
        }
        public string getName()
        {
            return Name;
        }
        public void setName(string Name)
        {
            this.Name=Name; 
        }
    }
}
