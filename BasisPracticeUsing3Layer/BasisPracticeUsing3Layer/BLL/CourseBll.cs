using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using BasisPracticeUsing3Layer.DLL.DAO;
using BasisPracticeUsing3Layer.DLL.gateway;

namespace BasisPracticeUsing3Layer.BLL
{
    class CourseBll
    {
        CourseGateway aCourseGateway = new CourseGateway();

        public string SaveCourse(Course aCourse)
        {
            return aCourseGateway.Save(aCourse);
        }

        public List<Course> getCourseName(Course aCourse)
        {
            return aCourseGateway.getCourseName(aCourse);
        } 

    }
}
