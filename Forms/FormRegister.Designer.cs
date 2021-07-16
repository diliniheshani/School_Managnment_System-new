
namespace School_Managnment_System_new.Forms
{
    partial class FormRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpdateofregister = new System.Windows.Forms.DateTimePicker();
            this.dtpdateofbirth = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbstates = new System.Windows.Forms.ComboBox();
            this.cmbclass = new System.Windows.Forms.ComboBox();
            this.cmbreligion = new System.Windows.Forms.ComboBox();
            this.cmbcountry = new System.Windows.Forms.ComboBox();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtmobilenumber = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtmothername = new System.Windows.Forms.TextBox();
            this.txtfathername = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.lbldateofregister = new System.Windows.Forms.Label();
            this.lbldateofbirth = new System.Windows.Forms.Label();
            this.lblstates = new System.Windows.Forms.Label();
            this.lblclass = new System.Windows.Forms.Label();
            this.lblreligion = new System.Windows.Forms.Label();
            this.lblcountry = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblmobilenumber = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblmothername = new System.Windows.Forms.Label();
            this.lblfathername = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnbrowser = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dtpdateofregister);
            this.panel1.Controls.Add(this.dtpdateofbirth);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cmbstates);
            this.panel1.Controls.Add(this.cmbclass);
            this.panel1.Controls.Add(this.cmbreligion);
            this.panel1.Controls.Add(this.cmbcountry);
            this.panel1.Controls.Add(this.cmbgender);
            this.panel1.Controls.Add(this.txtaddress);
            this.panel1.Controls.Add(this.txtmobilenumber);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.txtmothername);
            this.panel1.Controls.Add(this.txtfathername);
            this.panel1.Controls.Add(this.txtlastname);
            this.panel1.Controls.Add(this.txtfirstname);
            this.panel1.Controls.Add(this.lbldateofregister);
            this.panel1.Controls.Add(this.lbldateofbirth);
            this.panel1.Controls.Add(this.lblstates);
            this.panel1.Controls.Add(this.lblclass);
            this.panel1.Controls.Add(this.lblreligion);
            this.panel1.Controls.Add(this.lblcountry);
            this.panel1.Controls.Add(this.lblgender);
            this.panel1.Controls.Add(this.lbladdress);
            this.panel1.Controls.Add(this.lblmobilenumber);
            this.panel1.Controls.Add(this.lblemail);
            this.panel1.Controls.Add(this.lblmothername);
            this.panel1.Controls.Add(this.lblfathername);
            this.panel1.Controls.Add(this.lbllastname);
            this.panel1.Controls.Add(this.lblfirstname);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 444);
            this.panel1.TabIndex = 0;
            // 
            // dtpdateofregister
            // 
            this.dtpdateofregister.Location = new System.Drawing.Point(635, 246);
            this.dtpdateofregister.Name = "dtpdateofregister";
            this.dtpdateofregister.Size = new System.Drawing.Size(210, 20);
            this.dtpdateofregister.TabIndex = 31;
            // 
            // dtpdateofbirth
            // 
            this.dtpdateofbirth.Location = new System.Drawing.Point(635, 203);
            this.dtpdateofbirth.Name = "dtpdateofbirth";
            this.dtpdateofbirth.Size = new System.Drawing.Size(210, 20);
            this.dtpdateofbirth.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(635, 290);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // cmbstates
            // 
            this.cmbstates.FormattingEnabled = true;
            this.cmbstates.Items.AddRange(new object[] {
            "Sinhala",
            "Tamil",
            "Muslim"});
            this.cmbstates.Location = new System.Drawing.Point(635, 160);
            this.cmbstates.Name = "cmbstates";
            this.cmbstates.Size = new System.Drawing.Size(210, 21);
            this.cmbstates.TabIndex = 28;
            // 
            // cmbclass
            // 
            this.cmbclass.FormattingEnabled = true;
            this.cmbclass.Items.AddRange(new object[] {
            "1 A",
            "1 B",
            "1 C",
            "2 A",
            "2 B",
            "2 C",
            "3 A",
            "3 B",
            "3 C",
            "4 A",
            "4 B",
            "4 C",
            "5 A",
            "5 B",
            "5 C",
            "6 A",
            "6 B",
            "6 C",
            "7 A",
            "7 B",
            "7 C",
            "8 A",
            "8 B",
            "8 C",
            "9 A",
            "9 B",
            "9 C",
            "10 A",
            "10 B",
            "10 C",
            "11 A",
            "11 B",
            "11 C"});
            this.cmbclass.Location = new System.Drawing.Point(635, 118);
            this.cmbclass.Name = "cmbclass";
            this.cmbclass.Size = new System.Drawing.Size(210, 21);
            this.cmbclass.TabIndex = 27;
            // 
            // cmbreligion
            // 
            this.cmbreligion.FormattingEnabled = true;
            this.cmbreligion.Items.AddRange(new object[] {
            "Budhism",
            "Islam",
            "Christianity",
            "Hinduism",
            "Judaism"});
            this.cmbreligion.Location = new System.Drawing.Point(635, 74);
            this.cmbreligion.Name = "cmbreligion";
            this.cmbreligion.Size = new System.Drawing.Size(210, 21);
            this.cmbreligion.TabIndex = 26;
            // 
            // cmbcountry
            // 
            this.cmbcountry.FormattingEnabled = true;
            this.cmbcountry.Items.AddRange(new object[] {
            "Australiya",
            "china",
            "Japan",
            "Srilanka",
            "Malayasiya",
            "Canada"});
            this.cmbcountry.Location = new System.Drawing.Point(635, 28);
            this.cmbcountry.Name = "cmbcountry";
            this.cmbcountry.Size = new System.Drawing.Size(210, 21);
            this.cmbcountry.TabIndex = 25;
            // 
            // cmbgender
            // 
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cmbgender.Location = new System.Drawing.Point(196, 338);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(210, 21);
            this.cmbgender.TabIndex = 24;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(196, 293);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(210, 20);
            this.txtaddress.TabIndex = 23;
            // 
            // txtmobilenumber
            // 
            this.txtmobilenumber.Location = new System.Drawing.Point(196, 249);
            this.txtmobilenumber.Name = "txtmobilenumber";
            this.txtmobilenumber.Size = new System.Drawing.Size(210, 20);
            this.txtmobilenumber.TabIndex = 22;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(196, 204);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(210, 20);
            this.txtemail.TabIndex = 21;
            // 
            // txtmothername
            // 
            this.txtmothername.Location = new System.Drawing.Point(196, 161);
            this.txtmothername.Name = "txtmothername";
            this.txtmothername.Size = new System.Drawing.Size(210, 20);
            this.txtmothername.TabIndex = 20;
            // 
            // txtfathername
            // 
            this.txtfathername.Location = new System.Drawing.Point(196, 115);
            this.txtfathername.Name = "txtfathername";
            this.txtfathername.Size = new System.Drawing.Size(210, 20);
            this.txtfathername.TabIndex = 19;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(196, 71);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(210, 20);
            this.txtlastname.TabIndex = 18;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(196, 29);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(210, 20);
            this.txtfirstname.TabIndex = 17;
            // 
            // lbldateofregister
            // 
            this.lbldateofregister.AutoSize = true;
            this.lbldateofregister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldateofregister.Location = new System.Drawing.Point(455, 245);
            this.lbldateofregister.Name = "lbldateofregister";
            this.lbldateofregister.Size = new System.Drawing.Size(121, 21);
            this.lbldateofregister.TabIndex = 16;
            this.lbldateofregister.Text = "Date of Register";
            // 
            // lbldateofbirth
            // 
            this.lbldateofbirth.AutoSize = true;
            this.lbldateofbirth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldateofbirth.Location = new System.Drawing.Point(455, 201);
            this.lbldateofbirth.Name = "lbldateofbirth";
            this.lbldateofbirth.Size = new System.Drawing.Size(97, 21);
            this.lbldateofbirth.TabIndex = 15;
            this.lbldateofbirth.Text = "Date of Birth";
            // 
            // lblstates
            // 
            this.lblstates.AutoSize = true;
            this.lblstates.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstates.Location = new System.Drawing.Point(455, 158);
            this.lblstates.Name = "lblstates";
            this.lblstates.Size = new System.Drawing.Size(51, 21);
            this.lblstates.TabIndex = 14;
            this.lblstates.Text = "States";
            // 
            // lblclass
            // 
            this.lblclass.AutoSize = true;
            this.lblclass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclass.Location = new System.Drawing.Point(455, 115);
            this.lblclass.Name = "lblclass";
            this.lblclass.Size = new System.Drawing.Size(46, 21);
            this.lblclass.TabIndex = 13;
            this.lblclass.Text = "Class";
            // 
            // lblreligion
            // 
            this.lblreligion.AutoSize = true;
            this.lblreligion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreligion.Location = new System.Drawing.Point(455, 71);
            this.lblreligion.Name = "lblreligion";
            this.lblreligion.Size = new System.Drawing.Size(67, 21);
            this.lblreligion.TabIndex = 12;
            this.lblreligion.Text = "Religion";
            // 
            // lblcountry
            // 
            this.lblcountry.AutoSize = true;
            this.lblcountry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcountry.Location = new System.Drawing.Point(455, 29);
            this.lblcountry.Name = "lblcountry";
            this.lblcountry.Size = new System.Drawing.Size(66, 21);
            this.lblcountry.TabIndex = 11;
            this.lblcountry.Text = "Country";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(28, 338);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(61, 21);
            this.lblgender.TabIndex = 10;
            this.lblgender.Text = "Gender";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(28, 290);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(66, 21);
            this.lbladdress.TabIndex = 9;
            this.lbladdress.Text = "Address";
            // 
            // lblmobilenumber
            // 
            this.lblmobilenumber.AutoSize = true;
            this.lblmobilenumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmobilenumber.Location = new System.Drawing.Point(28, 246);
            this.lblmobilenumber.Name = "lblmobilenumber";
            this.lblmobilenumber.Size = new System.Drawing.Size(120, 21);
            this.lblmobilenumber.TabIndex = 8;
            this.lblmobilenumber.Text = "Mobile Number";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(28, 201);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(48, 21);
            this.lblemail.TabIndex = 7;
            this.lblemail.Text = "Email";
            // 
            // lblmothername
            // 
            this.lblmothername.AutoSize = true;
            this.lblmothername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmothername.Location = new System.Drawing.Point(28, 158);
            this.lblmothername.Name = "lblmothername";
            this.lblmothername.Size = new System.Drawing.Size(107, 21);
            this.lblmothername.TabIndex = 6;
            this.lblmothername.Text = "Mother Name";
            // 
            // lblfathername
            // 
            this.lblfathername.AutoSize = true;
            this.lblfathername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfathername.Location = new System.Drawing.Point(28, 115);
            this.lblfathername.Name = "lblfathername";
            this.lblfathername.Size = new System.Drawing.Size(99, 21);
            this.lblfathername.TabIndex = 5;
            this.lblfathername.Text = "Father Name";
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastname.Location = new System.Drawing.Point(28, 71);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(84, 21);
            this.lbllastname.TabIndex = 4;
            this.lbllastname.Text = "Last Name";
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.Location = new System.Drawing.Point(28, 29);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(86, 21);
            this.lblfirstname.TabIndex = 3;
            this.lblfirstname.Text = "First Name";
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(124, 480);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(95, 41);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(258, 480);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(95, 41);
            this.btnreset.TabIndex = 4;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnbrowser
            // 
            this.btnbrowser.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbrowser.Location = new System.Drawing.Point(385, 480);
            this.btnbrowser.Name = "btnbrowser";
            this.btnbrowser.Size = new System.Drawing.Size(95, 41);
            this.btnbrowser.TabIndex = 5;
            this.btnbrowser.Text = "Browse";
            this.btnbrowser.UseVisualStyleBackColor = true;
            this.btnbrowser.Click += new System.EventHandler(this.btnbrowser_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 550);
            this.Controls.Add(this.btnbrowser);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegister";
            this.Text = "NEW STUDENT REGISTER";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbldateofregister;
        private System.Windows.Forms.Label lbldateofbirth;
        private System.Windows.Forms.Label lblstates;
        private System.Windows.Forms.Label lblclass;
        private System.Windows.Forms.Label lblreligion;
        private System.Windows.Forms.Label lblcountry;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblmobilenumber;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblmothername;
        private System.Windows.Forms.Label lblfathername;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.ComboBox cmbstates;
        private System.Windows.Forms.ComboBox cmbclass;
        private System.Windows.Forms.ComboBox cmbreligion;
        private System.Windows.Forms.ComboBox cmbcountry;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtmobilenumber;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtmothername;
        private System.Windows.Forms.TextBox txtfathername;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.DateTimePicker dtpdateofregister;
        private System.Windows.Forms.DateTimePicker dtpdateofbirth;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnbrowser;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}