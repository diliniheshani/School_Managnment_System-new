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
    public partial class FormMapStudent : Form
    {
        public FormMapStudent()
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
                cmd.CommandText = "insert into Map_Student values ('" + txtstudentno.Text + "','" + txtstudentname.Text + "','" + cmbgrade.Text + "','" + cmbsection.Text + "','" + txtclassteacher.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();//close the connection
                txtstudentno.Text = "";
                txtstudentname.Text = "";
                cmbgrade.Text = "";
                cmbsection.Text = "";
                txtclassteacher.Text = "";
                fill_lstOutput();
                //Sucessfull Message after the execution
                MessageBox.Show(" Data Added Suceesfully !");

            }
            catch (Exception)//When thare is a error, this used to display that error
            {
                MessageBox.Show("Error while data adding!"); //Show the exception message

            }
        }
        public void fill_lstOutput()
        {
            try {
                lstOutput.Items.Clear();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select studentname from Map_Student";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    lstOutput.Items.Add(dr["studentname"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)//When thare is a error, this used to display that error
            {
                MessageBox.Show("Error" + ex);//Show the exception message
            }
        }

        private void FormMapStudent_Load(object sender, EventArgs e)
        {
            fill_lstOutput();
            LoadTheme();
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


        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {

                //open the connection
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Map_Student where studentname = '" + txtstudentname.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();//close the connection
                txtstudentno.Text = "";
                txtstudentname.Text = "";
                cmbgrade.Text = "";
                cmbsection.Text = "";
                txtclassteacher.Text = "";
                fill_lstOutput();
                //Sucessfull Message after the execution
                MessageBox.Show(" Data Deleted Suceesfully !");

            }
            catch (Exception)//When thare is a error, this used to display that error
            {
                MessageBox.Show("Error while data Deleting!"); //Show the exception message

            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                //open the connection
                con.Open();
                //SQL DataAdapter
                SqlDataAdapter sda = new SqlDataAdapter("UPDATE Map_Student SET studentno = '" + txtstudentno.Text + "', studentname = '" + txtstudentname.Text + "', grade = '" + cmbgrade.Text + "', section = '" + cmbsection.Text + "', classteacher = '" + txtclassteacher.Text + "' WHERE studentname = '" + txtstudentname.Text + "'", con);
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

        private void btnclear_Click(object sender, EventArgs e)
        {
            //Clear the entered data
            txtstudentno.Clear();
            txtstudentname.Clear();
            cmbgrade.Text = "--SELECT--";
            cmbsection.Text = "--SELECT--";
            txtclassteacher.Clear();

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

        private void lstOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Map_Student ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();//DataTable
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                //data rows
                    txtstudentno.Text = dr["studentno"].ToString();
                    txtstudentname.Text = dr["studentname"].ToString();
                    cmbgrade.Text = dr["grade"].ToString();
                    cmbsection.Text = dr["section"].ToString();
                    txtclassteacher.Text = dr["classteacher"].ToString();
                }
                con.Close();

            }
            } 
            }
        
    


    
    

