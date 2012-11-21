using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSort
{
    public class OrderByScoreAscCommand:ICommand
    {
       

        public OrderByScoreAscCommand()
        {
        }

        public void ExecuteCommand( )
        {
            if (Doc.Sudents == null || Doc.Sudents.Count == 0)
            {
                Console.WriteLine("还没有学生信息，请先输入学生姓名和成绩。");
                return ;
            }

            var q = from s in Doc.Sudents orderby s.Score select s;

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
