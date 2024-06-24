using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Net.NetworkInformation;

namespace Projet_prev
{
    public partial class Gestionfrm : Form
    {
        public Gestionfrm()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
           
            if (this.panelmain.Controls.Count > 0)
                this.panelmain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelmain.Controls.Add(f);
            this.panelmain.Tag = f;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void job_btn_Click(object sender, EventArgs e)
        {
            panelhead.BackColor = Color.DarkGreen;
            panelside.BackColor = Color.DarkGreen;
            board_btn.BackColor = Color.DarkGreen;
            emp_btn.BackColor = Color.DarkGreen;
            job_btn.BackColor = Color.DarkGreen;
            loc_btn.BackColor = Color.DarkGreen;
            dep_btn.BackColor = Color.DarkGreen;
            button1.BackColor = Color.DarkGreen;
            loadform(new job_frm());
        }

        private void dep_btn_Click(object sender, EventArgs e)
        {
            panelhead.BackColor = Color.DarkRed;
            panelside.BackColor = Color.DarkRed;
            board_btn.BackColor = Color.DarkRed;
            emp_btn.BackColor = Color.DarkRed;
            job_btn.BackColor = Color.DarkRed;
            loc_btn.BackColor = Color.DarkRed;
            dep_btn.BackColor = Color.DarkRed;
            button1.BackColor = Color.DarkRed;
            loadform(new Departments());
        }

        private void loc_btn_Click(object sender, EventArgs e)
        {
            panelhead.BackColor = Color.DarkGoldenrod;
            panelside.BackColor = Color.DarkGoldenrod;
            board_btn.BackColor = Color.DarkGoldenrod;
            emp_btn.BackColor = Color.DarkGoldenrod;
            job_btn.BackColor = Color.DarkGoldenrod;
            loc_btn.BackColor = Color.DarkGoldenrod;
            dep_btn.BackColor = Color.DarkGoldenrod;
            button1.BackColor = Color.DarkGoldenrod;
            loadform(new locfrm());
        }

        private void Gestionfrm_Load(object sender, EventArgs e)
        {

            loadform(new interfrm());



        }

        private void emp_btn_Click(object sender, EventArgs e)
        {
            panelhead.BackColor = Color.DarkMagenta;
            panelside.BackColor = Color.DarkMagenta;
            board_btn.BackColor = Color.DarkMagenta;
            emp_btn.BackColor = Color.DarkMagenta;
            job_btn.BackColor = Color.DarkMagenta;
            loc_btn.BackColor = Color.DarkMagenta;
            dep_btn.BackColor = Color.DarkMagenta;
            button1.BackColor = Color.DarkMagenta;
            loadform(new Emp_frm());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loadform(new interfrm());
        }

        private void board_btn_Click(object sender, EventArgs e)
        {
            loadform(new dashfrm());
        }
    }
}
