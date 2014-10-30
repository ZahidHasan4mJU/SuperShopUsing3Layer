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
    public partial class CourseUI : Form
    {
        public CourseUI()
        {
            InitializeComponent();
        }

        private Course aCourse;
        CourseBll aCourseBll = new CourseBll();

        private void courseSaveButton_Click(object sender, EventArgs e)
        {
            aCourse = new Course(courseCodeTextBox.Text, nameTextBox.Text, 
                                 courseCreditTextBox.Text);
            string msg = aCourseBll.SaveCourse(aCourse);
            MessageBox.Show(msg);
        }
    }
}
