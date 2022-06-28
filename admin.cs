using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDV
{
    public partial class admin : MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RDV.mdf;Integrated Security=True");

        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.secretaire' table. You can move, or remove it, as needed.
            this.secretaireTableAdapter.Fill(this.dataSet.secretaire);
            // TODO: This line of code loads data into the 'dataSet.medecin' table. You can move, or remove it, as needed.
            this.medecinTableAdapter1.Fill(this.dataSet.medecin);
            // TODO: This line of code loads data into the 'rDVDataSet1.medecin' table. You can move, or remove it, as needed.
            this.medecinTableAdapter.Fill(this.rDVDataSet1.medecin);

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void secretaire_Click(object sender, EventArgs e)
        {
            this.Hide();
            var s = new secretaire_inscr();
            s.Show();
        }

        private void medecin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var m = new medecin_inscr();
            m.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f1 = new username();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView2.SelectedRows[0].Index;
            int rowID = int.Parse(dataGridView2.Rows[selectedIndex].Cells["secretaire_id"].Value.ToString());

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from secretaire where secretaire_id = '"+ rowID + "'";
            int query = cmd.ExecuteNonQuery();
            SqlCommand r = connection.CreateCommand();
            r.CommandType = CommandType.Text;
            r.CommandText = "select * from secretaire";
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(r.CommandText, connection); ;
            dataadp.Fill(dta);
            dataGridView2.DataSource = dta;
            connection.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView1.SelectedRows[0].Index;
            int rowID = int.Parse(dataGridView1.Rows[selectedIndex].Cells["medecin_id"].Value.ToString());

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from medecin where medecin_Id = '" + rowID + "'";
            int query = cmd.ExecuteNonQuery();
            SqlCommand r = connection.CreateCommand();
            r.CommandType = CommandType.Text;
            r.CommandText = "select * from medecin";
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(r.CommandText, connection); ;
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;
            connection.Close();
        }

        private void metroLabel14_Click(object sender, EventArgs e)
        {

        }

        private void inputAdresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (login.Text == "" || mdp.Text == "")
                MetroMessageBox.Show(this, "Veuillez remplir le(s) champ(s) vide(s)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                int selectedIndex = dataGridView2.SelectedRows[0].Index;
                int rowID = int.Parse(dataGridView2.Rows[selectedIndex].Cells["secretaire_id"].Value.ToString());

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update secretaire set login ='" + login.Text + "',mdp ='" + mdp.Text + "' where secretaire_id ='" +rowID +"'";
                cmd.Connection = connection;
                connection.Open();
                int query = cmd.ExecuteNonQuery();
                SqlCommand r = connection.CreateCommand();
                r.CommandType = CommandType.Text;
                r.CommandText = "select * from secretaire";
                DataTable dta = new DataTable();
                SqlDataAdapter dataadp = new SqlDataAdapter(r.CommandText, connection); ;
                dataadp.Fill(dta);
                dataGridView2.DataSource = dta;
                connection.Close();
                if (query == 1)
                {
                    this.Close();
                    MetroMessageBox.Show(this, "Compte secretaire modifié avec succé !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var u = new admin();
                    u.Show();


                }
                else
                {
                    MessageBox.Show("Erreur lors de la modification.");

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView1.SelectedRows[0].Index;
            int rowID = int.Parse(dataGridView1.Rows[selectedIndex].Cells["medecin_id"].Value.ToString());

            if (nom.Text == "" || prenom.Text == "" || age.Text == "" || tel.Text == "" || inputAdresse.Text == "" || login1.Text == "" || mdp1.Text == "" || inputPays.Text == "" || inputSpec.SelectedItem == null || InputVilles.SelectedItem == null)
            {
                MetroMessageBox.Show(this, "Veuillez remplir le(s) champ(s) vide(s)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //verification nom
            if (!Regex.Match(nom.Text, "^[a-zA-Z]*$").Success)
            {
                MetroMessageBox.Show(this, "Nom Invalid", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            //verification prenom
            if (!Regex.Match(prenom.Text, "^[a-zA-Z]*$").Success)
            {
                MetroMessageBox.Show(this, "Prénom Invalid", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            //verification age
            if (!Regex.Match(age.Text, "^[0-9]+$").Success)
            {
                MetroMessageBox.Show(this, "Age Invalid", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            //verification age (entre 18 et 100) 
            if (int.Parse(age.Text) < 18 || int.Parse(age.Text) > 100)
            {
                MetroMessageBox.Show(this, "L'age que vous avez saisi est n'est pas valide", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            //verification phone
            if (!Regex.Match(tel.Text, "^[0-9]+$").Success || tel.Text.Length != 10)
            {
                MetroMessageBox.Show(this, "Téléphone Invalide !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }


            var name = nom.Text.ToString();
            var pre = prenom.Text.ToString();

            var spec = inputSpec.SelectedItem.ToString();
            var adresse = inputAdresse.Text.ToString();
            var phone = long.Parse(tel.Text);
            var log = login1.Text.ToString();
            var passe = mdp1.Text.ToString();



            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update medecin set nom = '" + name + "',prenom ='"+ pre +"',specialite = '" + spec + "',adresse = '" + adresse + "',tel = '" + phone + "',login = '" + log + "',mdp = '" + passe + "',ville = '" + InputVilles.SelectedItem.ToString() + "' where medecin_Id = '"+rowID+"'"; 
            int query = cmd.ExecuteNonQuery();
            SqlCommand r = connection.CreateCommand();
            r.CommandType = CommandType.Text;
            r.CommandText = "select * from medecin";
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(r.CommandText, connection); ;
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;
            connection.Close();

            tel.Text = inputAdresse.Text.ToString();
            if (query == 1)
            {
                this.Hide();
                var u = new admin();
                u.Show();
                MetroMessageBox.Show(this, "Compte Medecin modifié avec succès !", "Information", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            else
            {
                System.Windows.MessageBox.Show("Erreur lors de la modification de medecin.");

            }
        }
    }
        
}
