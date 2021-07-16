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

using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;


namespace School_Managnment_System_new.Forms
{
    public partial class FormMarks : Form
    {
        public FormMarks()
        {
            InitializeComponent();
        }
        //Initializing Database connection
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter Sqlda = new SqlDataAdapter();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O305795\SQLEXPRESS;Initial Catalog=School_Managnment_System;Integrated Security=True");

        private void FormMarks_Load(object sender, EventArgs e)
        {
            LoadTheme();

           
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
            loadtable();

        }
        private void loadtable()
        {
            try
            {

                con.Open();
                // label3.Text = "Connection Successfull!";

                SqlCommand cmd = con.CreateCommand();//sql command
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Mark";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

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
                SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO Mark (studentno,studentname,examroleno,examyear,examtype,sinhala,maths,buddhism,history,english,science,geography,englishliterary,ict,totalscore,average,rank) VALUES ('" + txtstudentno.Text + "','" + txtstudentname.Text + "','" + txtexamroleno.Text + "','" + cmbexamyear.Text + "','" + cmbexamtype.Text + "','" + txtsinhala.Text + "','" + txtmaths.Text + "','" + txtbuddhism.Text + "','" + txthistory.Text + "','" + txtenglish.Text + "','" + txtscience.Text + "','" + txtgeography.Text + "','" + txtenglishliterary.Text + "','" + txtict.Text + "','" + txttotalscore.Text + "','" + txtaverage.Text + "','" + txtrank.Text + "')", con);
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
                SqlDataAdapter sda = new SqlDataAdapter("UPDATE Mark SET studentno = '" + txtstudentno.Text + "',studentname = '" + txtstudentname.Text + "', examroleno= '" + txtexamroleno.Text + "', examyear = '" + cmbexamyear.Text + "',  examtype = '" + cmbexamtype.Text + "', sinhala = '" + txtsinhala.Text + "', maths = '" + txtmaths.Text + "', buddhism = '" + txtbuddhism.Text + "',  history = '" + txthistory.Text + "', english = '" + txtenglish.Text + "', science = '" + txtscience.Text + "', geography = '" + txtgeography.Text + "', englishliterary = '" + txtenglishliterary.Text + "', ict = '" + txtict.Text + "',totalscore = '" + txttotalscore.Text + "',average = '" + txtaverage.Text + "',rank = '" + txtrank.Text + "' WHERE examroleno = '" + txtexamroleno.Text + "'", con);
                int v = sda.SelectCommand.ExecuteNonQuery();//Execute the code
                con.Close();//close the connection
                            //Sucessfull Message after the execution
                MessageBox.Show(" Record Updated Suceesfully !");
                loadtable();
            }
            catch (Exception)//When thare is a error, this used to display that error
            {
                MessageBox.Show("Error while data updating!"); //Show the exception message

            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //Clear the entered data
            txtstudentno.Clear();
            txtstudentname.Clear();
            txtexamroleno.Clear();
            cmbexamyear.ResetText();
            cmbexamtype.ResetText();
            txtsinhala.Clear();
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
            txtrank.Clear();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            // enter the calculate buuton, afater the disapay data
            int a = Convert.ToInt32(txtsinhala.Text);
            int b = Convert.ToInt32(txtmaths.Text);
            int c = Convert.ToInt32(txtbuddhism.Text);
            int k = Convert.ToInt32(txthistory.Text);
            int f = Convert.ToInt32(txtenglish.Text);
            int g = Convert.ToInt32(txtscience.Text);
            int h = Convert.ToInt32(txtgeography.Text);
            int i = Convert.ToInt32(txtenglishliterary.Text);
            int j = Convert.ToInt32(txtict.Text);
            int p = a + b + c + k + f + g + h + i + j;
            double s = Convert.ToDouble(p) / 9.0;
            txttotalscore.Text = Convert.ToString(p);
            txtaverage.Text = Convert.ToString(s);
        }

        private void btnexporttoexcel_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misvalue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misvalue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;

            for (i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dataGridView1[j, i];
                    xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }
            //save path
            xlWorkBook.SaveAs("E:\\export\\studentmark.xls", Excel.XlFileFormat.xlWorkbookNormal, misvalue, misvalue, misvalue, misvalue, Excel.XlSaveAsAccessMode.xlExclusive, misvalue, misvalue, misvalue, misvalue, misvalue);

            xlWorkBook.Close(true, misvalue, misvalue);
            xlApp.Quit();

            releaseobject(xlWorkSheet);
            releaseobject(xlWorkBook);
            releaseobject(xlApp);

            //display the Meassgae
            MessageBox.Show("Excel file created,you can find the file on E:\\export\\studentmark.xls");

        }

        private void releaseobject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)//When thare is a error, this used to display that error
            {
                obj = null;
                MessageBox.Show("Exception occured while releasing object" + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                con.Open();
                // label3.Text = "Connection Successfull!";



                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                string examroleno = txttypetheexamrolleno.Text;
                cmd.CommandText = "select * from Mark where examroleno like '%" + examroleno + "%' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;


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
            //click the datagridview cell
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                txtstudentno.Text = dataGridView1.Rows[e.RowIndex].Cells["studentno"].FormattedValue.ToString();
                txtstudentname.Text = dataGridView1.Rows[e.RowIndex].Cells["studentname"].FormattedValue.ToString();
                txtexamroleno.Text = dataGridView1.Rows[e.RowIndex].Cells["examroleno"].FormattedValue.ToString();
                cmbexamyear.Text = dataGridView1.Rows[e.RowIndex].Cells["examyear"].FormattedValue.ToString();
                cmbexamtype.Text = dataGridView1.Rows[e.RowIndex].Cells["examtype"].FormattedValue.ToString();
                txtsinhala.Text = dataGridView1.Rows[e.RowIndex].Cells["sinhala"].FormattedValue.ToString();
                txtmaths.Text = dataGridView1.Rows[e.RowIndex].Cells["maths"].FormattedValue.ToString();
                txtbuddhism.Text = dataGridView1.Rows[e.RowIndex].Cells["buddhism"].FormattedValue.ToString();
                txthistory.Text = dataGridView1.Rows[e.RowIndex].Cells["history"].FormattedValue.ToString();
                txtenglish.Text = dataGridView1.Rows[e.RowIndex].Cells["english"].FormattedValue.ToString();
                txtscience.Text = dataGridView1.Rows[e.RowIndex].Cells["science"].FormattedValue.ToString();
                txtgeography.Text = dataGridView1.Rows[e.RowIndex].Cells["geography"].FormattedValue.ToString();
                txtenglishliterary.Text = dataGridView1.Rows[e.RowIndex].Cells["englishliterary"].FormattedValue.ToString();
                txtict.Text = dataGridView1.Rows[e.RowIndex].Cells["ict"].FormattedValue.ToString();
                txttotalscore.Text = dataGridView1.Rows[e.RowIndex].Cells["totalscore"].FormattedValue.ToString();
                txtaverage.Text = dataGridView1.Rows[e.RowIndex].Cells["average"].FormattedValue.ToString();
                txtrank.Text = dataGridView1.Rows[e.RowIndex].Cells["rank"].FormattedValue.ToString();

            }
        }
    }
}
