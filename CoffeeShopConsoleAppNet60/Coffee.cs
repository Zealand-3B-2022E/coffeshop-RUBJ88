using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
     internal abstract class Coffee
    {
        //private int _price;
        //private string _strenght;
        //private int _discount;

        //public Coffee(int price, string strenght, int discound)
        //{
        //    _price = 0;
        //    _strenght = strenght;
        //    _discount = discound;
        //}

        //public virtual int Price
        //{
        //    get { return _price; }
        //    set { _price = value; }
        //}
        //public string Strenght
        //{
        //    get { return _strenght; }
        //    set { _strenght = value; }

        //}

        //public int Discount
        //{
        //    get { return _discount; }
        //    set { _discount = value; }
        //}
      
        


      


        //public override string ToString()
        //{
        //    return $"{nameof(_price)}: {_price}, {nameof(_strenght)}: {_strenght}, {nameof(_discount)}: {_discount}";
        //}


        private int _discount;


        public int Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }

        public virtual int price()
        {
            return 20;
        }

        public abstract string strenght();
        
        protected Coffee(int discount)
        {
            _discount = discount;
        }


    }
}
