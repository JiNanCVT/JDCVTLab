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
        Student _catcheStudent;

        public InputStudentCommand()
        {
            _catcheStudent = null;
            Console.WriteLine("请输入学生姓名和成绩。");
            Console.WriteLine("按Esc键停止输入学生信息。");
        }

       

        private SimpleCommand GetSimpleCommand()
        {
            if (_catcheStudent == null)
            {
                _catcheStudent = new Student();
                return new InputName(_catcheStudent);
            }
            else
            {
                return new InputScore(_catcheStudent);
            }
        }

        private bool IsStudentAllInputed()
        {
            if (string.IsNullOrEmpty(_catcheStudent.Name) == false && _catcheStudent.Score != -1)
                return true;
            return false;
        }

        private string ReadLine()
        {
            string str = string.Empty;
            while (true)
            {

                var k = Console.ReadKey(true);

                //如果用户按了Esc键，打断本命令的执行
                if ( k.Key == ConsoleKey.Escape)
                    throw new InterruptCommandException();

                if (k.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }

                str += k.KeyChar;
                Console.Write(k.KeyChar);
            }


            return str;
        }


        public void ExecuteCommand()
        {
            try
            {
                while (true)
                {
                    SimpleCommand c = GetSimpleCommand();
                    string str;
                    try
                    {
                        str = ReadLine();
                    }
                    catch (InterruptCommandException)
                    {
                        return;
                    }
                    c.ExecuteCommand(str);
                    if (IsStudentAllInputed())
                    {
                        Doc.Sudents.Add(_catcheStudent);
                        _catcheStudent = null;
                    }
                }
            }
            catch (SimpleCommandErrorException)
            {
                ExecuteCommand();
            }

        }

        protected class SimpleCommand
        {
            protected Student _student;
            public SimpleCommand(Student student)
            {
                _student = student;
            }
            public virtual void ExecuteCommand(string str)
            {
                throw new NotImplementedException();
            }
        }

        protected class SimpleCommandErrorException : Exception { }

        protected class InputName : SimpleCommand
        {
            public InputName(Student student):base(student)
            {
                Console.WriteLine("请输入姓名：");
            }

            public override void ExecuteCommand(string str)
            {
                if (string.IsNullOrEmpty(str))
                {
                    Console.WriteLine("出错，输入的名字不能为空！");
                    throw new SimpleCommandErrorException();
                }
                _student.Name = str;
            }
        }

        protected class InputScore : SimpleCommand
        {
            public InputScore(Student student):base(student)
            {
                Console.WriteLine( "请输入成绩。");
            }

            public override void ExecuteCommand(string str)
            {
                try
                {
                    _student.Score = int.Parse(str);
                }
                catch (Student.InvalidScoreException)
                {
                    throw new SimpleCommandErrorException();
                    Console.WriteLine("出错，分数不能是负数。");
                }
                catch (Exception e)
                {
                    Console.WriteLine("出错，输入的不是整数。");
                    System.Diagnostics.Debug.WriteLine(e.GetType() + "---");
                    throw new SimpleCommandErrorException();
                }
            }
        }




        

        public class InterruptCommandException : Exception
        {

        }
    }
}
