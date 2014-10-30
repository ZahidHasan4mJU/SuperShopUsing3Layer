﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasisPracticeUsing3Layer
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void courseUIButton_Click(object sender, EventArgs e)
        {
            CourseUI aCourseUi = new CourseUI();
            aCourseUi.ShowDialog();
        }

        private void studentInfoButton_Click(object sender, EventArgs e)
        {
            StudentUI aStudentUi = new StudentUI();
            aStudentUi.ShowDialog();

        }

        private void enrollButton_Click(object sender, EventArgs e)
        {
            EnrollmentUI aEnrollmentUi = new EnrollmentUI();
            aEnrollmentUi.ShowDialog();
        }
    }
}
