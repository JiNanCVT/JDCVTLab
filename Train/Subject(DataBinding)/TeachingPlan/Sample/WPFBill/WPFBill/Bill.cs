using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WPFBill
{
    public class Bill : INotifyPropertyChanged
    {
        private int _price;

        public int Price
        {
            get { return _price; }
            set 
            {
                if (_price != value)
                {
                    _price = value;
                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs("Total"));
                }                
            }
        }
        private int _q;

        public int Q
        {
            get { return _q; }
            set 
            {
                if (_q != value)
                {
                    _q = value;
                    if (PropertyChanged != null)
                        PropertyChanged(this, new PropertyChangedEventArgs("Total"));
                }
            }
        }

        public int Total
        {
            get
            {
                return _price * _q;
            }            
        }

        public Bill()
        {
            _price = 10;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
