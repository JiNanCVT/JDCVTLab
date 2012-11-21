using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSort
{
    public static class Doc
    {
        static List<Student> _sudents = new List<Student>();

        public static List<Student> Sudents
        {
            get { return Doc._sudents; }
            set { Doc._sudents = value; }
        }

    }
}
