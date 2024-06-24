using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_prev
{
    public partial class dashfrm : Form
    {
        public dashfrm()
        {
            InitializeComponent();
        }

        private void dashfrm_Load(object sender, EventArgs e)
        {
            chart1.Titles.Add("titre 1").Text = "NOMBRE D'EMPLOYES PAR METIER";
            chart1.Titles[0].ForeColor = Color.MidnightBlue;

            chart1.Series[0].Points.AddXY("AD PRES", 3);
            chart1.Series[0].Points.AddXY("VP", 8);
            chart1.Series[0].Points.AddXY("FI ACC", 5);
            chart1.Series[0].Points.AddXY("FI MGR", 1);
            chart1.Series[0].Points.AddXY("SA MAN", 5);
            chart1.Series[0].Points.AddXY("SA REP", 6);
            chart1.Series[0].Points.AddXY("AD ASST", 8);

            chart1.Series[0].IsValueShownAsLabel = true;
            chart1.Series[0].LegendText = "NOMBRE D'EMPLOYES";

           
            chart1.Series[0].Label="#PERCENT" ;


            




        }
    }
}
