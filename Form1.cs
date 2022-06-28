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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDV
{
    public partial class username : MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\RDV.mdf;Integrated Security=True");

        public username()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sisncrire_Click(object sender, EventArgs e)
        {
            this.Hide();
            var choix = new patient_inscr();
            choix.Show();
        }

        private void connexion_Click(object sender, EventArgs e)
        {
            if (userbox.Text == "" || pwdbox.Text == "")
            {
                MetroMessageBox.Show(this, "Veuillez remplir le(s) champ(s) vide(s)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                
                if (patient.Checked == true)
                {
                    cmd.CommandText = " select patient_id from patient where login ='" + userbox.Text + "' and mdp = '" + pwdbox.Text + "'";
                    SqlDataAdapter sda= new SqlDataAdapter(cmd.CommandText,connection);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    cmd.Connection = connection;
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    
                    connection.Close();
                    if (dt.Rows.Count == 0)
                    {
                        MetroMessageBox.Show(this, "username ou mdp incorect !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        connection.Open();
                        Globals.ID_PATIENT = (int)dt.Rows[0][0]; //(int)cmd.ExecuteScalar() ;
                        connection.Close();

                        this.Hide();
                        var p = new patient();
                        p.Show();
                    }
                }
                else
                if (medecin.Checked == true)
                {
                    if (userbox.Text == "admin" && pwdbox.Text == "adminadmin")
                    {
                        this.Hide();
                        var a = new admin();
                        a.Show();
                    }
                    else {
                        cmd.CommandText = " select medecin_id from medecin where login ='" + userbox.Text + "' and mdp = '" + pwdbox.Text + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(cmd.CommandText, connection);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        cmd.Connection = connection;
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        if (dt.Rows.Count == 0)
                        {
                            MetroMessageBox.Show(this, "username ou mdp incorect !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            connection.Open();
                            Globals.ID_MEDECIN = (int)dt.Rows[0][0]; //(int)cmd.ExecuteScalar() ;
                            connection.Close();

                            this.Hide();
                            var sm = new Medecin();
                            sm.Show();
                        }
                    }
                    
                }
                else
                if (secretaire.Checked == true)
                {
                    cmd.CommandText = " select secretaire_id from secretaire where login ='" + userbox.Text + "' and mdp = '" + pwdbox.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(cmd.CommandText, connection);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    cmd.Connection = connection;
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    if (dt.Rows.Count == 0)
                    {
                        MetroMessageBox.Show(this, "username ou mdp incorect !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        this.Hide();
                        var sm = new Secretaire();
                        sm.Show();
                    }
                }
                else
                    MetroMessageBox.Show(this, "Veillez choisir votre position svp !", "Votre Position", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void patient_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void pwdbox_Click(object sender, EventArgs e)
        {
            pwdbox.PasswordChar = '*';
        }
    }
}
