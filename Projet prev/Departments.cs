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
    public partial class Departments : Form
    {
        public Departments()
        {
            InitializeComponent();
        }
        int index;

        private void Departments_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'rHDataSet2.Departments'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.departmentsTableAdapter.Fill(this.rHDataSet2.Departments);

        }

        private void first_btn_Click(object sender, EventArgs e)
        {
            departmentsBindingSource.MoveFirst();
        }

        private void last_btn_Click(object sender, EventArgs e)
        {
            departmentsBindingSource.MoveLast();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            departmentsBindingSource.MoveNext();
        }

        private void previous_btn_Click(object sender, EventArgs e)
        {
            departmentsBindingSource.MovePrevious();
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.AllowUserToAddRows = true;
                DataRowView newRow = (DataRowView)departmentsBindingSource.AddNew();
                newRow["Department_id"] = key_txt.Text;
                newRow["Department_name"] = title_txt.Text;
                newRow["Location_id"] = loc_txt.Text;
                departmentsBindingSource.EndEdit();
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
                row.Cells[1].Value = title_txt.Text;
                row.Cells[2].Value = loc_txt.Text;
                departmentsBindingSource.EndEdit();


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
            title_txt.Text = row.Cells[1].Value.ToString();
            loc_txt.Text = row.Cells[2].Value.ToString();
        }

        private void undo_btn_Click(object sender, EventArgs e)
        {
            try
            {

                this.departmentsTableAdapter.Fill(this.rHDataSet2.Departments);
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
                departmentsBindingSource.RemoveCurrent();


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
                this.departmentsBindingSource.EndEdit();
                this.departmentsTableAdapter.Update(rHDataSet2.Departments);
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
            title_txt.Text = "";
            cherche_txt.Text = "";
            loc_txt.Text = "";
            dataGridView1.ClearSelection();
            panel1.BackColor = Color.DarkRed;
            cherche_txt.BackColor = Color.DarkRed;
            panel3.BackColor = Color.DarkRed;
            title_txt.BackColor = Color.DarkRed;
            panel4.BackColor = Color.DarkRed;
            key_txt.BackColor = Color.DarkRed;
            panel6.BackColor = Color.DarkRed;
            loc_txt.BackColor = Color.DarkRed;

        }

        private void key_txt_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.DarkRed;
            cherche_txt.BackColor = Color.DarkRed;
            panel3.BackColor = Color.DarkRed;
            title_txt.BackColor = Color.DarkRed;
            panel4.BackColor = Color.Red;
            key_txt.BackColor = Color.Red;
            
            panel6.BackColor = Color.DarkRed;
            loc_txt.BackColor = Color.DarkRed;
        }

        private void title_txt_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.DarkRed;
            cherche_txt.BackColor = Color.DarkRed;
            panel3.BackColor = Color.Red;
            title_txt.BackColor = Color.Red;
            
            panel4.BackColor = Color.DarkRed;
            key_txt.BackColor = Color.DarkRed;
            panel6.BackColor = Color.DarkRed;
            loc_txt.BackColor = Color.DarkRed;
        }

        private void loc_txt_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.DarkRed;
            cherche_txt.BackColor = Color.DarkRed;
            panel3.BackColor = Color.DarkRed;
            title_txt.BackColor = Color.DarkRed;
            panel4.BackColor = Color.DarkRed;
            key_txt.BackColor = Color.DarkRed;
            panel6.BackColor = Color.Red;
            loc_txt.BackColor = Color.Red;
            
        }

        private void cherche_txt_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Red;
            cherche_txt.BackColor = Color.Red;
            panel3.BackColor = Color.DarkRed;
            title_txt.BackColor = Color.DarkRed;
            panel4.BackColor = Color.DarkRed;
            key_txt.BackColor = Color.DarkRed;
            panel6.BackColor = Color.DarkRed;
            loc_txt.BackColor = Color.DarkRed;
        }

        private void key_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Veuillez taper des entiers", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void title_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Veuillez taper des caracteres", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loc_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Veuillez taper des enitiers", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cherche_btn_Click(object sender, EventArgs e)
        {
            string searchString = cherche_txt.Text;

            int rowIndex = departmentsBindingSource.Find("Department_id", searchString);
            if (rowIndex != -1)
            {
                dataGridView1.Rows[rowIndex].Selected = true;
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                key_txt.Text = row.Cells[0].Value.ToString();
                title_txt.Text = row.Cells[1].Value.ToString();
                loc_txt.Text = row.Cells[2].Value.ToString();

            }
            else
            {
                MessageBox.Show("La chaîne saisie n'a pas été trouvée dans la source de données.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
