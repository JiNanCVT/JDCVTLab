using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSort
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();
            InputStudentCommand command = new InputStudentCommand(students);
            command.ExecuteCommand();
            Console.ReadLine();
        }
    }
}
