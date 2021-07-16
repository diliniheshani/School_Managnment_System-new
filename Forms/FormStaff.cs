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
    public partial class FormStaff : Form
    {
        public FormStaff()
        {
            InitializeComponent();
        }
        //Initializing Database connection
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter Sqlda = new SqlDataAdapter();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O305795\SQLEXPRESS;Initial Catalog=School_Managnment_System;Integrated Security=True");

        private void FormStaff_Load(object sender, EventArgs e)
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

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                //open the connection
                con.Open();
                //SQL DataAdapter
                SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO Staff (teacherid,firstname,lastname,birthdate,phonenumber,address,email,nic,post,gender) VALUES ('" + txtteacherid.Text + "','" + txtfirstname.Text + "','" + txtlastname.Text + "','" + Convert.ToDateTime(dtpbirthdate.Text) + "','" + txtphonenumber.Text + "','" + txtaddress.Text + "','" + txtemail.Text + "','" + txtnic.Text + "','" + cmbpost.Text + "','" + cmbgender.Text + "')", con);
                int v = sda.SelectCommand.ExecuteNonQuery();
                con.Close();//close the connection
                            //Sucessfull Message after the execution
                MessageBox.Show(" Data Saved Suceesfully !");
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
                SqlDataAdapter sda = new SqlDataAdapter("UPDATE Staff SET teacherid = '" + txtteacherid.Text + "',firstname = '" + txtfirstname.Text + "', lastname = '" + txtlastname.Text + "', birthdate = '" + Convert.ToDateTime(dtpbirthdate.Text) + "',  phonenumber = '" + txtphonenumber.Text + "', address = '" + txtaddress.Text + "', email = '" + txtemail.Text + "', nic = '" + txtnic.Text + "', post = '" + cmbpost.Text + "', gender = '" + cmbgender.Text + "' WHERE email = '" + txtemail.Text + "'", con);
                int v = sda.SelectCommand.ExecuteNonQuery();
                con.Close();//close the connection
                            //Sucessfull Message after the execution
                MessageBox.Show(" Record Updated Suceesfully !");
            }
            catch (Exception)//When thare is a error, this used to display that error
            {
                MessageBox.Show("Error while data updating!"); //Show the exception message

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                //open the connection
                con.Open();
                //SQL DataAdapter
                SqlDataAdapter sda = new SqlDataAdapter("DELETE FROM Staff WHERE email = '" + txtemail.Text + "'", con);
                int v = sda.SelectCommand.ExecuteNonQuery();
                con.Close();//close the connection
                            //Sucessfull Message after the execution
                MessageBox.Show(" Record Deleted Suceesfully !");
            }
            catch (Exception)//When thare is a error, this used to display that error
            {
                MessageBox.Show("Error while data deleting!"); //Show the exception message

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //open picture Box
            OpenFileDialog opf = new OpenFileDialog();
            PictureBox p = sender as PictureBox;
            if (p != null)
            {
                opf.Filter = "(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pbimage.Image = Image.FromFile(opf.FileName);

                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //Clear the entered data
            txtteacherid.Clear();
            txtfirstname.Clear();
            txtlastname.Clear();
            dtpbirthdate.ResetText();
            txtphonenumber.Clear();
            txtaddress.Clear();
            txtemail.Clear();
            txtnic.Clear();
            cmbpost.ResetText();
            cmbgender.ResetText();
            pbimage.Image = null;
            pbimage.Invalidate();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                con.Open();//connection open
                // label3.Text = "Connection Successfull!";



                SqlCommand cmd = con.CreateCommand();//sql command
                cmd.CommandType = CommandType.Text;
                string email = txttypetheemail.Text;
                cmd.CommandText = "select * from Staff where email like '%" + email + "%' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;


                //connection close
                con.Close();



                if (count == 0)
                {
                    MessageBox.Show("Record not found!");
                }
            }
            catch (Exception ex)//When thare is a error, this used to display that error
            {
                MessageBox.Show("Error" + ex);//Show the exception message
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridview cell
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                txtteacherid.Text = dataGridView1.Rows[e.RowIndex].Cells["teacherid"].FormattedValue.ToString();
                txtfirstname.Text = dataGridView1.Rows[e.RowIndex].Cells["firstname"].FormattedValue.ToString();
                txtlastname.Text = dataGridView1.Rows[e.RowIndex].Cells["lastname"].FormattedValue.ToString();
                dtpbirthdate.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["Birthdate"].FormattedValue.ToString());
                txtphonenumber.Text = dataGridView1.Rows[e.RowIndex].Cells["phonenumber"].FormattedValue.ToString();
                txtaddress.Text = dataGridView1.Rows[e.RowIndex].Cells["address"].FormattedValue.ToString();
                txtemail.Text = dataGridView1.Rows[e.RowIndex].Cells["email"].FormattedValue.ToString();
                txtnic.Text = dataGridView1.Rows[e.RowIndex].Cells["nic"].FormattedValue.ToString();
                cmbpost.Text = dataGridView1.Rows[e.RowIndex].Cells["post"].FormattedValue.ToString();
                cmbgender.Text = dataGridView1.Rows[e.RowIndex].Cells["gender"].FormattedValue.ToString();



            }
        }
    }
    }

