using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSort
{
    public class InputScore:Command
    {
        public InputScore()
        {
            _helpMessage = new List<string>();
            _helpMessage.Add("请输入整数分数。");
        }


        protected override object Execute()
        {
            var str = Console.ReadLine();
            try
            {
                return int.Parse(str);
            }
            catch (Exception e)
            {
                throw new CommandErrorException("输入的不是整数");
            }
        }

    }
}
