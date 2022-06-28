namespace RDV
{
    partial class medecin_inscr
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
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.inputPays = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.InputVilles = new MetroFramework.Controls.MetroComboBox();
            this.inputSpec = new MetroFramework.Controls.MetroComboBox();
            this.inputAdresse = new System.Windows.Forms.TextBox();
            this.retour = new MetroFramework.Controls.MetroButton();
            this.enregistrer = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mdp = new MetroFramework.Controls.MetroTextBox();
            this.login = new MetroFramework.Controls.MetroTextBox();
            this.age = new MetroFramework.Controls.MetroTextBox();
            this.tel = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.prenom = new MetroFramework.Controls.MetroTextBox();
            this.nom = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroPanel1.Controls.Add(this.metroLabel12);
            this.metroPanel1.Controls.Add(this.inputPays);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.InputVilles);
            this.metroPanel1.Controls.Add(this.inputSpec);
            this.metroPanel1.Controls.Add(this.inputAdresse);
            this.metroPanel1.Controls.Add(this.retour);
            this.metroPanel1.Controls.Add(this.enregistrer);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.mdp);
            this.metroPanel1.Controls.Add(this.login);
            this.metroPanel1.Controls.Add(this.age);
            this.metroPanel1.Controls.Add(this.tel);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.prenom);
            this.metroPanel1.Controls.Add(this.nom);
            this.metroPanel1.ForeColor = System.Drawing.Color.White;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 19;
            this.metroPanel1.Location = new System.Drawing.Point(127, 131);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1018, 615);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 21;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.Location = new System.Drawing.Point(497, 112);
            this.metroLabel12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(61, 25);
            this.metroLabel12.TabIndex = 34;
            this.metroLabel12.Text = "Pays :";
            this.metroLabel12.UseCustomBackColor = true;
            this.metroLabel12.UseCustomForeColor = true;
            // 
            // inputPays
            // 
            this.inputPays.FormattingEnabled = true;
            this.inputPays.ItemHeight = 24;
            this.inputPays.Items.AddRange(new object[] {
            "Maroc"});
            this.inputPays.Location = new System.Drawing.Point(685, 112);
            this.inputPays.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.inputPays.Name = "inputPays";
            this.inputPays.Size = new System.Drawing.Size(220, 30);
            this.inputPays.TabIndex = 32;
            this.inputPays.UseSelectable = true;
            this.inputPays.SelectedIndexChanged += new System.EventHandler(this.inputPays_SelectedIndexChanged);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(497, 175);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(59, 25);
            this.metroLabel10.TabIndex = 31;
            this.metroLabel10.Text = "Ville :";
            this.metroLabel10.UseCustomBackColor = true;
            this.metroLabel10.UseCustomForeColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(497, 45);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(104, 25);
            this.metroLabel9.TabIndex = 30;
            this.metroLabel9.Text = "Spécialite :";
            this.metroLabel9.UseCustomBackColor = true;
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // InputVilles
            // 
            this.InputVilles.FormattingEnabled = true;
            this.InputVilles.ItemHeight = 24;
            this.InputVilles.Items.AddRange(new object[] {
            "Cassablanca"});
            this.InputVilles.Location = new System.Drawing.Point(685, 175);
            this.InputVilles.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.InputVilles.Name = "InputVilles";
            this.InputVilles.Size = new System.Drawing.Size(220, 30);
            this.InputVilles.TabIndex = 29;
            this.InputVilles.UseSelectable = true;
            // 
            // inputSpec
            // 
            this.inputSpec.FormattingEnabled = true;
            this.inputSpec.ItemHeight = 24;
            this.inputSpec.Items.AddRange(new object[] {
            "Général"});
            this.inputSpec.Location = new System.Drawing.Point(685, 45);
            this.inputSpec.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.inputSpec.Name = "inputSpec";
            this.inputSpec.Size = new System.Drawing.Size(220, 30);
            this.inputSpec.TabIndex = 28;
            this.inputSpec.UseSelectable = true;
            // 
            // inputAdresse
            // 
            this.inputAdresse.Location = new System.Drawing.Point(199, 380);
            this.inputAdresse.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.inputAdresse.Multiline = true;
            this.inputAdresse.Name = "inputAdresse";
            this.inputAdresse.Size = new System.Drawing.Size(239, 133);
            this.inputAdresse.TabIndex = 27;
            // 
            // retour
            // 
            this.retour.BackColor = System.Drawing.Color.Teal;
            this.retour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.retour.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.retour.Location = new System.Drawing.Point(701, 530);
            this.retour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(142, 58);
            this.retour.TabIndex = 26;
            this.retour.Text = "Retour";
            this.retour.UseCustomBackColor = true;
            this.retour.UseCustomForeColor = true;
            this.retour.UseSelectable = true;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // enregistrer
            // 
            this.enregistrer.BackColor = System.Drawing.Color.Teal;
            this.enregistrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.enregistrer.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.enregistrer.Highlight = true;
            this.enregistrer.Location = new System.Drawing.Point(249, 530);
            this.enregistrer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(122, 58);
            this.enregistrer.TabIndex = 23;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.UseCustomBackColor = true;
            this.enregistrer.UseCustomForeColor = true;
            this.enregistrer.UseSelectable = true;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.metroLabel8.Location = new System.Drawing.Point(482, 288);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(402, 17);
            this.metroLabel8.TabIndex = 22;
            this.metroLabel8.Text = "Les deux derniers parametres pour se connecter pour gerer votre RDV :";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(513, 431);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(135, 25);
            this.metroLabel7.TabIndex = 21;
            this.metroLabel7.Text = "Mot de passe :";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(513, 351);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(69, 25);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Login :";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(36, 202);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(61, 25);
            this.metroLabel3.TabIndex = 19;
            this.metroLabel3.Text = " Age :";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.UseWaitCursor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(39, 291);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 25);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Tel :";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // mdp
            // 
            this.mdp.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.mdp.CustomButton.Image = null;
            this.mdp.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.mdp.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mdp.CustomButton.Name = "";
            this.mdp.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.mdp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mdp.CustomButton.TabIndex = 1;
            this.mdp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mdp.CustomButton.UseSelectable = true;
            this.mdp.CustomButton.Visible = false;
            this.mdp.Lines = new string[0];
            this.mdp.Location = new System.Drawing.Point(701, 431);
            this.mdp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mdp.MaxLength = 32767;
            this.mdp.Name = "mdp";
            this.mdp.PasswordChar = '\0';
            this.mdp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mdp.SelectedText = "";
            this.mdp.SelectionLength = 0;
            this.mdp.SelectionStart = 0;
            this.mdp.ShortcutsEnabled = true;
            this.mdp.Size = new System.Drawing.Size(170, 35);
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
            this.login.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.login.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.login.CustomButton.Name = "";
            this.login.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.login.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.login.CustomButton.TabIndex = 1;
            this.login.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.login.CustomButton.UseSelectable = true;
            this.login.CustomButton.Visible = false;
            this.login.Lines = new string[0];
            this.login.Location = new System.Drawing.Point(701, 345);
            this.login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.login.MaxLength = 32767;
            this.login.Name = "login";
            this.login.PasswordChar = '\0';
            this.login.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.login.SelectedText = "";
            this.login.SelectionLength = 0;
            this.login.SelectionStart = 0;
            this.login.ShortcutsEnabled = true;
            this.login.Size = new System.Drawing.Size(170, 35);
            this.login.TabIndex = 16;
            this.login.UseSelectable = true;
            this.login.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.login.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // age
            // 
            this.age.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.age.CustomButton.Image = null;
            this.age.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.age.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.age.CustomButton.Name = "";
            this.age.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.age.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.age.CustomButton.TabIndex = 1;
            this.age.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.age.CustomButton.UseSelectable = true;
            this.age.CustomButton.Visible = false;
            this.age.Lines = new string[0];
            this.age.Location = new System.Drawing.Point(213, 199);
            this.age.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.age.MaxLength = 32767;
            this.age.Name = "age";
            this.age.PasswordChar = '\0';
            this.age.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.age.SelectedText = "";
            this.age.SelectionLength = 0;
            this.age.SelectionStart = 0;
            this.age.ShortcutsEnabled = true;
            this.age.Size = new System.Drawing.Size(170, 35);
            this.age.TabIndex = 15;
            this.age.UseSelectable = true;
            this.age.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.age.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tel
            // 
            this.tel.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tel.CustomButton.Image = null;
            this.tel.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.tel.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tel.CustomButton.Name = "";
            this.tel.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.tel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tel.CustomButton.TabIndex = 1;
            this.tel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tel.CustomButton.UseSelectable = true;
            this.tel.CustomButton.Visible = false;
            this.tel.Lines = new string[0];
            this.tel.Location = new System.Drawing.Point(213, 288);
            this.tel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tel.MaxLength = 32767;
            this.tel.Name = "tel";
            this.tel.PasswordChar = '\0';
            this.tel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tel.SelectedText = "";
            this.tel.SelectionLength = 0;
            this.tel.SelectionStart = 0;
            this.tel.ShortcutsEnabled = true;
            this.tel.Size = new System.Drawing.Size(170, 35);
            this.tel.TabIndex = 14;
            this.tel.UseSelectable = true;
            this.tel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.ForeColor = System.Drawing.Color.White;
            this.metroLabel6.Location = new System.Drawing.Point(36, 380);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(89, 25);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Adresse :";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            this.metroLabel6.UseWaitCursor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.Color.White;
            this.metroLabel5.Location = new System.Drawing.Point(36, 128);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(88, 25);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Prenom :";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            this.metroLabel5.UseWaitCursor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(36, 45);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 25);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Nom :";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseWaitCursor = true;
            // 
            // prenom
            // 
            this.prenom.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.prenom.CustomButton.Image = null;
            this.prenom.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.prenom.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.prenom.CustomButton.Name = "";
            this.prenom.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.prenom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.prenom.CustomButton.TabIndex = 1;
            this.prenom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.prenom.CustomButton.UseSelectable = true;
            this.prenom.CustomButton.Visible = false;
            this.prenom.Lines = new string[0];
            this.prenom.Location = new System.Drawing.Point(213, 121);
            this.prenom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prenom.MaxLength = 32767;
            this.prenom.Name = "prenom";
            this.prenom.PasswordChar = '\0';
            this.prenom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.prenom.SelectedText = "";
            this.prenom.SelectionLength = 0;
            this.prenom.SelectionStart = 0;
            this.prenom.ShortcutsEnabled = true;
            this.prenom.Size = new System.Drawing.Size(170, 35);
            this.prenom.TabIndex = 8;
            this.prenom.UseSelectable = true;
            this.prenom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.prenom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nom
            // 
            this.nom.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.nom.CustomButton.Image = null;
            this.nom.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.nom.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nom.CustomButton.Name = "";
            this.nom.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.nom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nom.CustomButton.TabIndex = 1;
            this.nom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nom.CustomButton.UseSelectable = true;
            this.nom.CustomButton.Visible = false;
            this.nom.Lines = new string[0];
            this.nom.Location = new System.Drawing.Point(213, 45);
            this.nom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nom.MaxLength = 32767;
            this.nom.Name = "nom";
            this.nom.PasswordChar = '\0';
            this.nom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nom.SelectedText = "";
            this.nom.SelectionLength = 0;
            this.nom.SelectionStart = 0;
            this.nom.ShortcutsEnabled = true;
            this.nom.Size = new System.Drawing.Size(170, 35);
            this.nom.TabIndex = 5;
            this.nom.UseSelectable = true;
            this.nom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.nom.Click += new System.EventHandler(this.nom_Click);
            // 
            // medecin_inscr
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1277, 825);
            this.Controls.Add(this.metroPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "medecin_inscr";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Text = "Inscription du medecin";
            this.Load += new System.EventHandler(this.medecin_inscr_Load);
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
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mdp;
        private MetroFramework.Controls.MetroTextBox login;
        private MetroFramework.Controls.MetroTextBox age;
        private MetroFramework.Controls.MetroTextBox tel;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox prenom;
        private MetroFramework.Controls.MetroTextBox nom;
        private MetroFramework.Controls.MetroButton retour;
        private System.Windows.Forms.TextBox inputAdresse;
        private MetroFramework.Controls.MetroComboBox InputVilles;
        private MetroFramework.Controls.MetroComboBox inputSpec;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroComboBox inputPays;
    }
}