using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingSample2
{
    public class Bill
    {
        private int _price;

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private int _quantity;

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }


        public int Total
        {
            get { return _price * _quantity; }
        }

    }
}
