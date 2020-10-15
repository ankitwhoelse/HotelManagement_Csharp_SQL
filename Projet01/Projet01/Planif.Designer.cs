namespace Projet01
{
    partial class Planif
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bDB56AnkitDataSet = new Projet01.BDB56AnkitDataSet();
            this.p01_SoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p01_SoinTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.P01_SoinTableAdapter();
            this.tableAdapterManager = new Projet01.BDB56AnkitDataSetTableAdapters.TableAdapterManager();
            this.p01_AssistantTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.P01_AssistantTableAdapter();
            this.p01_AssistantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p01_AssistantComboBox = new System.Windows.Forms.ComboBox();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_Annuler = new System.Windows.Forms.Button();
            this.noEtNomComplet_ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noEtNomComplet_ClientTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.NoEtNomComplet_ClientTableAdapter();
            this.CbPersonnes = new System.Windows.Forms.ComboBox();
            this.gbPersonne = new System.Windows.Forms.GroupBox();
            this.rbInvite = new System.Windows.Forms.RadioButton();
            this.rbClient = new System.Windows.Forms.RadioButton();
            this.nomNumeroInvitesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nom_Numero_InvitesTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.Nom_Numero_InvitesTableAdapter();
            this.tbSoin = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56AnkitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_SoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_AssistantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtNomComplet_ClientBindingSource)).BeginInit();
            this.gbPersonne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nomNumeroInvitesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Invité ou client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Assistant";
            // 
            // bDB56AnkitDataSet
            // 
            this.bDB56AnkitDataSet.DataSetName = "BDB56AnkitDataSet";
            this.bDB56AnkitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p01_SoinBindingSource
            // 
            this.p01_SoinBindingSource.DataMember = "P01_Soin";
            this.p01_SoinBindingSource.DataSource = this.bDB56AnkitDataSet;
            // 
            // p01_SoinTableAdapter
            // 
            this.p01_SoinTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.P01_AssistantSoinTableAdapter = null;
            this.tableAdapterManager.P01_AssistantTableAdapter = this.p01_AssistantTableAdapter;
            this.tableAdapterManager.P01_ChambreTableAdapter = null;
            this.tableAdapterManager.P01_ClientTableAdapter = null;
            this.tableAdapterManager.P01_InviteTableAdapter = null;
            this.tableAdapterManager.P01_PlanifSoinTableAdapter = null;
            this.tableAdapterManager.P01_ReservationChambreTableAdapter = null;
            this.tableAdapterManager.P01_SoinTableAdapter = this.p01_SoinTableAdapter;
            this.tableAdapterManager.P01_TypeChambreTableAdapter = null;
            this.tableAdapterManager.P01_TypeSoinTableAdapter = null;
            this.tableAdapterManager.P01_TypeUtilisateurTableAdapter = null;
            this.tableAdapterManager.P01_UtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet01.BDB56AnkitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // p01_AssistantTableAdapter
            // 
            this.p01_AssistantTableAdapter.ClearBeforeFill = true;
            // 
            // p01_AssistantBindingSource
            // 
            this.p01_AssistantBindingSource.DataMember = "P01_Assistant";
            this.p01_AssistantBindingSource.DataSource = this.bDB56AnkitDataSet;
            // 
            // p01_AssistantComboBox
            // 
            this.p01_AssistantComboBox.DataSource = this.p01_AssistantBindingSource;
            this.p01_AssistantComboBox.DisplayMember = "Prenom";
            this.p01_AssistantComboBox.FormattingEnabled = true;
            this.p01_AssistantComboBox.Location = new System.Drawing.Point(163, 212);
            this.p01_AssistantComboBox.Name = "p01_AssistantComboBox";
            this.p01_AssistantComboBox.Size = new System.Drawing.Size(176, 24);
            this.p01_AssistantComboBox.TabIndex = 4;
            this.p01_AssistantComboBox.ValueMember = "NoAssistant";
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(142, 298);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(91, 59);
            this.btn_ajouter.TabIndex = 5;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_Annuler
            // 
            this.btn_Annuler.Location = new System.Drawing.Point(290, 298);
            this.btn_Annuler.Name = "btn_Annuler";
            this.btn_Annuler.Size = new System.Drawing.Size(91, 59);
            this.btn_Annuler.TabIndex = 6;
            this.btn_Annuler.Text = "Annuler";
            this.btn_Annuler.UseVisualStyleBackColor = true;
            this.btn_Annuler.Click += new System.EventHandler(this.btn_Annuler_Click);
            // 
            // noEtNomComplet_ClientBindingSource
            // 
            this.noEtNomComplet_ClientBindingSource.DataMember = "NoEtNomComplet_Client";
            this.noEtNomComplet_ClientBindingSource.DataSource = this.bDB56AnkitDataSet;
            // 
            // noEtNomComplet_ClientTableAdapter
            // 
            this.noEtNomComplet_ClientTableAdapter.ClearBeforeFill = true;
            // 
            // CbPersonnes
            // 
            this.CbPersonnes.DataSource = this.noEtNomComplet_ClientBindingSource;
            this.CbPersonnes.DisplayMember = "No_Nom_Client";
            this.CbPersonnes.FormattingEnabled = true;
            this.CbPersonnes.Location = new System.Drawing.Point(163, 161);
            this.CbPersonnes.Name = "CbPersonnes";
            this.CbPersonnes.Size = new System.Drawing.Size(176, 24);
            this.CbPersonnes.TabIndex = 7;
            this.CbPersonnes.ValueMember = "NoClient";
            // 
            // gbPersonne
            // 
            this.gbPersonne.Controls.Add(this.rbInvite);
            this.gbPersonne.Controls.Add(this.rbClient);
            this.gbPersonne.Location = new System.Drawing.Point(163, 90);
            this.gbPersonne.Name = "gbPersonne";
            this.gbPersonne.Size = new System.Drawing.Size(176, 65);
            this.gbPersonne.TabIndex = 8;
            this.gbPersonne.TabStop = false;
            // 
            // rbInvite
            // 
            this.rbInvite.AutoSize = true;
            this.rbInvite.Location = new System.Drawing.Point(6, 37);
            this.rbInvite.Name = "rbInvite";
            this.rbInvite.Size = new System.Drawing.Size(62, 21);
            this.rbInvite.TabIndex = 1;
            this.rbInvite.TabStop = true;
            this.rbInvite.Text = "Invité";
            this.rbInvite.UseVisualStyleBackColor = true;
            this.rbInvite.CheckedChanged += new System.EventHandler(this.rbInvite_CheckedChanged);
            // 
            // rbClient
            // 
            this.rbClient.AutoSize = true;
            this.rbClient.Location = new System.Drawing.Point(6, 10);
            this.rbClient.Name = "rbClient";
            this.rbClient.Size = new System.Drawing.Size(64, 21);
            this.rbClient.TabIndex = 0;
            this.rbClient.TabStop = true;
            this.rbClient.Text = "Client";
            this.rbClient.UseVisualStyleBackColor = true;
            this.rbClient.CheckedChanged += new System.EventHandler(this.rbClient_CheckedChanged);
            // 
            // nomNumeroInvitesBindingSource
            // 
            this.nomNumeroInvitesBindingSource.DataMember = "Nom_Numero_Invites";
            this.nomNumeroInvitesBindingSource.DataSource = this.bDB56AnkitDataSet;
            // 
            // nom_Numero_InvitesTableAdapter
            // 
            this.nom_Numero_InvitesTableAdapter.ClearBeforeFill = true;
            // 
            // tbSoin
            // 
            this.tbSoin.Location = new System.Drawing.Point(163, 60);
            this.tbSoin.Name = "tbSoin";
            this.tbSoin.ReadOnly = true;
            this.tbSoin.Size = new System.Drawing.Size(176, 22);
            this.tbSoin.TabIndex = 9;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(163, 256);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(176, 22);
            this.datePicker.TabIndex = 10;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(45, 256);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(95, 17);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Date et heure";
            // 
            // TimePicker
            // 
            this.TimePicker.Location = new System.Drawing.Point(354, 256);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(113, 22);
            this.TimePicker.TabIndex = 12;
            // 
            // Planif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.tbSoin);
            this.Controls.Add(this.gbPersonne);
            this.Controls.Add(this.CbPersonnes);
            this.Controls.Add(this.btn_Annuler);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.p01_AssistantComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Planif";
            this.Text = "Ajout d\'une planification de soin";
            this.Load += new System.EventHandler(this.Planif_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56AnkitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_SoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_AssistantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtNomComplet_ClientBindingSource)).EndInit();
            this.gbPersonne.ResumeLayout(false);
            this.gbPersonne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nomNumeroInvitesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private BDB56AnkitDataSet bDB56AnkitDataSet;
        private System.Windows.Forms.BindingSource p01_SoinBindingSource;
        private BDB56AnkitDataSetTableAdapters.P01_SoinTableAdapter p01_SoinTableAdapter;
        private BDB56AnkitDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BDB56AnkitDataSetTableAdapters.P01_AssistantTableAdapter p01_AssistantTableAdapter;
        private System.Windows.Forms.BindingSource p01_AssistantBindingSource;
        private System.Windows.Forms.ComboBox p01_AssistantComboBox;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_Annuler;
        private System.Windows.Forms.BindingSource noEtNomComplet_ClientBindingSource;
        private BDB56AnkitDataSetTableAdapters.NoEtNomComplet_ClientTableAdapter noEtNomComplet_ClientTableAdapter;
        private System.Windows.Forms.ComboBox CbPersonnes;
        private System.Windows.Forms.GroupBox gbPersonne;
        private System.Windows.Forms.RadioButton rbInvite;
        private System.Windows.Forms.RadioButton rbClient;
        private System.Windows.Forms.BindingSource nomNumeroInvitesBindingSource;
        private BDB56AnkitDataSetTableAdapters.Nom_Numero_InvitesTableAdapter nom_Numero_InvitesTableAdapter;
        private System.Windows.Forms.TextBox tbSoin;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker TimePicker;
    }
}