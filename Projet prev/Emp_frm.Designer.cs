namespace Projet_prev
{
    partial class Emp_frm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emp_frm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.eMPLOYEESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rHDataSet4 = new Projet_prev.RHDataSet4();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.dep_txt = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.job_txt = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.first_txt = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.last_txt = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.annul_btn = new System.Windows.Forms.Button();
            this.new_btn = new System.Windows.Forms.Button();
            this.undo_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.val_btn = new System.Windows.Forms.Button();
            this.up_btn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.key_txt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cherche_btn = new System.Windows.Forms.Button();
            this.cherche_txt = new System.Windows.Forms.TextBox();
            this.eMPLOYEESTableAdapter = new Projet_prev.RHDataSet4TableAdapters.EMPLOYEESTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rHDataSet4)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(470, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 616);
            this.panel1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.DarkMagenta;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.DataSource = this.eMPLOYEESBindingSource;
            this.listBox1.DisplayMember = "First_name";
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(257, 616);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "Last_name";
            // 
            // eMPLOYEESBindingSource
            // 
            this.eMPLOYEESBindingSource.DataMember = "EMPLOYEES";
            this.eMPLOYEESBindingSource.DataSource = this.rHDataSet4;
            // 
            // rHDataSet4
            // 
            this.rHDataSet4.DataSetName = "RHDataSet4";
            this.rHDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 616);
            this.panel2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.DarkMagenta;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.DarkMagenta;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEESBindingSource, "Hire_date", true));
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 231);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(376, 31);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel9.Controls.Add(this.pictureBox5);
            this.panel9.Controls.Add(this.dep_txt);
            this.panel9.ForeColor = System.Drawing.Color.Black;
            this.panel9.Location = new System.Drawing.Point(20, 316);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(376, 37);
            this.panel9.TabIndex = 32;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox5.Image = global::Projet_prev.Properties.Resources.department_ConvertImage;
            this.pictureBox5.Location = new System.Drawing.Point(3, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(26, 26);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // dep_txt
            // 
            this.dep_txt.BackColor = System.Drawing.Color.DarkMagenta;
            this.dep_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dep_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEESBindingSource, "Department_id", true));
            this.dep_txt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dep_txt.ForeColor = System.Drawing.Color.White;
            this.dep_txt.Location = new System.Drawing.Point(40, 3);
            this.dep_txt.Name = "dep_txt";
            this.dep_txt.Size = new System.Drawing.Size(330, 24);
            this.dep_txt.TabIndex = 1;
            this.dep_txt.Click += new System.EventHandler(this.dep_txt_Click);
            this.dep_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dep_txt_KeyPress);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel10.Controls.Add(this.pictureBox6);
            this.panel10.Controls.Add(this.job_txt);
            this.panel10.ForeColor = System.Drawing.Color.Black;
            this.panel10.Location = new System.Drawing.Point(20, 273);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(376, 37);
            this.panel10.TabIndex = 31;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox6.Image = global::Projet_prev.Properties.Resources.suitcase_ConvertImage;
            this.pictureBox6.Location = new System.Drawing.Point(3, 4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(26, 26);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // job_txt
            // 
            this.job_txt.BackColor = System.Drawing.Color.DarkMagenta;
            this.job_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.job_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEESBindingSource, "Job_id", true));
            this.job_txt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job_txt.ForeColor = System.Drawing.Color.White;
            this.job_txt.Location = new System.Drawing.Point(40, 4);
            this.job_txt.Name = "job_txt";
            this.job_txt.Size = new System.Drawing.Size(330, 24);
            this.job_txt.TabIndex = 0;
            this.job_txt.Click += new System.EventHandler(this.job_txt_Click);
            this.job_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.job_txt_KeyPress);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel6.Controls.Add(this.pictureBox4);
            this.panel6.Controls.Add(this.first_txt);
            this.panel6.ForeColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(20, 144);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(376, 37);
            this.panel6.TabIndex = 30;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Image = global::Projet_prev.Properties.Resources.man_ConvertImage;
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // first_txt
            // 
            this.first_txt.BackColor = System.Drawing.Color.DarkMagenta;
            this.first_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.first_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEESBindingSource, "First_name", true));
            this.first_txt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_txt.ForeColor = System.Drawing.Color.White;
            this.first_txt.Location = new System.Drawing.Point(40, 3);
            this.first_txt.Name = "first_txt";
            this.first_txt.Size = new System.Drawing.Size(330, 24);
            this.first_txt.TabIndex = 1;
            this.first_txt.Click += new System.EventHandler(this.first_txt_Click);
            this.first_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.first_txt_KeyPress);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel8.Controls.Add(this.pictureBox3);
            this.panel8.Controls.Add(this.last_txt);
            this.panel8.ForeColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(20, 187);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(376, 37);
            this.panel8.TabIndex = 31;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Image = global::Projet_prev.Properties.Resources.man_ConvertImage;
            this.pictureBox3.Location = new System.Drawing.Point(3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // last_txt
            // 
            this.last_txt.BackColor = System.Drawing.Color.DarkMagenta;
            this.last_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.last_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEESBindingSource, "Last_name", true));
            this.last_txt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_txt.ForeColor = System.Drawing.Color.White;
            this.last_txt.Location = new System.Drawing.Point(40, 4);
            this.last_txt.Name = "last_txt";
            this.last_txt.Size = new System.Drawing.Size(330, 24);
            this.last_txt.TabIndex = 0;
            this.last_txt.Click += new System.EventHandler(this.last_txt_Click);
            this.last_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.last_txt_KeyPress);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.annul_btn);
            this.panel5.Controls.Add(this.new_btn);
            this.panel5.Controls.Add(this.undo_btn);
            this.panel5.Controls.Add(this.del_btn);
            this.panel5.Controls.Add(this.val_btn);
            this.panel5.Controls.Add(this.up_btn);
            this.panel5.Location = new System.Drawing.Point(80, 349);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(213, 162);
            this.panel5.TabIndex = 31;
            // 
            // annul_btn
            // 
            this.annul_btn.BackColor = System.Drawing.Color.DarkMagenta;
            this.annul_btn.FlatAppearance.BorderSize = 0;
            this.annul_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.annul_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annul_btn.ForeColor = System.Drawing.Color.White;
            this.annul_btn.Location = new System.Drawing.Point(115, 112);
            this.annul_btn.Name = "annul_btn";
            this.annul_btn.Size = new System.Drawing.Size(95, 35);
            this.annul_btn.TabIndex = 19;
            this.annul_btn.Text = "ANNULER";
            this.annul_btn.UseVisualStyleBackColor = false;
            this.annul_btn.Click += new System.EventHandler(this.annul_btn_Click);
            // 
            // new_btn
            // 
            this.new_btn.BackColor = System.Drawing.Color.DarkMagenta;
            this.new_btn.FlatAppearance.BorderSize = 0;
            this.new_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_btn.ForeColor = System.Drawing.Color.White;
            this.new_btn.Location = new System.Drawing.Point(3, 30);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(95, 35);
            this.new_btn.TabIndex = 14;
            this.new_btn.Text = "NEW";
            this.new_btn.UseVisualStyleBackColor = false;
            this.new_btn.Click += new System.EventHandler(this.new_btn_Click);
            // 
            // undo_btn
            // 
            this.undo_btn.BackColor = System.Drawing.Color.DarkMagenta;
            this.undo_btn.FlatAppearance.BorderSize = 0;
            this.undo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undo_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undo_btn.ForeColor = System.Drawing.Color.White;
            this.undo_btn.Location = new System.Drawing.Point(3, 112);
            this.undo_btn.Name = "undo_btn";
            this.undo_btn.Size = new System.Drawing.Size(95, 35);
            this.undo_btn.TabIndex = 18;
            this.undo_btn.Text = "UNDO";
            this.undo_btn.UseVisualStyleBackColor = false;
            this.undo_btn.Click += new System.EventHandler(this.undo_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.Color.DarkMagenta;
            this.del_btn.FlatAppearance.BorderSize = 0;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_btn.ForeColor = System.Drawing.Color.White;
            this.del_btn.Location = new System.Drawing.Point(116, 30);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(95, 35);
            this.del_btn.TabIndex = 15;
            this.del_btn.Text = "DELETE";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // val_btn
            // 
            this.val_btn.BackColor = System.Drawing.Color.DarkMagenta;
            this.val_btn.FlatAppearance.BorderSize = 0;
            this.val_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.val_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val_btn.ForeColor = System.Drawing.Color.White;
            this.val_btn.Location = new System.Drawing.Point(116, 71);
            this.val_btn.Name = "val_btn";
            this.val_btn.Size = new System.Drawing.Size(95, 35);
            this.val_btn.TabIndex = 17;
            this.val_btn.Text = "VALIDATE";
            this.val_btn.UseVisualStyleBackColor = false;
            this.val_btn.Click += new System.EventHandler(this.val_btn_Click);
            // 
            // up_btn
            // 
            this.up_btn.BackColor = System.Drawing.Color.DarkMagenta;
            this.up_btn.FlatAppearance.BorderSize = 0;
            this.up_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.up_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up_btn.ForeColor = System.Drawing.Color.White;
            this.up_btn.Location = new System.Drawing.Point(3, 71);
            this.up_btn.Name = "up_btn";
            this.up_btn.Size = new System.Drawing.Size(95, 35);
            this.up_btn.TabIndex = 16;
            this.up_btn.Text = "UPDATE";
            this.up_btn.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.key_txt);
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(20, 101);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(376, 37);
            this.panel4.TabIndex = 29;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::Projet_prev.Properties.Resources.cle_ConvertImage;
            this.pictureBox2.Location = new System.Drawing.Point(3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // key_txt
            // 
            this.key_txt.BackColor = System.Drawing.Color.DarkMagenta;
            this.key_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.key_txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEESBindingSource, "Employee_id", true));
            this.key_txt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key_txt.ForeColor = System.Drawing.Color.White;
            this.key_txt.Location = new System.Drawing.Point(40, 4);
            this.key_txt.Name = "key_txt";
            this.key_txt.Size = new System.Drawing.Size(330, 24);
            this.key_txt.TabIndex = 0;
            this.key_txt.Click += new System.EventHandler(this.key_txt_Click);
            this.key_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_txt_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel3.Controls.Add(this.cherche_btn);
            this.panel3.Controls.Add(this.cherche_txt);
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(20, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(376, 37);
            this.panel3.TabIndex = 32;
            // 
            // cherche_btn
            // 
            this.cherche_btn.Image = global::Projet_prev.Properties.Resources.chercher_ConvertImage;
            this.cherche_btn.Location = new System.Drawing.Point(333, 0);
            this.cherche_btn.Name = "cherche_btn";
            this.cherche_btn.Size = new System.Drawing.Size(43, 37);
            this.cherche_btn.TabIndex = 5;
            this.cherche_btn.Text = ".";
            this.cherche_btn.UseVisualStyleBackColor = true;
            this.cherche_btn.Click += new System.EventHandler(this.cherche_btn_Click);
            // 
            // cherche_txt
            // 
            this.cherche_txt.BackColor = System.Drawing.Color.DarkMagenta;
            this.cherche_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cherche_txt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cherche_txt.ForeColor = System.Drawing.Color.White;
            this.cherche_txt.Location = new System.Drawing.Point(3, 4);
            this.cherche_txt.Name = "cherche_txt";
            this.cherche_txt.Size = new System.Drawing.Size(324, 24);
            this.cherche_txt.TabIndex = 0;
            this.cherche_txt.Click += new System.EventHandler(this.cherche_txt_Click);
            // 
            // eMPLOYEESTableAdapter
            // 
            this.eMPLOYEESTableAdapter.ClearBeforeFill = true;
            // 
            // Emp_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(727, 616);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Emp_frm";
            this.Text = "Emp_frm";
            this.Load += new System.EventHandler(this.Emp_frm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rHDataSet4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private RHDataSet4 rHDataSet4;
        private System.Windows.Forms.BindingSource eMPLOYEESBindingSource;
        private RHDataSet4TableAdapters.EMPLOYEESTableAdapter eMPLOYEESTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox dep_txt;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox job_txt;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox first_txt;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox last_txt;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button annul_btn;
        private System.Windows.Forms.Button new_btn;
        private System.Windows.Forms.Button undo_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button val_btn;
        private System.Windows.Forms.Button up_btn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox key_txt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button cherche_btn;
        private System.Windows.Forms.TextBox cherche_txt;
        private System.Windows.Forms.ListBox listBox1;
    }
}