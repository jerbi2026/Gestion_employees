using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_prev
{
    public partial class interfrm : Form
    {
        public interfrm()
        {
            InitializeComponent();
        }

        private void interfrm_Load(object sender, EventArgs e)
        {
            SqlConnection ma_connexion;
            ma_connexion = new SqlConnection("Data Source=JERBI ;Initial Catalog =RH;User ID = jerbi; Password=12345678;");
            ma_connexion.Open();
            string sql2 = "SELECT COUNT(*) FROM EMPLOYEES;";
            SqlCommand cmd = new SqlCommand(sql2, ma_connexion);


            int count = (int)cmd.ExecuteScalar();


            label1.Text = "Nombre d'employés : " + count.ToString();

            string sql3 = "SELECT COUNT(*) FROM Locations;";
            SqlCommand cmd3 = new SqlCommand(sql3, ma_connexion);


            int count2 = (int)cmd3.ExecuteScalar();


            label2.Text = "Nombre de Location : " + count2.ToString();

            string sql4 = "SELECT COUNT(*) FROM Jobs;";
            SqlCommand cmd4 = new SqlCommand(sql4, ma_connexion);


            int count4 = (int)cmd4.ExecuteScalar();


            label4.Text = "Nombre d'emplois : " + count4.ToString();

            string sql5 = "SELECT COUNT(*) FROM Departments;";
            SqlCommand cmd5 = new SqlCommand(sql5, ma_connexion);


            int count5 = (int)cmd5.ExecuteScalar();

            label3.Text = "Nombre de departements : " + count5.ToString();

        }
    }
}
