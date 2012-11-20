using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSort
{
    /// <summary>
    /// 人
    /// 其实在此示例中，只有学生，没有老师，没有必要写几个基类“人”。
    /// 示例为了演示继承，而写个person。
    /// </summary>
    class Person
    {
        
        string _name;

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Person()
        {
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name">姓名</param>
        public Person(string name)
        {
            _name = name;
        }
    }
}
