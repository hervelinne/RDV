using MetroFramework.Forms;
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

namespace RDV
{
    public partial class Medecin : MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RDV.mdf;Integrated Security=True");

        public Medecin()
        {
            InitializeComponent();
            inputIdMedecin.Text = Globals.ID_MEDECIN.ToString();
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from rdv where medecin_id ='" + inputIdMedecin.Text + "'";
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
            dataadp.Fill(dta);
            dataGridView2.DataSource = dta;
            connection.Close();
        }

        private void Medecin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.rdv' table. You can move, or remove it, as needed.
            this.rdvTableAdapter.Fill(this.dataSet1.rdv);
            // TODO: This line of code loads data into the 'dataSet.rdv' table. You can move, or remove it, as needed.
            this.rdvTableAdapter.Fill(this.dataSet.rdv);

        }

        private void Authetification_Click(object sender, EventArgs e)
        {

        }

        private void modifier_Click(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f1 = new username();
            f1.Show();
        }

        private void inputIdMedecin_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rdvTableAdapter.FillBy(this.dataSet.rdv);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rdvTableAdapter.FillBy1(this.dataSet.rdv);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView2.SelectedRows[0].Index;
            int rowID = int.Parse(dataGridView2.Rows[selectedIndex].Cells["rdv_id"].Value.ToString());

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from rdv where rdv_id = '" + rowID + "'";
            int query = cmd.ExecuteNonQuery();
            SqlCommand r = connection.CreateCommand();
            r.CommandType = CommandType.Text;
            r.CommandText = "select * from rdv where medecin_id ='" + inputIdMedecin.Text + "'";
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(r.CommandText, connection); ;
            dataadp.Fill(dta);
            dataGridView2.DataSource = dta;
            connection.Close();
        }
    }
}
