using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalligraphySample.Entities
{
    public class EntityBase:INotifyPropertyChanged
    {
        public enum Statuses
        {
            Updated,
            New,
            Edit,
            Delete
        }

        private Statuses _status;

        public Statuses Status
        {
            get { return _status; }
            set 
            { 
                _status = value; 
            }
        }

        public void SetPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public EntityBase()
        {
            PropertyChanged += EntityBase_PropertyChanged;
        }

        void EntityBase_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            _status = Statuses.Edit;
        }
    }
}
