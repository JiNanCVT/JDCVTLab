using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSort
{
    public class InputName:Command
    {
        public InputName()
        {
            _helpMessage = new List<string>();
            _helpMessage.Add("请输入学生姓名。");
        }        

        protected override object Execute()
        {
            return Console.ReadLine();
        }

    }
}
