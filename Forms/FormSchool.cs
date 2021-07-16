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
    public partial class FormSchool : Form
    {
        public FormSchool()
        {
            InitializeComponent();
            LoadTheme();
        }
        //Initializing Database connection
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter Sqlda = new SqlDataAdapter();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O305795\SQLEXPRESS;Initial Catalog=School_Managnment_System;Integrated Security=True");


        private void FormSchool_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            //color Buuton
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {

                //open the connection
                con.Open();
                //SQL DataAdapter
                SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO School (schoolid,schoolname,teachercount,studentcount,minstaffcount,phonenumber,websitelink,email) VALUES ('" + txtschoolid.Text + "','" + txtschoolname.Text + "','" + nmuteachercount.Value + "','" + nmustudentcount.Value + "','" + nmuministaffcount.Value + "','" + txtphonenumber.Text + "','" + txtwebsitelink.Text + "','" + txtemail.Text + "')", con);
                int v = sda.SelectCommand.ExecuteNonQuery();
                con.Close();//close the connection
                            //Sucessfull Message after the execution
                MessageBox.Show(" Data Saved Suceesfully !");
            }
            catch (Exception)//When thare is a error, this used to display that error
            {
                MessageBox.Show("Error while saving a record!");//Show the exception message
            }
        }
           

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                //open the connection
                con.Open();
                //SQL DataAdapter
                SqlDataAdapter sda = new SqlDataAdapter("UPDATE School SET schoolid = '" + txtschoolid.Text + "', schoolname = '" + txtschoolname.Text + "', teachercount = '" + nmuteachercount.Value + "', studentcount = '" + nmustudentcount.Value + "', minstaffcount = '" + nmuministaffcount.Value + "', phonenumber = '" + txtphonenumber.Text + "', websitelink = '" + txtwebsitelink.Text + "', email = '" + txtemail.Text + "' WHERE schoolid = '" + txtschoolid.Text + "'", con);
                int v = sda.SelectCommand.ExecuteNonQuery();
                con.Close();//close the connection
                            //Sucessfull Message after the execution
                MessageBox.Show(" Record Updated Suceesfully !");
            }
            catch (Exception)//When thare is a error, this used to display that error
            {
                MessageBox.Show("Error while updating a record!");//Show the exception message
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            //Clear the entered data
            txtschoolid.Clear();
            txtschoolname.Clear();
            nmuteachercount.ResetText();
            nmustudentcount.ResetText();
            nmuministaffcount.ResetText();
            txtphonenumber.Clear();
            txtwebsitelink.Clear();
            txtemail.Clear();
           
        }
    }
}
