using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Managnment_System_new
{
    public partial class Admin_Dashboard : Form
    {
        //Fields
        private Button currentButton;
        private Random radom;
        private int tempIndex;
        private Form activateForm;

        public Admin_Dashboard(Color color)
        {
            this.BackColor = color;
        }

        //constructor
        public Admin_Dashboard()
        { //Initializecomponet
            InitializeComponent();
            radom = new Random();
            btnclosechildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
        }
        [DllImport("user32,DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32,DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lparm);

        //Methods
        private Color SelectThemeColor()
        {
            //select themeclor
            int index = radom.Next(ThemeColor.colorList.Count);
            while (tempIndex == index)
            {
                index = radom.Next(ThemeColor.colorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.colorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnsender)
        {
            if (btnsender != null)
            {
                if (currentButton != (Button)btnsender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnsender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI Emoji", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    panelTittleBar.BackColor = color;
                    ThemeColor.primarycolor = color;
                    ThemeColor.secondarycolor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnclosechildForm.Visible = true;

                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in paneMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI Emoji", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnsender)
        {
            if (activateForm != null)
            
                activateForm.Close();

                ActivateButton(btnsender);
                activateForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                this.panelDesktoppanel.Controls.Add(childForm);
                this.panelDesktoppanel.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
                lblTittle.Text = childForm.Text;
            
        }

        private void btnschool_Click(object sender, EventArgs e)
        {
            //From school
            OpenChildForm(new Forms.FormSchool(), sender);
        }

        private void btnclass_Click(object sender, EventArgs e)
        {
            //From class
            OpenChildForm(new Forms.FormClass(), sender);
        }

        private void btnstudent_Click(object sender, EventArgs e)
        {
            //From student
            OpenChildForm(new Forms.FormStudent(), sender);
        }

        private void btnstaff_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormStaff(), sender);
        }

        private void btnsubject_Click(object sender, EventArgs e)
        {
            //From subject
            OpenChildForm(new Forms.FormSubject(), sender);
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            //From register
            OpenChildForm(new Forms.FormRegister(), sender);
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            try
            {
                //Take information to logout 
                DialogResult result = MessageBox.Show("Are you sure want to logout from this application !", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {

                    //Show the login form
                    this.Hide();
                    Login lg = new Login();
                    lg.Show();
                }
            }

            catch (Exception)//When thare is a error, this used to display that error
            {
                throw;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnclosechildForm_Click_1(object sender, EventArgs e)
        {
            if (activateForm != null)
                activateForm.Close();
            Reset();
        }
        private void Reset()
        {
            // Reset
            DisableButton();
            lblTittle.Text = "HOME";
            panelTittleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnclosechildForm.Visible = false;
        }

        private void panelDesktoppanel_Paint(object sender, PaintEventArgs e)
        {
            //start Time
            timer1.Start();
            lbltime.Text = DateTime.Now.ToLongTimeString();
            lbldate.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
    }

