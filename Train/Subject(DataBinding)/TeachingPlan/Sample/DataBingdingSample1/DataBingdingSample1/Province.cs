using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingSample1
{
    public class Province
    {
        public string Name
        {
            get;
            set;
        }
        public ObservableCollection<City> Cities
        {
            get;
            set;
        }
    }
}
