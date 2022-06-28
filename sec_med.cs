using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace RDV
{
    public partial class sec_med : MetroForm
    {
        public sec_med()
        {
            InitializeComponent();
            inputIdMedecin.Text = Globals.ID_MEDECIN.ToString();

        }

        private void sec_med_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'rDVDataSet.rdv'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.rdvTableAdapter.Fill(this.rDVDataSet.rdv);

        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f1 = new username();
            f1.Show();
        }

        private void cin_p_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
