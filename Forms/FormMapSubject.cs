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
    public partial class FormMapSubject : Form
    {
       
        public FormMapSubject()
        {
            InitializeComponent();
        }
        //Initializing Database connection
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O305795\SQLEXPRESS;Initial Catalog=School_Managnment_System;Integrated Security=True");



        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {

                //open the connection
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Map_Subject values ('" + cmbSubjectNo.Text+ "','" + cmbSubjectName.Text + "','" + cmbGrade.Text + "','" + cmbSection.Text + "','" + txtTeacher.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();//close the connection
                cmbSubjectNo.Text = "";
                cmbSubjectName.Text = "";
                cmbGrade.Text = "";
                cmbSection.Text = "";
                txtTeacher.Text = "";
                fill_lstOutput();
                //Sucessfull Message after the execution
                MessageBox.Show(" Data Added Suceesfully !");

            }
            catch (Exception)//When thare is a error, this used to display that error
            {
                MessageBox.Show("Error while data adding!"); //Show the exception message

            }


        }

        private void FormMapsubject_Load(object sender, EventArgs e)
        {
            fill_lstOutput();
            LoadTheme();///loadtheme
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
            result = MessageBox.Show("Confirm if you exit ", "Exit",
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

        private void btnclear_Click(object sender, EventArgs e)
        {
            //Clear the entered data
            cmbSubjectNo.Text = "--SELECT--";
            cmbSubjectName.Text = "--SELECT--";
            cmbGrade.Text = "--SELECT--";
            cmbSection.Text = "--SELECT--";
            txtTeacher.Clear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                //open the connection
                con.Open();
                //SQL DataAdapter
                SqlDataAdapter sda = new SqlDataAdapter("UPDATE Map_Subject SET subjectno = '" + cmbSubjectNo.Text + "', subjectname = '" + cmbSubjectName.Text + "', grade = '" + cmbGrade.Text + "', section = '" + cmbSection.Text + "', teacher = '" + txtTeacher.Text + "' WHERE subjectname = '" + cmbSubjectName.Text+ "'", con);
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {

                //open the connection
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Map_Subject where subjectname = '" + cmbSubjectName.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();//close the connection
                cmbSubjectNo.Text= "";
                cmbSubjectName.Text = "";
                cmbGrade.Text= "";
                cmbSection.Text = "";
                txtTeacher.Text= "";
                fill_lstOutput();
                //Sucessfull Message after the execution
                MessageBox.Show(" Data Deleted Suceesfully !");

            }
            catch (Exception)//When thare is a error, this used to display that error
            {
                MessageBox.Show("Error while data Deleting!"); //Show the exception message

            }
        }

        private void lstOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lsouput select
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Map_Subject ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmbSubjectNo.Text = dr["subjectno"].ToString();
                cmbSubjectName.Text = dr["subjectname"].ToString();
                cmbGrade.Text= dr["grade"].ToString();
                cmbSection.Text = dr["section"].ToString();
                txtTeacher.Text= dr["teacher"].ToString();
            }
            con.Close();
        }
        public void fill_lstOutput()
        {
            try
            {
                lstOutput.Items.Clear();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select subjectname from Map_Subject";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();//datatable
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    lstOutput.Items.Add(dr["subjectname"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)//When thare is a error, this used to display that error
            {
                MessageBox.Show("Error" + ex);//Show the exception message
            }
        }
    }
}
