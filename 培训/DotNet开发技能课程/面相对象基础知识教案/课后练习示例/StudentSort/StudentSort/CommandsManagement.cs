using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSort
{
    public class CommandsManagement
    {
        protected const string _exit = "exit";
        List<Student> _students;

        Dictionary<String, Type> _keyCommands;
        Dictionary<string, string> _keyDescriptions;

        public CommandsManagement()
        {
            _students = new List<Student>();

            _keyCommands = new Dictionary<string,Type>();
            
            _keyDescriptions = new Dictionary<string, string>();

            RegistCommand();
        }

        private void RegistCommand()
        {
            _keyCommands.Add("i", typeof(StudentSort.InputStudentCommand));
            _keyCommands.Add("show", typeof(StudentSort.ShowStudentsCommad));
            _keyCommands.Add("ona", typeof(StudentSort.OrderByNameAscCommand));
            _keyCommands.Add("osa", typeof(StudentSort.OrderByScoreAscCommand));
            _keyCommands.Add("exit", typeof(StudentSort.ExitCommad));

            _keyDescriptions.Add("i", "输入学生姓名和成绩");
            _keyDescriptions.Add("show", "显示学生列表");
            _keyDescriptions.Add("ona", "按学生名字升序排列");
            _keyDescriptions.Add("osa", "按学生成绩升序排列");
            _keyDescriptions.Add("exit", "退出程序");
        }

        private ICommand GetCommand(string str)
        {
            if (_keyCommands.ContainsKey(str))
               return Activator.CreateInstance(_keyCommands[str]) as ICommand;

            return null;
        }

        private void WriteHelpMessage()
        {
            foreach (var k in _keyDescriptions.Keys)
            {
                Console.Write(k);
                Console.Write("\t");
                Console.WriteLine(_keyDescriptions[k]);
            }
        }

        public void Execute()
        {
            WriteHelpMessage();

            String k = Console.ReadLine();

            ICommand c = GetCommand(k);
            if (c == null)
            {
                Console.WriteLine("找不到相应的命令");
                Execute();
            }
            c.ExecuteCommand();
            Execute();
        }

        

                
    }
}
