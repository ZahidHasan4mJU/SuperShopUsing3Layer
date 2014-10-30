using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasisPracticeUsing3Layer.DLL.DAO
{
    class Student
    {
        public string RegNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Student(string reg, string email, string address):this()
        {
            RegNo = reg;
            Email = email;
            Address = address;
        }

        public Student()
        {
            
        }
    }
}
