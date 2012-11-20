using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSort
{
    /// <summary>
    /// 输入学生信息命令
    /// </summary>
    public class InputStudentCommand:Command
    {
        List<Student> _students;
        public InputStudentCommand(List<Student> students)
        {
            _students = students;
            _helpMessage = new List<string>();
            _helpMessage.Add("输入学生姓名和成绩。");
            _helpMessage.Add("按Ctrl+C键停止录入学生姓名和成绩。");
            Console.CancelKeyPress += Console_CancelKeyPress;
        }

        void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            Console.WriteLine("停止了录入学生姓名和成绩.");
        }

        protected override object Execute()
        {
            try
            {
                while (true)
                {
                    InputName nameCommand = new InputName();
                    string name = (string)nameCommand.ExecuteCommand();
                    InputScore scoreCommnd = new InputScore();
                    int score = (int)scoreCommnd.ExecuteCommand();
                    Student s = new Student(name, score);
                    _students.Add(s);
                }
            }
            catch (Exception )
            {
                
            }

            return null;
        }
    }
}
