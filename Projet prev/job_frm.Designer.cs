namespace Projet_prev
{
    partial class job_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(job_frm));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jobidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobtitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rHDataSet = new Projet_prev.RHDataSet();
            this.jobsTableAdapter = new Projet_prev.RHDataSetTableAdapters.JobsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rHDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.previous_btn);
            this.panel2.Controls.Add(this.next_btn);
            this.panel2.Controls.Add(this.last_btn);
            this.panel2.Controls.Add(this.first_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 281);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(727, 335);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SpringGreen;
            this.panel1.Controls.Add(this.cherche_btn);
            this.panel1.Controls.Add(this.cherche_txt);
            this.panel1.Location = new System.Drawing.Point(28, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 37);
            this.panel1.TabIndex = 20;
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
            this.cherche_txt.BackColor = System.Drawing.Color.SpringGreen;
            this.cherche_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cherche_txt.Location = new System.Drawing.Point(45, 4);
            this.cherche_txt.Name = "cherche_txt";
            this.cherche_txt.Size = new System.Drawing.Size(282, 24);
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
            this.panel5.Location = new System.Drawing.Point(423, 77);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(213, 162);
            this.panel5.TabIndex = 19;
            // 
            // annul_btn
            // 
            this.annul_btn.BackColor = System.Drawing.Color.DarkGreen;
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
            this.new_btn.BackColor = System.Drawing.Color.DarkGreen;
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
            this.undo_btn.BackColor = System.Drawing.Color.DarkGreen;
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
            this.del_btn.BackColor = System.Drawing.Color.DarkGreen;
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
            this.val_btn.BackColor = System.Drawing.Color.DarkGreen;
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
            this.up_btn.BackColor = System.Drawing.Color.DarkGreen;
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
            this.panel3.BackColor = System.Drawing.Color.SpringGreen;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.title_txt);
            this.panel3.Location = new System.Drawing.Point(28, 245);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(376, 37);
            this.panel3.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Projet_prev.Properties.Resources.etiquette_de_prix_ConvertImage;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // title_txt
            // 
            this.title_txt.BackColor = System.Drawing.Color.SpringGreen;
            this.title_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title_txt.Location = new System.Drawing.Point(45, 3);
            this.title_txt.Name = "title_txt";
            this.title_txt.Size = new System.Drawing.Size(325, 24);
            this.title_txt.TabIndex = 1;
            this.title_txt.Click += new System.EventHandler(this.title_txt_Click);
            this.title_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.title_txt_KeyPress);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SpringGreen;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.key_txt);
            this.panel4.Location = new System.Drawing.Point(28, 202);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(376, 37);
            this.panel4.TabIndex = 12;
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
            this.key_txt.BackColor = System.Drawing.Color.SpringGreen;
            this.key_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.key_txt.Location = new System.Drawing.Point(45, 4);
            this.key_txt.Name = "key_txt";
            this.key_txt.Size = new System.Drawing.Size(325, 24);
            this.key_txt.TabIndex = 0;
            this.key_txt.Click += new System.EventHandler(this.key_txt_Click);
            this.key_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_txt_KeyPress);
            // 
            // previous_btn
            // 
            this.previous_btn.FlatAppearance.BorderSize = 0;
            this.previous_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previous_btn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previous_btn.ForeColor = System.Drawing.Color.DarkGreen;
            this.previous_btn.Location = new System.Drawing.Point(271, 25);
            this.previous_btn.Name = "previous_btn";
            this.previous_btn.Size = new System.Drawing.Size(75, 35);
            this.previous_btn.TabIndex = 11;
            this.previous_btn.Text = "PREVIOUS";
            this.previous_btn.UseVisualStyleBackColor = true;
            this.previous_btn.Click += new System.EventHandler(this.previous_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.FlatAppearance.BorderSize = 0;
            this.next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_btn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_btn.ForeColor = System.Drawing.Color.DarkGreen;
            this.next_btn.Location = new System.Drawing.Point(190, 25);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(75, 35);
            this.next_btn.TabIndex = 10;
            this.next_btn.Text = "NEXT";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // last_btn
            // 
            this.last_btn.FlatAppearance.BorderSize = 0;
            this.last_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.last_btn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_btn.ForeColor = System.Drawing.Color.DarkGreen;
            this.last_btn.Location = new System.Drawing.Point(109, 25);
            this.last_btn.Name = "last_btn";
            this.last_btn.Size = new System.Drawing.Size(75, 35);
            this.last_btn.TabIndex = 9;
            this.last_btn.Text = "LAST";
            this.last_btn.UseVisualStyleBackColor = true;
            this.last_btn.Click += new System.EventHandler(this.last_btn_Click);
            // 
            // first_btn
            // 
            this.first_btn.FlatAppearance.BorderSize = 0;
            this.first_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.first_btn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_btn.ForeColor = System.Drawing.Color.DarkGreen;
            this.first_btn.Location = new System.Drawing.Point(28, 25);
            this.first_btn.Name = "first_btn";
            this.first_btn.Size = new System.Drawing.Size(75, 35);
            this.first_btn.TabIndex = 8;
            this.first_btn.Text = "FIRST";
            this.first_btn.UseVisualStyleBackColor = true;
            this.first_btn.Click += new System.EventHandler(this.first_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobidDataGridViewTextBoxColumn,
            this.jobtitleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jobsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
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
            this.dataGridView1.Size = new System.Drawing.Size(727, 281);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // jobidDataGridViewTextBoxColumn
            // 
            this.jobidDataGridViewTextBoxColumn.DataPropertyName = "Job_id";
            this.jobidDataGridViewTextBoxColumn.HeaderText = "Job_id";
            this.jobidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jobidDataGridViewTextBoxColumn.Name = "jobidDataGridViewTextBoxColumn";
            // 
            // jobtitleDataGridViewTextBoxColumn
            // 
            this.jobtitleDataGridViewTextBoxColumn.DataPropertyName = "Job_title";
            this.jobtitleDataGridViewTextBoxColumn.HeaderText = "Job_title";
            this.jobtitleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jobtitleDataGridViewTextBoxColumn.Name = "jobtitleDataGridViewTextBoxColumn";
            // 
            // jobsBindingSource
            // 
            this.jobsBindingSource.DataMember = "Jobs";
            this.jobsBindingSource.DataSource = this.rHDataSet;
            // 
            // rHDataSet
            // 
            this.rHDataSet.DataSetName = "RHDataSet";
            this.rHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobsTableAdapter
            // 
            this.jobsTableAdapter.ClearBeforeFill = true;
            // 
            // job_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(727, 616);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "job_frm";
            this.Text = "job_frm";
            this.Load += new System.EventHandler(this.job_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rHDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private RHDataSet rHDataSet;
        private System.Windows.Forms.BindingSource jobsBindingSource;
        private RHDataSetTableAdapters.JobsTableAdapter jobsTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button undo_btn;
        private System.Windows.Forms.Button val_btn;
        private System.Windows.Forms.Button up_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button new_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox title_txt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox key_txt;
        private System.Windows.Forms.Button previous_btn;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Button last_btn;
        private System.Windows.Forms.Button first_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button annul_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox cherche_txt;
        private System.Windows.Forms.Button cherche_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobtitleDataGridViewTextBoxColumn;
    }
}