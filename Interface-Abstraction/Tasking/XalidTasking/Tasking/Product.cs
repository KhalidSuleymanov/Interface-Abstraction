using System;
using System.Collections.Generic;
using System.Text;

namespace Tasking
{
    internal class Product
    {
        public string Name;
        public double Price = 0;
        private double _discount;

        public double Discount
        {
            set
            {
                if(value >= 0 && value <= 100)
                {
                    _discount = value;
                }
                if(_discount > 0)
                {
                    Price = (Price - (Price * Discount) / 100);
                }
            }
            get
            {
                return _discount;
            }
        }

       
    }
}
