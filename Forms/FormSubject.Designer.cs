
namespace School_Managnment_System_new.Forms
{
    partial class FormSubject
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
            this.cmbsubjectname = new System.Windows.Forms.ComboBox();
            this.nudnoofperiod = new System.Windows.Forms.NumericUpDown();
            this.txtteacherlanguage = new System.Windows.Forms.TextBox();
            this.txtteachername = new System.Windows.Forms.TextBox();
            this.txtsubjectno = new System.Windows.Forms.TextBox();
            this.lblnoofperiod = new System.Windows.Forms.Label();
            this.lblteacherlanguage = new System.Windows.Forms.Label();
            this.lblteachername = new System.Windows.Forms.Label();
            this.lblsubjectname = new System.Windows.Forms.Label();
            this.lblsubjectno = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudnoofperiod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cmbsubjectname);
            this.panel1.Controls.Add(this.nudnoofperiod);
            this.panel1.Controls.Add(this.txtteacherlanguage);
            this.panel1.Controls.Add(this.txtteachername);
            this.panel1.Controls.Add(this.txtsubjectno);
            this.panel1.Controls.Add(this.lblnoofperiod);
            this.panel1.Controls.Add(this.lblteacherlanguage);
            this.panel1.Controls.Add(this.lblteachername);
            this.panel1.Controls.Add(this.lblsubjectname);
            this.panel1.Controls.Add(this.lblsubjectno);
            this.panel1.Location = new System.Drawing.Point(25, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 303);
            this.panel1.TabIndex = 0;
            // 
            // cmbsubjectname
            // 
            this.cmbsubjectname.FormattingEnabled = true;
            this.cmbsubjectname.Items.AddRange(new object[] {
            "Maths",
            "History",
            "sinhala",
            "Buddhism",
            "science",
            "English",
            "ICT",
            "English Literary",
            "Geography",
            "",
            ""});
            this.cmbsubjectname.Location = new System.Drawing.Point(185, 75);
            this.cmbsubjectname.Name = "cmbsubjectname";
            this.cmbsubjectname.Size = new System.Drawing.Size(210, 21);
            this.cmbsubjectname.TabIndex = 53;
            // 
            // nudnoofperiod
            // 
            this.nudnoofperiod.Location = new System.Drawing.Point(185, 199);
            this.nudnoofperiod.Name = "nudnoofperiod";
            this.nudnoofperiod.Size = new System.Drawing.Size(210, 20);
            this.nudnoofperiod.TabIndex = 52;
            // 
            // txtteacherlanguage
            // 
            this.txtteacherlanguage.Location = new System.Drawing.Point(185, 160);
            this.txtteacherlanguage.Name = "txtteacherlanguage";
            this.txtteacherlanguage.Size = new System.Drawing.Size(210, 20);
            this.txtteacherlanguage.TabIndex = 16;
            // 
            // txtteachername
            // 
            this.txtteachername.Location = new System.Drawing.Point(185, 120);
            this.txtteachername.Name = "txtteachername";
            this.txtteachername.Size = new System.Drawing.Size(210, 20);
            this.txtteachername.TabIndex = 15;
            // 
            // txtsubjectno
            // 
            this.txtsubjectno.Location = new System.Drawing.Point(185, 32);
            this.txtsubjectno.Name = "txtsubjectno";
            this.txtsubjectno.Size = new System.Drawing.Size(210, 20);
            this.txtsubjectno.TabIndex = 13;
            // 
            // lblnoofperiod
            // 
            this.lblnoofperiod.AutoSize = true;
            this.lblnoofperiod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnoofperiod.Location = new System.Drawing.Point(21, 199);
            this.lblnoofperiod.Name = "lblnoofperiod";
            this.lblnoofperiod.Size = new System.Drawing.Size(97, 21);
            this.lblnoofperiod.TabIndex = 6;
            this.lblnoofperiod.Text = "No of Period";
            // 
            // lblteacherlanguage
            // 
            this.lblteacherlanguage.AutoSize = true;
            this.lblteacherlanguage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblteacherlanguage.Location = new System.Drawing.Point(21, 160);
            this.lblteacherlanguage.Name = "lblteacherlanguage";
            this.lblteacherlanguage.Size = new System.Drawing.Size(134, 21);
            this.lblteacherlanguage.TabIndex = 5;
            this.lblteacherlanguage.Text = "Teacher Language";
            // 
            // lblteachername
            // 
            this.lblteachername.AutoSize = true;
            this.lblteachername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblteachername.Location = new System.Drawing.Point(21, 120);
            this.lblteachername.Name = "lblteachername";
            this.lblteachername.Size = new System.Drawing.Size(108, 21);
            this.lblteachername.TabIndex = 4;
            this.lblteachername.Text = "Teacher Name";
            // 
            // lblsubjectname
            // 
            this.lblsubjectname.AutoSize = true;
            this.lblsubjectname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubjectname.Location = new System.Drawing.Point(21, 75);
            this.lblsubjectname.Name = "lblsubjectname";
            this.lblsubjectname.Size = new System.Drawing.Size(107, 21);
            this.lblsubjectname.TabIndex = 3;
            this.lblsubjectname.Text = "Subject Name";
            // 
            // lblsubjectno
            // 
            this.lblsubjectno.AutoSize = true;
            this.lblsubjectno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubjectno.Location = new System.Drawing.Point(21, 32);
            this.lblsubjectno.Name = "lblsubjectno";
            this.lblsubjectno.Size = new System.Drawing.Size(86, 21);
            this.lblsubjectno.TabIndex = 2;
            this.lblsubjectno.Text = "Subject No";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(499, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(429, 303);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(25, 364);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(95, 41);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(135, 364);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(95, 41);
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(251, 364);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(95, 41);
            this.btndelete.TabIndex = 24;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(476, 364);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(95, 41);
            this.btnclear.TabIndex = 34;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnview
            // 
            this.btnview.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.Location = new System.Drawing.Point(363, 364);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(95, 41);
            this.btnview.TabIndex = 35;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // FormSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 450);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSubject";
            this.Text = "SUBJECT";
            this.Load += new System.EventHandler(this.FormSubject_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudnoofperiod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblnoofperiod;
        private System.Windows.Forms.Label lblteacherlanguage;
        private System.Windows.Forms.Label lblteachername;
        private System.Windows.Forms.Label lblsubjectname;
        private System.Windows.Forms.Label lblsubjectno;
        private System.Windows.Forms.TextBox txtteacherlanguage;
        private System.Windows.Forms.TextBox txtteachername;
        private System.Windows.Forms.TextBox txtsubjectno;
        private System.Windows.Forms.NumericUpDown nudnoofperiod;
        private System.Windows.Forms.ComboBox cmbsubjectname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnview;
    }
}