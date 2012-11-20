using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSort
{
    public class InputName:BaseCommand
    {
        public InputName()
        {
            _helpMessage = new List<string>();
            _helpMessage.Add("请输入学生姓名。");
        }        

        protected override object Execute(string str)
        {
            return str;
        }

    }
}
