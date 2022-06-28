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
using System.Windows;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace RDV
{
    public partial class patient_inscr : MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RDV.mdf;Integrated Security=True");

        public patient_inscr()
        {
            InitializeComponent();
        }

        private void patient_inscr_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void userbox_Click(object sender, EventArgs e)
        {

        }

        private void retour_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new username();
            form1.Show();
        }

        

        private void nom_Click(object sender, EventArgs e)
        {

        }

        private void nom_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            //verification nom
            if (!Regex.Match(nom.Text, "^[a-zA-Z]*$").Success)
            {
                System.Windows.MessageBox.Show("Nom Invalid", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                nom.Focus();
                return;
            }
            //verification prenom
            if (!Regex.Match(prenom.Text, "^[a-zA-Z]*$").Success)
            {
                System.Windows.MessageBox.Show("Prénom Invalid", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                prenom.Focus();
                return;
            }
            //verification age
            if (!Regex.Match(age.Text, "^[0-9]+$").Success)
            {
                System.Windows.MessageBox.Show("Age Invalid", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                age.Focus();
                return;
            }
            //verification age (entre 18 et 100) 
            if ( int.Parse(age.Text) < 18 || int.Parse(age.Text) > 100)
            {
                System.Windows.MessageBox.Show("L'age que vous avez saisi est non valide", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                age.Focus();
                return;
            }
            //verification phone
            if (!Regex.Match(tel.Text, "^[0-9]+$").Success || tel.Text.Length !=10 )
            {
                System.Windows.MessageBox.Show("Téléphone Invalid", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                tel.Focus();
                return;
            }
            //verification mail
            if (!Regex.Match(email.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success || tel.Text.Length != 10)
            {
                System.Windows.MessageBox.Show("E-mail Invalid", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                email.Focus();
                return;
            }
            var name = nom.Text.ToString();
            var pre = prenom.Text.ToString();

           
            
            var phone = long.Parse(tel.Text);
            var log = login.Text.ToString();
            var passe = mdp.Text.ToString();



            if (cin.Text == "" || nom.Text == "" || prenom.Text == "" || age.Text == "" || tel.Text == "" || email.Text == "" || login.Text == "" || mdp.Text == "")
                MetroMessageBox.Show(this, "Veuillez remplir le(s) champ(s) vide(s)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into patient(nom,prenom,email,age,tel,login,mdp) values ('" + name + "','" + pre + "','" + email.Text + "','" + int.Parse(age.Text) + "','" + phone + "','" + log + "','" + passe + "')";
                int query = cmd.ExecuteNonQuery();
                connection.Close();
                if (query == 1)
                {
                    this.Hide();
                    var u = new username();
                    u.Show();
                    MetroMessageBox.Show(this, "Votre Compte a été créer", "Information", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
                else
                {
                    System.Windows.MessageBox.Show("Erreur lors de l'ajout du client.");

                }
            }




        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
