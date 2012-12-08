using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalligraphySample.Entities
{
    public class Calligraphyer
    {
        private Guid _id;

        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public Calligraphyer()
        {
            _id = Guid.NewGuid();
        }

        public Calligraphyer(Guid id, string name, string description)
        {
            _id = id;
            _name = name;
            _description = description;
        }
    }
}
