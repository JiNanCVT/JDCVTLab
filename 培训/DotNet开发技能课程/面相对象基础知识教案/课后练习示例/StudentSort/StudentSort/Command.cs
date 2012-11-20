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
    abstract public class Command
    {
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
                return Execute();
            }
            //如果执行命令出错，从新执行命令
            catch (CommandErrorException ce)
            {
                Console.WriteLine(ce.Message);
                return ExecuteCommand();
            }
        }

        /// <summary>
        /// 执行命令
        /// </summary>
        protected virtual Object Execute()
        {
            throw new NotImplementedException();
        }

        private void ShowAllHelpMessage()
        {
            foreach (var m in _helpMessage)
            {
                Console.WriteLine(m);
            }
        }


        public class CommandErrorException : Exception
        {

            public CommandErrorException(string message):base(message)
            {
            }
        }


    }
}
