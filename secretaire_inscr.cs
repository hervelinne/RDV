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
using MetroFramework;
using MetroFramework.Forms;

namespace RDV
{
    public partial class secretaire_inscr : MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RDV.mdf;Integrated Security=True");

        //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RDV.mdf;Integrated Security=True");
        public secretaire_inscr()
        {
            InitializeComponent();
        }

        private void secretaire_inscr_Load(object sender, EventArgs e)
        {

        }

        private void retour_Click(object sender, EventArgs e)
        {
            this.Hide();
            var a = new admin();
            a.Show();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            if (login.Text == "" || mdp.Text == "")
                MetroMessageBox.Show(this, "Veuillez remplir le(s) champ(s) vide(s)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
   
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into secretaire(login, mdp) values ('" + login.Text + "','" + mdp.Text + "')";
                cmd.Connection = connection;
                connection.Open();
                int query = cmd.ExecuteNonQuery();
                connection.Close();
                if (query == 1)
                {
                    this.Close();
                    MetroMessageBox.Show(this, "Compte secretaire créé avec succès !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var u = new admin();
                    u.Show();
                    
     
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'ajout de secretaire.");
                    
                }


            }
        }

        private void login_Click(object sender, EventArgs e)
        {

        }
    }
}
