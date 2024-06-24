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
    public partial class Emp_frm : Form
    {
        public Emp_frm()
        {
            InitializeComponent();
        }

        private void Emp_frm_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'rHDataSet4.EMPLOYEES'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.eMPLOYEESTableAdapter.Fill(this.rHDataSet4.EMPLOYEES);

        }

        private void cherche_btn_Click(object sender, EventArgs e)
        {
            string searchString = cherche_txt.Text;

            int rowIndex = eMPLOYEESBindingSource.Find("Employee_id", searchString);
            if (rowIndex != -1)
            {
                listBox1.SelectedIndex = rowIndex;
                DataRowView rowView = (DataRowView)eMPLOYEESBindingSource[rowIndex];
                key_txt.Text = rowView["Employee_id"].ToString();
                first_txt.Text = rowView["First_name"].ToString();
                last_txt.Text = rowView["Last_name"].ToString();
                job_txt.Text = rowView["Job_id"].ToString();
                dep_txt.Text = rowView["Department_id"].ToString();
                dateTimePicker1.Text = rowView["Hire_date"].ToString();
            }
            else
            {
                MessageBox.Show("La chaîne saisie n'a pas été trouvée dans la source de données.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            try
            {
                
                DataRowView newRow = (DataRowView)eMPLOYEESBindingSource.AddNew();
                newRow["Employee_id"]=key_txt.Text ;
                newRow["First_name"] = first_txt.Text;
                newRow["Last_name"] = last_txt.Text;
                newRow["Job_id"] = job_txt.Text;
                newRow["Department_id"]= dep_txt.Text;
                newRow["Hire_date"]= dateTimePicker1.Text;
                eMPLOYEESBindingSource.EndEdit();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void undo_btn_Click(object sender, EventArgs e)
        {
            try
            {

                this.eMPLOYEESTableAdapter.Fill(this.rHDataSet4.EMPLOYEES);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            try
            {
                eMPLOYEESBindingSource.RemoveCurrent();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void val_btn_Click(object sender, EventArgs e)
        {
            try
            {

                this.Validate();
                this.eMPLOYEESBindingSource.EndEdit();
                this.eMPLOYEESTableAdapter.Update(rHDataSet4.EMPLOYEES);
                MessageBox.Show("la validation de données est faite", "CONGRATS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void annul_btn_Click(object sender, EventArgs e)
        {
            key_txt.Text ="";
            first_txt.Text = "";
            last_txt.Text = "";
            job_txt.Text = "";
            dep_txt.Text = "";
            listBox1.ClearSelected();
            panel4.BackColor = Color.DarkMagenta;
            key_txt.BackColor = Color.DarkMagenta;
            panel6.BackColor= Color.DarkMagenta;
            first_txt.BackColor= Color.DarkMagenta;
            panel8.BackColor= Color.DarkMagenta;
            last_txt.BackColor= Color.DarkMagenta;
            job_txt.BackColor= Color.DarkMagenta;
            panel10.BackColor= Color.DarkMagenta;
            dep_txt.BackColor= Color.DarkMagenta;
            panel9.BackColor= Color.DarkMagenta;
            cherche_txt.BackColor= Color.DarkMagenta;
            panel3.BackColor= Color.DarkMagenta;


        }

        private void cherche_txt_Click(object sender, EventArgs e)
        {
            panel4.BackColor = Color.DarkMagenta;
            key_txt.BackColor = Color.DarkMagenta;
            panel6.BackColor = Color.DarkMagenta;
            first_txt.BackColor = Color.DarkMagenta;
            panel8.BackColor = Color.DarkMagenta;
            last_txt.BackColor = Color.DarkMagenta;
            job_txt.BackColor = Color.DarkMagenta;
            panel10.BackColor = Color.DarkMagenta;
            dep_txt.BackColor = Color.DarkMagenta;
            panel9.BackColor = Color.DarkMagenta;
            cherche_txt.BackColor = Color.MediumOrchid;
            panel3.BackColor = Color.MediumOrchid;
        }

        private void key_txt_Click(object sender, EventArgs e)
        {
            panel4.BackColor = Color.MediumOrchid;
            key_txt.BackColor = Color.MediumOrchid;
            panel6.BackColor = Color.DarkMagenta;
            first_txt.BackColor = Color.DarkMagenta;
            panel8.BackColor = Color.DarkMagenta;
            last_txt.BackColor = Color.DarkMagenta;
            job_txt.BackColor = Color.DarkMagenta;
            panel10.BackColor = Color.DarkMagenta;
            dep_txt.BackColor = Color.DarkMagenta;
            panel9.BackColor = Color.DarkMagenta;
            cherche_txt.BackColor = Color.DarkMagenta;
            panel3.BackColor = Color.DarkMagenta;
        }

        private void first_txt_Click(object sender, EventArgs e)
        {
            panel4.BackColor = Color.DarkMagenta;
            key_txt.BackColor = Color.DarkMagenta;
            panel6.BackColor = Color.MediumOrchid;
            first_txt.BackColor = Color.MediumOrchid;
            panel8.BackColor = Color.DarkMagenta;
            last_txt.BackColor = Color.DarkMagenta;
            job_txt.BackColor = Color.DarkMagenta;
            panel10.BackColor = Color.DarkMagenta;
            dep_txt.BackColor = Color.DarkMagenta;
            panel9.BackColor = Color.DarkMagenta;
            cherche_txt.BackColor = Color.DarkMagenta;
            panel3.BackColor = Color.DarkMagenta;
        }

        private void last_txt_Click(object sender, EventArgs e)
        {
            panel4.BackColor = Color.DarkMagenta;
            key_txt.BackColor = Color.DarkMagenta;
            panel6.BackColor = Color.DarkMagenta;
            first_txt.BackColor = Color.DarkMagenta;
            panel8.BackColor = Color.MediumOrchid;
            last_txt.BackColor = Color.MediumOrchid;
            job_txt.BackColor = Color.DarkMagenta;
            panel10.BackColor = Color.DarkMagenta;
            dep_txt.BackColor = Color.DarkMagenta;
            panel9.BackColor = Color.DarkMagenta;
            cherche_txt.BackColor = Color.DarkMagenta;
            panel3.BackColor = Color.DarkMagenta;
        }

        private void job_txt_Click(object sender, EventArgs e)
        {
            panel4.BackColor = Color.DarkMagenta;
            key_txt.BackColor = Color.DarkMagenta;
            panel6.BackColor = Color.DarkMagenta;
            first_txt.BackColor = Color.DarkMagenta;
            panel8.BackColor = Color.DarkMagenta;
            last_txt.BackColor = Color.DarkMagenta;
            job_txt.BackColor = Color.MediumOrchid;
            panel10.BackColor = Color.MediumOrchid;
            dep_txt.BackColor = Color.DarkMagenta;
            panel9.BackColor = Color.DarkMagenta;
            cherche_txt.BackColor = Color.DarkMagenta;
            panel3.BackColor = Color.DarkMagenta;
        }

        private void dep_txt_Click(object sender, EventArgs e)
        {
            panel4.BackColor = Color.DarkMagenta;
            key_txt.BackColor = Color.DarkMagenta;
            panel6.BackColor = Color.DarkMagenta;
            first_txt.BackColor = Color.DarkMagenta;
            panel8.BackColor = Color.DarkMagenta;
            last_txt.BackColor = Color.DarkMagenta;
            job_txt.BackColor = Color.DarkMagenta;
            panel10.BackColor = Color.DarkMagenta;
            dep_txt.BackColor = Color.MediumOrchid;
            panel9.BackColor = Color.MediumOrchid;
            cherche_txt.BackColor = Color.DarkMagenta;
            panel3.BackColor = Color.DarkMagenta;
        }

        private void key_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Veuillez taper des enitiers", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dep_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Veuillez taper des enitiers", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void first_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Veuillez taper des caracteres", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void last_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Veuillez taper des caracteres", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void job_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Veuillez taper des caracteres", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
