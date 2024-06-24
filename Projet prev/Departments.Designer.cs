namespace Projet_prev
{
    partial class Departments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departments));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cherche_btn = new System.Windows.Forms.Button();
            this.cherche_txt = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.annul_btn = new System.Windows.Forms.Button();
            this.new_btn = new System.Windows.Forms.Button();
            this.undo_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.val_btn = new System.Windows.Forms.Button();
            this.up_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title_txt = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.key_txt = new System.Windows.Forms.TextBox();
            this.previous_btn = new System.Windows.Forms.Button();
            this.next_btn = new System.Windows.Forms.Button();
            this.last_btn = new System.Windows.Forms.Button();
            this.first_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.departmentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rHDataSet2 = new Projet_prev.RHDataSet2();
            this.departmentsTableAdapter = new Projet_prev.RHDataSet2TableAdapters.DepartmentsTableAdapter();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.loc_txt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rHDataSet2)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.cherche_btn);
            this.panel1.Controls.Add(this.cherche_txt);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(44, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 37);
            this.panel1.TabIndex = 28;
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
            this.cherche_txt.BackColor = System.Drawing.Color.DarkRed;
            this.cherche_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cherche_txt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cherche_txt.ForeColor = System.Drawing.Color.White;
            this.cherche_txt.Location = new System.Drawing.Point(3, 4);
            this.cherche_txt.Name = "cherche_txt";
            this.cherche_txt.Size = new System.Drawing.Size(324, 24);
            this.cherche_txt.TabIndex = 0;
            this.cherche_txt.Click += new System.EventHandler(this.cherche_txt_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.annul_btn);
            this.panel5.Controls.Add(this.new_btn);
            this.panel5.Controls.Add(this.undo_btn);
            this.panel5.Controls.Add(this.del_btn);
            this.panel5.Controls.Add(this.val_btn);
            this.panel5.Controls.Add(this.up_btn);
            this.panel5.Location = new System.Drawing.Point(439, 55);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(213, 162);
            this.panel5.TabIndex = 27;
            // 
            // annul_btn
            // 
            this.annul_btn.BackColor = System.Drawing.Color.DarkRed;
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
            this.new_btn.BackColor = System.Drawing.Color.DarkRed;
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
            this.undo_btn.BackColor = System.Drawing.Color.DarkRed;
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
            this.del_btn.BackColor = System.Drawing.Color.DarkRed;
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
            this.val_btn.BackColor = System.Drawing.Color.DarkRed;
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
            this.up_btn.BackColor = System.Drawing.Color.DarkRed;
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
            this.up_btn.Click += new System.EventHandler(this.up_btn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkRed;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.title_txt);
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(44, 223);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(376, 37);
            this.panel3.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Projet_prev.Properties.Resources.department_ConvertImage;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // title_txt
            // 
            this.title_txt.BackColor = System.Drawing.Color.DarkRed;
            this.title_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title_txt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_txt.ForeColor = System.Drawing.Color.White;
            this.title_txt.Location = new System.Drawing.Point(40, 3);
            this.title_txt.Name = "title_txt";
            this.title_txt.Size = new System.Drawing.Size(330, 24);
            this.title_txt.TabIndex = 1;
            this.title_txt.Click += new System.EventHandler(this.title_txt_Click);
            this.title_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.title_txt_KeyPress);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkRed;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.key_txt);
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(44, 180);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(376, 37);
            this.panel4.TabIndex = 25;
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
            this.key_txt.BackColor = System.Drawing.Color.DarkRed;
            this.key_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.key_txt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key_txt.ForeColor = System.Drawing.Color.White;
            this.key_txt.Location = new System.Drawing.Point(40, 4);
            this.key_txt.Name = "key_txt";
            this.key_txt.Size = new System.Drawing.Size(330, 24);
            this.key_txt.TabIndex = 0;
            this.key_txt.Click += new System.EventHandler(this.key_txt_Click);
            this.key_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_txt_KeyPress);
            // 
            // previous_btn
            // 
            this.previous_btn.FlatAppearance.BorderSize = 0;
            this.previous_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previous_btn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previous_btn.ForeColor = System.Drawing.Color.DarkRed;
            this.previous_btn.Location = new System.Drawing.Point(287, 3);
            this.previous_btn.Name = "previous_btn";
            this.previous_btn.Size = new System.Drawing.Size(75, 35);
            this.previous_btn.TabIndex = 24;
            this.previous_btn.Text = "PREVIOUS";
            this.previous_btn.UseVisualStyleBackColor = true;
            this.previous_btn.Click += new System.EventHandler(this.previous_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.FlatAppearance.BorderSize = 0;
            this.next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_btn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_btn.ForeColor = System.Drawing.Color.DarkRed;
            this.next_btn.Location = new System.Drawing.Point(206, 3);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(75, 35);
            this.next_btn.TabIndex = 23;
            this.next_btn.Text = "NEXT";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // last_btn
            // 
            this.last_btn.FlatAppearance.BorderSize = 0;
            this.last_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.last_btn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_btn.ForeColor = System.Drawing.Color.DarkRed;
            this.last_btn.Location = new System.Drawing.Point(125, 3);
            this.last_btn.Name = "last_btn";
            this.last_btn.Size = new System.Drawing.Size(75, 35);
            this.last_btn.TabIndex = 22;
            this.last_btn.Text = "LAST";
            this.last_btn.UseVisualStyleBackColor = true;
            this.last_btn.Click += new System.EventHandler(this.last_btn_Click);
            // 
            // first_btn
            // 
            this.first_btn.FlatAppearance.BorderSize = 0;
            this.first_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.first_btn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_btn.ForeColor = System.Drawing.Color.DarkRed;
            this.first_btn.Location = new System.Drawing.Point(44, 3);
            this.first_btn.Name = "first_btn";
            this.first_btn.Size = new System.Drawing.Size(75, 35);
            this.first_btn.TabIndex = 21;
            this.first_btn.Text = "FIRST";
            this.first_btn.UseVisualStyleBackColor = true;
            this.first_btn.Click += new System.EventHandler(this.first_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.last_btn);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.first_btn);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.next_btn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.previous_btn);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(727, 322);
            this.panel2.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmentidDataGridViewTextBoxColumn,
            this.departmentnameDataGridViewTextBoxColumn,
            this.locationidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.departmentsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(727, 294);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // departmentidDataGridViewTextBoxColumn
            // 
            this.departmentidDataGridViewTextBoxColumn.DataPropertyName = "Department_id";
            this.departmentidDataGridViewTextBoxColumn.HeaderText = "Department_id";
            this.departmentidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentidDataGridViewTextBoxColumn.Name = "departmentidDataGridViewTextBoxColumn";
            // 
            // departmentnameDataGridViewTextBoxColumn
            // 
            this.departmentnameDataGridViewTextBoxColumn.DataPropertyName = "Department_name";
            this.departmentnameDataGridViewTextBoxColumn.HeaderText = "Department_name";
            this.departmentnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentnameDataGridViewTextBoxColumn.Name = "departmentnameDataGridViewTextBoxColumn";
            // 
            // locationidDataGridViewTextBoxColumn
            // 
            this.locationidDataGridViewTextBoxColumn.DataPropertyName = "Location_id";
            this.locationidDataGridViewTextBoxColumn.HeaderText = "Location_id";
            this.locationidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationidDataGridViewTextBoxColumn.Name = "locationidDataGridViewTextBoxColumn";
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.rHDataSet2;
            // 
            // rHDataSet2
            // 
            this.rHDataSet2.DataSetName = "RHDataSet2";
            this.rHDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkRed;
            this.panel6.Controls.Add(this.pictureBox4);
            this.panel6.Controls.Add(this.loc_txt);
            this.panel6.ForeColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(44, 266);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(376, 37);
            this.panel6.TabIndex = 27;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Image = global::Projet_prev.Properties.Resources.location_ConvertImage;
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // loc_txt
            // 
            this.loc_txt.BackColor = System.Drawing.Color.DarkRed;
            this.loc_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loc_txt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loc_txt.ForeColor = System.Drawing.Color.White;
            this.loc_txt.Location = new System.Drawing.Point(40, 3);
            this.loc_txt.Name = "loc_txt";
            this.loc_txt.Size = new System.Drawing.Size(330, 24);
            this.loc_txt.TabIndex = 1;
            this.loc_txt.Click += new System.EventHandler(this.loc_txt_Click);
            this.loc_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loc_txt_KeyPress);
            // 
            // Departments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(727, 616);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Departments";
            this.Text = "Departments";
            this.Load += new System.EventHandler(this.Departments_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rHDataSet2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cherche_btn;
        private System.Windows.Forms.TextBox cherche_txt;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button annul_btn;
        private System.Windows.Forms.Button new_btn;
        private System.Windows.Forms.Button undo_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button val_btn;
        private System.Windows.Forms.Button up_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox title_txt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox key_txt;
        private System.Windows.Forms.Button previous_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Button last_btn;
        private System.Windows.Forms.Button first_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RHDataSet2 rHDataSet2;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private RHDataSet2TableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox loc_txt;
    }
}