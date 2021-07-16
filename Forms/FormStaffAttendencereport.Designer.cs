
namespace School_Managnment_System_new.Forms
{
    partial class FormStaffAttendencereport
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtteachername = new System.Windows.Forms.TextBox();
            this.lblteachername = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnclose = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 38.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(937, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Attendence Records";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtteachername);
            this.panel2.Controls.Add(this.lblteachername);
            this.panel2.Location = new System.Drawing.Point(78, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 91);
            this.panel2.TabIndex = 27;
            // 
            // txtteachername
            // 
            this.txtteachername.Location = new System.Drawing.Point(182, 33);
            this.txtteachername.Name = "txtteachername";
            this.txtteachername.Size = new System.Drawing.Size(230, 20);
            this.txtteachername.TabIndex = 23;
            this.txtteachername.TextChanged += new System.EventHandler(this.txtteachername_TextChanged);
            // 
            // lblteachername
            // 
            this.lblteachername.AutoSize = true;
            this.lblteachername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblteachername.Location = new System.Drawing.Point(29, 30);
            this.lblteachername.Name = "lblteachername";
            this.lblteachername.Size = new System.Drawing.Size(108, 21);
            this.lblteachername.TabIndex = 2;
            this.lblteachername.Text = "Teacher Name";
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(578, 146);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(95, 41);
            this.btnexit.TabIndex = 30;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(858, 316);
            this.dataGridView1.TabIndex = 31;
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnclose.Location = new System.Drawing.Point(862, 27);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(37, 25);
            this.btnclose.TabIndex = 32;
            this.btnclose.Text = "x";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // FormStaffAttendencereport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 569);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStaffAttendencereport";
            this.Text = "STAFF ATTENDENCE";
            this.Load += new System.EventHandler(this.FormStaffAttendencereport_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtteachername;
        private System.Windows.Forms.Label lblteachername;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnclose;
    }
}