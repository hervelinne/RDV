namespace RDV
{
    partial class sec_med
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
            this.Authetification = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.rdvidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medecinidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rDVDataSet = new RDV.RDVDataSet();
            this.logout = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cin_m = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.inputIdMedecin = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.rdvTableAdapter = new RDV.RDVDataSetTableAdapters.rdvTableAdapter();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdvBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDVDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Authetification
            // 
            this.Authetification.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Authetification.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Authetification.Location = new System.Drawing.Point(335, 43);
            this.Authetification.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Authetification.Name = "Authetification";
            this.Authetification.Size = new System.Drawing.Size(241, 34);
            this.Authetification.TabIndex = 3;
            this.Authetification.Text = "Gerer les rendez-vous";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroPanel1.Controls.Add(this.dataGridView2);
            this.metroPanel1.Controls.Add(this.logout);
            this.metroPanel1.Controls.Add(this.modifier);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.maskedTextBox1);
            this.metroPanel1.Controls.Add(this.dateTimePicker1);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.cin_m);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.inputIdMedecin);
            this.metroPanel1.Controls.Add(this.metroLabel16);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(74, 98);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(732, 402);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rdvidDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.heureDataGridViewTextBoxColumn,
            this.medecinidDataGridViewTextBoxColumn,
            this.patientidDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.rdvBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(38, 162);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(666, 154);
            this.dataGridView2.TabIndex = 40;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // rdvidDataGridViewTextBoxColumn
            // 
            this.rdvidDataGridViewTextBoxColumn.DataPropertyName = "rdv_id";
            this.rdvidDataGridViewTextBoxColumn.HeaderText = "rdv_id";
            this.rdvidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rdvidDataGridViewTextBoxColumn.Name = "rdvidDataGridViewTextBoxColumn";
            this.rdvidDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // heureDataGridViewTextBoxColumn
            // 
            this.heureDataGridViewTextBoxColumn.DataPropertyName = "heure";
            this.heureDataGridViewTextBoxColumn.HeaderText = "heure";
            this.heureDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.heureDataGridViewTextBoxColumn.Name = "heureDataGridViewTextBoxColumn";
            this.heureDataGridViewTextBoxColumn.Width = 150;
            // 
            // medecinidDataGridViewTextBoxColumn
            // 
            this.medecinidDataGridViewTextBoxColumn.DataPropertyName = "medecin_id";
            this.medecinidDataGridViewTextBoxColumn.HeaderText = "medecin_id";
            this.medecinidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.medecinidDataGridViewTextBoxColumn.Name = "medecinidDataGridViewTextBoxColumn";
            this.medecinidDataGridViewTextBoxColumn.Width = 150;
            // 
            // patientidDataGridViewTextBoxColumn
            // 
            this.patientidDataGridViewTextBoxColumn.DataPropertyName = "patient_id";
            this.patientidDataGridViewTextBoxColumn.HeaderText = "patient_id";
            this.patientidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.patientidDataGridViewTextBoxColumn.Name = "patientidDataGridViewTextBoxColumn";
            this.patientidDataGridViewTextBoxColumn.Width = 150;
            // 
            // rdvBindingSource
            // 
            this.rdvBindingSource.DataMember = "rdv";
            this.rdvBindingSource.DataSource = this.rDVDataSet;
            // 
            // rDVDataSet
            // 
            this.rDVDataSet.DataSetName = "RDVDataSet";
            this.rDVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.DarkTurquoise;
            this.logout.Location = new System.Drawing.Point(546, 341);
            this.logout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(158, 48);
            this.logout.TabIndex = 39;
            this.logout.Text = "Se deconnecter";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // modifier
            // 
            this.modifier.BackColor = System.Drawing.Color.DarkTurquoise;
            this.modifier.Location = new System.Drawing.Point(38, 341);
            this.modifier.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(158, 48);
            this.modifier.TabIndex = 38;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroLabel5.Location = new System.Drawing.Point(38, 139);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(142, 15);
            this.metroLabel5.TabIndex = 36;
            this.metroLabel5.Text = "Listes de vos rendez-vous :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroLabel3.Location = new System.Drawing.Point(306, 80);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(157, 19);
            this.metroLabel3.TabIndex = 32;
            this.metroLabel3.Text = " L\'heure du rendez-vous :";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(512, 80);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(98, 20);
            this.maskedTextBox1.TabIndex = 31;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(512, 28);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroLabel2.Location = new System.Drawing.Point(304, 28);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(158, 19);
            this.metroLabel2.TabIndex = 29;
            this.metroLabel2.Text = " La date du rendez-vous :";
            // 
            // cin_m
            // 
            this.cin_m.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.cin_m.CustomButton.Image = null;
            this.cin_m.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.cin_m.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cin_m.CustomButton.Name = "";
            this.cin_m.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.cin_m.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cin_m.CustomButton.TabIndex = 1;
            this.cin_m.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cin_m.CustomButton.UseSelectable = true;
            this.cin_m.CustomButton.Visible = false;
            this.cin_m.Lines = new string[0];
            this.cin_m.Location = new System.Drawing.Point(150, 76);
            this.cin_m.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cin_m.MaxLength = 32767;
            this.cin_m.Name = "cin_m";
            this.cin_m.PasswordChar = '\0';
            this.cin_m.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cin_m.SelectedText = "";
            this.cin_m.SelectionLength = 0;
            this.cin_m.SelectionStart = 0;
            this.cin_m.ShortcutsEnabled = true;
            this.cin_m.Size = new System.Drawing.Size(114, 23);
            this.cin_m.TabIndex = 28;
            this.cin_m.UseSelectable = true;
            this.cin_m.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cin_m.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroLabel1.Location = new System.Drawing.Point(28, 76);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 19);
            this.metroLabel1.TabIndex = 27;
            this.metroLabel1.Text = "Id Patient :";
            // 
            // inputIdMedecin
            // 
            this.inputIdMedecin.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.inputIdMedecin.CustomButton.Image = null;
            this.inputIdMedecin.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.inputIdMedecin.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputIdMedecin.CustomButton.Name = "";
            this.inputIdMedecin.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.inputIdMedecin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.inputIdMedecin.CustomButton.TabIndex = 1;
            this.inputIdMedecin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.inputIdMedecin.CustomButton.UseSelectable = true;
            this.inputIdMedecin.CustomButton.Visible = false;
            this.inputIdMedecin.Lines = new string[0];
            this.inputIdMedecin.Location = new System.Drawing.Point(150, 26);
            this.inputIdMedecin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.inputIdMedecin.MaxLength = 32767;
            this.inputIdMedecin.Name = "inputIdMedecin";
            this.inputIdMedecin.PasswordChar = '\0';
            this.inputIdMedecin.ReadOnly = true;
            this.inputIdMedecin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.inputIdMedecin.SelectedText = "";
            this.inputIdMedecin.SelectionLength = 0;
            this.inputIdMedecin.SelectionStart = 0;
            this.inputIdMedecin.ShortcutsEnabled = true;
            this.inputIdMedecin.Size = new System.Drawing.Size(114, 23);
            this.inputIdMedecin.TabIndex = 26;
            this.inputIdMedecin.UseSelectable = true;
            this.inputIdMedecin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.inputIdMedecin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.inputIdMedecin.Click += new System.EventHandler(this.cin_p_Click);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroLabel16.Location = new System.Drawing.Point(28, 28);
            this.metroLabel16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(62, 19);
            this.metroLabel16.TabIndex = 25;
            this.metroLabel16.Text = "Votre Id :";
            // 
            // rdvTableAdapter
            // 
            this.rdvTableAdapter.ClearBeforeFill = true;
            // 
            // sec_med
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(825, 513);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.Authetification);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "sec_med";
            this.Padding = new System.Windows.Forms.Padding(20, 62, 20, 21);
            this.Text = "Bienvenue !";
            this.Load += new System.EventHandler(this.sec_med_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdvBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rDVDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel Authetification;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox cin_m;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox inputIdMedecin;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button logout;
        private RDVDataSet rDVDataSet;
        private System.Windows.Forms.BindingSource rdvBindingSource;
        private RDVDataSetTableAdapters.rdvTableAdapter rdvTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdvidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medecinidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientidDataGridViewTextBoxColumn;
    }
}