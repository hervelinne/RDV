using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace RDV
{
    public partial class medecin_inscr : MetroForm
    {
       
        //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RDV.mdf;Integrated Security=True");
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RDV.mdf;Integrated Security=True");

        public medecin_inscr()
        {
            InitializeComponent();


        }

        private void medecin_inscr_Load(object sender, EventArgs e)
        {

        }

        private void retour_Click(object sender, EventArgs e)
        {
            this.Hide();
            var a = new admin();
            a.Show();
        }

        private void inputPays_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nom_Click(object sender, EventArgs e)
        {

        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            if (nom.Text == "" || prenom.Text == "" || age.Text == "" || tel.Text == "" || inputAdresse.Text == "" || login.Text == "" || mdp.Text == "" || inputPays.Text == "" || inputSpec.SelectedItem == null || InputVilles.SelectedItem == null)
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
                MetroMessageBox.Show(this, "L'age que vous avez saisi est non valid", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return;
            }
            //verification phone
            if (!Regex.Match(tel.Text, "^[0-9]+$").Success || tel.Text.Length != 10)
            {
                MetroMessageBox.Show(this, "Téléphone Invalid !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return;
            }


            var name = nom.Text.ToString();
            var pre = prenom.Text.ToString();
          
            var spec = inputSpec.SelectedItem.ToString();
            var adresse = inputAdresse.Text.ToString();
            var phone = long.Parse(tel.Text);
            var log = login.Text.ToString();
            var passe = mdp.Text.ToString();


            
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into medecin(nom,prenom,specialite,adresse,tel,login,mdp,ville) values ('" + name + "','" + pre + "','" + spec + "','" + adresse + "','" + phone + "','" + log + "','" + passe + "','" + InputVilles.SelectedItem.ToString() + "')";
                int query = cmd.ExecuteNonQuery();
                connection.Close();

                tel.Text = inputAdresse.Text.ToString();
                if (query == 1)
                {
                    this.Hide();
                    var u = new admin();
                    u.Show();
                    MetroMessageBox.Show(this, "Compte Medecin créé avec succé !", "Information", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
                else
                {
                    System.Windows.MessageBox.Show("Erreur lors de l'ajout du client.");

                }
            

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {

        }
    }
}
