using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Projet_prev
{
    public partial class job_frm : Form
    {
        public job_frm()
        {
            InitializeComponent();
            
        }
       
        SqlConnection conn = new SqlConnection("Data Source=JERBI ;Initial Catalog =RH;User ID = jerbi; Password=12345678;");
        int index;
        

        private void job_frm_Load(object sender, EventArgs e)
        {
            
            // TODO: cette ligne de code charge les données dans la table 'rHDataSet.Jobs'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.jobsTableAdapter.Fill(this.rHDataSet.Jobs);
            

        }

        private void key_txt_Click(object sender, EventArgs e)
        {
            panel4.BackColor = SystemColors.Control;
            key_txt.BackColor = SystemColors.Control;
            panel3.BackColor = Color.SpringGreen;
            title_txt.BackColor = Color.SpringGreen;
            panel1.BackColor = Color.SpringGreen;
            cherche_txt.BackColor = Color.SpringGreen;
        }

        private void title_txt_Click(object sender, EventArgs e)
        {
            panel3.BackColor = SystemColors.Control;
            title_txt.BackColor = SystemColors.Control;
            panel4.BackColor = Color.SpringGreen;
            key_txt.BackColor = Color.SpringGreen;
            panel1.BackColor = Color.SpringGreen;
            cherche_txt.BackColor = Color.SpringGreen;

        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.AllowUserToAddRows = true;
                DataRowView newRow = (DataRowView)jobsBindingSource.AddNew();
                newRow["Job_id"] = key_txt.Text;
                newRow["Job_title"] = title_txt.Text;
                jobsBindingSource.EndEdit();
                dataGridView1.AllowUserToAddRows = false;

                dataGridView1.Refresh();
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
            


        }

        private void first_btn_Click(object sender, EventArgs e)
        {
            jobsBindingSource.MoveFirst();
        }

        private void last_btn_Click(object sender, EventArgs e)
        {
            jobsBindingSource.MoveLast();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            jobsBindingSource.MoveNext();

        }

        private void previous_btn_Click(object sender, EventArgs e)
        {
            jobsBindingSource.MovePrevious();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            try
            {
                jobsBindingSource.RemoveCurrent();
                

            }
            catch(Exception ex)
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
                jobsBindingSource.EndEdit();
                
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            

        }

        private void annul_btn_Click(object sender, EventArgs e)
        {
            key_txt.Text = "";
            title_txt.Text = "";
            cherche_txt.Text = "";
            dataGridView1.ClearSelection();
            panel1.BackColor = Color.SpringGreen;
            cherche_txt.BackColor = Color.SpringGreen;
            panel3.BackColor = Color.SpringGreen;
            title_txt.BackColor = Color.SpringGreen;
            panel4.BackColor = Color.SpringGreen;
            key_txt.BackColor = Color.SpringGreen;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            key_txt.Text = row.Cells[0].Value.ToString();
            title_txt.Text = row.Cells[1].Value.ToString();
        }

        private void val_btn_Click(object sender, EventArgs e)
        {
            try
            {

                this.Validate();
                this.jobsBindingSource.EndEdit();
                this.jobsTableAdapter.Update(rHDataSet.Jobs);
                MessageBox.Show("la validation de données est faite", "CONGRATS", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void undo_btn_Click(object sender, EventArgs e)
        {
            try
            {
                
                this.jobsTableAdapter.Fill(this.rHDataSet.Jobs);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void key_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Veuillez taper des caracteres", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void title_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                MessageBox.Show("Veuillez taper des caracteres", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cherche_txt_Click(object sender, EventArgs e)
        {
            panel1.BackColor = SystemColors.Control;
            cherche_txt.BackColor = SystemColors.Control;
            panel3.BackColor = Color.SpringGreen;
            title_txt.BackColor = Color.SpringGreen;
            panel4.BackColor = Color.SpringGreen;
            key_txt.BackColor = Color.SpringGreen;
        }

        private void cherche_btn_Click(object sender, EventArgs e)
        {
            string searchString = cherche_txt.Text;

            int rowIndex = jobsBindingSource.Find("Job_id", searchString);
            if (rowIndex != -1)
            {
                dataGridView1.Rows[rowIndex].Selected = true;
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                key_txt.Text = row.Cells[0].Value.ToString();
                title_txt.Text = row.Cells[1].Value.ToString();

            }
            else
            {
                MessageBox.Show("La chaîne saisie n'a pas été trouvée dans la source de données.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
