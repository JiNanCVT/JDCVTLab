using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSort
{
    public class ExitCommad:ICommand
    {
        public string KeyString
        {
            get { return "exit"; }
        }

        public string Description
        {
            get { return "退出程序"; }
        }

        public void ExecuteCommand()
        {
            Environment.Exit(0);
        }


        public bool IsNeedInput
        {
            get { return false; }
        }
    }
}
