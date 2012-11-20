using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSort
{
    public class OrderByNameAscCommand:ICommand
    {

        public string KeyString
        {
            get { return "na"; }
        }

        public string Description
        {
            get { return "按学生名字升序排列"; }
        }

        public OrderByNameAscCommand()
        {
        }

        public void ExecuteCommand()
        {
            if (Doc.Sudents == null || Doc.Sudents.Count == 0)
            {
                Console.WriteLine("还没有学生信息，不能排序。");
                return ;
            }
            var q = from s in Doc.Sudents orderby s.Name select s;
            var students = q.ToList<Student>();
            foreach (var s in students)
            {
                Console.Write(s.Name);
                Console.Write("\t");
                Console.WriteLine(s.Score);
            }
            return ;
        }

    }
}
