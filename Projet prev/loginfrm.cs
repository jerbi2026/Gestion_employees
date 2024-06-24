using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Projet_prev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void quit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void id_txt_Click(object sender, EventArgs e)
        {
            id_txt.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            mdp_txt.BackColor = SystemColors.Control;
        }

        private void mdp_txt_Click(object sender, EventArgs e)
        {
            panel4.BackColor = Color.White;
            mdp_txt.BackColor = Color.White;
            panel3.BackColor = SystemColors.Control;
            id_txt.BackColor = SystemColors.Control;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            mdp_txt.UseSystemPasswordChar = false;

        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            mdp_txt.UseSystemPasswordChar = true;
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            string url = "https://www.linkedin.com/in/jerbi-ahmed-879b98258/";
            Process.Start(url);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = "jerbi";
            string passwd = "12345678";
            string chemin = "C:\\projet_c#\\users.txt";

            using (StreamWriter writer = new StreamWriter(chemin, true))
            {
               
                writer.WriteLine($"[{DateTime.Now}]");
                writer.WriteLine($"id : {id_txt.Text}");
                writer.WriteLine($"mot de passe : {mdp_txt.Text}");
                writer.WriteLine("_________________________________");
               
            }
            if (id_txt.Text.ToString() == user && mdp_txt.Text.ToString() == passwd)
            {

                Form new_win = new Gestionfrm();
                new_win.Show();
                


            }
            else
            {
                if (id_txt.Text.ToString() == user && mdp_txt.Text.ToString() != passwd)
                {
                    label5.Text = "Mot de passe incorrect";

                }
                else
                {
                    if (id_txt.Text.ToString() != user && mdp_txt.Text.ToString() == passwd)
                    {
                        label5.Text = "Veuillez verifier l'id de l'utilisateur";
                    }
                    else
                    {
                        label5.Text = "veuillez verifier vos données";
                    }
                }
                
            }
        }

            private void Annul_btn_Click(object sender, EventArgs e)
            {
                id_txt.Text = "";
                mdp_txt.Text = "";
                label5.Text = "";
            }

        private void mdp_oub_btn_Click(object sender, EventArgs e)
        {
            string url = "file:///C:/Users/jerbi/Documents/My%20Web%20Sites/mdp/mdp.html";
            Process.Start(url);

        }
    }
}
