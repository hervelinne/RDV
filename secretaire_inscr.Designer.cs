namespace RDV
{
    partial class secretaire_inscr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.retour = new MetroFramework.Controls.MetroButton();
            this.enregistrer = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mdp = new MetroFramework.Controls.MetroTextBox();
            this.login = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroPanel1.Controls.Add(this.retour);
            this.metroPanel1.Controls.Add(this.enregistrer);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.mdp);
            this.metroPanel1.Controls.Add(this.login);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 12;
            this.metroPanel1.Location = new System.Drawing.Point(82, 87);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(636, 221);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 14;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // retour
            // 
            this.retour.Location = new System.Drawing.Point(437, 144);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(75, 23);
            this.retour.TabIndex = 24;
            this.retour.Text = "Retour";
            this.retour.UseSelectable = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // enregistrer
            // 
            this.enregistrer.Location = new System.Drawing.Point(151, 144);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(75, 23);
            this.enregistrer.TabIndex = 23;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.UseSelectable = true;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel8.Location = new System.Drawing.Point(151, 36);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(364, 15);
            this.metroLabel8.TabIndex = 22;
            this.metroLabel8.Text = "Les deux derniers parametres pour se connecter pour gerer votre RDV :";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroLabel7.Location = new System.Drawing.Point(310, 77);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(95, 19);
            this.metroLabel7.TabIndex = 21;
            this.metroLabel7.Text = "Mot de passe :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroLabel4.Location = new System.Drawing.Point(32, 77);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(48, 19);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Login :";
            // 
            // mdp
            // 
            this.mdp.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.mdp.CustomButton.Image = null;
            this.mdp.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.mdp.CustomButton.Name = "";
            this.mdp.CustomButton.Size = new System.Drawing.Size(14, 14);
            this.mdp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mdp.CustomButton.TabIndex = 1;
            this.mdp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mdp.CustomButton.UseSelectable = true;
            this.mdp.CustomButton.Visible = false;
            this.mdp.Lines = new string[0];
            this.mdp.Location = new System.Drawing.Point(437, 77);
            this.mdp.MaxLength = 32767;
            this.mdp.Name = "mdp";
            this.mdp.PasswordChar = '\0';
            this.mdp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mdp.SelectedText = "";
            this.mdp.SelectionLength = 0;
            this.mdp.SelectionStart = 0;
            this.mdp.ShortcutsEnabled = true;
            this.mdp.Size = new System.Drawing.Size(113, 23);
            this.mdp.TabIndex = 17;
            this.mdp.UseSelectable = true;
            this.mdp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mdp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.login.CustomButton.Image = null;
            this.login.CustomButton.Location = new System.Drawing.Point(61, 1);
            this.login.CustomButton.Name = "";
            this.login.CustomButton.Size = new System.Drawing.Size(14, 14);
            this.login.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.login.CustomButton.TabIndex = 1;
            this.login.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.login.CustomButton.UseSelectable = true;
            this.login.CustomButton.Visible = false;
            this.login.Lines = new string[0];
            this.login.Location = new System.Drawing.Point(151, 77);
            this.login.MaxLength = 32767;
            this.login.Name = "login";
            this.login.PasswordChar = '\0';
            this.login.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.login.SelectedText = "";
            this.login.SelectionLength = 0;
            this.login.SelectionStart = 0;
            this.login.ShortcutsEnabled = true;
            this.login.Size = new System.Drawing.Size(113, 23);
            this.login.TabIndex = 16;
            this.login.UseSelectable = true;
            this.login.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.login.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // secretaire_inscr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 396);
            this.Controls.Add(this.metroPanel1);
            this.Name = "secretaire_inscr";
            this.Padding = new System.Windows.Forms.Padding(20, 61, 20, 21);
            this.Text = "Inscription de la secretaire";
            this.Load += new System.EventHandler(this.secretaire_inscr_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton enregistrer;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox mdp;
        private MetroFramework.Controls.MetroTextBox login;
        private MetroFramework.Controls.MetroButton retour;
    }
}