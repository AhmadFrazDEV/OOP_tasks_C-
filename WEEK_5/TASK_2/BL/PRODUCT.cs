using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_2.BL
{
    class PRODUCT
    {
        private string Name;
        private string Category;
        private float Price;
        private int Qunatity;
        public PRODUCT(string Name,string Category,float Price,int Quantity)
        {
            this.Name = Name;
            this.Price = Price;
            this.Qunatity = Quantity;
            this.Category = Category;
        }
        public string getName()
        {
            return this.Name;
        }
        public string getCategory()
        {
            return this.Category;
        }
        public float getPrice()
        {
            return this.Price;
        }
        public int getQuantity()
        {
            return this.Qunatity;
        }
        public void setQuantity(int Qunatity)
        {
            this.Qunatity = Qunatity;
        }
        public PRODUCT()
        {

        }
    }
}
