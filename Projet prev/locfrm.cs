using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_prev
{
    public partial class locfrm : Form
    {
        public locfrm()
        {
            InitializeComponent();
        }

        private void locfrm_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'rHDataSet5.Locations'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.locationsTableAdapter.Fill(this.rHDataSet5.Locations);
            

        }
        int index;

        private void first_btn_Click(object sender, EventArgs e)
        {
            locationsBindingSource1.MoveFirst();
        }

        private void last_btn_Click(object sender, EventArgs e)
        {
            locationsBindingSource1.MoveLast();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            locationsBindingSource1.MoveNext();
        }

        private void previous_btn_Click(object sender, EventArgs e)
        {
            locationsBindingSource1.MovePrevious();
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.AllowUserToAddRows = true;
                DataRowView newRow = (DataRowView)locationsBindingSource1.AddNew();
                newRow["Location_id"] = key_txt.Text;
                newRow["Location_details"] = loc_txt.Text;
                locationsBindingSource1.EndEdit();
                dataGridView1.AllowUserToAddRows = false;

                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void up_btn_Click(object sender, EventArgs e)
        {

            try
            {
                DataGridViewRow row = dataGridView1.Rows[index];
                row.Cells[0].Value = key_txt.Text;
                row.Cells[1].Value = loc_txt.Text;
                locationsBindingSource1.EndEdit();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            key_txt.Text = row.Cells[0].Value.ToString();
            
            loc_txt.Text = row.Cells[1].Value.ToString();
        }

        private void undo_btn_Click(object sender, EventArgs e)
        {
            try
            {

                this.locationsTableAdapter.Fill(this.rHDataSet5.Locations);
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
                locationsBindingSource1.RemoveCurrent();


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
                this.locationsBindingSource1.EndEdit();
                this.locationsTableAdapter.Update(rHDataSet5.Locations);
                MessageBox.Show("la validation de données est faite", "CONGRATS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void annul_btn_Click(object sender, EventArgs e)
        {
            key_txt.Text = "";
            
            cherche_txt.Text = "";
            loc_txt.Text = "";
            dataGridView1.ClearSelection();
            panel1.BackColor = Color.DarkGoldenrod;
            cherche_txt.BackColor = Color.DarkGoldenrod;
            panel4.BackColor = Color.DarkGoldenrod;
            key_txt.BackColor = Color.DarkGoldenrod;
            panel6.BackColor = Color.DarkGoldenrod;
            loc_txt.BackColor = Color.DarkGoldenrod;
        }

        private void cherche_txt_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Olive;
            cherche_txt.BackColor = Color.Olive;
           
            panel4.BackColor = Color.DarkGoldenrod;
            key_txt.BackColor = Color.DarkGoldenrod;

            panel6.BackColor = Color.DarkGoldenrod;
            loc_txt.BackColor = Color.DarkGoldenrod;
        }

        private void key_txt_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.DarkGoldenrod;
            cherche_txt.BackColor = Color.DarkGoldenrod;

            panel4.BackColor = Color.Olive;
            key_txt.BackColor = Color.Olive;

            panel6.BackColor = Color.DarkGoldenrod;
            loc_txt.BackColor = Color.DarkGoldenrod;

        }

        private void loc_txt_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.DarkGoldenrod;
            cherche_txt.BackColor = Color.DarkGoldenrod;

            panel4.BackColor = Color.DarkGoldenrod;
            key_txt.BackColor = Color.DarkGoldenrod;

            panel6.BackColor = Color.Olive;
            loc_txt.BackColor = Color.Olive;
        }

        private void key_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Veuillez taper des enitiers", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loc_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Veuillez taper des caracteres", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cherche_btn_Click(object sender, EventArgs e)
        {
            string searchString = cherche_txt.Text;

            int rowIndex = locationsBindingSource1.Find("Location_id", searchString);
            if (rowIndex != -1)
            {
                dataGridView1.Rows[rowIndex].Selected = true;
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                key_txt.Text = row.Cells[0].Value.ToString();
                
                loc_txt.Text = row.Cells[1].Value.ToString();

            }
            else
            {
                MessageBox.Show("La chaîne saisie n'a pas été trouvée dans la source de données.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
