
namespace School_Managnment_System_new.Forms
{
    partial class FormStaff
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
            this.pbimage = new System.Windows.Forms.PictureBox();
            this.cmbgender = new System.Windows.Forms.ComboBox();
            this.cmbpost = new System.Windows.Forms.ComboBox();
            this.txtnic = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtphonenumber = new System.Windows.Forms.TextBox();
            this.dtpbirthdate = new System.Windows.Forms.DateTimePicker();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtteacherid = new System.Windows.Forms.TextBox();
            this.lblpicture = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblpost = new System.Windows.Forms.Label();
            this.lblnic = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lphonenumber = new System.Windows.Forms.Label();
            this.lblbirthdate = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lblteacherid = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txttypetheemail = new System.Windows.Forms.TextBox();
            this.lbltypetheemail = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbimage)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pbimage);
            this.panel1.Controls.Add(this.cmbgender);
            this.panel1.Controls.Add(this.cmbpost);
            this.panel1.Controls.Add(this.txtnic);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.txtaddress);
            this.panel1.Controls.Add(this.txtphonenumber);
            this.panel1.Controls.Add(this.dtpbirthdate);
            this.panel1.Controls.Add(this.txtlastname);
            this.panel1.Controls.Add(this.txtfirstname);
            this.panel1.Controls.Add(this.txtteacherid);
            this.panel1.Controls.Add(this.lblpicture);
            this.panel1.Controls.Add(this.lblgender);
            this.panel1.Controls.Add(this.lblpost);
            this.panel1.Controls.Add(this.lblnic);
            this.panel1.Controls.Add(this.lblemail);
            this.panel1.Controls.Add(this.lbladdress);
            this.panel1.Controls.Add(this.lphonenumber);
            this.panel1.Controls.Add(this.lblbirthdate);
            this.panel1.Controls.Add(this.lbllastname);
            this.panel1.Controls.Add(this.lblfirstname);
            this.panel1.Controls.Add(this.lblteacherid);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 548);
            this.panel1.TabIndex = 0;
            // 
            // pbimage
            // 
            this.pbimage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbimage.Location = new System.Drawing.Point(209, 414);
            this.pbimage.Name = "pbimage";
            this.pbimage.Size = new System.Drawing.Size(135, 111);
            this.pbimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimage.TabIndex = 22;
            this.pbimage.TabStop = false;
            this.pbimage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cmbgender
            // 
            this.cmbgender.FormattingEnabled = true;
            this.cmbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbgender.Location = new System.Drawing.Point(209, 380);
            this.cmbgender.Name = "cmbgender";
            this.cmbgender.Size = new System.Drawing.Size(210, 21);
            this.cmbgender.TabIndex = 21;
            // 
            // cmbpost
            // 
            this.cmbpost.FormattingEnabled = true;
            this.cmbpost.Items.AddRange(new object[] {
            "Teacher",
            "Miner Teacher"});
            this.cmbpost.Location = new System.Drawing.Point(209, 344);
            this.cmbpost.Name = "cmbpost";
            this.cmbpost.Size = new System.Drawing.Size(210, 21);
            this.cmbpost.TabIndex = 20;
            // 
            // txtnic
            // 
            this.txtnic.Location = new System.Drawing.Point(209, 306);
            this.txtnic.Name = "txtnic";
            this.txtnic.Size = new System.Drawing.Size(210, 20);
            this.txtnic.TabIndex = 19;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(209, 270);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(210, 20);
            this.txtemail.TabIndex = 18;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(209, 234);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(210, 20);
            this.txtaddress.TabIndex = 17;
            // 
            // txtphonenumber
            // 
            this.txtphonenumber.Location = new System.Drawing.Point(209, 195);
            this.txtphonenumber.Name = "txtphonenumber";
            this.txtphonenumber.Size = new System.Drawing.Size(210, 20);
            this.txtphonenumber.TabIndex = 16;
            // 
            // dtpbirthdate
            // 
            this.dtpbirthdate.Location = new System.Drawing.Point(209, 156);
            this.dtpbirthdate.Name = "dtpbirthdate";
            this.dtpbirthdate.Size = new System.Drawing.Size(210, 20);
            this.dtpbirthdate.TabIndex = 15;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(209, 111);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(210, 20);
            this.txtlastname.TabIndex = 14;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(209, 71);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(210, 20);
            this.txtfirstname.TabIndex = 13;
            // 
            // txtteacherid
            // 
            this.txtteacherid.Location = new System.Drawing.Point(209, 32);
            this.txtteacherid.Name = "txtteacherid";
            this.txtteacherid.Size = new System.Drawing.Size(210, 20);
            this.txtteacherid.TabIndex = 12;
            // 
            // lblpicture
            // 
            this.lblpicture.AutoSize = true;
            this.lblpicture.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpicture.Location = new System.Drawing.Point(32, 425);
            this.lblpicture.Name = "lblpicture";
            this.lblpicture.Size = new System.Drawing.Size(58, 21);
            this.lblpicture.TabIndex = 11;
            this.lblpicture.Text = "Picture";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(32, 380);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(61, 21);
            this.lblgender.TabIndex = 10;
            this.lblgender.Text = "Gender";
            // 
            // lblpost
            // 
            this.lblpost.AutoSize = true;
            this.lblpost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpost.Location = new System.Drawing.Point(32, 344);
            this.lblpost.Name = "lblpost";
            this.lblpost.Size = new System.Drawing.Size(39, 21);
            this.lblpost.TabIndex = 9;
            this.lblpost.Text = "Post";
            // 
            // lblnic
            // 
            this.lblnic.AutoSize = true;
            this.lblnic.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnic.Location = new System.Drawing.Point(32, 306);
            this.lblnic.Name = "lblnic";
            this.lblnic.Size = new System.Drawing.Size(40, 21);
            this.lblnic.TabIndex = 8;
            this.lblnic.Text = "NIC ";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(32, 267);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(48, 21);
            this.lblemail.TabIndex = 7;
            this.lblemail.Text = "Email";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(32, 233);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(66, 21);
            this.lbladdress.TabIndex = 6;
            this.lbladdress.Text = "Address";
            // 
            // lphonenumber
            // 
            this.lphonenumber.AutoSize = true;
            this.lphonenumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lphonenumber.Location = new System.Drawing.Point(32, 195);
            this.lphonenumber.Name = "lphonenumber";
            this.lphonenumber.Size = new System.Drawing.Size(116, 21);
            this.lphonenumber.TabIndex = 5;
            this.lphonenumber.Text = "Phone Number";
            // 
            // lblbirthdate
            // 
            this.lblbirthdate.AutoSize = true;
            this.lblbirthdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbirthdate.Location = new System.Drawing.Point(32, 156);
            this.lblbirthdate.Name = "lblbirthdate";
            this.lblbirthdate.Size = new System.Drawing.Size(75, 21);
            this.lblbirthdate.TabIndex = 4;
            this.lblbirthdate.Text = "BirthDate";
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastname.Location = new System.Drawing.Point(32, 111);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(84, 21);
            this.lbllastname.TabIndex = 3;
            this.lbllastname.Text = "Last Name";
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.Location = new System.Drawing.Point(32, 71);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(86, 21);
            this.lblfirstname.TabIndex = 2;
            this.lblfirstname.Text = "First Name";
            // 
            // lblteacherid
            // 
            this.lblteacherid.AutoSize = true;
            this.lblteacherid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblteacherid.Location = new System.Drawing.Point(32, 29);
            this.lblteacherid.Name = "lblteacherid";
            this.lblteacherid.Size = new System.Drawing.Size(81, 21);
            this.lblteacherid.TabIndex = 1;
            this.lblteacherid.Text = "Teacher ID";
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(84, 586);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(95, 41);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(198, 586);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(95, 41);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(313, 586);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(95, 41);
            this.btndelete.TabIndex = 23;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(423, 586);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(95, 41);
            this.btnclear.TabIndex = 24;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txttypetheemail);
            this.panel2.Controls.Add(this.lbltypetheemail);
            this.panel2.Location = new System.Drawing.Point(548, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 91);
            this.panel2.TabIndex = 25;
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
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(878, 46);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(95, 41);
            this.btnsearch.TabIndex = 26;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(528, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(469, 408);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 639);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStaff";
            this.Text = "STAFF";
            this.Load += new System.EventHandler(this.FormStaff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbimage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblpicture;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblpost;
        private System.Windows.Forms.Label lblnic;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lphonenumber;
        private System.Windows.Forms.Label lblbirthdate;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label lblteacherid;
        private System.Windows.Forms.PictureBox pbimage;
        private System.Windows.Forms.ComboBox cmbgender;
        private System.Windows.Forms.ComboBox cmbpost;
        private System.Windows.Forms.TextBox txtnic;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtphonenumber;
        private System.Windows.Forms.DateTimePicker dtpbirthdate;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtteacherid;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txttypetheemail;
        private System.Windows.Forms.Label lbltypetheemail;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}