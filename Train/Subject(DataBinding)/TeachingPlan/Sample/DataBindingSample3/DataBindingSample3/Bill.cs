using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingSample3
{
    public class Bill:INotifyPropertyChanged
    {
        private int _price;

        public int Price
        {
            get { return _price; }
            set 
            {               
                _price = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Total"));
            }
        }

        private int _quantity;

        public int Quantity
        {
            get { return _quantity; }
            set 
            {
                _quantity = value; 
                if(PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Total"));
            }
        }


        public int Total
        {

            get { return _price * _quantity; }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
