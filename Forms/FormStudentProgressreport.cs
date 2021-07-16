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

    public partial class FormStudentProgressreport : Form
    {

        public FormStudentProgressreport()
        {
            InitializeComponent();
        }

        //Initializing Database connection
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter Sqlda = new SqlDataAdapter();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O305795\SQLEXPRESS;Initial Catalog=School_Managnment_System;Integrated Security=True");


        private void studentProgressBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentProgressBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.school_Managnment_SystemDataSet);

        }

        private void FormStudentProgressreport_Load(object sender, EventArgs e)
        {
            LoadTheme();
            // TODO: This line of code loads data into the 'school_Managnment_SystemDataSet.StudentProgress' table. You can move, or remove it, as needed.
            this.studentProgressTableAdapter.Fill(this.school_Managnment_SystemDataSet.StudentProgress);

           
            try
            {
                cmbsid.Items.Clear();
                String seleque = "SELECT studentno FROM StudentProgress";
                con.Open();
                Sqlda = new SqlDataAdapter(seleque, con);
                DataTable studentno = new DataTable();
                Sqlda.Fill(studentno);




                cmbsid.Items.Add("---SELECT---");
                foreach (DataRow row in studentno.Rows)
                {
                    cmbsid.Items.Add(row["studentno"]);
                }
                cmbsid.SelectedIndex = 0;



                con.Close();



            }
            catch (Exception ex)//When thare is a error, this used to display that error
            {
                MessageBox.Show("Error While Search..." + Environment.NewLine + ex);
            }

        }
        private void LoadTheme()
        {
            //button clour
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
            result = MessageBox.Show("confirm if you want exit?", "print students Records",
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

        private void btnprevious_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentProgressBindingSource.MovePrevious();
            }

            catch (Exception)//When thare is a error, this used to display that error
            {
                MessageBox.Show("Error, check your system");//Show the exception message
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentProgressBindingSource.MoveNext();
            }

            catch (Exception ex)//When thare is a error, this used to display that error
            {
                MessageBox.Show(ex.Message);//Show the exception message
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
           
            try
            {
                printPreviewDialog1.ShowDialog();
            }

            catch (Exception)//When thare is a error, this used to display that error
            {
                MessageBox.Show("Error, check your system");//Show the exception message
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
            try
            {
                e.Graphics.DrawString(rtReceipt.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, 0));
            }

            catch (Exception)//When thare is a error, this used to display that error
            {
                MessageBox.Show("Error, check your system");//Show the exception message
            }
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                rtReceipt.Clear();
                rtReceipt.AppendText("\t" + "OMP INTERNATIONAL SCHOL" + "\n");
                rtReceipt.AppendText("................................................" + "\n");
                rtReceipt.AppendText("Student No" +"\t" +"\t"+cmbsid.Text+ "\n");
                rtReceipt.AppendText("Student Name" + "\t" + "\t" +  txtsname.Text + "\n");
                rtReceipt.AppendText("Exam Role No" + "\t" + "\t"   +txtexrno.Text + "\n");
                rtReceipt.AppendText("Exam Year" + "\t" + "\t"  +  txteyear.Text+ "\n");
                rtReceipt.AppendText("Exam Type" + "\t" + "\t"  + txtetyp.Text + "\n");
                rtReceipt.AppendText("Sinhala" + "\t" + "\t" + "\t"  +  txtsin.Text+ "\n");
                rtReceipt.AppendText("Maths" + "\t" + "\t" + "\t"  +    txtmaths.Text + "\n");
                rtReceipt.AppendText("Buddhism" + "\t" + "\t" + "\t" + txtbuddhism.Text + "\n");
                rtReceipt.AppendText("History" + "\t" + "\t" + "\t"  + txthistory.Text + "\n");
                rtReceipt.AppendText("English" + "\t" + "\t" + "\t" +  txtenglish.Text + "\n");
                rtReceipt.AppendText("Science" + "\t" + "\t" + "\t"  + txtscience.Text + "\n");
                rtReceipt.AppendText("Geography" + "\t" + "\t" + txtgeography.Text + "\n");
                rtReceipt.AppendText("English Literary" + "\t" + "\t" + txtenglishliterary.Text + "\n");
                rtReceipt.AppendText("ICT" + "\t" + "\t" + "\t"+ txtict.Text + "\n");
                rtReceipt.AppendText("Total Score" + "\t" + "\t"  + txttotalscore.Text + "\n");
                rtReceipt.AppendText("Average" + "\t" + "\t"  + txtaverage.Text+ "\n");

                rtReceipt.AppendText("................................................" + "\n");
                rtReceipt.AppendText("\t" + "\t" + "complete");

            }

            catch (Exception)//When thare is a error, this used to display that error
            {
                MessageBox.Show("Error, check your system");//Show the exception message
            }
        }

        

        private void btnclear_Click(object sender, EventArgs e)
        {
            //Clear the entered data
            cmbsid.Text = "--SELECT--";
            txtsname.Clear();
            txtexrno.Clear();
            txteyear.ResetText();
            txtetyp.ResetText();
            txtsin.Clear();
            txtmaths.Clear();
            txtbuddhism.Clear();
            txthistory.Clear();
            txtenglish.Clear();
            txtscience.Clear();
            txtgeography.Clear();
            txtenglishliterary.Clear();
            txtict.Clear();
            txttotalscore.Clear();
            txtaverage.Clear();
           
        }

        private void studentProgressDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //click the studentProgressDataGridView cell
            if (studentProgressDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                

            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void studentProgressDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbsid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbsid.SelectedIndex > 0)
                {
                    String studentno = cmbsid.Text;
                    String setdata = "SELECT * FROM StudentProgress WHERE studentno='" + cmbsid.Text + "'";
                    con.Open();
                    cmd = new SqlCommand(setdata, con);
                    SqlDataReader R = cmd.ExecuteReader();


                    while (R.Read())
                    {
                        txtsname.Text = R.GetValue(1).ToString();
                        txtexrno.Text = R.GetValue(2).ToString();
                        txteyear.Text = R.GetValue(3).ToString();
                        txtetyp.Text = R.GetValue(4).ToString();
                        txtsin.Text = R.GetValue(5).ToString();
                        txtmaths.Text = R.GetValue(6).ToString();
                        txtbuddhism.Text = R.GetValue(7).ToString();
                        txthistory.Text = R.GetValue(8).ToString();
                        txtenglish.Text = R.GetValue(9).ToString();
                        txtscience.Text = R.GetValue(10).ToString();
                        txtgeography.Text = R.GetValue(11).ToString();
                        txtenglishliterary.Text = R.GetValue(12).ToString();
                        txtict.Text = R.GetValue(13).ToString();
                        txttotalscore.Text = R.GetValue(14).ToString();
                        txtaverage.Text = R.GetValue(15).ToString();
                        


                    }
                    con.Close();

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Select...." + ex);
            }
            
        }
    }
    
    }

