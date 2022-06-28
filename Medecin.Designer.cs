namespace RDV
{
    partial class Medecin
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.logout = new System.Windows.Forms.Button();
            this.inputIdMedecin = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.Authetification = new MetroFramework.Controls.MetroLabel();
            this.rdvTableAdapter = new RDV.DataSetTableAdapters.rdvTableAdapter();
            this.tableAdapterManager = new RDV.DataSetTableAdapters.TableAdapterManager();
            this.rdvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new RDV.DataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.dataSet1 = new RDV.DataSet();
            this.rdvBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rdv_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medecinidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdvBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdvBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroPanel1.Controls.Add(this.button1);
            this.metroPanel1.Controls.Add(this.dataGridView2);
            this.metroPanel1.Controls.Add(this.logout);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(48, 63);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(732, 368);
            this.metroPanel1.TabIndex = 6;
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
            this.rdv_id,
            this.dateDataGridViewTextBoxColumn,
            this.heureDataGridViewTextBoxColumn,
            this.medecinidDataGridViewTextBoxColumn,
            this.patientidDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.rdvBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(78, 12);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(564, 189);
            this.dataGridView2.TabIndex = 40;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.DarkTurquoise;
            this.logout.Location = new System.Drawing.Point(484, 207);
            this.logout.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(158, 48);
            this.logout.TabIndex = 39;
            this.logout.Text = "Se deconnecter";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // inputIdMedecin
            // 
            this.inputIdMedecin.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.inputIdMedecin.CustomButton.Image = null;
            this.inputIdMedecin.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.inputIdMedecin.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.inputIdMedecin.CustomButton.Name = "";
            this.inputIdMedecin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.inputIdMedecin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.inputIdMedecin.CustomButton.TabIndex = 1;
            this.inputIdMedecin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.inputIdMedecin.CustomButton.UseSelectable = true;
            this.inputIdMedecin.CustomButton.Visible = false;
            this.inputIdMedecin.Lines = new string[0];
            this.inputIdMedecin.Location = new System.Drawing.Point(652, 28);
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
            this.inputIdMedecin.Click += new System.EventHandler(this.inputIdMedecin_Click);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroLabel16.Location = new System.Drawing.Point(568, 32);
            this.metroLabel16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(62, 19);
            this.metroLabel16.TabIndex = 25;
            this.metroLabel16.Text = "Votre Id :";
            // 
            // Authetification
            // 
            this.Authetification.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Authetification.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Authetification.Location = new System.Drawing.Point(252, 26);
            this.Authetification.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Authetification.Name = "Authetification";
            this.Authetification.Size = new System.Drawing.Size(241, 34);
            this.Authetification.TabIndex = 5;
            this.Authetification.Text = "Liste de vos rendez-vous : ";
            this.Authetification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Authetification.Click += new System.EventHandler(this.Authetification_Click);
            // 
            // rdvTableAdapter
            // 
            this.rdvTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.medecinTableAdapter = null;
            this.tableAdapterManager.patientTableAdapter = null;
            this.tableAdapterManager.rdvTableAdapter = this.rdvTableAdapter;
            this.tableAdapterManager.secretaireTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RDV.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rdvBindingSource
            // 
            this.rdvBindingSource.DataMember = "rdv";
            this.rdvBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.Location = new System.Drawing.Point(87, 207);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 48);
            this.button1.TabIndex = 41;
            this.button1.Text = "Supprimer rendez-vous";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rdvBindingSource1
            // 
            this.rdvBindingSource1.DataMember = "rdv";
            this.rdvBindingSource1.DataSource = this.dataSet1;
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
            // Medecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.Authetification);
            this.Controls.Add(this.inputIdMedecin);
            this.Controls.Add(this.metroLabel16);
            this.Name = "Medecin";
            this.Text = "Bienvenu !";
            this.Load += new System.EventHandler(this.Medecin_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdvBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdvBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button logout;
        private MetroFramework.Controls.MetroTextBox inputIdMedecin;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel Authetification;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource rdvBindingSource;
        private DataSetTableAdapters.rdvTableAdapter rdvTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private DataSet dataSet1;
        private System.Windows.Forms.BindingSource rdvBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rdv_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medecinidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientidDataGridViewTextBoxColumn;
    }
}