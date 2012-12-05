using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseSampleConsole
{
    /// <summary>
    /// 数据实体，书法家
    /// </summary>
    public class Calligrapher
    {
        private int _id;

        public int Id
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

        public override string ToString()
        {
            return "ID = " + _id.ToString() + "Name = " + _name;
        }
    }
}
