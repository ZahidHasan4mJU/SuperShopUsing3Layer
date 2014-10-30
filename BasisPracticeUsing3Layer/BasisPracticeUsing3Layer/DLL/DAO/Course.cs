using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasisPracticeUsing3Layer.DLL.DAO
{
    class Course
    {
        public string Code { get; set; }
        public string CourseName { get; set; }
        public string CourseCredit { get; set; }

        public Course(string code, string name, string credit):this()
        {
            Code = code;
            CourseName = name;
            CourseCredit = credit;
        }

        public Course()
        {
            
        }
    }
}
