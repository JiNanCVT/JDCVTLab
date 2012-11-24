using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace DataBindingSample1
{
    public class VMProvinces
    {
        private CollectionViewSource _provinces;

        public CollectionViewSource Provinces
        {
            get { return _provinces; }
        }

        private ObservableCollection<Province> _Obc_Provinces;
        
        public VMProvinces()
        {
            _Obc_Provinces = new ObservableCollection<Province>();

            Province p1 = new Province();
            p1.Name = "广东";
            p1.Cities = new ObservableCollection<City>();
            p1.Cities.Add(new City("广州"));
            p1.Cities.Add(new City("中山"));
            p1.Cities.Add(new City("佛山"));
            _Obc_Provinces.Add(p1);

            Province p2 = new Province();
            p2.Name = "广西";
            p2.Cities = new ObservableCollection<City>();
            p2.Cities.Add(new City("梧州"));
            p2.Cities.Add(new City("南宁"));
            _Obc_Provinces.Add(p2);

            _provinces = new CollectionViewSource();
            _provinces.Source = _Obc_Provinces;
        }
    }
}
