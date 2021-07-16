
namespace School_Managnment_System_new.Forms
{
    partial class FormMarks
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbexamtype = new System.Windows.Forms.ComboBox();
            this.cmbexamyear = new System.Windows.Forms.ComboBox();
            this.txtexamroleno = new System.Windows.Forms.TextBox();
            this.txtstudentname = new System.Windows.Forms.TextBox();
            this.txtstudentno = new System.Windows.Forms.TextBox();
            this.lblexamtype = new System.Windows.Forms.Label();
            this.lblexamyear = new System.Windows.Forms.Label();
            this.lblexamroleno = new System.Windows.Forms.Label();
            this.lblstudentname = new System.Windows.Forms.Label();
            this.lblstudentno = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnexporttoexcel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtrank = new System.Windows.Forms.TextBox();
            this.txtaverage = new System.Windows.Forms.TextBox();
            this.txttotalscore = new System.Windows.Forms.TextBox();
            this.lblrank = new System.Windows.Forms.Label();
            this.lblaverage = new System.Windows.Forms.Label();
            this.lbltotalscore = new System.Windows.Forms.Label();
            this.lblict = new System.Windows.Forms.Label();
            this.lblenglishliterary = new System.Windows.Forms.Label();
            this.lblgeography = new System.Windows.Forms.Label();
            this.txtict = new System.Windows.Forms.TextBox();
            this.txtenglishliterary = new System.Windows.Forms.TextBox();
            this.txtgeography = new System.Windows.Forms.TextBox();
            this.lblscience = new System.Windows.Forms.Label();
            this.txtscience = new System.Windows.Forms.TextBox();
            this.txtenglish = new System.Windows.Forms.TextBox();
            this.txthistory = new System.Windows.Forms.TextBox();
            this.lblenglish = new System.Windows.Forms.Label();
            this.lblhistory = new System.Windows.Forms.Label();
            this.txtmaths = new System.Windows.Forms.TextBox();
            this.txtsinhala = new System.Windows.Forms.TextBox();
            this.txtbuddhism = new System.Windows.Forms.TextBox();
            this.lblbuddhism = new System.Windows.Forms.Label();
            this.lblmarks = new System.Windows.Forms.Label();
            this.lblmaths = new System.Windows.Forms.Label();
            this.lblsinhala = new System.Windows.Forms.Label();
            this.lblsubject = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txttypetheexamrolleno = new System.Windows.Forms.TextBox();
            this.lblexamrolleno = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbexamtype);
            this.groupBox1.Controls.Add(this.cmbexamyear);
            this.groupBox1.Controls.Add(this.txtexamroleno);
            this.groupBox1.Controls.Add(this.txtstudentname);
            this.groupBox1.Controls.Add(this.txtstudentno);
            this.groupBox1.Controls.Add(this.lblexamtype);
            this.groupBox1.Controls.Add(this.lblexamyear);
            this.groupBox1.Controls.Add(this.lblexamroleno);
            this.groupBox1.Controls.Add(this.lblstudentname);
            this.groupBox1.Controls.Add(this.lblstudentno);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(22, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Details";
            // 
            // cmbexamtype
            // 
            this.cmbexamtype.FormattingEnabled = true;
            this.cmbexamtype.Items.AddRange(new object[] {
            "1 st Tearm Test",
            "2 nd Term Test ",
            "3 rd Term Test"});
            this.cmbexamtype.Location = new System.Drawing.Point(490, 82);
            this.cmbexamtype.Name = "cmbexamtype";
            this.cmbexamtype.Size = new System.Drawing.Size(185, 29);
            this.cmbexamtype.TabIndex = 11;
            // 
            // cmbexamyear
            // 
            this.cmbexamyear.FormattingEnabled = true;
            this.cmbexamyear.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021"});
            this.cmbexamyear.Location = new System.Drawing.Point(490, 38);
            this.cmbexamyear.Name = "cmbexamyear";
            this.cmbexamyear.Size = new System.Drawing.Size(185, 29);
            this.cmbexamyear.TabIndex = 10;
            // 
            // txtexamroleno
            // 
            this.txtexamroleno.Location = new System.Drawing.Point(153, 131);
            this.txtexamroleno.Name = "txtexamroleno";
            this.txtexamroleno.Size = new System.Drawing.Size(185, 29);
            this.txtexamroleno.TabIndex = 9;
            // 
            // txtstudentname
            // 
            this.txtstudentname.Location = new System.Drawing.Point(153, 90);
            this.txtstudentname.Name = "txtstudentname";
            this.txtstudentname.Size = new System.Drawing.Size(185, 29);
            this.txtstudentname.TabIndex = 8;
            // 
            // txtstudentno
            // 
            this.txtstudentno.Location = new System.Drawing.Point(153, 46);
            this.txtstudentno.Name = "txtstudentno";
            this.txtstudentno.Size = new System.Drawing.Size(185, 29);
            this.txtstudentno.TabIndex = 7;
            // 
            // lblexamtype
            // 
            this.lblexamtype.AutoSize = true;
            this.lblexamtype.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexamtype.ForeColor = System.Drawing.Color.Black;
            this.lblexamtype.Location = new System.Drawing.Point(376, 90);
            this.lblexamtype.Name = "lblexamtype";
            this.lblexamtype.Size = new System.Drawing.Size(83, 21);
            this.lblexamtype.TabIndex = 6;
            this.lblexamtype.Text = "Exam Type";
            // 
            // lblexamyear
            // 
            this.lblexamyear.AutoSize = true;
            this.lblexamyear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexamyear.ForeColor = System.Drawing.Color.Black;
            this.lblexamyear.Location = new System.Drawing.Point(376, 46);
            this.lblexamyear.Name = "lblexamyear";
            this.lblexamyear.Size = new System.Drawing.Size(81, 21);
            this.lblexamyear.TabIndex = 5;
            this.lblexamyear.Text = "Exam Year";
            // 
            // lblexamroleno
            // 
            this.lblexamroleno.AutoSize = true;
            this.lblexamroleno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexamroleno.ForeColor = System.Drawing.Color.Black;
            this.lblexamroleno.Location = new System.Drawing.Point(21, 139);
            this.lblexamroleno.Name = "lblexamroleno";
            this.lblexamroleno.Size = new System.Drawing.Size(107, 21);
            this.lblexamroleno.TabIndex = 4;
            this.lblexamroleno.Text = "Exam Role No";
            // 
            // lblstudentname
            // 
            this.lblstudentname.AutoSize = true;
            this.lblstudentname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentname.ForeColor = System.Drawing.Color.Black;
            this.lblstudentname.Location = new System.Drawing.Point(19, 98);
            this.lblstudentname.Name = "lblstudentname";
            this.lblstudentname.Size = new System.Drawing.Size(109, 21);
            this.lblstudentname.TabIndex = 3;
            this.lblstudentname.Text = "Student Name";
            // 
            // lblstudentno
            // 
            this.lblstudentno.AutoSize = true;
            this.lblstudentno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentno.ForeColor = System.Drawing.Color.Black;
            this.lblstudentno.Location = new System.Drawing.Point(19, 54);
            this.lblstudentno.Name = "lblstudentno";
            this.lblstudentno.Size = new System.Drawing.Size(88, 21);
            this.lblstudentno.TabIndex = 2;
            this.lblstudentno.Text = "Student No";
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(743, 36);
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
            this.btnupdate.Location = new System.Drawing.Point(858, 36);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(95, 41);
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(979, 36);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(95, 41);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(743, 95);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(125, 41);
            this.btncalculate.TabIndex = 8;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnexporttoexcel
            // 
            this.btnexporttoexcel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexporttoexcel.Location = new System.Drawing.Point(890, 95);
            this.btnexporttoexcel.Name = "btnexporttoexcel";
            this.btnexporttoexcel.Size = new System.Drawing.Size(209, 41);
            this.btnexporttoexcel.TabIndex = 9;
            this.btnexporttoexcel.Text = "Export to excel";
            this.btnexporttoexcel.UseVisualStyleBackColor = true;
            this.btnexporttoexcel.Click += new System.EventHandler(this.btnexporttoexcel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtrank);
            this.groupBox2.Controls.Add(this.txtaverage);
            this.groupBox2.Controls.Add(this.txttotalscore);
            this.groupBox2.Controls.Add(this.lblrank);
            this.groupBox2.Controls.Add(this.lblaverage);
            this.groupBox2.Controls.Add(this.lbltotalscore);
            this.groupBox2.Controls.Add(this.lblict);
            this.groupBox2.Controls.Add(this.lblenglishliterary);
            this.groupBox2.Controls.Add(this.lblgeography);
            this.groupBox2.Controls.Add(this.txtict);
            this.groupBox2.Controls.Add(this.txtenglishliterary);
            this.groupBox2.Controls.Add(this.txtgeography);
            this.groupBox2.Controls.Add(this.lblscience);
            this.groupBox2.Controls.Add(this.txtscience);
            this.groupBox2.Controls.Add(this.txtenglish);
            this.groupBox2.Controls.Add(this.txthistory);
            this.groupBox2.Controls.Add(this.lblenglish);
            this.groupBox2.Controls.Add(this.lblhistory);
            this.groupBox2.Controls.Add(this.txtmaths);
            this.groupBox2.Controls.Add(this.txtsinhala);
            this.groupBox2.Controls.Add(this.txtbuddhism);
            this.groupBox2.Controls.Add(this.lblbuddhism);
            this.groupBox2.Controls.Add(this.lblmarks);
            this.groupBox2.Controls.Add(this.lblmaths);
            this.groupBox2.Controls.Add(this.lblsinhala);
            this.groupBox2.Controls.Add(this.lblsubject);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(22, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 415);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Marks Point Obtained";
            // 
            // txtrank
            // 
            this.txtrank.Location = new System.Drawing.Point(464, 287);
            this.txtrank.Name = "txtrank";
            this.txtrank.Size = new System.Drawing.Size(179, 29);
            this.txtrank.TabIndex = 27;
            // 
            // txtaverage
            // 
            this.txtaverage.Location = new System.Drawing.Point(449, 200);
            this.txtaverage.Name = "txtaverage";
            this.txtaverage.Size = new System.Drawing.Size(217, 29);
            this.txtaverage.TabIndex = 26;
            // 
            // txttotalscore
            // 
            this.txttotalscore.Location = new System.Drawing.Point(449, 125);
            this.txttotalscore.Name = "txttotalscore";
            this.txttotalscore.Size = new System.Drawing.Size(217, 29);
            this.txttotalscore.TabIndex = 25;
            // 
            // lblrank
            // 
            this.lblrank.AutoSize = true;
            this.lblrank.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrank.ForeColor = System.Drawing.Color.DarkRed;
            this.lblrank.Location = new System.Drawing.Point(519, 251);
            this.lblrank.Name = "lblrank";
            this.lblrank.Size = new System.Drawing.Size(48, 21);
            this.lblrank.TabIndex = 24;
            this.lblrank.Text = "Rank";
            // 
            // lblaverage
            // 
            this.lblaverage.AutoSize = true;
            this.lblaverage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaverage.ForeColor = System.Drawing.Color.DarkRed;
            this.lblaverage.Location = new System.Drawing.Point(507, 168);
            this.lblaverage.Name = "lblaverage";
            this.lblaverage.Size = new System.Drawing.Size(73, 21);
            this.lblaverage.TabIndex = 23;
            this.lblaverage.Text = "Average";
            // 
            // lbltotalscore
            // 
            this.lbltotalscore.AutoSize = true;
            this.lbltotalscore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalscore.ForeColor = System.Drawing.Color.DarkRed;
            this.lbltotalscore.Location = new System.Drawing.Point(496, 90);
            this.lbltotalscore.Name = "lbltotalscore";
            this.lbltotalscore.Size = new System.Drawing.Size(94, 21);
            this.lbltotalscore.TabIndex = 22;
            this.lbltotalscore.Text = "Total Score";
            // 
            // lblict
            // 
            this.lblict.AutoSize = true;
            this.lblict.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblict.ForeColor = System.Drawing.Color.Black;
            this.lblict.Location = new System.Drawing.Point(36, 375);
            this.lblict.Name = "lblict";
            this.lblict.Size = new System.Drawing.Size(32, 21);
            this.lblict.TabIndex = 21;
            this.lblict.Text = "ICT";
            // 
            // lblenglishliterary
            // 
            this.lblenglishliterary.AutoSize = true;
            this.lblenglishliterary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenglishliterary.ForeColor = System.Drawing.Color.Black;
            this.lblenglishliterary.Location = new System.Drawing.Point(36, 340);
            this.lblenglishliterary.Name = "lblenglishliterary";
            this.lblenglishliterary.Size = new System.Drawing.Size(117, 21);
            this.lblenglishliterary.TabIndex = 20;
            this.lblenglishliterary.Text = "English Literary";
            // 
            // lblgeography
            // 
            this.lblgeography.AutoSize = true;
            this.lblgeography.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgeography.ForeColor = System.Drawing.Color.Black;
            this.lblgeography.Location = new System.Drawing.Point(36, 305);
            this.lblgeography.Name = "lblgeography";
            this.lblgeography.Size = new System.Drawing.Size(87, 21);
            this.lblgeography.TabIndex = 19;
            this.lblgeography.Text = "Geography";
            // 
            // txtict
            // 
            this.txtict.Location = new System.Drawing.Point(244, 367);
            this.txtict.Name = "txtict";
            this.txtict.Size = new System.Drawing.Size(139, 29);
            this.txtict.TabIndex = 18;
            // 
            // txtenglishliterary
            // 
            this.txtenglishliterary.Location = new System.Drawing.Point(244, 332);
            this.txtenglishliterary.Name = "txtenglishliterary";
            this.txtenglishliterary.Size = new System.Drawing.Size(139, 29);
            this.txtenglishliterary.TabIndex = 17;
            // 
            // txtgeography
            // 
            this.txtgeography.Location = new System.Drawing.Point(244, 297);
            this.txtgeography.Name = "txtgeography";
            this.txtgeography.Size = new System.Drawing.Size(139, 29);
            this.txtgeography.TabIndex = 16;
            // 
            // lblscience
            // 
            this.lblscience.AutoSize = true;
            this.lblscience.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscience.ForeColor = System.Drawing.Color.Black;
            this.lblscience.Location = new System.Drawing.Point(34, 270);
            this.lblscience.Name = "lblscience";
            this.lblscience.Size = new System.Drawing.Size(62, 21);
            this.lblscience.TabIndex = 15;
            this.lblscience.Text = "Science";
            // 
            // txtscience
            // 
            this.txtscience.Location = new System.Drawing.Point(244, 262);
            this.txtscience.Name = "txtscience";
            this.txtscience.Size = new System.Drawing.Size(139, 29);
            this.txtscience.TabIndex = 14;
            // 
            // txtenglish
            // 
            this.txtenglish.Location = new System.Drawing.Point(244, 230);
            this.txtenglish.Name = "txtenglish";
            this.txtenglish.Size = new System.Drawing.Size(139, 29);
            this.txtenglish.TabIndex = 13;
            // 
            // txthistory
            // 
            this.txthistory.Location = new System.Drawing.Point(244, 195);
            this.txthistory.Name = "txthistory";
            this.txthistory.Size = new System.Drawing.Size(139, 29);
            this.txthistory.TabIndex = 12;
            // 
            // lblenglish
            // 
            this.lblenglish.AutoSize = true;
            this.lblenglish.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenglish.ForeColor = System.Drawing.Color.Black;
            this.lblenglish.Location = new System.Drawing.Point(36, 238);
            this.lblenglish.Name = "lblenglish";
            this.lblenglish.Size = new System.Drawing.Size(60, 21);
            this.lblenglish.TabIndex = 11;
            this.lblenglish.Text = "English";
            // 
            // lblhistory
            // 
            this.lblhistory.AutoSize = true;
            this.lblhistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhistory.ForeColor = System.Drawing.Color.Black;
            this.lblhistory.Location = new System.Drawing.Point(36, 203);
            this.lblhistory.Name = "lblhistory";
            this.lblhistory.Size = new System.Drawing.Size(60, 21);
            this.lblhistory.TabIndex = 10;
            this.lblhistory.Text = "History";
            // 
            // txtmaths
            // 
            this.txtmaths.Location = new System.Drawing.Point(244, 125);
            this.txtmaths.Name = "txtmaths";
            this.txtmaths.Size = new System.Drawing.Size(139, 29);
            this.txtmaths.TabIndex = 9;
            // 
            // txtsinhala
            // 
            this.txtsinhala.Location = new System.Drawing.Point(244, 90);
            this.txtsinhala.Name = "txtsinhala";
            this.txtsinhala.Size = new System.Drawing.Size(139, 29);
            this.txtsinhala.TabIndex = 8;
            // 
            // txtbuddhism
            // 
            this.txtbuddhism.Location = new System.Drawing.Point(244, 160);
            this.txtbuddhism.Name = "txtbuddhism";
            this.txtbuddhism.Size = new System.Drawing.Size(139, 29);
            this.txtbuddhism.TabIndex = 7;
            // 
            // lblbuddhism
            // 
            this.lblbuddhism.AutoSize = true;
            this.lblbuddhism.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuddhism.ForeColor = System.Drawing.Color.Black;
            this.lblbuddhism.Location = new System.Drawing.Point(36, 168);
            this.lblbuddhism.Name = "lblbuddhism";
            this.lblbuddhism.Size = new System.Drawing.Size(80, 21);
            this.lblbuddhism.TabIndex = 6;
            this.lblbuddhism.Text = "Buddhism";
            // 
            // lblmarks
            // 
            this.lblmarks.AutoSize = true;
            this.lblmarks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmarks.ForeColor = System.Drawing.Color.Green;
            this.lblmarks.Location = new System.Drawing.Point(282, 46);
            this.lblmarks.Name = "lblmarks";
            this.lblmarks.Size = new System.Drawing.Size(56, 21);
            this.lblmarks.TabIndex = 5;
            this.lblmarks.Text = "Marks";
            // 
            // lblmaths
            // 
            this.lblmaths.AutoSize = true;
            this.lblmaths.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaths.ForeColor = System.Drawing.Color.Black;
            this.lblmaths.Location = new System.Drawing.Point(36, 133);
            this.lblmaths.Name = "lblmaths";
            this.lblmaths.Size = new System.Drawing.Size(53, 21);
            this.lblmaths.TabIndex = 4;
            this.lblmaths.Text = "Maths";
            // 
            // lblsinhala
            // 
            this.lblsinhala.AutoSize = true;
            this.lblsinhala.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsinhala.ForeColor = System.Drawing.Color.Black;
            this.lblsinhala.Location = new System.Drawing.Point(36, 98);
            this.lblsinhala.Name = "lblsinhala";
            this.lblsinhala.Size = new System.Drawing.Size(61, 21);
            this.lblsinhala.TabIndex = 3;
            this.lblsinhala.Text = "Sinhala";
            // 
            // lblsubject
            // 
            this.lblsubject.AutoSize = true;
            this.lblsubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubject.ForeColor = System.Drawing.Color.Green;
            this.lblsubject.Location = new System.Drawing.Point(42, 46);
            this.lblsubject.Name = "lblsubject";
            this.lblsubject.Size = new System.Drawing.Size(74, 21);
            this.lblsubject.TabIndex = 2;
            this.lblsubject.Text = "Subjects";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txttypetheexamrolleno);
            this.panel2.Controls.Add(this.lblexamrolleno);
            this.panel2.Location = new System.Drawing.Point(743, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 91);
            this.panel2.TabIndex = 27;
            // 
            // txttypetheexamrolleno
            // 
            this.txttypetheexamrolleno.Location = new System.Drawing.Point(20, 59);
            this.txttypetheexamrolleno.Name = "txttypetheexamrolleno";
            this.txttypetheexamrolleno.Size = new System.Drawing.Size(188, 20);
            this.txttypetheexamrolleno.TabIndex = 23;
            // 
            // lblexamrolleno
            // 
            this.lblexamrolleno.AutoSize = true;
            this.lblexamrolleno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexamrolleno.Location = new System.Drawing.Point(30, 15);
            this.lblexamrolleno.Name = "lblexamrolleno";
            this.lblexamrolleno.Size = new System.Drawing.Size(169, 21);
            this.lblexamrolleno.TabIndex = 2;
            this.lblexamrolleno.Text = "Type the Exam Role No";
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(1037, 269);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(95, 41);
            this.btnsearch.TabIndex = 30;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(724, 347);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(418, 325);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FormMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 684);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnexporttoexcel);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMarks";
            this.Text = "MARKS";
            this.Load += new System.EventHandler(this.FormMarks_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblexamtype;
        private System.Windows.Forms.Label lblexamyear;
        private System.Windows.Forms.Label lblexamroleno;
        private System.Windows.Forms.Label lblstudentname;
        private System.Windows.Forms.Label lblstudentno;
        private System.Windows.Forms.ComboBox cmbexamtype;
        private System.Windows.Forms.ComboBox cmbexamyear;
        private System.Windows.Forms.TextBox txtexamroleno;
        private System.Windows.Forms.TextBox txtstudentname;
        private System.Windows.Forms.TextBox txtstudentno;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtmaths;
        private System.Windows.Forms.TextBox txtsinhala;
        private System.Windows.Forms.TextBox txtbuddhism;
        private System.Windows.Forms.Label lblbuddhism;
        private System.Windows.Forms.Label lblmarks;
        private System.Windows.Forms.Label lblmaths;
        private System.Windows.Forms.Label lblsinhala;
        private System.Windows.Forms.Label lblsubject;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnexporttoexcel;
        private System.Windows.Forms.Label lblict;
        private System.Windows.Forms.Label lblenglishliterary;
        private System.Windows.Forms.Label lblgeography;
        private System.Windows.Forms.TextBox txtict;
        private System.Windows.Forms.TextBox txtenglishliterary;
        private System.Windows.Forms.TextBox txtgeography;
        private System.Windows.Forms.Label lblscience;
        private System.Windows.Forms.TextBox txtscience;
        private System.Windows.Forms.TextBox txtenglish;
        private System.Windows.Forms.TextBox txthistory;
        private System.Windows.Forms.Label lblenglish;
        private System.Windows.Forms.Label lblhistory;
        private System.Windows.Forms.TextBox txtrank;
        private System.Windows.Forms.TextBox txtaverage;
        private System.Windows.Forms.TextBox txttotalscore;
        private System.Windows.Forms.Label lblrank;
        private System.Windows.Forms.Label lblaverage;
        private System.Windows.Forms.Label lbltotalscore;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txttypetheexamrolleno;
        private System.Windows.Forms.Label lblexamrolleno;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}