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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }
        //Initializing Database connection
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter Sqlda = new SqlDataAdapter();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O305795\SQLEXPRESS;Initial Catalog=School_Managnment_System;Integrated Security=True");


        private void FormRegister_Load(object sender, EventArgs e)
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                //open the connection
                con.Open();
                //SQL DataAdapter
                SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO Register (firstname,lastname,fathername,mothername,email,mobilenumber,address,gender,country,religion,class,states,dateofbirth,dateofregister) VALUES ('" + txtfirstname.Text + "','" + txtlastname.Text + "','" + txtfathername.Text + "','" + txtmothername.Text + "','" + txtemail.Text + "','" + txtmobilenumber.Text + "','" + txtaddress.Text + "','" + cmbgender.Text + "','" + cmbcountry.Text + "','" + cmbreligion.Text + "','" + cmbclass.Text + "','" + cmbstates.Text + "','" + Convert.ToDateTime(dtpdateofbirth.Text) + "','" + Convert.ToDateTime(dtpdateofregister.Text) + "')", con);
                int v = sda.SelectCommand.ExecuteNonQuery();
                con.Close();//close the connection
                            //Sucessfull Message after the execution
                MessageBox.Show(" Data Add Suceesfully !");
            }
            catch (Exception)//When thare is a error, this used to display that error
            {
                MessageBox.Show("Error while data adding!"); //Show the exception message

            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            //Clear the entered data
            txtfirstname.Clear();
            txtlastname.Clear();
            txtfathername.Clear();
            txtmothername.Clear();
            txtemail.Clear();
            txtmobilenumber.Clear();
            txtaddress.Clear();
            cmbgender.ResetText();
            cmbcountry.ResetText();
            cmbreligion.ResetText();
            cmbclass.ResetText();
            cmbstates.ResetText();
            dtpdateofbirth.ResetText();
            dtpdateofregister.ResetText();
            pictureBox1.Image = null;
            pictureBox1.Invalidate();
        }

        private void btnbrowser_Click(object sender, EventArgs e)
        {
            //open pictre box
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);

            }
        }
    }
}
