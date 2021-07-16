using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Managnment_System_new.Forms
{
    public partial class FormReports : Form
    {
        public FormReports()
        {
            InitializeComponent();
        }

        private void btnstudentprogress_Click(object sender, EventArgs e)
        {
            //Show the  FormStudentProgressreport Form
            FormStudentProgressreport fsp = new FormStudentProgressreport();
            fsp.Show();
        }

        private void btnstudentattendance_Click(object sender, EventArgs e)
        {
            // Show the FormStudentAttendence Form
            FormStudentAttendence fsa = new FormStudentAttendence();
            fsa.Show();
        }

        private void btnstaffattendence_Click(object sender, EventArgs e)
        {
            //Show the  FormStafftAttendence Form
            FormStaffAttendencereport fsar = new FormStaffAttendencereport();
            fsar.Show();
        }
    }
}
