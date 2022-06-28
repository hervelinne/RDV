namespace RDV
{
    partial class admin
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.medecinBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new RDV.DataSet();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.secretaireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.secretaire = new System.Windows.Forms.Button();
            this.medecin = new System.Windows.Forms.Button();
            this.rDVDataSet1 = new RDV.RDVDataSet1();
            this.medecinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medecinTableAdapter = new RDV.RDVDataSet1TableAdapters.medecinTableAdapter();
            this.medecinTableAdapter1 = new RDV.DataSetTableAdapters.medecinTableAdapter();
            this.secretaireTableAdapter = new RDV.DataSetTableAdapters.secretaireTableAdapter();
            this.logout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.secretaire_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mdpDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mdp = new MetroFramework.Controls.MetroTextBox();
            this.login = new MetroFramework.Controls.MetroTextBox();
            this.inputAdresse = new System.Windows.Forms.TextBox();
            this.tel = new MetroFramework.Controls.MetroTextBox();
            this.prenom = new MetroFramework.Controls.MetroTextBox();
            this.nom = new MetroFramework.Controls.MetroTextBox();
            this.inputPays = new MetroFramework.Controls.MetroComboBox();
            this.InputVilles = new MetroFramework.Controls.MetroComboBox();
            this.inputSpec = new MetroFramework.Controls.MetroComboBox();
            this.mdp1 = new MetroFramework.Controls.MetroTextBox();
            this.login1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.age = new MetroFramework.Controls.MetroTextBox();
            this.medecinBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.medecin_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mdpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretaireBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medecin_id,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.specialiteDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.mdpDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.medecinBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(411, 101);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(408, 149);
            this.dataGridView1.TabIndex = 39;
            // 
            // medecinBindingSource1
            // 
            this.medecinBindingSource1.DataMember = "medecin";
            this.medecinBindingSource1.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel4.Location = new System.Drawing.Point(411, 73);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(105, 15);
            this.metroLabel4.TabIndex = 38;
            this.metroLabel4.Text = "Listes des medecins";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.secretaire_id,
            this.loginDataGridViewTextBoxColumn1,
            this.mdpDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.secretaireBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(22, 101);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(367, 149);
            this.dataGridView2.TabIndex = 41;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // secretaireBindingSource
            // 
            this.secretaireBindingSource.DataMember = "secretaire";
            this.secretaireBindingSource.DataSource = this.dataSet;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel1.Location = new System.Drawing.Point(22, 73);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(111, 15);
            this.metroLabel1.TabIndex = 40;
            this.metroLabel1.Text = "Listes des secretaires";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // secretaire
            // 
            this.secretaire.BackColor = System.Drawing.Color.Silver;
            this.secretaire.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.secretaire.Location = new System.Drawing.Point(24, 267);
            this.secretaire.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.secretaire.Name = "secretaire";
            this.secretaire.Size = new System.Drawing.Size(112, 45);
            this.secretaire.TabIndex = 43;
            this.secretaire.Text = "Ajouter Secretaire";
            this.secretaire.UseVisualStyleBackColor = false;
            this.secretaire.Click += new System.EventHandler(this.secretaire_Click);
            // 
            // medecin
            // 
            this.medecin.BackColor = System.Drawing.Color.Silver;
            this.medecin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.medecin.Location = new System.Drawing.Point(411, 267);
            this.medecin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.medecin.Name = "medecin";
            this.medecin.Size = new System.Drawing.Size(112, 45);
            this.medecin.TabIndex = 42;
            this.medecin.Text = "Ajouter Medecin";
            this.medecin.UseVisualStyleBackColor = false;
            this.medecin.Click += new System.EventHandler(this.medecin_Click);
            // 
            // rDVDataSet1
            // 
            this.rDVDataSet1.DataSetName = "RDVDataSet1";
            this.rDVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medecinBindingSource
            // 
            this.medecinBindingSource.DataMember = "medecin";
            this.medecinBindingSource.DataSource = this.rDVDataSet1;
            // 
            // medecinTableAdapter
            // 
            this.medecinTableAdapter.ClearBeforeFill = true;
            // 
            // medecinTableAdapter1
            // 
            this.medecinTableAdapter1.ClearBeforeFill = true;
            // 
            // secretaireTableAdapter
            // 
            this.secretaireTableAdapter.ClearBeforeFill = true;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Orange;
            this.logout.Location = new System.Drawing.Point(63, 533);
            this.logout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(158, 48);
            this.logout.TabIndex = 44;
            this.logout.Text = "Se deconnecter";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(144, 267);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 45);
            this.button1.TabIndex = 45;
            this.button1.Text = "Supprimer Secretaire";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(531, 267);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 45);
            this.button2.TabIndex = 46;
            this.button2.Text = "Supprimer Medecin";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // secretaire_id
            // 
            this.secretaire_id.DataPropertyName = "secretaire_id";
            this.secretaire_id.HeaderText = "secretaire_id";
            this.secretaire_id.Name = "secretaire_id";
            this.secretaire_id.ReadOnly = true;
            // 
            // loginDataGridViewTextBoxColumn1
            // 
            this.loginDataGridViewTextBoxColumn1.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn1.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn1.Name = "loginDataGridViewTextBoxColumn1";
            // 
            // mdpDataGridViewTextBoxColumn1
            // 
            this.mdpDataGridViewTextBoxColumn1.DataPropertyName = "mdp";
            this.mdpDataGridViewTextBoxColumn1.HeaderText = "mdp";
            this.mdpDataGridViewTextBoxColumn1.Name = "mdpDataGridViewTextBoxColumn1";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(707, 345);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 45);
            this.button3.TabIndex = 47;
            this.button3.Text = "Modifier Medecin";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(228, 365);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 45);
            this.button4.TabIndex = 48;
            this.button4.Text = "Modifier secretaire";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroLabel7.Location = new System.Drawing.Point(22, 391);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(95, 19);
            this.metroLabel7.TabIndex = 52;
            this.metroLabel7.Text = "Mot de passe :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroLabel2.Location = new System.Drawing.Point(24, 339);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 51;
            this.metroLabel2.Text = "Login :";
            // 
            // mdp
            // 
            this.mdp.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.mdp.CustomButton.Image = null;
            this.mdp.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.mdp.CustomButton.Name = "";
            this.mdp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mdp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mdp.CustomButton.TabIndex = 1;
            this.mdp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mdp.CustomButton.UseSelectable = true;
            this.mdp.CustomButton.Visible = false;
            this.mdp.Lines = new string[0];
            this.mdp.Location = new System.Drawing.Point(95, 413);
            this.mdp.MaxLength = 32767;
            this.mdp.Name = "mdp";
            this.mdp.PasswordChar = '\0';
            this.mdp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mdp.SelectedText = "";
            this.mdp.SelectionLength = 0;
            this.mdp.SelectionStart = 0;
            this.mdp.ShortcutsEnabled = true;
            this.mdp.Size = new System.Drawing.Size(113, 23);
            this.mdp.TabIndex = 50;
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
            this.login.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.login.CustomButton.Name = "";
            this.login.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.login.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.login.CustomButton.TabIndex = 1;
            this.login.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.login.CustomButton.UseSelectable = true;
            this.login.CustomButton.Visible = false;
            this.login.Lines = new string[0];
            this.login.Location = new System.Drawing.Point(95, 339);
            this.login.MaxLength = 32767;
            this.login.Name = "login";
            this.login.PasswordChar = '\0';
            this.login.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.login.SelectedText = "";
            this.login.SelectionLength = 0;
            this.login.SelectionStart = 0;
            this.login.ShortcutsEnabled = true;
            this.login.Size = new System.Drawing.Size(113, 23);
            this.login.TabIndex = 49;
            this.login.UseSelectable = true;
            this.login.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.login.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // inputAdresse
            // 
            this.inputAdresse.Location = new System.Drawing.Point(421, 548);
            this.inputAdresse.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.inputAdresse.Multiline = true;
            this.inputAdresse.Name = "inputAdresse";
            this.inputAdresse.Size = new System.Drawing.Size(148, 71);
            this.inputAdresse.TabIndex = 62;
            this.inputAdresse.TextChanged += new System.EventHandler(this.inputAdresse_TextChanged);
            // 
            // tel
            // 
            this.tel.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tel.CustomButton.Image = null;
            this.tel.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.tel.CustomButton.Name = "";
            this.tel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tel.CustomButton.TabIndex = 1;
            this.tel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tel.CustomButton.UseSelectable = true;
            this.tel.CustomButton.Visible = false;
            this.tel.Lines = new string[0];
            this.tel.Location = new System.Drawing.Point(421, 496);
            this.tel.MaxLength = 32767;
            this.tel.Name = "tel";
            this.tel.PasswordChar = '\0';
            this.tel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tel.SelectedText = "";
            this.tel.SelectionLength = 0;
            this.tel.SelectionStart = 0;
            this.tel.ShortcutsEnabled = true;
            this.tel.Size = new System.Drawing.Size(113, 23);
            this.tel.TabIndex = 63;
            this.tel.UseSelectable = true;
            this.tel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // prenom
            // 
            this.prenom.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.prenom.CustomButton.Image = null;
            this.prenom.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.prenom.CustomButton.Name = "";
            this.prenom.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.prenom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.prenom.CustomButton.TabIndex = 1;
            this.prenom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.prenom.CustomButton.UseSelectable = true;
            this.prenom.CustomButton.Visible = false;
            this.prenom.Lines = new string[0];
            this.prenom.Location = new System.Drawing.Point(421, 401);
            this.prenom.MaxLength = 32767;
            this.prenom.Name = "prenom";
            this.prenom.PasswordChar = '\0';
            this.prenom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.prenom.SelectedText = "";
            this.prenom.SelectionLength = 0;
            this.prenom.SelectionStart = 0;
            this.prenom.ShortcutsEnabled = true;
            this.prenom.Size = new System.Drawing.Size(113, 23);
            this.prenom.TabIndex = 64;
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
            this.nom.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.nom.CustomButton.Name = "";
            this.nom.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nom.CustomButton.TabIndex = 1;
            this.nom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nom.CustomButton.UseSelectable = true;
            this.nom.CustomButton.Visible = false;
            this.nom.Lines = new string[0];
            this.nom.Location = new System.Drawing.Point(421, 347);
            this.nom.MaxLength = 32767;
            this.nom.Name = "nom";
            this.nom.PasswordChar = '\0';
            this.nom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nom.SelectedText = "";
            this.nom.SelectionLength = 0;
            this.nom.SelectionStart = 0;
            this.nom.ShortcutsEnabled = true;
            this.nom.Size = new System.Drawing.Size(113, 23);
            this.nom.TabIndex = 65;
            this.nom.UseSelectable = true;
            this.nom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // inputPays
            // 
            this.inputPays.FormattingEnabled = true;
            this.inputPays.ItemHeight = 23;
            this.inputPays.Items.AddRange(new object[] {
            "Maroc"});
            this.inputPays.Location = new System.Drawing.Point(585, 414);
            this.inputPays.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.inputPays.Name = "inputPays";
            this.inputPays.Size = new System.Drawing.Size(114, 29);
            this.inputPays.TabIndex = 68;
            this.inputPays.UseSelectable = true;
            // 
            // InputVilles
            // 
            this.InputVilles.FormattingEnabled = true;
            this.InputVilles.ItemHeight = 23;
            this.InputVilles.Items.AddRange(new object[] {
            "Cassablanca"});
            this.InputVilles.Location = new System.Drawing.Point(585, 464);
            this.InputVilles.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.InputVilles.Name = "InputVilles";
            this.InputVilles.Size = new System.Drawing.Size(114, 29);
            this.InputVilles.TabIndex = 67;
            this.InputVilles.UseSelectable = true;
            // 
            // inputSpec
            // 
            this.inputSpec.FormattingEnabled = true;
            this.inputSpec.ItemHeight = 23;
            this.inputSpec.Items.AddRange(new object[] {
            "Général"});
            this.inputSpec.Location = new System.Drawing.Point(585, 361);
            this.inputSpec.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.inputSpec.Name = "inputSpec";
            this.inputSpec.Size = new System.Drawing.Size(114, 29);
            this.inputSpec.TabIndex = 66;
            this.inputSpec.UseSelectable = true;
            // 
            // mdp1
            // 
            this.mdp1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.mdp1.CustomButton.Image = null;
            this.mdp1.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.mdp1.CustomButton.Name = "";
            this.mdp1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mdp1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mdp1.CustomButton.TabIndex = 1;
            this.mdp1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mdp1.CustomButton.UseSelectable = true;
            this.mdp1.CustomButton.Visible = false;
            this.mdp1.Lines = new string[0];
            this.mdp1.Location = new System.Drawing.Point(662, 570);
            this.mdp1.MaxLength = 32767;
            this.mdp1.Name = "mdp1";
            this.mdp1.PasswordChar = '\0';
            this.mdp1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mdp1.SelectedText = "";
            this.mdp1.SelectionLength = 0;
            this.mdp1.SelectionStart = 0;
            this.mdp1.ShortcutsEnabled = true;
            this.mdp1.Size = new System.Drawing.Size(113, 23);
            this.mdp1.TabIndex = 69;
            this.mdp1.UseSelectable = true;
            this.mdp1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mdp1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.login1.CustomButton.Image = null;
            this.login1.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.login1.CustomButton.Name = "";
            this.login1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.login1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.login1.CustomButton.TabIndex = 1;
            this.login1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.login1.CustomButton.UseSelectable = true;
            this.login1.CustomButton.Visible = false;
            this.login1.Lines = new string[0];
            this.login1.Location = new System.Drawing.Point(662, 508);
            this.login1.MaxLength = 32767;
            this.login1.Name = "login1";
            this.login1.PasswordChar = '\0';
            this.login1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.login1.SelectedText = "";
            this.login1.SelectionLength = 0;
            this.login1.SelectionStart = 0;
            this.login1.ShortcutsEnabled = true;
            this.login1.Size = new System.Drawing.Size(113, 23);
            this.login1.TabIndex = 70;
            this.login1.UseSelectable = true;
            this.login1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.login1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroLabel3.Location = new System.Drawing.Point(604, 548);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(95, 19);
            this.metroLabel3.TabIndex = 72;
            this.metroLabel3.Text = "Mot de passe :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroLabel5.Location = new System.Drawing.Point(604, 512);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(48, 19);
            this.metroLabel5.TabIndex = 71;
            this.metroLabel5.Text = "Login :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroLabel6.Location = new System.Drawing.Point(405, 474);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(35, 19);
            this.metroLabel6.TabIndex = 73;
            this.metroLabel6.Text = "Tel : ";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroLabel8.Location = new System.Drawing.Point(405, 522);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(66, 19);
            this.metroLabel8.TabIndex = 74;
            this.metroLabel8.Text = "Adresse : ";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroLabel10.Location = new System.Drawing.Point(405, 325);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(50, 19);
            this.metroLabel10.TabIndex = 75;
            this.metroLabel10.Text = "Nom : ";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroLabel11.Location = new System.Drawing.Point(555, 340);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(75, 19);
            this.metroLabel11.TabIndex = 76;
            this.metroLabel11.Text = "Specialite : ";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroLabel12.Location = new System.Drawing.Point(555, 392);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(45, 19);
            this.metroLabel12.TabIndex = 77;
            this.metroLabel12.Text = "Pays : ";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroLabel13.Location = new System.Drawing.Point(555, 443);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(40, 19);
            this.metroLabel13.TabIndex = 78;
            this.metroLabel13.Text = "Ville :";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroLabel14.Location = new System.Drawing.Point(405, 373);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(67, 19);
            this.metroLabel14.TabIndex = 79;
            this.metroLabel14.Text = "Prenom : ";
            this.metroLabel14.Click += new System.EventHandler(this.metroLabel14_Click);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroLabel15.Location = new System.Drawing.Point(405, 427);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(44, 19);
            this.metroLabel15.TabIndex = 81;
            this.metroLabel15.Text = "Age : ";
            // 
            // age
            // 
            this.age.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.age.CustomButton.Image = null;
            this.age.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.age.CustomButton.Name = "";
            this.age.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.age.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.age.CustomButton.TabIndex = 1;
            this.age.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.age.CustomButton.UseSelectable = true;
            this.age.CustomButton.Visible = false;
            this.age.Lines = new string[0];
            this.age.Location = new System.Drawing.Point(421, 449);
            this.age.MaxLength = 32767;
            this.age.Name = "age";
            this.age.PasswordChar = '\0';
            this.age.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.age.SelectedText = "";
            this.age.SelectionLength = 0;
            this.age.SelectionStart = 0;
            this.age.ShortcutsEnabled = true;
            this.age.Size = new System.Drawing.Size(113, 23);
            this.age.TabIndex = 80;
            this.age.UseSelectable = true;
            this.age.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.age.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // medecinBindingSource2
            // 
            this.medecinBindingSource2.DataMember = "medecin";
            this.medecinBindingSource2.DataSource = this.dataSet;
            // 
            // medecin_id
            // 
            this.medecin_id.DataPropertyName = "medecin_Id";
            this.medecin_id.HeaderText = "medecin_Id";
            this.medecin_id.Name = "medecin_id";
            this.medecin_id.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            // 
            // specialiteDataGridViewTextBoxColumn
            // 
            this.specialiteDataGridViewTextBoxColumn.DataPropertyName = "specialite";
            this.specialiteDataGridViewTextBoxColumn.HeaderText = "specialite";
            this.specialiteDataGridViewTextBoxColumn.Name = "specialiteDataGridViewTextBoxColumn";
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "tel";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // mdpDataGridViewTextBoxColumn
            // 
            this.mdpDataGridViewTextBoxColumn.DataPropertyName = "mdp";
            this.mdpDataGridViewTextBoxColumn.HeaderText = "mdp";
            this.mdpDataGridViewTextBoxColumn.Name = "mdpDataGridViewTextBoxColumn";
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "ville";
            this.villeDataGridViewTextBoxColumn.HeaderText = "ville";
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 630);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.age);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.mdp1);
            this.Controls.Add(this.inputPays);
            this.Controls.Add(this.InputVilles);
            this.Controls.Add(this.inputSpec);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.inputAdresse);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.login);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.secretaire);
            this.Controls.Add(this.medecin);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroLabel4);
            this.Name = "admin";
            this.Text = "Bienvenu dans la page admin !";
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretaireBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button secretaire;
        private System.Windows.Forms.Button medecin;
        private RDVDataSet1 rDVDataSet1;
        private System.Windows.Forms.BindingSource medecinBindingSource;
        private RDVDataSet1TableAdapters.medecinTableAdapter medecinTableAdapter;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource medecinBindingSource1;
        private DataSetTableAdapters.medecinTableAdapter medecinTableAdapter1;
        private System.Windows.Forms.BindingSource secretaireBindingSource;
        private DataSetTableAdapters.secretaireTableAdapter secretaireTableAdapter;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn secretaire_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mdpDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mdp;
        private MetroFramework.Controls.MetroTextBox login;
        private System.Windows.Forms.TextBox inputAdresse;
        private MetroFramework.Controls.MetroTextBox tel;
        private MetroFramework.Controls.MetroTextBox prenom;
        private MetroFramework.Controls.MetroTextBox nom;
        private MetroFramework.Controls.MetroComboBox inputPays;
        private MetroFramework.Controls.MetroComboBox InputVilles;
        private MetroFramework.Controls.MetroComboBox inputSpec;
        private MetroFramework.Controls.MetroTextBox mdp1;
        private MetroFramework.Controls.MetroTextBox login1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox age;
        private System.Windows.Forms.DataGridViewTextBoxColumn medecin_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mdpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource medecinBindingSource2;
    }
}