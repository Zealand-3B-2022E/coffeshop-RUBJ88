using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class latte : Coffee
    {
        public latte(int price, string strenght, int discound) : base(price, strenght, discound)
        {

        }

        private int _price;

        public override int Price 
        {
            get
            {
                return _price;
            }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _price = value;
                }
                else
                {
                    _price = 40;
                }
            }
        }

        public override string Strenght()
        {
            return "weak";
        }
    }
}
