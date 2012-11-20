using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSort
{
    /// <summary>
    /// 命令的基类
    /// </summary>
    abstract public class BaseCommand : StudentSort.ICommand
    {
        protected const string _exit = "exit";

        protected List<string> _helpMessage;

        /// <summary>
        /// 执行命令
        /// </summary>
        public Object ExecuteCommand()
        {
           //显示提示信息
            ShowAllHelpMessage();
            try
            {
                string str = ReadLine();
                return Execute(str);
            }
            //如果执行命令出错，从新执行命令
            catch (CommandErrorException ce)
            {
                Console.WriteLine(ce.Message);
                return ExecuteCommand();
            }
        }



        private string ReadLine()
        {
            string str = string.Empty;
            while (true)
            {

                var k = Console.ReadKey(true);
                
                //如果用户按了Esc键，打断本命令的执行
                if (k.Key == ConsoleKey.Escape)
                    throw new InterruptCommandException();

                if (k.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }

                str += k.KeyChar;
                Console.Write(k.KeyChar);
            }
            
            if (str == _exit)
                throw new ExitException();

            return str;

        }

        /// <summary>
        /// 执行命令
        /// </summary>
        protected abstract Object Execute(string str);

        private void ShowAllHelpMessage()
        {
            foreach (var m in _helpMessage)
            {
                Console.WriteLine(m);
            }
        }

        public class ExitException : Exception
        {
        }

        public class InterruptCommandException : Exception
        {
            
        }


        public class CommandErrorException : Exception
        {

            public CommandErrorException(string message):base(message)
            {
            }
        }


    }
}
