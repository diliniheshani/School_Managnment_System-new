
namespace School_Managnment_System_new.Forms
{
    partial class FormMapSubject
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.cmbSubjectNo = new System.Windows.Forms.ComboBox();
            this.cmbSubjectName = new System.Windows.Forms.ComboBox();
            this.lblteacher = new System.Windows.Forms.Label();
            this.lblsection = new System.Windows.Forms.Label();
            this.lblgrade = new System.Windows.Forms.Label();
            this.lblsubjectno = new System.Windows.Forms.Label();
            this.lblsubjectname = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.txtTeacher);
            this.panel1.Controls.Add(this.cmbSection);
            this.panel1.Controls.Add(this.cmbGrade);
            this.panel1.Controls.Add(this.cmbSubjectNo);
            this.panel1.Controls.Add(this.cmbSubjectName);
            this.panel1.Controls.Add(this.lblteacher);
            this.panel1.Controls.Add(this.lblsection);
            this.panel1.Controls.Add(this.lblgrade);
            this.panel1.Controls.Add(this.lblsubjectno);
            this.panel1.Controls.Add(this.lblsubjectname);
            this.panel1.Location = new System.Drawing.Point(25, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 405);
            this.panel1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(38, 180);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(630, 199);
            this.listBox1.TabIndex = 17;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(492, 76);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(210, 20);
            this.txtTeacher.TabIndex = 16;
            // 
            // cmbSection
            // 
            this.cmbSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSection.ForeColor = System.Drawing.Color.Black;
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmbSection.Location = new System.Drawing.Point(492, 33);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(210, 24);
            this.cmbSection.TabIndex = 15;
            this.cmbSection.Text = "---SELECT----";
            // 
            // cmbGrade
            // 
            this.cmbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrade.ForeColor = System.Drawing.Color.Black;
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.cmbGrade.Location = new System.Drawing.Point(156, 111);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(210, 24);
            this.cmbGrade.TabIndex = 14;
            this.cmbGrade.Text = "--SELECT--";
            // 
            // cmbSubjectNo
            // 
            this.cmbSubjectNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubjectNo.ForeColor = System.Drawing.Color.Black;
            this.cmbSubjectNo.FormattingEnabled = true;
            this.cmbSubjectNo.Items.AddRange(new object[] {
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cmbSubjectNo.Location = new System.Drawing.Point(156, 33);
            this.cmbSubjectNo.Name = "cmbSubjectNo";
            this.cmbSubjectNo.Size = new System.Drawing.Size(210, 24);
            this.cmbSubjectNo.TabIndex = 13;
            this.cmbSubjectNo.Text = "--SELECT--";
            // 
            // cmbSubjectName
            // 
            this.cmbSubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubjectName.ForeColor = System.Drawing.Color.Black;
            this.cmbSubjectName.FormattingEnabled = true;
            this.cmbSubjectName.Items.AddRange(new object[] {
            "Maths",
            "History",
            "sinhala",
            "Buddhism",
            "science",
            "English",
            "ICT",
            "English Literary",
            "Geography"});
            this.cmbSubjectName.Location = new System.Drawing.Point(156, 73);
            this.cmbSubjectName.Name = "cmbSubjectName";
            this.cmbSubjectName.Size = new System.Drawing.Size(210, 24);
            this.cmbSubjectName.TabIndex = 12;
            this.cmbSubjectName.Text = "--SELECT--";
            // 
            // lblteacher
            // 
            this.lblteacher.AutoSize = true;
            this.lblteacher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblteacher.Location = new System.Drawing.Point(411, 73);
            this.lblteacher.Name = "lblteacher";
            this.lblteacher.Size = new System.Drawing.Size(62, 21);
            this.lblteacher.TabIndex = 6;
            this.lblteacher.Text = "Teacher";
            // 
            // lblsection
            // 
            this.lblsection.AutoSize = true;
            this.lblsection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsection.Location = new System.Drawing.Point(412, 33);
            this.lblsection.Name = "lblsection";
            this.lblsection.Size = new System.Drawing.Size(61, 21);
            this.lblsection.TabIndex = 5;
            this.lblsection.Text = "Section";
            // 
            // lblgrade
            // 
            this.lblgrade.AutoSize = true;
            this.lblgrade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrade.Location = new System.Drawing.Point(34, 111);
            this.lblgrade.Name = "lblgrade";
            this.lblgrade.Size = new System.Drawing.Size(52, 21);
            this.lblgrade.TabIndex = 4;
            this.lblgrade.Text = "Grade";
            // 
            // lblsubjectno
            // 
            this.lblsubjectno.AutoSize = true;
            this.lblsubjectno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubjectno.Location = new System.Drawing.Point(34, 33);
            this.lblsubjectno.Name = "lblsubjectno";
            this.lblsubjectno.Size = new System.Drawing.Size(86, 21);
            this.lblsubjectno.TabIndex = 3;
            this.lblsubjectno.Text = "Subject No";
            // 
            // lblsubjectname
            // 
            this.lblsubjectname.AutoSize = true;
            this.lblsubjectname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubjectname.Location = new System.Drawing.Point(34, 73);
            this.lblsubjectname.Name = "lblsubjectname";
            this.lblsubjectname.Size = new System.Drawing.Size(107, 21);
            this.lblsubjectname.TabIndex = 2;
            this.lblsubjectname.Text = "Subject Name";
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(73, 453);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(95, 41);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(194, 453);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(95, 41);
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(555, 453);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(95, 41);
            this.btnexit.TabIndex = 31;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(432, 453);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(95, 41);
            this.btnclear.TabIndex = 32;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(314, 453);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(95, 41);
            this.btndelete.TabIndex = 36;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // FormMapSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 506);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMapSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAP SUBJECT";
            this.Load += new System.EventHandler(this.FormMapsubject_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblteacher;
        private System.Windows.Forms.Label lblsection;
        private System.Windows.Forms.Label lblgrade;
        private System.Windows.Forms.Label lblsubjectno;
        private System.Windows.Forms.Label lblsubjectname;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.ComboBox cmbSubjectNo;
        private System.Windows.Forms.ComboBox cmbSubjectName;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
    }
}