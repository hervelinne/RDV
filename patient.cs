using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace RDV
{
    public partial class patient : MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RDV.mdf;Integrated Security=True");

        public patient()
        {
            InitializeComponent();
            inputIdPatient.Text = Globals.ID_PATIENT.ToString();

            connection.Open();
            SqlCommand cmdd = connection.CreateCommand();
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = "select * from rdv where patient_id = '" + Globals.ID_PATIENT + "'";
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmdd.CommandText, connection); ;
            dataadp.Fill(dta);
            dataGridView2.DataSource = dta;
            connection.Close();

        }

        private void patient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.rdv' table. You can move, or remove it, as needed.
            this.rdvTableAdapter1.Fill(this.dataSet.rdv);
            // TODO: This line of code loads data into the 'dataSet.medecin' table. You can move, or remove it, as needed.
            this.medecinTableAdapter1.Fill(this.dataSet.medecin);
            // TODO: cette ligne de code charge les données dans la table 'rDVDataSet.rdv'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.rdvTableAdapter.Fill(this.rDVDataSet.rdv);
            // TODO: cette ligne de code charge les données dans la table 'rDVDataSet1.medecin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.medecinTableAdapter.Fill(this.rDVDataSet1.medecin);

        }


        private void logout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var f1 = new username();
            f1.Show();
        }

        private void cin_p_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void modifier_Click(object sender, EventArgs e)
        {
            if (!Regex.Match(inputIdMedecin.Text, "^[0-9]+$").Success)
            {
                MetroMessageBox.Show(this, "Id Invalid !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from medecin where medecin_Id = '" + int.Parse(inputIdMedecin.Text)+"'";
            SqlDataAdapter sda = new SqlDataAdapter(cmd.CommandText, connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int query = cmd.ExecuteNonQuery();
            connection.Close();
            if (dt.Rows.Count == 0)
            {
                MetroMessageBox.Show(this, "Médecin inexistant !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            if (date.Value < DateTime.Now)
            {
                MetroMessageBox.Show(this, "Date invalide !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            DateTime dateTime = DateTime.ParseExact(heure.Text, "HH:mm",
                                        CultureInfo.InvariantCulture);
            DateTime time1 = DateTime.ParseExact("08:00", "HH:mm",
                                        CultureInfo.InvariantCulture);
            DateTime time2 = DateTime.ParseExact("18:00", "HH:mm",
            CultureInfo.InvariantCulture);
            DateTime dateTime1 = DateTime.ParseExact(heure.Text+":00", "HH:mm:ss",
                                       CultureInfo.InvariantCulture);
            if (dateTime < time1 || dateTime>time2)
            {
                MetroMessageBox.Show(this, "Veuillez entrer un horaire entre 08:00 et 18:00 !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            DateTime ins = date.Value;
            string format = "yyyy-MM-dd HH:mm:ss";
            connection.Open();
            SqlCommand cmd1 = connection.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "insert into rdv(date,heure,medecin_id,patient_id) values ('" + ins.ToString(format) + "','" + dateTime1.ToString("HH:mm:ss") + "','" + int.Parse(inputIdMedecin.Text) + "','" + Globals.ID_PATIENT + "')";
            int query1 = cmd1.ExecuteNonQuery();
            SqlCommand r = connection.CreateCommand();
            r.CommandType = CommandType.Text;
            r.CommandText = "select * from rdv where patient_id ='" + inputIdPatient.Text + "'";
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(r.CommandText, connection); ;
            dataadp.Fill(dta);
            dataGridView2.DataSource = dta;
            connection.Close();
            


        }

        private void inputIdMedecin_Click(object sender, EventArgs e)
        {

        }

        private void rechercher_Click(object sender, EventArgs e)
        {
            
            if(rech.Text == "Nom")
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from medecin where nom = '" + med.Text + "'";
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
                dataadp.Fill(dta);
                dataGridView1.DataSource = dta;
                connection.Close();
                
            }
            if (rech.Text == "Spécialité")
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from medecin where specialite = '" + med.Text + "'";
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
                dataadp.Fill(dta);
                dataGridView1.DataSource = dta;
                connection.Close();

            }
            if (rech.Text == "Ville")
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from medecin where ville = '" + med.Text + "'";
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
                dataadp.Fill(dta);
                dataGridView1.DataSource = dta;
                connection.Close();

            }
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from medecin";
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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
            r.CommandText = "select * from rdv where patient_id ='" + inputIdPatient.Text + "'";
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(r.CommandText, connection); ;
            dataadp.Fill(dta);
            dataGridView2.DataSource = dta;
            connection.Close();

        }
    }
}
