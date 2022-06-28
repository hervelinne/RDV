
namespace RDV
{
    partial class username
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Authetification = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.sisncrire = new MetroFramework.Controls.MetroButton();
            this.connexion = new MetroFramework.Controls.MetroButton();
            this.secretaire = new MetroFramework.Controls.MetroRadioButton();
            this.medecin = new MetroFramework.Controls.MetroRadioButton();
            this.patient = new MetroFramework.Controls.MetroRadioButton();
            this.pwdbox = new MetroFramework.Controls.MetroTextBox();
            this.userbox = new MetroFramework.Controls.MetroTextBox();
            this.pwd = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Authetification
            // 
            this.Authetification.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Authetification.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Authetification.Location = new System.Drawing.Point(305, 70);
            this.Authetification.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Authetification.Name = "Authetification";
            this.Authetification.Size = new System.Drawing.Size(151, 33);
            this.Authetification.TabIndex = 0;
            this.Authetification.Text = "Authentification : ";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.sisncrire);
            this.metroPanel1.Controls.Add(this.connexion);
            this.metroPanel1.Controls.Add(this.secretaire);
            this.metroPanel1.Controls.Add(this.medecin);
            this.metroPanel1.Controls.Add(this.patient);
            this.metroPanel1.Controls.Add(this.pwdbox);
            this.metroPanel1.Controls.Add(this.userbox);
            this.metroPanel1.Controls.Add(this.pwd);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 12;
            this.metroPanel1.Location = new System.Drawing.Point(181, 125);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(408, 240);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 14;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel2.Location = new System.Drawing.Point(19, 190);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 15);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Pas encore insrcit ?";
            // 
            // sisncrire
            // 
            this.sisncrire.Location = new System.Drawing.Point(19, 214);
            this.sisncrire.Name = "sisncrire";
            this.sisncrire.Size = new System.Drawing.Size(75, 23);
            this.sisncrire.TabIndex = 10;
            this.sisncrire.Text = "S\'inscrire";
            this.sisncrire.UseSelectable = true;
            this.sisncrire.Click += new System.EventHandler(this.sisncrire_Click);
            // 
            // connexion
            // 
            this.connexion.Location = new System.Drawing.Point(273, 214);
            this.connexion.Name = "connexion";
            this.connexion.Size = new System.Drawing.Size(75, 23);
            this.connexion.TabIndex = 9;
            this.connexion.Text = "Connexion";
            this.connexion.UseSelectable = true;
            this.connexion.Click += new System.EventHandler(this.connexion_Click);
            // 
            // secretaire
            // 
            this.secretaire.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.secretaire.Location = new System.Drawing.Point(303, 159);
            this.secretaire.Name = "secretaire";
            this.secretaire.Size = new System.Drawing.Size(93, 28);
            this.secretaire.TabIndex = 8;
            this.secretaire.TabStop = true;
            this.secretaire.Text = "Secretaire";
            this.secretaire.UseSelectable = true;
            // 
            // medecin
            // 
            this.medecin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.medecin.Location = new System.Drawing.Point(177, 159);
            this.medecin.Name = "medecin";
            this.medecin.Size = new System.Drawing.Size(83, 28);
            this.medecin.TabIndex = 7;
            this.medecin.TabStop = true;
            this.medecin.Text = "Medecin";
            this.medecin.UseSelectable = true;
            // 
            // patient
            // 
            this.patient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.patient.Location = new System.Drawing.Point(35, 159);
            this.patient.Name = "patient";
            this.patient.Size = new System.Drawing.Size(83, 28);
            this.patient.TabIndex = 6;
            this.patient.TabStop = true;
            this.patient.Text = "Patient";
            this.patient.UseSelectable = true;
            this.patient.CheckedChanged += new System.EventHandler(this.patient_CheckedChanged);
            // 
            // pwdbox
            // 
            // 
            // 
            // 
            this.pwdbox.CustomButton.Image = null;
            this.pwdbox.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.pwdbox.CustomButton.Name = "";
            this.pwdbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.pwdbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pwdbox.CustomButton.TabIndex = 1;
            this.pwdbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pwdbox.CustomButton.UseSelectable = true;
            this.pwdbox.CustomButton.Visible = false;
            this.pwdbox.Lines = new string[0];
            this.pwdbox.Location = new System.Drawing.Point(160, 95);
            this.pwdbox.MaxLength = 32767;
            this.pwdbox.Name = "pwdbox";
            this.pwdbox.PasswordChar = '\0';
            this.pwdbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pwdbox.SelectedText = "";
            this.pwdbox.SelectionLength = 0;
            this.pwdbox.SelectionStart = 0;
            this.pwdbox.ShortcutsEnabled = true;
            this.pwdbox.Size = new System.Drawing.Size(113, 23);
            this.pwdbox.TabIndex = 5;
            this.pwdbox.UseSelectable = true;
            this.pwdbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pwdbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.pwdbox.Click += new System.EventHandler(this.pwdbox_Click);
            // 
            // userbox
            // 
            // 
            // 
            // 
            this.userbox.CustomButton.Image = null;
            this.userbox.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.userbox.CustomButton.Name = "";
            this.userbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.userbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userbox.CustomButton.TabIndex = 1;
            this.userbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userbox.CustomButton.UseSelectable = true;
            this.userbox.CustomButton.Visible = false;
            this.userbox.Lines = new string[0];
            this.userbox.Location = new System.Drawing.Point(160, 27);
            this.userbox.MaxLength = 32767;
            this.userbox.Name = "userbox";
            this.userbox.PasswordChar = '\0';
            this.userbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userbox.SelectedText = "";
            this.userbox.SelectionLength = 0;
            this.userbox.SelectionStart = 0;
            this.userbox.ShortcutsEnabled = true;
            this.userbox.Size = new System.Drawing.Size(113, 23);
            this.userbox.TabIndex = 4;
            this.userbox.UseSelectable = true;
            this.userbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pwd
            // 
            this.pwd.AutoSize = true;
            this.pwd.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.pwd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pwd.Location = new System.Drawing.Point(34, 95);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(85, 19);
            this.pwd.TabIndex = 3;
            this.pwd.Text = "Password : ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel1.Location = new System.Drawing.Point(34, 27);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Username :";
            // 
            // username
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(765, 416);
            this.Controls.Add(this.Authetification);
            this.Controls.Add(this.metroPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "username";
            this.Padding = new System.Windows.Forms.Padding(14, 60, 14, 12);
            this.Text = "Gestion de RDV";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel Authetification;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox userbox;
        private MetroFramework.Controls.MetroLabel pwd;
        private MetroFramework.Controls.MetroTextBox pwdbox;
        private MetroFramework.Controls.MetroRadioButton patient;
        private MetroFramework.Controls.MetroButton connexion;
        private MetroFramework.Controls.MetroRadioButton secretaire;
        private MetroFramework.Controls.MetroRadioButton medecin;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton sisncrire;
    }
}

