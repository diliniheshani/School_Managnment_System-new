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
    public partial class FormSubject : Form
    {
        public FormSubject()
        {
            InitializeComponent();
        }
        //Initializing Database connection
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter Sqlda = new SqlDataAdapter();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O305795\SQLEXPRESS;Initial Catalog=School_Managnment_System;Integrated Security=True");


        private void FormSubject_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
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

                con.Open();
                // label3.Text = "Connection Successfull!";

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Subject";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            try
            {
                //open the connection
                con.Open();
                //SQL DataAdapter
                SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO Subject (subjectno,subjectname,teachername,teacherlanguage,noofperiod) VALUES ('" + txtsubjectno.Text + "','" + cmbsubjectname.Text + "','" + txtteachername.Text + "','" + txtteacherlanguage.Text + "','" + nudnoofperiod.Value + "')", con);
                int v = sda.SelectCommand.ExecuteNonQuery();
                con.Close();//close the connection
                            //Sucessfull Message after the execution
                MessageBox.Show(" Data Saved Suceesfully !");
                loadtable();
            }
            catch (Exception)//When thare is a error, this used to display that error
            {
                MessageBox.Show("Error while saved a record!");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                //open the connection
                con.Open();
                //SQL DataAdapter
                SqlDataAdapter sda = new SqlDataAdapter("UPDATE Subject SET subjectno = '" + txtsubjectno.Text + "', subjectname = '" + cmbsubjectname.Text + "', teachername = '" + txtteachername.Text + "', teacherlanguage = '" + txtteacherlanguage.Text + "', noofperiod = '" + nudnoofperiod.Value + "' WHERE subjectno = '" + txtsubjectno.Text + "'", con);
                int v = sda.SelectCommand.ExecuteNonQuery();
                con.Close();//close the connection
                            //Sucessfull Message after the execution
                MessageBox.Show(" Record Updated Suceesfully !");
                loadtable();
            }
            catch (Exception)//When thare is a error, this used to display that error
            {
                MessageBox.Show("Error while updated a record!");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                //open the connection
                con.Open();
                //SQL DataAdapter
                SqlDataAdapter sda = new SqlDataAdapter("DELETE FROM Subject WHERE subjectno = '" + txtsubjectno.Text + "'", con);
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
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Subject", con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            con.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //Clear the entered data
            txtsubjectno.Clear();
            cmbsubjectname.ResetText();
            txtteachername.Clear();
            txtteacherlanguage.Clear();
            nudnoofperiod.ResetText();
        }
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtsubjectno.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            cmbsubjectname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtteachername.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtteacherlanguage.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            nudnoofperiod.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[5].ToString());

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                txtsubjectno.Text = dataGridView1.Rows[e.RowIndex].Cells["subjectno"].FormattedValue.ToString();
                cmbsubjectname.Text = dataGridView1.Rows[e.RowIndex].Cells["subjectname"].FormattedValue.ToString();
                txtteachername.Text = dataGridView1.Rows[e.RowIndex].Cells["teachername"].FormattedValue.ToString();
                txtteacherlanguage.Text = dataGridView1.Rows[e.RowIndex].Cells["teacherlanguage"].FormattedValue.ToString();
                nudnoofperiod.Value = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["noofperiod"].FormattedValue.ToString());

            }
        }
    }
}
