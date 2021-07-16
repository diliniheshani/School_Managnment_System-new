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
    public partial class FormClass : Form
    {
        public FormClass()
        {
            InitializeComponent();
        }
        //Initializing Database connection
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter Sqlda = new SqlDataAdapter();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O305795\SQLEXPRESS;Initial Catalog=School_Managnment_System;Integrated Security=True");


        private void FormClass_Load(object sender, EventArgs e)
        {
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
            loadtable();
        }
        private void loadtable()
        {
            try
            {
                //connection open
                con.Open();
                // label3.Text = "Connection Successfull!";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Class";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                //connection close
                con.Close();
            }
            catch (Exception ex)//When thare is a error, this used to display that error
            {
                MessageBox.Show("Error" + ex);//Show the exception message
            }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {

                //open the connection
                con.Open();
                //SQL DataAdapter
                SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO Class (name,section,teacherincharge,accistantteacherincharge,studentcount) VALUES ('" + txtname.Text + "','" + txtsection.Text + "','" + txtteacherincharge.Text + "','" + txtaccistantteacherincharge.Text + "','" + nmustudentcount.Value + "')", con);
                int v = sda.SelectCommand.ExecuteNonQuery();
                con.Close();//close the connection
                            //Sucessfull Message after the execution
                MessageBox.Show(" Data Saved Suceesfully !");
                loadtable();
            }
            catch (Exception)//When thare is a error, this used to display that error
            {
                MessageBox.Show("Error while data adding!"); //Show the exception message

            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                //open the connection
                con.Open();
                //SQL DataAdapter
                SqlDataAdapter sda = new SqlDataAdapter("UPDATE Class SET name = '" + txtname.Text + "', section = '" + txtsection.Text + "', teacherincharge = '" + txtteacherincharge.Text + "', accistantteacherincharge = '" + txtaccistantteacherincharge.Text + "', studentcount = '" + nmustudentcount.Value + "' WHERE name = '" + txtname.Text + "'", con);
                int v = sda.SelectCommand.ExecuteNonQuery();
                con.Close();//close the connection
                //Sucessfull Message after the execution
                MessageBox.Show(" Record Updated Suceesfully !");
                loadtable();
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
                //SQL DataAdapter
                SqlDataAdapter sda = new SqlDataAdapter("DELETE FROM Class WHERE name = '" + txtname.Text + "'", con);
                int v = sda.SelectCommand.ExecuteNonQuery();
                con.Close();//close the connection
                            //Sucessfull Message after the execution
                MessageBox.Show(" Record Deleted Suceesfully !");
                loadtable();
            }
            catch (Exception)//When thare is a error, this used to display that error
            {
                MessageBox.Show("Error while Deleting a record!");
            }
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            //datagridview check
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Class", con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            con.Close();
        }
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtsection.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtteacherincharge.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtaccistantteacherincharge.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            nmustudentcount.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[5].ToString());

        }

        private void btnreset_Click(object sender, EventArgs e)
        {

            //Clear the entered data
            txtname.Clear();
            txtsection.Clear();
            txtteacherincharge.Clear();
            txtaccistantteacherincharge.Clear();
            nmustudentcount.ResetText();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridview cell click
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                txtname.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
                txtsection.Text = dataGridView1.Rows[e.RowIndex].Cells["section"].FormattedValue.ToString();
                txtteacherincharge.Text = dataGridView1.Rows[e.RowIndex].Cells["teacherincharge"].FormattedValue.ToString();
                txtaccistantteacherincharge.Text = dataGridView1.Rows[e.RowIndex].Cells["accistantteacherincharge"].FormattedValue.ToString();
                nmustudentcount.Value = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["studentcount"].FormattedValue.ToString());

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
