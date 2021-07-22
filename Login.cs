using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //To use sql server
using System.Windows.Forms;

namespace School_Managnment_System_new
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        //Initializing Database connection
        SqlDataAdapter sda = new SqlDataAdapter();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O305795\SQLEXPRESS;Initial Catalog=School_Managnment_System;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string Username = txtusername.Text;
            string Password = txtpassword.Text;

            if (Username == "Admin" && Password == "2468")
            {
                Admin_Dashboard ad = new Admin_Dashboard();
                ad.Show();
            }
            else if (Username == "Staff" && Password == "3692")
            {
                Staff_Dashboard ad = new Staff_Dashboard();
                ad.Show();
            }

            else
            {
                MessageBox.Show("Incorrect Username Or Password, Please Enter Valid Details!!", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //Declare a variable for dialogresult
            DialogResult result;
            //Apply if statement for check dialogresult and exit from the form
            result = MessageBox.Show("Do you want to Exit?", "Exit",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void checkpassword_CheckedChanged(object sender, EventArgs e)
        {
            //To show and hide password
            if (checkpassword.Checked == false)
            {
                txtpassword.PasswordChar = '*';
            }
            else
            {
                txtpassword.PasswordChar = default(char);
            }
        }
    }
}
