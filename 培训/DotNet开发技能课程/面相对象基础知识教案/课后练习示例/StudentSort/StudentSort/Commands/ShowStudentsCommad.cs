using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSort
{
    public class ShowStudentsCommad:ICommand
    {
        public void ExecuteCommand()
        {
            foreach (var s in Doc.Sudents)
            {
                Console.Write(s.Name);
                Console.Write("\t");
                Console.WriteLine(s.Score);
            }
        }
    }
}
