using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasisPracticeUsing3Layer.BLL;
using BasisPracticeUsing3Layer.DLL.DAO;

namespace BasisPracticeUsing3Layer
{
    public partial class EnrollmentUI : Form
    {
        public EnrollmentUI()
        {
            InitializeComponent();
            List<Course> courses = new List<Course>();
            courses = aCourseBll.getCourseName(aCourse);

            foreach (Course course1 in courses)
            {
                courseNameComboBox.Items.Add(course1);
            }
            courseNameComboBox.DisplayMember = "Code";
        }
        CourseBll aCourseBll = new CourseBll();
        Course aCourse =  new Course();

        private void enrollButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
