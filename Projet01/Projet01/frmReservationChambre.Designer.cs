namespace Projet01
{
    partial class frmReservationChambre
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
            System.Windows.Forms.Label noClientLabel;
            System.Windows.Forms.Label noChambreLabel;
            System.Windows.Forms.Label dateArriveeLabel;
            System.Windows.Forms.Label dateDepartLabel;
            System.Windows.Forms.Label nbPersonnesLabel;
            this.bDB56AnkitDataSet = new Projet01.BDB56AnkitDataSet();
            this.noChambreTextBox = new System.Windows.Forms.TextBox();
            this.dateArriveeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateDepartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.p01_ClientTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.P01_ClientTableAdapter();
            this.p01_ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nbPersonnesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tableAdapterManager = new Projet01.BDB56AnkitDataSetTableAdapters.TableAdapterManager();
            this.p01_ReservationChambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p01_ReservationChambreTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.P01_ReservationChambreTableAdapter();
            this.nosEtNomsClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nosEtNomsClientsTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.nosEtNomsClientsTableAdapter();
            this.cboClient = new System.Windows.Forms.ComboBox();
            noClientLabel = new System.Windows.Forms.Label();
            noChambreLabel = new System.Windows.Forms.Label();
            dateArriveeLabel = new System.Windows.Forms.Label();
            dateDepartLabel = new System.Windows.Forms.Label();
            nbPersonnesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56AnkitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_ClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPersonnesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_ReservationChambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosEtNomsClientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // noClientLabel
            // 
            noClientLabel.AutoSize = true;
            noClientLabel.Location = new System.Drawing.Point(16, 76);
            noClientLabel.Name = "noClientLabel";
            noClientLabel.Size = new System.Drawing.Size(36, 13);
            noClientLabel.TabIndex = 1;
            noClientLabel.Text = "Client:";
            // 
            // noChambreLabel
            // 
            noChambreLabel.AutoSize = true;
            noChambreLabel.Location = new System.Drawing.Point(16, 50);
            noChambreLabel.Name = "noChambreLabel";
            noChambreLabel.Size = new System.Drawing.Size(69, 13);
            noChambreLabel.TabIndex = 3;
            noChambreLabel.Text = "No Chambre:";
            // 
            // dateArriveeLabel
            // 
            dateArriveeLabel.AutoSize = true;
            dateArriveeLabel.Location = new System.Drawing.Point(16, 105);
            dateArriveeLabel.Name = "dateArriveeLabel";
            dateArriveeLabel.Size = new System.Drawing.Size(69, 13);
            dateArriveeLabel.TabIndex = 5;
            dateArriveeLabel.Text = "Date Arrivee:";
            // 
            // dateDepartLabel
            // 
            dateDepartLabel.AutoSize = true;
            dateDepartLabel.Location = new System.Drawing.Point(16, 131);
            dateDepartLabel.Name = "dateDepartLabel";
            dateDepartLabel.Size = new System.Drawing.Size(68, 13);
            dateDepartLabel.TabIndex = 7;
            dateDepartLabel.Text = "Date Depart:";
            // 
            // nbPersonnesLabel
            // 
            nbPersonnesLabel.AutoSize = true;
            nbPersonnesLabel.Location = new System.Drawing.Point(16, 156);
            nbPersonnesLabel.Name = "nbPersonnesLabel";
            nbPersonnesLabel.Size = new System.Drawing.Size(77, 13);
            nbPersonnesLabel.TabIndex = 9;
            nbPersonnesLabel.Text = "Nb Personnes:";
            // 
            // bDB56AnkitDataSet
            // 
            this.bDB56AnkitDataSet.DataSetName = "BDB56AnkitDataSet";
            this.bDB56AnkitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // noChambreTextBox
            // 
            this.noChambreTextBox.Location = new System.Drawing.Point(99, 47);
            this.noChambreTextBox.Name = "noChambreTextBox";
            this.noChambreTextBox.ReadOnly = true;
            this.noChambreTextBox.Size = new System.Drawing.Size(171, 20);
            this.noChambreTextBox.TabIndex = 4;
            // 
            // dateArriveeDateTimePicker
            // 
            this.dateArriveeDateTimePicker.Location = new System.Drawing.Point(99, 101);
            this.dateArriveeDateTimePicker.Name = "dateArriveeDateTimePicker";
            this.dateArriveeDateTimePicker.Size = new System.Drawing.Size(171, 20);
            this.dateArriveeDateTimePicker.TabIndex = 6;
            // 
            // dateDepartDateTimePicker
            // 
            this.dateDepartDateTimePicker.Location = new System.Drawing.Point(99, 127);
            this.dateDepartDateTimePicker.Name = "dateDepartDateTimePicker";
            this.dateDepartDateTimePicker.Size = new System.Drawing.Size(171, 20);
            this.dateDepartDateTimePicker.TabIndex = 8;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(12, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(57, 20);
            this.lblTitre.TabIndex = 30;
            this.lblTitre.Text = "label1";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(145, 185);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 56);
            this.btnAnnuler.TabIndex = 29;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(50, 185);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(89, 56);
            this.btnConfirmer.TabIndex = 28;
            this.btnConfirmer.Text = "button1";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // p01_ClientTableAdapter
            // 
            this.p01_ClientTableAdapter.ClearBeforeFill = true;
            // 
            // p01_ClientBindingSource
            // 
            this.p01_ClientBindingSource.DataMember = "P01_Client";
            this.p01_ClientBindingSource.DataSource = this.bDB56AnkitDataSet;
            // 
            // nbPersonnesNumericUpDown
            // 
            this.nbPersonnesNumericUpDown.Location = new System.Drawing.Point(99, 153);
            this.nbPersonnesNumericUpDown.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nbPersonnesNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbPersonnesNumericUpDown.Name = "nbPersonnesNumericUpDown";
            this.nbPersonnesNumericUpDown.Size = new System.Drawing.Size(171, 20);
            this.nbPersonnesNumericUpDown.TabIndex = 31;
            this.nbPersonnesNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.tableAdapterManager.UpdateOrder = Projet01.BDB56AnkitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // p01_ReservationChambreBindingSource
            // 
            this.p01_ReservationChambreBindingSource.DataMember = "P01_ReservationChambre";
            this.p01_ReservationChambreBindingSource.DataSource = this.bDB56AnkitDataSet;
            // 
            // p01_ReservationChambreTableAdapter
            // 
            this.p01_ReservationChambreTableAdapter.ClearBeforeFill = true;
            // 
            // nosEtNomsClientsBindingSource
            // 
            this.nosEtNomsClientsBindingSource.DataMember = "nosEtNomsClients";
            this.nosEtNomsClientsBindingSource.DataSource = this.bDB56AnkitDataSet;
            // 
            // nosEtNomsClientsTableAdapter
            // 
            this.nosEtNomsClientsTableAdapter.ClearBeforeFill = true;
            // 
            // cboClient
            // 
            this.cboClient.DataSource = this.nosEtNomsClientsBindingSource;
            this.cboClient.DisplayMember = "NomComplet";
            this.cboClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClient.FormattingEnabled = true;
            this.cboClient.Location = new System.Drawing.Point(99, 73);
            this.cboClient.Name = "cboClient";
            this.cboClient.Size = new System.Drawing.Size(171, 21);
            this.cboClient.TabIndex = 31;
            this.cboClient.ValueMember = "NoClient";
            // 
            // frmReservationChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 251);
            this.Controls.Add(this.cboClient);
            this.Controls.Add(this.nbPersonnesNumericUpDown);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(noClientLabel);
            this.Controls.Add(noChambreLabel);
            this.Controls.Add(this.noChambreTextBox);
            this.Controls.Add(dateArriveeLabel);
            this.Controls.Add(this.dateArriveeDateTimePicker);
            this.Controls.Add(dateDepartLabel);
            this.Controls.Add(this.dateDepartDateTimePicker);
            this.Controls.Add(nbPersonnesLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReservationChambre";
            this.Text = "frmReservationChambre";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReservationChambre_FormClosing);
            this.Load += new System.EventHandler(this.frmReservationChambre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56AnkitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_ClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPersonnesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_ReservationChambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosEtNomsClientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDB56AnkitDataSet bDB56AnkitDataSet;
        private BDB56AnkitDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox noChambreTextBox;
        private System.Windows.Forms.DateTimePicker dateArriveeDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateDepartDateTimePicker;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.BindingSource p01_ClientBindingSource;
        private BDB56AnkitDataSetTableAdapters.P01_ClientTableAdapter p01_ClientTableAdapter;
        private System.Windows.Forms.NumericUpDown nbPersonnesNumericUpDown;
        private System.Windows.Forms.BindingSource p01_ReservationChambreBindingSource;
        private BDB56AnkitDataSetTableAdapters.P01_ReservationChambreTableAdapter p01_ReservationChambreTableAdapter;
        private System.Windows.Forms.BindingSource nosEtNomsClientsBindingSource;
        private BDB56AnkitDataSetTableAdapters.nosEtNomsClientsTableAdapter nosEtNomsClientsTableAdapter;
        private System.Windows.Forms.ComboBox cboClient;
    }
}