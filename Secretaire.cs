using MetroFramework;
using MetroFramework.Forms;
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

namespace RDV
{
    public partial class Secretaire : MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RDV.mdf;Integrated Security=True");

        public Secretaire()
        {
            InitializeComponent();
        }

        private void Secretaire_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.dataSet.patient);
            // TODO: This line of code loads data into the 'dataSet.medecin' table. You can move, or remove it, as needed.
            this.medecinTableAdapter.Fill(this.dataSet.medecin);
            // TODO: This line of code loads data into the 'dataSet.rdv' table. You can move, or remove it, as needed.
            this.rdvTableAdapter.Fill(this.dataSet.rdv);

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void rechercher_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from rdv";
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
            dataadp.Fill(dta);
            dataGridView2.DataSource = dta;
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rech.Text == "Id_Medecin")
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from rdv where medecin_Id = '" + txt.Text + "'";
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
                dataadp.Fill(dta);
                dataGridView2.DataSource = dta;
                connection.Close();

            }
            if (rech.Text == "Id_Patient")
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from rdv where patient_Id = '" + txt.Text + "'";
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
                dataadp.Fill(dta);
                dataGridView2.DataSource = dta;
                connection.Close();

            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f1 = new username();
            f1.Show();
        }

        private void modifier_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Regex.Match(idMed.Text, "^[0-9]+$").Success)
            {
                MetroMessageBox.Show(this, "Id Medecin Invalide !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from medecin where medecin_Id = '" + int.Parse(idMed.Text) + "'";
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
            if (!Regex.Match(idPatient.Text, "^[0-9]+$").Success)
            {
                MetroMessageBox.Show(this, "Id Patient Invalide !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            connection.Open();
            SqlCommand cmd1 = connection.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from patient where patient_Id = '" + int.Parse(idPatient.Text) + "'";
            SqlDataAdapter sda1 = new SqlDataAdapter(cmd.CommandText, connection);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            int query1 = cmd1.ExecuteNonQuery();
            connection.Close();
            if (dt1.Rows.Count == 0)
            {
                MetroMessageBox.Show(this, "Patient inexistant !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
            DateTime dateTime1 = DateTime.ParseExact(heure.Text + ":00", "HH:mm:ss",
                                       CultureInfo.InvariantCulture);
            if (dateTime < time1 || dateTime > time2)
            {
                MetroMessageBox.Show(this, "Veuillez entrer un horaire entre 08:00 et 18:00 !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            DateTime ins = date.Value;
            string format = "yyyy-MM-dd HH:mm:ss";
            connection.Open();
            SqlCommand cmd2 = connection.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "insert into rdv(date,heure,medecin_id,patient_id) values ('" + ins.ToString(format) + "','" + dateTime.ToString("HH:mm:ss") + "','" + int.Parse(idMed.Text) + "','" + int.Parse(idPatient.Text) + "')";
            int query2 = cmd2.ExecuteNonQuery();
            SqlCommand r = connection.CreateCommand();
            r.CommandType = CommandType.Text;
            r.CommandText = "select * from rdv ";
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(r.CommandText, connection); ;
            dataadp.Fill(dta);
            dataGridView2.DataSource = dta;
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView2.SelectedRows[0].Index;
            int rowID = int.Parse(dataGridView2.Rows[selectedIndex].Cells["rdv_id"].Value.ToString());

            if (!Regex.Match(idMed.Text, "^[0-9]+$").Success)
            {
                MetroMessageBox.Show(this, "Id Medecin Invalide !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from medecin where medecin_Id = '" + int.Parse(idMed.Text) + "'";
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
            if (!Regex.Match(idPatient.Text, "^[0-9]+$").Success)
            {
                MetroMessageBox.Show(this, "Id Patient Invalide !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            connection.Open();
            SqlCommand cmd1 = connection.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from patient where patient_Id = '" + int.Parse(idPatient.Text) + "'";
            SqlDataAdapter sda1 = new SqlDataAdapter(cmd.CommandText, connection);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            int query1 = cmd1.ExecuteNonQuery();
            connection.Close();
            if (dt1.Rows.Count == 0)
            {
                MetroMessageBox.Show(this, "Patient inexistant !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
            DateTime dateTime1 = DateTime.ParseExact(heure.Text + ":00", "HH:mm:ss",
                                       CultureInfo.InvariantCulture);
            if (dateTime < time1 || dateTime > time2)
            {
                MetroMessageBox.Show(this, "Veuillez entrer un horaire entre 08:00 et 18:00 !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            DateTime ins = date.Value;
            string format = "yyyy-MM-dd HH:mm:ss";
            connection.Open();
            SqlCommand cmd2 = connection.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "update rdv set date = '"+ ins.ToString(format) + "',heure = '" + dateTime.ToString("HH:mm:ss") + "',medecin_id ='"+ int.Parse(idMed.Text) + "',patient_id ='" + int.Parse(idPatient.Text) + "'where rdv_id = '"+rowID+"'";
            int query2 = cmd2.ExecuteNonQuery();
            SqlCommand r = connection.CreateCommand();
            r.CommandType = CommandType.Text;
            r.CommandText = "select * from rdv ";
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(r.CommandText, connection); ;
            dataadp.Fill(dta);
            dataGridView2.DataSource = dta;
            connection.Close();
        }

        private void rech_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (rech1.Text == "Nom")
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
            if (rech1.Text == "Spécialité")
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
            if (rech1.Text == "Ville")
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

        private void button7_Click(object sender, EventArgs e)
        {
            if (rech2.Text == "Nom")
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from patient where nom = '" + patient.Text + "'";
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
                dataadp.Fill(dta);
                dataGridView3.DataSource = dta;
                connection.Close();

            }
            if (rech2.Text == "Prenom")
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from patient where prenom = '" + patient.Text + "'";
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
                dataadp.Fill(dta);
                dataGridView3.DataSource = dta;
                connection.Close();

            }
            if (rech2.Text == "Email")
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from patient where email = '" + med.Text + "'";
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
                dataadp.Fill(dta);
                dataGridView3.DataSource = dta;
                connection.Close();

            }
            if (rech2.Text == "Telephone")
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from patient where tel = '" + patient.Text + "'";
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
                dataadp.Fill(dta);
                dataGridView3.DataSource = dta;
                connection.Close();

            }
            if (rech2.Text == "Age")
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from patient where age = '" + patient.Text + "'";
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
                dataadp.Fill(dta);
                dataGridView3.DataSource = dta;
                connection.Close();

            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from patient";
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
            dataadp.Fill(dta);
            dataGridView3.DataSource = dta;
            connection.Close();
        }
    }
}
