
namespace School_Managnment_System_new.Forms
{
    partial class FormStudent
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbgrade = new System.Windows.Forms.ComboBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtphonenumber = new System.Windows.Forms.TextBox();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.dtpbirthdate = new System.Windows.Forms.DateTimePicker();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.lblpicture = new System.Windows.Forms.Label();
            this.lblgrade = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lphonenumber = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblbirthdate = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lblstudentid = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txttypetheemail = new System.Windows.Forms.TextBox();
            this.lbltypetheemail = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cmbgrade);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.txtaddress);
            this.panel1.Controls.Add(this.txtphonenumber);
            this.panel1.Controls.Add(this.cmbgender);
            this.panel1.Controls.Add(this.dtpbirthdate);
            this.panel1.Controls.Add(this.txtlastname);
            this.panel1.Controls.Add(this.txtfirstname);
            this.panel1.Controls.Add(this.txtstudentid);
            this.panel1.Controls.Add(this.lblpicture);
            this.panel1.Controls.Add(this.lblgrade);
            this.panel1.Controls.Add(this.lblemail);
            this.panel1.Controls.Add(this.lbladdress);
            this.panel1.Controls.Add(this.lphonenumber);
            this.panel1.Controls.Add(this.lblgender);
            this.panel1.Controls.Add(this.lblbirthdate);
            this.panel1.Controls.Add(this.lbllastname);
            this.panel1.Controls.Add(this.lblfirstname);
            this.panel1.Controls.Add(this.lblstudentid);
            this.panel1.Location = new System.Drawing.Point(29, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 493);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(168, 365);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // cmbgrade
            // 
            this.cmbgrade.FormattingEnabled = true;
            this.cmbgrade.Items.AddRange(new object[] {
            "1 A",
            "1 B",
            "1C",
            "2 A",
            " 2 B",
            " 2 C",
            "3 A",
            " 3 B",
            " 3 C",
            " 4 A",
            " 4 B",
            " 4 C",
            " 5 A",
            " 5 B",
            "5 C",
            "6 A",
            " 6 B ",
            "6 C",
            " 7 A",
            " 7 B",
            "7 C",
            " 8 A",
            "8 B",
            "8 C",
            "9 A",
            "9 B",
            "9 C",
            "10 A",
            "10 B",
            " 10 C",
            "11 A",
            "11 B",
            "11 C"});
            this.cmbgrade.Location = new System.Drawing.Point(168, 325);
            this.cmbgrade.Name = "cmbgrade";
            this.cmbgrade.Size = new System.Drawing.Size(210, 21);
            this.cmbgrade.TabIndex = 26;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(168, 289);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(210, 20);
            this.txtemail.TabIndex = 25;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(168, 252);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(210, 20);
            this.txtaddress.TabIndex = 24;
            // 
            // txtphonenumber
            // 
            this.txtphonenumber.Location = new System.Drawing.Point(168, 215);
            this.txtphonenumber.Name = "txtphonenumber";
            this.txtphonenumber.Size = new System.Drawing.Size(210, 20);
            this.txtphonenumber.TabIndex = 23;
            // 
            // cmbgender
            // 
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbgender.Location = new System.Drawing.Point(168, 176);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(210, 21);
            this.cmbgender.TabIndex = 22;
            // 
            // dtpbirthdate
            // 
            this.dtpbirthdate.Location = new System.Drawing.Point(168, 140);
            this.dtpbirthdate.Name = "dtpbirthdate";
            this.dtpbirthdate.Size = new System.Drawing.Size(210, 20);
            this.dtpbirthdate.TabIndex = 20;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(168, 101);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(210, 20);
            this.txtlastname.TabIndex = 19;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(168, 64);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(210, 20);
            this.txtfirstname.TabIndex = 18;
            // 
            // txtstudentid
            // 
            this.txtstudentid.Location = new System.Drawing.Point(168, 29);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(210, 20);
            this.txtstudentid.TabIndex = 17;
            // 
            // lblpicture
            // 
            this.lblpicture.AutoSize = true;
            this.lblpicture.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpicture.Location = new System.Drawing.Point(22, 376);
            this.lblpicture.Name = "lblpicture";
            this.lblpicture.Size = new System.Drawing.Size(58, 21);
            this.lblpicture.TabIndex = 16;
            this.lblpicture.Text = "Picture";
            // 
            // lblgrade
            // 
            this.lblgrade.AutoSize = true;
            this.lblgrade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrade.Location = new System.Drawing.Point(19, 325);
            this.lblgrade.Name = "lblgrade";
            this.lblgrade.Size = new System.Drawing.Size(52, 21);
            this.lblgrade.TabIndex = 15;
            this.lblgrade.Text = "Grade";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(19, 289);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(48, 21);
            this.lblemail.TabIndex = 14;
            this.lblemail.Text = "Email";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(19, 252);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(66, 21);
            this.lbladdress.TabIndex = 13;
            this.lbladdress.Text = "Address";
            // 
            // lphonenumber
            // 
            this.lphonenumber.AutoSize = true;
            this.lphonenumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lphonenumber.Location = new System.Drawing.Point(19, 215);
            this.lphonenumber.Name = "lphonenumber";
            this.lphonenumber.Size = new System.Drawing.Size(116, 21);
            this.lphonenumber.TabIndex = 12;
            this.lphonenumber.Text = "Phone Number";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(19, 176);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(61, 21);
            this.lblgender.TabIndex = 11;
            this.lblgender.Text = "Gender";
            // 
            // lblbirthdate
            // 
            this.lblbirthdate.AutoSize = true;
            this.lblbirthdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbirthdate.Location = new System.Drawing.Point(19, 140);
            this.lblbirthdate.Name = "lblbirthdate";
            this.lblbirthdate.Size = new System.Drawing.Size(75, 21);
            this.lblbirthdate.TabIndex = 5;
            this.lblbirthdate.Text = "BirthDate";
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastname.Location = new System.Drawing.Point(19, 101);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(84, 21);
            this.lbllastname.TabIndex = 4;
            this.lbllastname.Text = "Last Name";
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.Location = new System.Drawing.Point(19, 64);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(86, 21);
            this.lblfirstname.TabIndex = 3;
            this.lblfirstname.Text = "First Name";
            // 
            // lblstudentid
            // 
            this.lblstudentid.AutoSize = true;
            this.lblstudentid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentid.Location = new System.Drawing.Point(19, 29);
            this.lblstudentid.Name = "lblstudentid";
            this.lblstudentid.Size = new System.Drawing.Size(82, 21);
            this.lblstudentid.TabIndex = 2;
            this.lblstudentid.Text = "Student ID";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txttypetheemail);
            this.panel2.Controls.Add(this.lbltypetheemail);
            this.panel2.Location = new System.Drawing.Point(480, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 91);
            this.panel2.TabIndex = 26;
            // 
            // txttypetheemail
            // 
            this.txttypetheemail.Location = new System.Drawing.Point(34, 54);
            this.txttypetheemail.Name = "txttypetheemail";
            this.txttypetheemail.Size = new System.Drawing.Size(230, 20);
            this.txttypetheemail.TabIndex = 23;
            // 
            // lbltypetheemail
            // 
            this.lbltypetheemail.AutoSize = true;
            this.lbltypetheemail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltypetheemail.Location = new System.Drawing.Point(30, 15);
            this.lbltypetheemail.Name = "lbltypetheemail";
            this.lbltypetheemail.Size = new System.Drawing.Size(110, 21);
            this.lbltypetheemail.TabIndex = 2;
            this.lbltypetheemail.Text = "Type the Email";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(470, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(469, 408);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(823, 53);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(95, 41);
            this.btnsearch.TabIndex = 29;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(16, 540);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(95, 41);
            this.btnsave.TabIndex = 30;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(128, 540);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(95, 41);
            this.btnupdate.TabIndex = 31;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(239, 540);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(95, 41);
            this.btndelete.TabIndex = 32;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(352, 540);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(95, 41);
            this.btnclear.TabIndex = 33;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 606);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStudent";
            this.Text = "STUDENT";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblstudentid;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.Label lblbirthdate;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lphonenumber;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblgrade;
        private System.Windows.Forms.Label lblpicture;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.DateTimePicker dtpbirthdate;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.TextBox txtphonenumber;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.ComboBox cmbgrade;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txttypetheemail;
        private System.Windows.Forms.Label lbltypetheemail;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}