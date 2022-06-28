namespace RDV
{
    partial class patient
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.date = new MetroFramework.Controls.MetroDateTime();
            this.logout = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.medecinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rDVDataSet1 = new RDV.RDVDataSet1();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.med = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.heure = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.inputIdMedecin = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.inputIdPatient = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.rech = new MetroFramework.Controls.MetroComboBox();
            this.rechercher = new System.Windows.Forms.Button();
            this.Authetification = new MetroFramework.Controls.MetroLabel();
            this.medecinTableAdapter = new RDV.RDVDataSet1TableAdapters.medecinTableAdapter();
            this.rDVDataSet = new RDV.RDVDataSet();
            this.rdvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rdvTableAdapter = new RDV.RDVDataSetTableAdapters.rdvTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.medecin_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet = new RDV.DataSet();
            this.medecinBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.medecinTableAdapter1 = new RDV.DataSetTableAdapters.medecinTableAdapter();
            this.rdvBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rdvTableAdapter1 = new RDV.DataSetTableAdapters.rdvTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.rdvBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.rdv_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medecinidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDVDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdvBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdvBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdvBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroPanel1.Controls.Add(this.button2);
            this.metroPanel1.Controls.Add(this.button1);
            this.metroPanel1.Controls.Add(this.date);
            this.metroPanel1.Controls.Add(this.logout);
            this.metroPanel1.Controls.Add(this.modifier);
            this.metroPanel1.Controls.Add(this.dataGridView1);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.dataGridView2);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.med);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.heure);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.inputIdMedecin);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.inputIdPatient);
            this.metroPanel1.Controls.Add(this.metroLabel16);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.rech);
            this.metroPanel1.Controls.Add(this.rechercher);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(67, 92);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(794, 604);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(532, 21);
            this.date.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.date.MinimumSize = new System.Drawing.Size(0, 29);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(161, 30);
            this.date.TabIndex = 41;
            this.date.ValueChanged += new System.EventHandler(this.metroDateTime1_ValueChanged);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.Orange;
            this.logout.Location = new System.Drawing.Point(624, 545);
            this.logout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(158, 48);
            this.logout.TabIndex = 40;
            this.logout.Text = "Se deconnecter";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click_1);
            // 
            // modifier
            // 
            this.modifier.BackColor = System.Drawing.Color.Orange;
            this.modifier.Location = new System.Drawing.Point(650, 104);
            this.modifier.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(132, 45);
            this.modifier.TabIndex = 39;
            this.modifier.Text = "Prendre RDV";
            this.modifier.UseVisualStyleBackColor = false;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medecin_Id,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.specialiteDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.medecinBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(198, 162);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(594, 154);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // medecinBindingSource
            // 
            this.medecinBindingSource.DataMember = "medecin";
            this.medecinBindingSource.DataSource = this.rDVDataSet1;
            // 
            // rDVDataSet1
            // 
            this.rDVDataSet1.DataSetName = "RDVDataSet1";
            this.rDVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel5.Location = new System.Drawing.Point(59, 337);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(136, 15);
            this.metroLabel5.TabIndex = 36;
            this.metroLabel5.Text = "Listes de vos rendez-vous";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.OldLace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rdv_id,
            this.dateDataGridViewTextBoxColumn,
            this.heureDataGridViewTextBoxColumn,
            this.medecinidDataGridViewTextBoxColumn,
            this.patientidDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.rdvBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(59, 371);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(571, 154);
            this.dataGridView2.TabIndex = 35;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel4.Location = new System.Drawing.Point(222, 134);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(105, 15);
            this.metroLabel4.TabIndex = 34;
            this.metroLabel4.Text = "Listes des medecins";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // med
            // 
            this.med.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.med.CustomButton.Image = null;
            this.med.CustomButton.Location = new System.Drawing.Point(54, 1);
            this.med.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.med.CustomButton.Name = "";
            this.med.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.med.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.med.CustomButton.TabIndex = 1;
            this.med.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.med.CustomButton.UseSelectable = true;
            this.med.CustomButton.Visible = false;
            this.med.Lines = new string[0];
            this.med.Location = new System.Drawing.Point(28, 196);
            this.med.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.med.MaxLength = 32767;
            this.med.Name = "med";
            this.med.PasswordChar = '\0';
            this.med.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.med.SelectedText = "";
            this.med.SelectionLength = 0;
            this.med.SelectionStart = 0;
            this.med.ShortcutsEnabled = true;
            this.med.Size = new System.Drawing.Size(138, 23);
            this.med.TabIndex = 33;
            this.med.UseSelectable = true;
            this.med.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.med.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroLabel3.Location = new System.Drawing.Point(322, 80);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(157, 19);
            this.metroLabel3.TabIndex = 32;
            this.metroLabel3.Text = " L\'heure du rendez-vous :";
            // 
            // heure
            // 
            this.heure.Location = new System.Drawing.Point(532, 78);
            this.heure.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.heure.Mask = "00:00";
            this.heure.Name = "heure";
            this.heure.Size = new System.Drawing.Size(98, 20);
            this.heure.TabIndex = 31;
            this.heure.ValidatingType = typeof(System.DateTime);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroLabel2.Location = new System.Drawing.Point(322, 29);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(158, 19);
            this.metroLabel2.TabIndex = 29;
            this.metroLabel2.Text = " La date du rendez-vous :";
            // 
            // inputIdMedecin
            // 
            this.inputIdMedecin.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.inputIdMedecin.CustomButton.Image = null;
            this.inputIdMedecin.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.inputIdMedecin.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.inputIdMedecin.CustomButton.Name = "";
            this.inputIdMedecin.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.inputIdMedecin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.inputIdMedecin.CustomButton.TabIndex = 1;
            this.inputIdMedecin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.inputIdMedecin.CustomButton.UseSelectable = true;
            this.inputIdMedecin.CustomButton.Visible = false;
            this.inputIdMedecin.Lines = new string[0];
            this.inputIdMedecin.Location = new System.Drawing.Point(150, 76);
            this.inputIdMedecin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.inputIdMedecin.MaxLength = 32767;
            this.inputIdMedecin.Name = "inputIdMedecin";
            this.inputIdMedecin.PasswordChar = '\0';
            this.inputIdMedecin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.inputIdMedecin.SelectedText = "";
            this.inputIdMedecin.SelectionLength = 0;
            this.inputIdMedecin.SelectionStart = 0;
            this.inputIdMedecin.ShortcutsEnabled = true;
            this.inputIdMedecin.Size = new System.Drawing.Size(114, 23);
            this.inputIdMedecin.TabIndex = 28;
            this.inputIdMedecin.UseSelectable = true;
            this.inputIdMedecin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.inputIdMedecin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.inputIdMedecin.Click += new System.EventHandler(this.inputIdMedecin_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroLabel1.Location = new System.Drawing.Point(28, 76);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 27;
            this.metroLabel1.Text = "Id medecin :";
            // 
            // inputIdPatient
            // 
            this.inputIdPatient.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.inputIdPatient.CustomButton.Image = null;
            this.inputIdPatient.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.inputIdPatient.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.inputIdPatient.CustomButton.Name = "";
            this.inputIdPatient.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.inputIdPatient.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.inputIdPatient.CustomButton.TabIndex = 1;
            this.inputIdPatient.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.inputIdPatient.CustomButton.UseSelectable = true;
            this.inputIdPatient.CustomButton.Visible = false;
            this.inputIdPatient.Lines = new string[0];
            this.inputIdPatient.Location = new System.Drawing.Point(150, 25);
            this.inputIdPatient.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.inputIdPatient.MaxLength = 32767;
            this.inputIdPatient.Name = "inputIdPatient";
            this.inputIdPatient.PasswordChar = '\0';
            this.inputIdPatient.ReadOnly = true;
            this.inputIdPatient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.inputIdPatient.SelectedText = "";
            this.inputIdPatient.SelectionLength = 0;
            this.inputIdPatient.SelectionStart = 0;
            this.inputIdPatient.ShortcutsEnabled = true;
            this.inputIdPatient.Size = new System.Drawing.Size(114, 23);
            this.inputIdPatient.TabIndex = 26;
            this.inputIdPatient.UseSelectable = true;
            this.inputIdPatient.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.inputIdPatient.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.inputIdPatient.Click += new System.EventHandler(this.cin_p_Click);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroLabel16.Location = new System.Drawing.Point(28, 29);
            this.metroLabel16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(62, 19);
            this.metroLabel16.TabIndex = 25;
            this.metroLabel16.Text = "Votre Id :";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel8.Location = new System.Drawing.Point(28, 134);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(148, 15);
            this.metroLabel8.TabIndex = 23;
            this.metroLabel8.Text = "Rechercher un medecin par :";
            // 
            // rech
            // 
            this.rech.FormattingEnabled = true;
            this.rech.ItemHeight = 23;
            this.rech.Items.AddRange(new object[] {
            "Nom",
            "Spécialité",
            "Ville"});
            this.rech.Location = new System.Drawing.Point(28, 162);
            this.rech.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rech.Name = "rech";
            this.rech.Size = new System.Drawing.Size(138, 29);
            this.rech.TabIndex = 17;
            this.rech.UseSelectable = true;
            this.rech.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
            // 
            // rechercher
            // 
            this.rechercher.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rechercher.Location = new System.Drawing.Point(27, 224);
            this.rechercher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rechercher.Name = "rechercher";
            this.rechercher.Size = new System.Drawing.Size(82, 33);
            this.rechercher.TabIndex = 16;
            this.rechercher.Text = "Rechercher";
            this.rechercher.UseVisualStyleBackColor = true;
            this.rechercher.Click += new System.EventHandler(this.rechercher_Click);
            // 
            // Authetification
            // 
            this.Authetification.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Authetification.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Authetification.Location = new System.Drawing.Point(378, 54);
            this.Authetification.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Authetification.Name = "Authetification";
            this.Authetification.Size = new System.Drawing.Size(318, 34);
            this.Authetification.TabIndex = 2;
            this.Authetification.Text = "Effectuer votre rendez-vous";
            // 
            // medecinTableAdapter
            // 
            this.medecinTableAdapter.ClearBeforeFill = true;
            // 
            // rDVDataSet
            // 
            this.rDVDataSet.DataSetName = "RDVDataSet";
            this.rDVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rdvBindingSource
            // 
            this.rdvBindingSource.DataMember = "rdv";
            this.rdvBindingSource.DataSource = this.rDVDataSet;
            // 
            // rdvTableAdapter
            // 
            this.rdvTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(113, 224);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 33);
            this.button1.TabIndex = 42;
            this.button1.Text = "Annuler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // medecin_Id
            // 
            this.medecin_Id.DataPropertyName = "medecin_Id";
            this.medecin_Id.HeaderText = "medecin_Id";
            this.medecin_Id.Name = "medecin_Id";
            this.medecin_Id.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.Width = 125;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "prenom";
            this.prenomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.Width = 125;
            // 
            // specialiteDataGridViewTextBoxColumn
            // 
            this.specialiteDataGridViewTextBoxColumn.DataPropertyName = "specialite";
            this.specialiteDataGridViewTextBoxColumn.HeaderText = "specialite";
            this.specialiteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.specialiteDataGridViewTextBoxColumn.Name = "specialiteDataGridViewTextBoxColumn";
            this.specialiteDataGridViewTextBoxColumn.Width = 125;
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "ville";
            this.villeDataGridViewTextBoxColumn.HeaderText = "ville";
            this.villeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            this.villeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medecinBindingSource1
            // 
            this.medecinBindingSource1.DataMember = "medecin";
            this.medecinBindingSource1.DataSource = this.dataSet;
            // 
            // medecinTableAdapter1
            // 
            this.medecinTableAdapter1.ClearBeforeFill = true;
            // 
            // rdvBindingSource1
            // 
            this.rdvBindingSource1.DataMember = "rdv";
            this.rdvBindingSource1.DataSource = this.dataSet;
            // 
            // rdvTableAdapter1
            // 
            this.rdvTableAdapter1.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.Location = new System.Drawing.Point(63, 545);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 45);
            this.button2.TabIndex = 43;
            this.button2.Text = "Supprimer rendez-vous";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rdvBindingSource2
            // 
            this.rdvBindingSource2.DataMember = "rdv";
            this.rdvBindingSource2.DataSource = this.dataSet;
            // 
            // rdv_id
            // 
            this.rdv_id.DataPropertyName = "rdv_id";
            this.rdv_id.HeaderText = "rdv_id";
            this.rdv_id.Name = "rdv_id";
            this.rdv_id.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // heureDataGridViewTextBoxColumn
            // 
            this.heureDataGridViewTextBoxColumn.DataPropertyName = "heure";
            this.heureDataGridViewTextBoxColumn.HeaderText = "heure";
            this.heureDataGridViewTextBoxColumn.Name = "heureDataGridViewTextBoxColumn";
            // 
            // medecinidDataGridViewTextBoxColumn
            // 
            this.medecinidDataGridViewTextBoxColumn.DataPropertyName = "medecin_id";
            this.medecinidDataGridViewTextBoxColumn.HeaderText = "medecin_id";
            this.medecinidDataGridViewTextBoxColumn.Name = "medecinidDataGridViewTextBoxColumn";
            // 
            // patientidDataGridViewTextBoxColumn
            // 
            this.patientidDataGridViewTextBoxColumn.DataPropertyName = "patient_id";
            this.patientidDataGridViewTextBoxColumn.HeaderText = "patient_id";
            this.patientidDataGridViewTextBoxColumn.Name = "patientidDataGridViewTextBoxColumn";
            // 
            // patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(924, 709);
            this.Controls.Add(this.Authetification);
            this.Controls.Add(this.metroPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "patient";
            this.Padding = new System.Windows.Forms.Padding(20, 62, 20, 21);
            this.Text = "Bienvenue !";
            this.Load += new System.EventHandler(this.patient_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDVDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdvBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdvBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdvBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Button rechercher;
        private MetroFramework.Controls.MetroComboBox rech;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel Authetification;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox inputIdMedecin;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox inputIdPatient;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.MaskedTextBox heure;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox med;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button logout;
        private RDVDataSet1 rDVDataSet1;
        private System.Windows.Forms.BindingSource medecinBindingSource;
        private RDVDataSet1TableAdapters.medecinTableAdapter medecinTableAdapter;
        private MetroFramework.Controls.MetroDateTime date;
        private RDVDataSet rDVDataSet;
        private System.Windows.Forms.BindingSource rdvBindingSource;
        private RDVDataSetTableAdapters.rdvTableAdapter rdvTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn medecin_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource medecinBindingSource1;
        private DataSetTableAdapters.medecinTableAdapter medecinTableAdapter1;
        private System.Windows.Forms.BindingSource rdvBindingSource1;
        private DataSetTableAdapters.rdvTableAdapter rdvTableAdapter1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource rdvBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdv_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medecinidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientidDataGridViewTextBoxColumn;
    }
}