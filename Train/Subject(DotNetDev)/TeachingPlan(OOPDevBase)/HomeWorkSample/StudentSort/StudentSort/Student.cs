using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSort
{
    /// <summary>
    /// 学生类
    /// </summary>
    public class Student:Person
    {
        private int _score;

        /// <summary>
        /// 分数
        /// </summary>
        public int Score
        {
            get { return _score; }
            set 
            {
                if (value < 0)
                {
                    throw new InvalidScoreException();
                }
                _score = value; 
            }
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        public Student()
        {
            _score = -1;
        }
        /// <summary>
        /// 注意base这种用法
        /// </summary>
        /// <param name="name"></param>
        /// <param name="score"></param>
        public Student(string name, int score):base(name)
        {
            Score = score;
        }

        public class InvalidScoreException : Exception { }
    }
}
