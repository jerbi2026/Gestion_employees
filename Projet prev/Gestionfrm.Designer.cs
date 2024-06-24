namespace Projet_prev
{
    partial class Gestionfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestionfrm));
            this.panelside = new System.Windows.Forms.Panel();
            this.panelhead = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelmain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loc_btn = new System.Windows.Forms.Button();
            this.board_btn = new System.Windows.Forms.Button();
            this.dep_btn = new System.Windows.Forms.Button();
            this.emp_btn = new System.Windows.Forms.Button();
            this.job_btn = new System.Windows.Forms.Button();
            this.panelside.SuspendLayout();
            this.panelhead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelside
            // 
            this.panelside.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelside.Controls.Add(this.pictureBox1);
            this.panelside.Controls.Add(this.loc_btn);
            this.panelside.Controls.Add(this.board_btn);
            this.panelside.Controls.Add(this.dep_btn);
            this.panelside.Controls.Add(this.emp_btn);
            this.panelside.Controls.Add(this.job_btn);
            this.panelside.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelside.Location = new System.Drawing.Point(0, 0);
            this.panelside.Name = "panelside";
            this.panelside.Size = new System.Drawing.Size(250, 646);
            this.panelside.TabIndex = 0;
            // 
            // panelhead
            // 
            this.panelhead.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelhead.Controls.Add(this.button1);
            this.panelhead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelhead.Location = new System.Drawing.Point(250, 0);
            this.panelhead.Name = "panelhead";
            this.panelhead.Size = new System.Drawing.Size(890, 30);
            this.panelhead.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(860, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelmain
            // 
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.Location = new System.Drawing.Point(250, 30);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(890, 616);
            this.panelmain.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projet_prev.Properties.Resources.office_ConvertImage;
            this.pictureBox1.Location = new System.Drawing.Point(58, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // loc_btn
            // 
            this.loc_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.loc_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loc_btn.FlatAppearance.BorderSize = 0;
            this.loc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loc_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loc_btn.ForeColor = System.Drawing.Color.White;
            this.loc_btn.Image = global::Projet_prev.Properties.Resources.location_ConvertImage;
            this.loc_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loc_btn.Location = new System.Drawing.Point(-3, 385);
            this.loc_btn.Name = "loc_btn";
            this.loc_btn.Size = new System.Drawing.Size(250, 50);
            this.loc_btn.TabIndex = 5;
            this.loc_btn.Text = "  LOCATIONS";
            this.loc_btn.UseVisualStyleBackColor = false;
            this.loc_btn.Click += new System.EventHandler(this.loc_btn_Click);
            // 
            // board_btn
            // 
            this.board_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.board_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.board_btn.FlatAppearance.BorderSize = 0;
            this.board_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.board_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.board_btn.ForeColor = System.Drawing.Color.White;
            this.board_btn.Image = global::Projet_prev.Properties.Resources.dashboard_ConvertImage;
            this.board_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.board_btn.Location = new System.Drawing.Point(0, 201);
            this.board_btn.Name = "board_btn";
            this.board_btn.Size = new System.Drawing.Size(250, 50);
            this.board_btn.TabIndex = 1;
            this.board_btn.Text = "   DASHBOARD";
            this.board_btn.UseVisualStyleBackColor = false;
            this.board_btn.Click += new System.EventHandler(this.board_btn_Click);
            // 
            // dep_btn
            // 
            this.dep_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.dep_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dep_btn.FlatAppearance.BorderSize = 0;
            this.dep_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dep_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dep_btn.ForeColor = System.Drawing.Color.White;
            this.dep_btn.Image = global::Projet_prev.Properties.Resources.department_ConvertImage;
            this.dep_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dep_btn.Location = new System.Drawing.Point(0, 293);
            this.dep_btn.Name = "dep_btn";
            this.dep_btn.Size = new System.Drawing.Size(250, 50);
            this.dep_btn.TabIndex = 4;
            this.dep_btn.Text = "    DEPARTMENTS";
            this.dep_btn.UseVisualStyleBackColor = false;
            this.dep_btn.Click += new System.EventHandler(this.dep_btn_Click);
            // 
            // emp_btn
            // 
            this.emp_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.emp_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emp_btn.FlatAppearance.BorderSize = 0;
            this.emp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emp_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_btn.ForeColor = System.Drawing.Color.White;
            this.emp_btn.Image = global::Projet_prev.Properties.Resources.businessman_ConvertImage;
            this.emp_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emp_btn.Location = new System.Drawing.Point(0, 247);
            this.emp_btn.Name = "emp_btn";
            this.emp_btn.Size = new System.Drawing.Size(250, 50);
            this.emp_btn.TabIndex = 2;
            this.emp_btn.Text = "  EMPLOYEE";
            this.emp_btn.UseVisualStyleBackColor = false;
            this.emp_btn.Click += new System.EventHandler(this.emp_btn_Click);
            // 
            // job_btn
            // 
            this.job_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.job_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.job_btn.FlatAppearance.BorderSize = 0;
            this.job_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.job_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job_btn.ForeColor = System.Drawing.Color.White;
            this.job_btn.Image = global::Projet_prev.Properties.Resources.suitcase_ConvertImage;
            this.job_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.job_btn.Location = new System.Drawing.Point(0, 339);
            this.job_btn.Name = "job_btn";
            this.job_btn.Size = new System.Drawing.Size(250, 50);
            this.job_btn.TabIndex = 3;
            this.job_btn.Text = "JOBS";
            this.job_btn.UseVisualStyleBackColor = false;
            this.job_btn.Click += new System.EventHandler(this.job_btn_Click);
            // 
            // Gestionfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1140, 646);
            this.Controls.Add(this.panelmain);
            this.Controls.Add(this.panelhead);
            this.Controls.Add(this.panelside);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gestionfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionfrm";
            this.Load += new System.EventHandler(this.Gestionfrm_Load);
            this.panelside.ResumeLayout(false);
            this.panelhead.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelside;
        private System.Windows.Forms.Panel panelhead;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelmain;
        private System.Windows.Forms.Button board_btn;
        private System.Windows.Forms.Button loc_btn;
        private System.Windows.Forms.Button dep_btn;
        private System.Windows.Forms.Button emp_btn;
        private System.Windows.Forms.Button job_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}