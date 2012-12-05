using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPFOrg
{
    public class VMRpo
    {
        CollectionViewSource _rpos;
        public CollectionViewSource Rpos
        {
            get { return _rpos; }
            set { _rpos = value; }
        }

        ObservableCollection<Rpo> _rpoCollection;
        public ObservableCollection<Rpo> RpoCollection
        {
            get { return _rpoCollection; }
            set { _rpoCollection = value; }
        }

        public VMRpo()
        {
            _rpos = new CollectionViewSource();
            _rpoCollection = new ObservableCollection<Rpo>();
            _rpos.Source = _rpoCollection;
            _rpoCollection.Add(new Rpo("a"));
            _rpoCollection.Add(new Rpo("e"));
            _rpoCollection.Add(new Rpo("z"));
            _rpos.SortDescriptions.Add(new System.ComponentModel.SortDescription("Name", System.ComponentModel.ListSortDirection.Descending));
        }
    }
}
