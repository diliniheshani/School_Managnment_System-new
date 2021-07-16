using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//To use sql server

namespace School_Managnment_System_new.Forms
{
    public partial class FormStudentAttendence : Form
    {
        public FormStudentAttendence()
        {
            InitializeComponent();
        }
        //Initializing Database connection
        string cs = (@"Data Source=DESKTOP-O305795\SQLEXPRESS;Initial Catalog=School_Managnment_System;Integrated Security=True");
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;

        private void txtstudentname_TextChanged(object sender, EventArgs e)
        {
            //txtstudentname TextChanged Event 
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Student_Attendences where studentname like '" + txtstudentname.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void FormStudentAttendence_Load(object sender, EventArgs e)
        {
            LoadTheme();
            //frmSearch Load Event
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Student_Attendences", con);
            dt = new DataTable();
            int v = adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void LoadTheme()
        {
            //color Button
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btns.BackColor = ThemeColor.primarycolor;
                    btns.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.secondarycolor;
                }
            }

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //Declare a variable for diaglogresult
            DialogResult result;
            //Apply if statemnet for dialogresult
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

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
