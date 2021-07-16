
namespace School_Managnment_System_new.Forms
{
    partial class FormClass
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.nmustudentcount = new System.Windows.Forms.NumericUpDown();
            this.txtaccistantteacherincharge = new System.Windows.Forms.TextBox();
            this.txtteacherincharge = new System.Windows.Forms.TextBox();
            this.txtsection = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblstudentcount = new System.Windows.Forms.Label();
            this.lblaccistantteacherincharge = new System.Windows.Forms.Label();
            this.lblteacherincharge = new System.Windows.Forms.Label();
            this.lblsection = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblschoolid = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmustudentcount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblschoolid);
            this.panel1.Location = new System.Drawing.Point(31, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 270);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.nmustudentcount);
            this.panel2.Controls.Add(this.txtaccistantteacherincharge);
            this.panel2.Controls.Add(this.txtteacherincharge);
            this.panel2.Controls.Add(this.txtsection);
            this.panel2.Controls.Add(this.txtname);
            this.panel2.Controls.Add(this.lblstudentcount);
            this.panel2.Controls.Add(this.lblaccistantteacherincharge);
            this.panel2.Controls.Add(this.lblteacherincharge);
            this.panel2.Controls.Add(this.lblsection);
            this.panel2.Controls.Add(this.lblname);
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(515, 296);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // nmustudentcount
            // 
            this.nmustudentcount.Location = new System.Drawing.Point(247, 208);
            this.nmustudentcount.Name = "nmustudentcount";
            this.nmustudentcount.Size = new System.Drawing.Size(210, 20);
            this.nmustudentcount.TabIndex = 51;
            // 
            // txtaccistantteacherincharge
            // 
            this.txtaccistantteacherincharge.Location = new System.Drawing.Point(247, 164);
            this.txtaccistantteacherincharge.Name = "txtaccistantteacherincharge";
            this.txtaccistantteacherincharge.Size = new System.Drawing.Size(210, 20);
            this.txtaccistantteacherincharge.TabIndex = 13;
            // 
            // txtteacherincharge
            // 
            this.txtteacherincharge.Location = new System.Drawing.Point(247, 121);
            this.txtteacherincharge.Name = "txtteacherincharge";
            this.txtteacherincharge.Size = new System.Drawing.Size(210, 20);
            this.txtteacherincharge.TabIndex = 12;
            // 
            // txtsection
            // 
            this.txtsection.Location = new System.Drawing.Point(247, 79);
            this.txtsection.Name = "txtsection";
            this.txtsection.Size = new System.Drawing.Size(210, 20);
            this.txtsection.TabIndex = 11;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(247, 31);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(210, 20);
            this.txtname.TabIndex = 10;
            // 
            // lblstudentcount
            // 
            this.lblstudentcount.AutoSize = true;
            this.lblstudentcount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentcount.Location = new System.Drawing.Point(32, 204);
            this.lblstudentcount.Name = "lblstudentcount";
            this.lblstudentcount.Size = new System.Drawing.Size(109, 21);
            this.lblstudentcount.TabIndex = 5;
            this.lblstudentcount.Text = "Student Count";
            // 
            // lblaccistantteacherincharge
            // 
            this.lblaccistantteacherincharge.AutoSize = true;
            this.lblaccistantteacherincharge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaccistantteacherincharge.Location = new System.Drawing.Point(32, 161);
            this.lblaccistantteacherincharge.Name = "lblaccistantteacherincharge";
            this.lblaccistantteacherincharge.Size = new System.Drawing.Size(192, 21);
            this.lblaccistantteacherincharge.TabIndex = 4;
            this.lblaccistantteacherincharge.Text = "Accistant Teacher Incharge";
            // 
            // lblteacherincharge
            // 
            this.lblteacherincharge.AutoSize = true;
            this.lblteacherincharge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblteacherincharge.Location = new System.Drawing.Point(32, 118);
            this.lblteacherincharge.Name = "lblteacherincharge";
            this.lblteacherincharge.Size = new System.Drawing.Size(126, 21);
            this.lblteacherincharge.TabIndex = 3;
            this.lblteacherincharge.Text = "Teacher Incharge";
            // 
            // lblsection
            // 
            this.lblsection.AutoSize = true;
            this.lblsection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsection.Location = new System.Drawing.Point(32, 76);
            this.lblsection.Name = "lblsection";
            this.lblsection.Size = new System.Drawing.Size(61, 21);
            this.lblsection.TabIndex = 2;
            this.lblsection.Text = "Section";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(32, 31);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(52, 21);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "School ID";
            // 
            // lblschoolid
            // 
            this.lblschoolid.AutoSize = true;
            this.lblschoolid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblschoolid.Location = new System.Drawing.Point(23, 28);
            this.lblschoolid.Name = "lblschoolid";
            this.lblschoolid.Size = new System.Drawing.Size(76, 21);
            this.lblschoolid.TabIndex = 1;
            this.lblschoolid.Text = "School ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(552, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(415, 391);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(12, 342);
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
            this.btnupdate.Location = new System.Drawing.Point(113, 342);
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
            this.btndelete.Location = new System.Drawing.Point(214, 342);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(95, 41);
            this.btndelete.TabIndex = 4;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnview
            // 
            this.btnview.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.Location = new System.Drawing.Point(315, 342);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(95, 41);
            this.btnview.TabIndex = 5;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(422, 342);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(95, 41);
            this.btnreset.TabIndex = 6;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // FormClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 459);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClass";
            this.Text = "CLASS";
            this.Load += new System.EventHandler(this.FormClass_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmustudentcount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblstudentcount;
        private System.Windows.Forms.Label lblaccistantteacherincharge;
        private System.Windows.Forms.Label lblteacherincharge;
        private System.Windows.Forms.Label lblsection;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblschoolid;
        private System.Windows.Forms.TextBox txtaccistantteacherincharge;
        private System.Windows.Forms.TextBox txtteacherincharge;
        private System.Windows.Forms.TextBox txtsection;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.NumericUpDown nmustudentcount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btnreset;
    }
}