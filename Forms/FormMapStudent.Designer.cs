
namespace School_Managnment_System_new.Forms
{
    partial class FormMapStudent
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
            this.txtclassteacher = new System.Windows.Forms.TextBox();
            this.lblclassteacher = new System.Windows.Forms.Label();
            this.cmbsection = new System.Windows.Forms.ComboBox();
            this.lblsection = new System.Windows.Forms.Label();
            this.cmbgrade = new System.Windows.Forms.ComboBox();
            this.lblgrade = new System.Windows.Forms.Label();
            this.txtstudentname = new System.Windows.Forms.TextBox();
            this.lblstudentname = new System.Windows.Forms.Label();
            this.txtstudentno = new System.Windows.Forms.TextBox();
            this.lblstudenttno = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.txtclassteacher);
            this.panel1.Controls.Add(this.lblclassteacher);
            this.panel1.Controls.Add(this.cmbsection);
            this.panel1.Controls.Add(this.lblsection);
            this.panel1.Controls.Add(this.cmbgrade);
            this.panel1.Controls.Add(this.lblgrade);
            this.panel1.Controls.Add(this.txtstudentname);
            this.panel1.Controls.Add(this.lblstudentname);
            this.panel1.Controls.Add(this.txtstudentno);
            this.panel1.Controls.Add(this.lblstudenttno);
            this.panel1.Location = new System.Drawing.Point(42, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 434);
            this.panel1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(42, 187);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(599, 199);
            this.listBox1.TabIndex = 26;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtclassteacher
            // 
            this.txtclassteacher.Location = new System.Drawing.Point(544, 81);
            this.txtclassteacher.Name = "txtclassteacher";
            this.txtclassteacher.Size = new System.Drawing.Size(210, 20);
            this.txtclassteacher.TabIndex = 25;
            // 
            // lblclassteacher
            // 
            this.lblclassteacher.AutoSize = true;
            this.lblclassteacher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclassteacher.Location = new System.Drawing.Point(423, 81);
            this.lblclassteacher.Name = "lblclassteacher";
            this.lblclassteacher.Size = new System.Drawing.Size(102, 21);
            this.lblclassteacher.TabIndex = 24;
            this.lblclassteacher.Text = "Class Teacher";
            // 
            // cmbsection
            // 
            this.cmbsection.ForeColor = System.Drawing.Color.Maroon;
            this.cmbsection.FormattingEnabled = true;
            this.cmbsection.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmbsection.Location = new System.Drawing.Point(544, 32);
            this.cmbsection.Name = "cmbsection";
            this.cmbsection.Size = new System.Drawing.Size(210, 21);
            this.cmbsection.TabIndex = 23;
            this.cmbsection.Text = "---SELECT----";
            // 
            // lblsection
            // 
            this.lblsection.AutoSize = true;
            this.lblsection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsection.Location = new System.Drawing.Point(423, 35);
            this.lblsection.Name = "lblsection";
            this.lblsection.Size = new System.Drawing.Size(61, 21);
            this.lblsection.TabIndex = 22;
            this.lblsection.Text = "Section";
            // 
            // cmbgrade
            // 
            this.cmbgrade.ForeColor = System.Drawing.Color.Maroon;
            this.cmbgrade.FormattingEnabled = true;
            this.cmbgrade.Items.AddRange(new object[] {
            "",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.cmbgrade.Location = new System.Drawing.Point(165, 127);
            this.cmbgrade.Name = "cmbgrade";
            this.cmbgrade.Size = new System.Drawing.Size(210, 21);
            this.cmbgrade.TabIndex = 21;
            this.cmbgrade.Text = "--SELECT--";
            // 
            // lblgrade
            // 
            this.lblgrade.AutoSize = true;
            this.lblgrade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrade.Location = new System.Drawing.Point(23, 127);
            this.lblgrade.Name = "lblgrade";
            this.lblgrade.Size = new System.Drawing.Size(52, 21);
            this.lblgrade.TabIndex = 20;
            this.lblgrade.Text = "Grade";
            // 
            // txtstudentname
            // 
            this.txtstudentname.Location = new System.Drawing.Point(165, 81);
            this.txtstudentname.Name = "txtstudentname";
            this.txtstudentname.Size = new System.Drawing.Size(210, 20);
            this.txtstudentname.TabIndex = 19;
            // 
            // lblstudentname
            // 
            this.lblstudentname.AutoSize = true;
            this.lblstudentname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentname.Location = new System.Drawing.Point(23, 81);
            this.lblstudentname.Name = "lblstudentname";
            this.lblstudentname.Size = new System.Drawing.Size(113, 21);
            this.lblstudentname.TabIndex = 18;
            this.lblstudentname.Text = "Student  Name";
            // 
            // txtstudentno
            // 
            this.txtstudentno.Location = new System.Drawing.Point(165, 35);
            this.txtstudentno.Name = "txtstudentno";
            this.txtstudentno.Size = new System.Drawing.Size(210, 20);
            this.txtstudentno.TabIndex = 17;
            // 
            // lblstudenttno
            // 
            this.lblstudenttno.AutoSize = true;
            this.lblstudenttno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudenttno.Location = new System.Drawing.Point(23, 32);
            this.lblstudenttno.Name = "lblstudenttno";
            this.lblstudenttno.Size = new System.Drawing.Size(92, 21);
            this.lblstudenttno.TabIndex = 4;
            this.lblstudenttno.Text = "Student  No";
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(64, 485);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(95, 41);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(181, 485);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(95, 41);
            this.btnupdate.TabIndex = 5;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(417, 485);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(95, 41);
            this.btnclear.TabIndex = 33;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(534, 485);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(95, 41);
            this.btnexit.TabIndex = 34;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(301, 485);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(95, 41);
            this.btndelete.TabIndex = 35;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // FormMapStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 538);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMapStudent";
            this.Text = "MAP STUDENT";
            this.Load += new System.EventHandler(this.FormMapStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblstudenttno;
        private System.Windows.Forms.TextBox txtstudentname;
        private System.Windows.Forms.Label lblstudentname;
        private System.Windows.Forms.TextBox txtstudentno;
        private System.Windows.Forms.Label lblgrade;
        private System.Windows.Forms.ComboBox cmbgrade;
        private System.Windows.Forms.Label lblsection;
        private System.Windows.Forms.ComboBox cmbsection;
        private System.Windows.Forms.TextBox txtclassteacher;
        private System.Windows.Forms.Label lblclassteacher;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btndelete;
    }
}