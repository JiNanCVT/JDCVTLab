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
    public class InputStudentCommand:ICommand
    {
        List<Student> _students;
        List<string> _helpMessage;

        public InputStudentCommand(List<Student> students)
        {
            _students = students;
            _helpMessage = new List<string>();
            _helpMessage.Add("请输入学生姓名和分数。");
            _helpMessage.Add("按Esc键停止输入学生姓名和分数。");
        }

        public object ExecuteCommand()
        {
            foreach (var msg in _helpMessage)
            {
                Console.WriteLine(msg);
            }

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
            catch (StudentSort.BaseCommand.InterruptCommandException)
            {
                Console.WriteLine("退出输入学生姓名、成绩。");
            }

            return null;
        }
    }
}
