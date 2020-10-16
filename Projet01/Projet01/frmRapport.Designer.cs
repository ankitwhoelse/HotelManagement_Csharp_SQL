namespace Projet01
{
    partial class frmRapport
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
            System.Windows.Forms.Label totalSoldeLabel;
            this.bDB56AnkitDataSet = new Projet01.BDB56AnkitDataSet();
            this.personnesPlanifBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personnesPlanifTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.personnesPlanifTableAdapter();
            this.tableAdapterManager = new Projet01.BDB56AnkitDataSetTableAdapters.TableAdapterManager();
            this.cboPersonnes = new System.Windows.Forms.ComboBox();
            this.rapportSoinsClientInviteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rapportSoinsClientInviteTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.rapportSoinsClientInviteTableAdapter();
            this.dgInfoSoinPersonne = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitre = new System.Windows.Forms.Label();
            this.totalSoldeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbRapport1 = new System.Windows.Forms.GroupBox();
            this.gbRapport3 = new System.Windows.Forms.GroupBox();
            this.assistantsListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assistantsListTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.assistantsListTableAdapter();
            this.assistantsListComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateSoinAssistantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateSoinAssistantTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.dateSoinAssistantTableAdapter();
            this.dateSoinAssistantComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.soinDateAssistantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soinDateAssistantTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.soinDateAssistantTableAdapter();
            this.soinDateAssistantComboBox = new System.Windows.Forms.ComboBox();
            this.rapportSoinsAssistantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rapportSoinsAssistantTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.rapportSoinsAssistantTableAdapter();
            this.rapportSoinsAssistantDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            totalSoldeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56AnkitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnesPlanifBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportSoinsClientInviteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInfoSoinPersonne)).BeginInit();
            this.gbRapport1.SuspendLayout();
            this.gbRapport3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assistantsListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSoinAssistantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinDateAssistantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportSoinsAssistantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportSoinsAssistantDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // totalSoldeLabel
            // 
            totalSoldeLabel.AutoSize = true;
            totalSoldeLabel.Location = new System.Drawing.Point(266, 257);
            totalSoldeLabel.Name = "totalSoldeLabel";
            totalSoldeLabel.Size = new System.Drawing.Size(81, 13);
            totalSoldeLabel.TabIndex = 19;
            totalSoldeLabel.Text = "Total des soins:";
            // 
            // bDB56AnkitDataSet
            // 
            this.bDB56AnkitDataSet.DataSetName = "BDB56AnkitDataSet";
            this.bDB56AnkitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personnesPlanifBindingSource
            // 
            this.personnesPlanifBindingSource.DataMember = "personnesPlanif";
            this.personnesPlanifBindingSource.DataSource = this.bDB56AnkitDataSet;
            // 
            // personnesPlanifTableAdapter
            // 
            this.personnesPlanifTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.assistantsListTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.nosEtNomsClientsTableAdapter = null;
            this.tableAdapterManager.P01_AssistantSoinTableAdapter = null;
            this.tableAdapterManager.P01_AssistantTableAdapter = null;
            this.tableAdapterManager.P01_ChambreTableAdapter = null;
            this.tableAdapterManager.P01_ClientTableAdapter = null;
            this.tableAdapterManager.P01_InviteTableAdapter = null;
            this.tableAdapterManager.P01_PlanifSoinTableAdapter = null;
            this.tableAdapterManager.P01_ReservationChambreTableAdapter = null;
            this.tableAdapterManager.P01_SoinTableAdapter = null;
            this.tableAdapterManager.P01_TypeChambreTableAdapter = null;
            this.tableAdapterManager.P01_TypeSoinTableAdapter = null;
            this.tableAdapterManager.P01_TypeUtilisateurTableAdapter = null;
            this.tableAdapterManager.P01_UtilisateurTableAdapter = null;
            this.tableAdapterManager.soinDateAssistantTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet01.BDB56AnkitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cboPersonnes
            // 
            this.cboPersonnes.DataSource = this.personnesPlanifBindingSource;
            this.cboPersonnes.DisplayMember = "NomComplet";
            this.cboPersonnes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPersonnes.FormattingEnabled = true;
            this.cboPersonnes.Location = new System.Drawing.Point(6, 18);
            this.cboPersonnes.Name = "cboPersonnes";
            this.cboPersonnes.Size = new System.Drawing.Size(192, 21);
            this.cboPersonnes.TabIndex = 1;
            this.cboPersonnes.ValueMember = "NoPersonne";
            // 
            // rapportSoinsClientInviteBindingSource
            // 
            this.rapportSoinsClientInviteBindingSource.DataMember = "fk_pers";
            this.rapportSoinsClientInviteBindingSource.DataSource = this.personnesPlanifBindingSource;
            // 
            // rapportSoinsClientInviteTableAdapter
            // 
            this.rapportSoinsClientInviteTableAdapter.ClearBeforeFill = true;
            // 
            // dgInfoSoinPersonne
            // 
            this.dgInfoSoinPersonne.AllowUserToAddRows = false;
            this.dgInfoSoinPersonne.AllowUserToDeleteRows = false;
            this.dgInfoSoinPersonne.AutoGenerateColumns = false;
            this.dgInfoSoinPersonne.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgInfoSoinPersonne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInfoSoinPersonne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dgInfoSoinPersonne.DataSource = this.rapportSoinsClientInviteBindingSource;
            this.dgInfoSoinPersonne.Location = new System.Drawing.Point(6, 61);
            this.dgInfoSoinPersonne.Name = "dgInfoSoinPersonne";
            this.dgInfoSoinPersonne.ReadOnly = true;
            this.dgInfoSoinPersonne.RowHeadersWidth = 20;
            this.dgInfoSoinPersonne.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgInfoSoinPersonne.Size = new System.Drawing.Size(447, 187);
            this.dgInfoSoinPersonne.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Soin";
            this.dataGridViewTextBoxColumn8.HeaderText = "Soin";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DateHeure";
            this.dataGridViewTextBoxColumn9.HeaderText = "Date et heure";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "NomComplet_Assistant";
            this.dataGridViewTextBoxColumn10.HeaderText = "Assistant";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "prix";
            this.dataGridViewTextBoxColumn11.HeaderText = "Prix";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "NoPersonne";
            this.dataGridViewTextBoxColumn12.HeaderText = "NoPersonne";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(12, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(57, 20);
            this.lblTitre.TabIndex = 19;
            this.lblTitre.Text = "label1";
            // 
            // totalSoldeTextBox
            // 
            this.totalSoldeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personnesPlanifBindingSource, "totalSolde", true));
            this.totalSoldeTextBox.Location = new System.Drawing.Point(353, 254);
            this.totalSoldeTextBox.Name = "totalSoldeTextBox";
            this.totalSoldeTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalSoldeTextBox.TabIndex = 20;
            this.totalSoldeTextBox.TextChanged += new System.EventHandler(this.totalSoldeTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Soins offerts a la personne";
            // 
            // gbRapport1
            // 
            this.gbRapport1.Controls.Add(this.dgInfoSoinPersonne);
            this.gbRapport1.Controls.Add(this.label1);
            this.gbRapport1.Controls.Add(this.cboPersonnes);
            this.gbRapport1.Controls.Add(totalSoldeLabel);
            this.gbRapport1.Controls.Add(this.totalSoldeTextBox);
            this.gbRapport1.Location = new System.Drawing.Point(12, 56);
            this.gbRapport1.Name = "gbRapport1";
            this.gbRapport1.Size = new System.Drawing.Size(462, 281);
            this.gbRapport1.TabIndex = 22;
            this.gbRapport1.TabStop = false;
            this.gbRapport1.Text = "Selectionnez une personne";
            this.gbRapport1.Visible = false;
            // 
            // gbRapport3
            // 
            this.gbRapport3.Controls.Add(this.rapportSoinsAssistantDataGridView);
            this.gbRapport3.Controls.Add(this.soinDateAssistantComboBox);
            this.gbRapport3.Controls.Add(this.dateSoinAssistantComboBox);
            this.gbRapport3.Controls.Add(this.label3);
            this.gbRapport3.Controls.Add(this.label2);
            this.gbRapport3.Controls.Add(this.assistantsListComboBox);
            this.gbRapport3.Location = new System.Drawing.Point(481, 56);
            this.gbRapport3.Name = "gbRapport3";
            this.gbRapport3.Size = new System.Drawing.Size(552, 281);
            this.gbRapport3.TabIndex = 23;
            this.gbRapport3.TabStop = false;
            this.gbRapport3.Text = "Selectionnez un assistant";
            // 
            // assistantsListBindingSource
            // 
            this.assistantsListBindingSource.DataMember = "assistantsList";
            this.assistantsListBindingSource.DataSource = this.bDB56AnkitDataSet;
            // 
            // assistantsListTableAdapter
            // 
            this.assistantsListTableAdapter.ClearBeforeFill = true;
            // 
            // assistantsListComboBox
            // 
            this.assistantsListComboBox.DataSource = this.assistantsListBindingSource;
            this.assistantsListComboBox.DisplayMember = "Assistant";
            this.assistantsListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.assistantsListComboBox.FormattingEnabled = true;
            this.assistantsListComboBox.Location = new System.Drawing.Point(6, 19);
            this.assistantsListComboBox.Name = "assistantsListComboBox";
            this.assistantsListComboBox.Size = new System.Drawing.Size(169, 21);
            this.assistantsListComboBox.TabIndex = 0;
            this.assistantsListComboBox.ValueMember = "NoAssistant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selectionnez une date";
            // 
            // dateSoinAssistantBindingSource
            // 
            this.dateSoinAssistantBindingSource.DataMember = "fk_NoAssistantPlanif4";
            this.dateSoinAssistantBindingSource.DataSource = this.assistantsListBindingSource;
            // 
            // dateSoinAssistantTableAdapter
            // 
            this.dateSoinAssistantTableAdapter.ClearBeforeFill = true;
            // 
            // dateSoinAssistantComboBox
            // 
            this.dateSoinAssistantComboBox.DataSource = this.dateSoinAssistantBindingSource;
            this.dateSoinAssistantComboBox.DisplayMember = "Date";
            this.dateSoinAssistantComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateSoinAssistantComboBox.FormattingEnabled = true;
            this.dateSoinAssistantComboBox.Location = new System.Drawing.Point(6, 63);
            this.dateSoinAssistantComboBox.Name = "dateSoinAssistantComboBox";
            this.dateSoinAssistantComboBox.Size = new System.Drawing.Size(169, 21);
            this.dateSoinAssistantComboBox.TabIndex = 2;
            this.dateSoinAssistantComboBox.ValueMember = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Selectionnez un soin";
            // 
            // soinDateAssistantBindingSource
            // 
            this.soinDateAssistantBindingSource.DataMember = "fk_NoSoinPlanif4";
            this.soinDateAssistantBindingSource.DataSource = this.dateSoinAssistantBindingSource;
            // 
            // soinDateAssistantTableAdapter
            // 
            this.soinDateAssistantTableAdapter.ClearBeforeFill = true;
            // 
            // soinDateAssistantComboBox
            // 
            this.soinDateAssistantComboBox.DataSource = this.soinDateAssistantBindingSource;
            this.soinDateAssistantComboBox.DisplayMember = "Description";
            this.soinDateAssistantComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.soinDateAssistantComboBox.FormattingEnabled = true;
            this.soinDateAssistantComboBox.Location = new System.Drawing.Point(6, 113);
            this.soinDateAssistantComboBox.Name = "soinDateAssistantComboBox";
            this.soinDateAssistantComboBox.Size = new System.Drawing.Size(169, 21);
            this.soinDateAssistantComboBox.TabIndex = 4;
            this.soinDateAssistantComboBox.ValueMember = "NoSoin";
            // 
            // rapportSoinsAssistantBindingSource
            // 
            this.rapportSoinsAssistantBindingSource.DataMember = "soinDateAssistant_rapportSoinsAssistant";
            this.rapportSoinsAssistantBindingSource.DataSource = this.soinDateAssistantBindingSource;
            // 
            // rapportSoinsAssistantTableAdapter
            // 
            this.rapportSoinsAssistantTableAdapter.ClearBeforeFill = true;
            // 
            // rapportSoinsAssistantDataGridView
            // 
            this.rapportSoinsAssistantDataGridView.AutoGenerateColumns = false;
            this.rapportSoinsAssistantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rapportSoinsAssistantDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.rapportSoinsAssistantDataGridView.DataSource = this.rapportSoinsAssistantBindingSource;
            this.rapportSoinsAssistantDataGridView.Location = new System.Drawing.Point(202, 55);
            this.rapportSoinsAssistantDataGridView.Name = "rapportSoinsAssistantDataGridView";
            this.rapportSoinsAssistantDataGridView.Size = new System.Drawing.Size(344, 220);
            this.rapportSoinsAssistantDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Assistant";
            this.dataGridViewTextBoxColumn1.HeaderText = "Assistant";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NoAssistant";
            this.dataGridViewTextBoxColumn2.HeaderText = "NoAssistant";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Personne";
            this.dataGridViewTextBoxColumn3.HeaderText = "Personne";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NoPersonne";
            this.dataGridViewTextBoxColumn4.HeaderText = "NoPersonne";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Soin";
            this.dataGridViewTextBoxColumn5.HeaderText = "Soin";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NoSoin";
            this.dataGridViewTextBoxColumn6.HeaderText = "NoSoin";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DateHeure";
            this.dataGridViewTextBoxColumn7.HeaderText = "DateHeure";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // frmRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 436);
            this.Controls.Add(this.gbRapport3);
            this.Controls.Add(this.gbRapport1);
            this.Controls.Add(this.lblTitre);
            this.Name = "frmRapport";
            this.Text = "frmRapport";
            this.Load += new System.EventHandler(this.frmRapport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56AnkitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personnesPlanifBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportSoinsClientInviteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInfoSoinPersonne)).EndInit();
            this.gbRapport1.ResumeLayout(false);
            this.gbRapport1.PerformLayout();
            this.gbRapport3.ResumeLayout(false);
            this.gbRapport3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assistantsListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSoinAssistantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinDateAssistantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportSoinsAssistantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapportSoinsAssistantDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDB56AnkitDataSet bDB56AnkitDataSet;
        private System.Windows.Forms.BindingSource personnesPlanifBindingSource;
        private BDB56AnkitDataSetTableAdapters.personnesPlanifTableAdapter personnesPlanifTableAdapter;
        private BDB56AnkitDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cboPersonnes;
        private System.Windows.Forms.BindingSource rapportSoinsClientInviteBindingSource;
        private BDB56AnkitDataSetTableAdapters.rapportSoinsClientInviteTableAdapter rapportSoinsClientInviteTableAdapter;
        private System.Windows.Forms.DataGridView dgInfoSoinPersonne;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TextBox totalSoldeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbRapport1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.GroupBox gbRapport3;
        private System.Windows.Forms.BindingSource assistantsListBindingSource;
        private BDB56AnkitDataSetTableAdapters.assistantsListTableAdapter assistantsListTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox assistantsListComboBox;
        private System.Windows.Forms.BindingSource dateSoinAssistantBindingSource;
        private BDB56AnkitDataSetTableAdapters.dateSoinAssistantTableAdapter dateSoinAssistantTableAdapter;
        private System.Windows.Forms.ComboBox dateSoinAssistantComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource soinDateAssistantBindingSource;
        private BDB56AnkitDataSetTableAdapters.soinDateAssistantTableAdapter soinDateAssistantTableAdapter;
        private System.Windows.Forms.ComboBox soinDateAssistantComboBox;
        private System.Windows.Forms.BindingSource rapportSoinsAssistantBindingSource;
        private BDB56AnkitDataSetTableAdapters.rapportSoinsAssistantTableAdapter rapportSoinsAssistantTableAdapter;
        private System.Windows.Forms.DataGridView rapportSoinsAssistantDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}