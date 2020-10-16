namespace Projet01
{
    partial class frmPrepose
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
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label villeLabel;
            System.Windows.Forms.Label paysLabel;
            System.Windows.Forms.Label adresseLabel;
            System.Windows.Forms.Label codePostalLabel;
            System.Windows.Forms.Label dateInscriptionLabel;
            System.Windows.Forms.Label noChambreLabel;
            System.Windows.Forms.Label emplacementLabel;
            System.Windows.Forms.Label decorationsLabel;
            System.Windows.Forms.Label noTypeChambreLabel;
            System.Windows.Forms.Label noInviteLabel;
            System.Windows.Forms.Label nomPrenomLabel;
            System.Windows.Forms.Label noClientLabel1;
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.bDB56AnkitDataSet = new Projet01.BDB56AnkitDataSet();
            this.p01_ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p01_ClientTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.P01_ClientTableAdapter();
            this.tableAdapterManager = new Projet01.BDB56AnkitDataSetTableAdapters.TableAdapterManager();
            this.cboClients = new System.Windows.Forms.ComboBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.noClientTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.villeTextBox = new System.Windows.Forms.TextBox();
            this.paysTextBox = new System.Windows.Forms.TextBox();
            this.adresseTextBox = new System.Windows.Forms.TextBox();
            this.codePostalTextBox = new System.Windows.Forms.TextBox();
            this.dateInscriptionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.gbInfoClient = new System.Windows.Forms.GroupBox();
            this.nosEtNomsClientsComboBox = new System.Windows.Forms.ComboBox();
            this.nosEtNomsClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbInfoChambre = new System.Windows.Forms.GroupBox();
            this.p01_TypeChambreComboBox = new System.Windows.Forms.ComboBox();
            this.p01_TypeChambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboChambre = new System.Windows.Forms.ComboBox();
            this.p01_ChambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noChambreTextBox = new System.Windows.Forms.TextBox();
            this.emplacementTextBox = new System.Windows.Forms.TextBox();
            this.decorationsTextBox = new System.Windows.Forms.TextBox();
            this.btnAjouterReservation = new System.Windows.Forms.Button();
            this.p01_ChambreTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.P01_ChambreTableAdapter();
            this.gbInfoInvite = new System.Windows.Forms.GroupBox();
            this.noInviteTextBox = new System.Windows.Forms.TextBox();
            this.p01_InviteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomPrenomTextBox = new System.Windows.Forms.TextBox();
            this.noClientTextBox1 = new System.Windows.Forms.TextBox();
            this.cboInvite = new System.Windows.Forms.ComboBox();
            this.btnSupprimeInvite = new System.Windows.Forms.Button();
            this.btnModifInvite = new System.Windows.Forms.Button();
            this.btnAjoutInvite = new System.Windows.Forms.Button();
            this.p01_InviteTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.P01_InviteTableAdapter();
            this.lblBonjour = new System.Windows.Forms.Label();
            this.nosEtNomsClientsTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.nosEtNomsClientsTableAdapter();
            this.p01_TypeChambreTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.P01_TypeChambreTableAdapter();
            noClientLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            villeLabel = new System.Windows.Forms.Label();
            paysLabel = new System.Windows.Forms.Label();
            adresseLabel = new System.Windows.Forms.Label();
            codePostalLabel = new System.Windows.Forms.Label();
            dateInscriptionLabel = new System.Windows.Forms.Label();
            noChambreLabel = new System.Windows.Forms.Label();
            emplacementLabel = new System.Windows.Forms.Label();
            decorationsLabel = new System.Windows.Forms.Label();
            noTypeChambreLabel = new System.Windows.Forms.Label();
            noInviteLabel = new System.Windows.Forms.Label();
            nomPrenomLabel = new System.Windows.Forms.Label();
            noClientLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56AnkitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_ClientBindingSource)).BeginInit();
            this.gbInfoClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nosEtNomsClientsBindingSource)).BeginInit();
            this.gbInfoChambre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p01_TypeChambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_ChambreBindingSource)).BeginInit();
            this.gbInfoInvite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p01_InviteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // noClientLabel
            // 
            noClientLabel.AutoSize = true;
            noClientLabel.Location = new System.Drawing.Point(6, 53);
            noClientLabel.Name = "noClientLabel";
            noClientLabel.Size = new System.Drawing.Size(53, 13);
            noClientLabel.TabIndex = 11;
            noClientLabel.Text = "No Client:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(6, 79);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(32, 13);
            nomLabel.TabIndex = 13;
            nomLabel.Text = "Nom:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(6, 105);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(46, 13);
            prenomLabel.TabIndex = 15;
            prenomLabel.Text = "Prenom:";
            // 
            // villeLabel
            // 
            villeLabel.AutoSize = true;
            villeLabel.Location = new System.Drawing.Point(6, 131);
            villeLabel.Name = "villeLabel";
            villeLabel.Size = new System.Drawing.Size(29, 13);
            villeLabel.TabIndex = 17;
            villeLabel.Text = "Ville:";
            // 
            // paysLabel
            // 
            paysLabel.AutoSize = true;
            paysLabel.Location = new System.Drawing.Point(6, 157);
            paysLabel.Name = "paysLabel";
            paysLabel.Size = new System.Drawing.Size(33, 13);
            paysLabel.TabIndex = 19;
            paysLabel.Text = "Pays:";
            // 
            // adresseLabel
            // 
            adresseLabel.AutoSize = true;
            adresseLabel.Location = new System.Drawing.Point(6, 183);
            adresseLabel.Name = "adresseLabel";
            adresseLabel.Size = new System.Drawing.Size(48, 13);
            adresseLabel.TabIndex = 21;
            adresseLabel.Text = "Adresse:";
            // 
            // codePostalLabel
            // 
            codePostalLabel.AutoSize = true;
            codePostalLabel.Location = new System.Drawing.Point(6, 209);
            codePostalLabel.Name = "codePostalLabel";
            codePostalLabel.Size = new System.Drawing.Size(67, 13);
            codePostalLabel.TabIndex = 23;
            codePostalLabel.Text = "Code Postal:";
            // 
            // dateInscriptionLabel
            // 
            dateInscriptionLabel.AutoSize = true;
            dateInscriptionLabel.Location = new System.Drawing.Point(6, 236);
            dateInscriptionLabel.Name = "dateInscriptionLabel";
            dateInscriptionLabel.Size = new System.Drawing.Size(84, 13);
            dateInscriptionLabel.TabIndex = 25;
            dateInscriptionLabel.Text = "Date Inscription:";
            // 
            // noChambreLabel
            // 
            noChambreLabel.AutoSize = true;
            noChambreLabel.Location = new System.Drawing.Point(6, 49);
            noChambreLabel.Name = "noChambreLabel";
            noChambreLabel.Size = new System.Drawing.Size(69, 13);
            noChambreLabel.TabIndex = 41;
            noChambreLabel.Text = "No Chambre:";
            // 
            // emplacementLabel
            // 
            emplacementLabel.AutoSize = true;
            emplacementLabel.Location = new System.Drawing.Point(6, 75);
            emplacementLabel.Name = "emplacementLabel";
            emplacementLabel.Size = new System.Drawing.Size(74, 13);
            emplacementLabel.TabIndex = 43;
            emplacementLabel.Text = "Emplacement:";
            // 
            // decorationsLabel
            // 
            decorationsLabel.AutoSize = true;
            decorationsLabel.Location = new System.Drawing.Point(6, 101);
            decorationsLabel.Name = "decorationsLabel";
            decorationsLabel.Size = new System.Drawing.Size(67, 13);
            decorationsLabel.TabIndex = 45;
            decorationsLabel.Text = "Decorations:";
            // 
            // noTypeChambreLabel
            // 
            noTypeChambreLabel.AutoSize = true;
            noTypeChambreLabel.Location = new System.Drawing.Point(6, 127);
            noTypeChambreLabel.Name = "noTypeChambreLabel";
            noTypeChambreLabel.Size = new System.Drawing.Size(79, 13);
            noTypeChambreLabel.TabIndex = 47;
            noTypeChambreLabel.Text = "Type Chambre:";
            // 
            // noInviteLabel
            // 
            noInviteLabel.AutoSize = true;
            noInviteLabel.Location = new System.Drawing.Point(14, 53);
            noInviteLabel.Name = "noInviteLabel";
            noInviteLabel.Size = new System.Drawing.Size(53, 13);
            noInviteLabel.TabIndex = 41;
            noInviteLabel.Text = "No Invite:";
            // 
            // nomPrenomLabel
            // 
            nomPrenomLabel.AutoSize = true;
            nomPrenomLabel.Location = new System.Drawing.Point(14, 79);
            nomPrenomLabel.Name = "nomPrenomLabel";
            nomPrenomLabel.Size = new System.Drawing.Size(71, 13);
            nomPrenomLabel.TabIndex = 43;
            nomPrenomLabel.Text = "Nom Prenom:";
            // 
            // noClientLabel1
            // 
            noClientLabel1.AutoSize = true;
            noClientLabel1.Location = new System.Drawing.Point(14, 105);
            noClientLabel1.Name = "noClientLabel1";
            noClientLabel1.Size = new System.Drawing.Size(53, 13);
            noClientLabel1.TabIndex = 45;
            noClientLabel1.Text = "No Client:";
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexion.Location = new System.Drawing.Point(371, 301);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(155, 33);
            this.btnDeconnexion.TabIndex = 1;
            this.btnDeconnexion.Text = "Deconnexion";
            this.btnDeconnexion.UseVisualStyleBackColor = true;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(532, 301);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(155, 33);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // bDB56AnkitDataSet
            // 
            this.bDB56AnkitDataSet.DataSetName = "BDB56AnkitDataSet";
            this.bDB56AnkitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p01_ClientBindingSource
            // 
            this.p01_ClientBindingSource.DataMember = "P01_Client";
            this.p01_ClientBindingSource.DataSource = this.bDB56AnkitDataSet;
            // 
            // p01_ClientTableAdapter
            // 
            this.p01_ClientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.nosEtNomsClientsTableAdapter = null;
            this.tableAdapterManager.P01_AssistantSoinTableAdapter = null;
            this.tableAdapterManager.P01_AssistantTableAdapter = null;
            this.tableAdapterManager.P01_ChambreTableAdapter = null;
            this.tableAdapterManager.P01_ClientTableAdapter = this.p01_ClientTableAdapter;
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
            // cboClients
            // 
            this.cboClients.DataSource = this.p01_ClientBindingSource;
            this.cboClients.DisplayMember = "Nom";
            this.cboClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClients.Enabled = false;
            this.cboClients.FormattingEnabled = true;
            this.cboClients.Location = new System.Drawing.Point(96, 19);
            this.cboClients.Name = "cboClients";
            this.cboClients.Size = new System.Drawing.Size(200, 21);
            this.cboClients.TabIndex = 4;
            this.cboClients.ValueMember = "NoClient";
            this.cboClients.Visible = false;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(115, 287);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 11;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(196, 287);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 10;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(115, 258);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(156, 23);
            this.btnAjouter.TabIndex = 9;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // noClientTextBox
            // 
            this.noClientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_ClientBindingSource, "NoClient", true));
            this.noClientTextBox.Location = new System.Drawing.Point(96, 50);
            this.noClientTextBox.Name = "noClientTextBox";
            this.noClientTextBox.ReadOnly = true;
            this.noClientTextBox.Size = new System.Drawing.Size(200, 20);
            this.noClientTextBox.TabIndex = 12;
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_ClientBindingSource, "Nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(96, 76);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.ReadOnly = true;
            this.nomTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomTextBox.TabIndex = 14;
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_ClientBindingSource, "Prenom", true));
            this.prenomTextBox.Location = new System.Drawing.Point(96, 102);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.ReadOnly = true;
            this.prenomTextBox.Size = new System.Drawing.Size(200, 20);
            this.prenomTextBox.TabIndex = 16;
            // 
            // villeTextBox
            // 
            this.villeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_ClientBindingSource, "Ville", true));
            this.villeTextBox.Location = new System.Drawing.Point(96, 128);
            this.villeTextBox.Name = "villeTextBox";
            this.villeTextBox.ReadOnly = true;
            this.villeTextBox.Size = new System.Drawing.Size(200, 20);
            this.villeTextBox.TabIndex = 18;
            // 
            // paysTextBox
            // 
            this.paysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_ClientBindingSource, "Pays", true));
            this.paysTextBox.Location = new System.Drawing.Point(96, 154);
            this.paysTextBox.Name = "paysTextBox";
            this.paysTextBox.ReadOnly = true;
            this.paysTextBox.Size = new System.Drawing.Size(200, 20);
            this.paysTextBox.TabIndex = 20;
            // 
            // adresseTextBox
            // 
            this.adresseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_ClientBindingSource, "Adresse", true));
            this.adresseTextBox.Location = new System.Drawing.Point(96, 180);
            this.adresseTextBox.Name = "adresseTextBox";
            this.adresseTextBox.ReadOnly = true;
            this.adresseTextBox.Size = new System.Drawing.Size(200, 20);
            this.adresseTextBox.TabIndex = 22;
            // 
            // codePostalTextBox
            // 
            this.codePostalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_ClientBindingSource, "CodePostal", true));
            this.codePostalTextBox.Location = new System.Drawing.Point(96, 206);
            this.codePostalTextBox.Name = "codePostalTextBox";
            this.codePostalTextBox.ReadOnly = true;
            this.codePostalTextBox.Size = new System.Drawing.Size(200, 20);
            this.codePostalTextBox.TabIndex = 24;
            // 
            // dateInscriptionDateTimePicker
            // 
            this.dateInscriptionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.p01_ClientBindingSource, "DateInscription", true));
            this.dateInscriptionDateTimePicker.Enabled = false;
            this.dateInscriptionDateTimePicker.Location = new System.Drawing.Point(96, 232);
            this.dateInscriptionDateTimePicker.Name = "dateInscriptionDateTimePicker";
            this.dateInscriptionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateInscriptionDateTimePicker.TabIndex = 26;
            // 
            // gbInfoClient
            // 
            this.gbInfoClient.Controls.Add(this.nosEtNomsClientsComboBox);
            this.gbInfoClient.Controls.Add(this.nomTextBox);
            this.gbInfoClient.Controls.Add(noClientLabel);
            this.gbInfoClient.Controls.Add(this.dateInscriptionDateTimePicker);
            this.gbInfoClient.Controls.Add(this.noClientTextBox);
            this.gbInfoClient.Controls.Add(this.btnSupprimer);
            this.gbInfoClient.Controls.Add(dateInscriptionLabel);
            this.gbInfoClient.Controls.Add(this.btnModifier);
            this.gbInfoClient.Controls.Add(nomLabel);
            this.gbInfoClient.Controls.Add(this.btnAjouter);
            this.gbInfoClient.Controls.Add(this.codePostalTextBox);
            this.gbInfoClient.Controls.Add(this.cboClients);
            this.gbInfoClient.Controls.Add(codePostalLabel);
            this.gbInfoClient.Controls.Add(prenomLabel);
            this.gbInfoClient.Controls.Add(this.adresseTextBox);
            this.gbInfoClient.Controls.Add(this.prenomTextBox);
            this.gbInfoClient.Controls.Add(adresseLabel);
            this.gbInfoClient.Controls.Add(villeLabel);
            this.gbInfoClient.Controls.Add(this.paysTextBox);
            this.gbInfoClient.Controls.Add(this.villeTextBox);
            this.gbInfoClient.Controls.Add(paysLabel);
            this.gbInfoClient.Location = new System.Drawing.Point(14, 19);
            this.gbInfoClient.Name = "gbInfoClient";
            this.gbInfoClient.Size = new System.Drawing.Size(302, 323);
            this.gbInfoClient.TabIndex = 27;
            this.gbInfoClient.TabStop = false;
            this.gbInfoClient.Text = "Information sur le client";
            // 
            // nosEtNomsClientsComboBox
            // 
            this.nosEtNomsClientsComboBox.DataSource = this.nosEtNomsClientsBindingSource;
            this.nosEtNomsClientsComboBox.DisplayMember = "NomComplet";
            this.nosEtNomsClientsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nosEtNomsClientsComboBox.FormattingEnabled = true;
            this.nosEtNomsClientsComboBox.Location = new System.Drawing.Point(96, 19);
            this.nosEtNomsClientsComboBox.Name = "nosEtNomsClientsComboBox";
            this.nosEtNomsClientsComboBox.Size = new System.Drawing.Size(200, 21);
            this.nosEtNomsClientsComboBox.TabIndex = 40;
            this.nosEtNomsClientsComboBox.ValueMember = "NoClient";
            this.nosEtNomsClientsComboBox.SelectedIndexChanged += new System.EventHandler(this.nosEtNomsClientsComboBox_SelectedIndexChanged);
            // 
            // nosEtNomsClientsBindingSource
            // 
            this.nosEtNomsClientsBindingSource.DataMember = "nosEtNomsClients";
            this.nosEtNomsClientsBindingSource.DataSource = this.bDB56AnkitDataSet;
            // 
            // gbInfoChambre
            // 
            this.gbInfoChambre.Controls.Add(this.p01_TypeChambreComboBox);
            this.gbInfoChambre.Controls.Add(noChambreLabel);
            this.gbInfoChambre.Controls.Add(this.cboChambre);
            this.gbInfoChambre.Controls.Add(this.noChambreTextBox);
            this.gbInfoChambre.Controls.Add(emplacementLabel);
            this.gbInfoChambre.Controls.Add(this.emplacementTextBox);
            this.gbInfoChambre.Controls.Add(decorationsLabel);
            this.gbInfoChambre.Controls.Add(this.decorationsTextBox);
            this.gbInfoChambre.Controls.Add(noTypeChambreLabel);
            this.gbInfoChambre.Controls.Add(this.btnAjouterReservation);
            this.gbInfoChambre.Location = new System.Drawing.Point(532, 19);
            this.gbInfoChambre.Name = "gbInfoChambre";
            this.gbInfoChambre.Size = new System.Drawing.Size(222, 202);
            this.gbInfoChambre.TabIndex = 38;
            this.gbInfoChambre.TabStop = false;
            this.gbInfoChambre.Text = "Information sur une chambre";
            // 
            // p01_TypeChambreComboBox
            // 
            this.p01_TypeChambreComboBox.DataSource = this.p01_TypeChambreBindingSource;
            this.p01_TypeChambreComboBox.DisplayMember = "Description";
            this.p01_TypeChambreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.p01_TypeChambreComboBox.Enabled = false;
            this.p01_TypeChambreComboBox.FormattingEnabled = true;
            this.p01_TypeChambreComboBox.Location = new System.Drawing.Point(108, 125);
            this.p01_TypeChambreComboBox.Name = "p01_TypeChambreComboBox";
            this.p01_TypeChambreComboBox.Size = new System.Drawing.Size(100, 21);
            this.p01_TypeChambreComboBox.TabIndex = 40;
            this.p01_TypeChambreComboBox.ValueMember = "NoTypeChambre";
            // 
            // p01_TypeChambreBindingSource
            // 
            this.p01_TypeChambreBindingSource.DataMember = "P01_TypeChambre";
            this.p01_TypeChambreBindingSource.DataSource = this.bDB56AnkitDataSet;
            // 
            // cboChambre
            // 
            this.cboChambre.DataSource = this.p01_ChambreBindingSource;
            this.cboChambre.DisplayMember = "NoChambre";
            this.cboChambre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChambre.FormattingEnabled = true;
            this.cboChambre.Location = new System.Drawing.Point(108, 19);
            this.cboChambre.Name = "cboChambre";
            this.cboChambre.Size = new System.Drawing.Size(100, 21);
            this.cboChambre.TabIndex = 38;
            this.cboChambre.ValueMember = "NoChambre";
            this.cboChambre.SelectedIndexChanged += new System.EventHandler(this.cboChambre_SelectedIndexChanged);
            // 
            // p01_ChambreBindingSource
            // 
            this.p01_ChambreBindingSource.DataMember = "P01_Chambre";
            this.p01_ChambreBindingSource.DataSource = this.bDB56AnkitDataSet;
            // 
            // noChambreTextBox
            // 
            this.noChambreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_ChambreBindingSource, "NoChambre", true));
            this.noChambreTextBox.Location = new System.Drawing.Point(108, 46);
            this.noChambreTextBox.Name = "noChambreTextBox";
            this.noChambreTextBox.ReadOnly = true;
            this.noChambreTextBox.Size = new System.Drawing.Size(100, 20);
            this.noChambreTextBox.TabIndex = 42;
            // 
            // emplacementTextBox
            // 
            this.emplacementTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_ChambreBindingSource, "Emplacement", true));
            this.emplacementTextBox.Location = new System.Drawing.Point(108, 72);
            this.emplacementTextBox.Name = "emplacementTextBox";
            this.emplacementTextBox.ReadOnly = true;
            this.emplacementTextBox.Size = new System.Drawing.Size(100, 20);
            this.emplacementTextBox.TabIndex = 44;
            // 
            // decorationsTextBox
            // 
            this.decorationsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_ChambreBindingSource, "Decorations", true));
            this.decorationsTextBox.Location = new System.Drawing.Point(108, 98);
            this.decorationsTextBox.Name = "decorationsTextBox";
            this.decorationsTextBox.ReadOnly = true;
            this.decorationsTextBox.Size = new System.Drawing.Size(100, 20);
            this.decorationsTextBox.TabIndex = 46;
            // 
            // btnAjouterReservation
            // 
            this.btnAjouterReservation.Location = new System.Drawing.Point(27, 157);
            this.btnAjouterReservation.Name = "btnAjouterReservation";
            this.btnAjouterReservation.Size = new System.Drawing.Size(157, 35);
            this.btnAjouterReservation.TabIndex = 41;
            this.btnAjouterReservation.Text = "Reserver la chambre";
            this.btnAjouterReservation.UseVisualStyleBackColor = true;
            this.btnAjouterReservation.Click += new System.EventHandler(this.btnAjouterReservation_Click);
            // 
            // p01_ChambreTableAdapter
            // 
            this.p01_ChambreTableAdapter.ClearBeforeFill = true;
            // 
            // gbInfoInvite
            // 
            this.gbInfoInvite.Controls.Add(noInviteLabel);
            this.gbInfoInvite.Controls.Add(this.noInviteTextBox);
            this.gbInfoInvite.Controls.Add(nomPrenomLabel);
            this.gbInfoInvite.Controls.Add(this.nomPrenomTextBox);
            this.gbInfoInvite.Controls.Add(noClientLabel1);
            this.gbInfoInvite.Controls.Add(this.noClientTextBox1);
            this.gbInfoInvite.Controls.Add(this.cboInvite);
            this.gbInfoInvite.Controls.Add(this.btnSupprimeInvite);
            this.gbInfoInvite.Controls.Add(this.btnModifInvite);
            this.gbInfoInvite.Controls.Add(this.btnAjoutInvite);
            this.gbInfoInvite.Location = new System.Drawing.Point(322, 19);
            this.gbInfoInvite.Name = "gbInfoInvite";
            this.gbInfoInvite.Size = new System.Drawing.Size(204, 202);
            this.gbInfoInvite.TabIndex = 39;
            this.gbInfoInvite.TabStop = false;
            this.gbInfoInvite.Text = "Information sur l\'invite";
            // 
            // noInviteTextBox
            // 
            this.noInviteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_InviteBindingSource, "NoInvite", true));
            this.noInviteTextBox.Location = new System.Drawing.Point(91, 50);
            this.noInviteTextBox.Name = "noInviteTextBox";
            this.noInviteTextBox.ReadOnly = true;
            this.noInviteTextBox.Size = new System.Drawing.Size(100, 20);
            this.noInviteTextBox.TabIndex = 42;
            // 
            // p01_InviteBindingSource
            // 
            this.p01_InviteBindingSource.DataMember = "P01_Invite";
            this.p01_InviteBindingSource.DataSource = this.bDB56AnkitDataSet;
            // 
            // nomPrenomTextBox
            // 
            this.nomPrenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_InviteBindingSource, "NomPrenom", true));
            this.nomPrenomTextBox.Location = new System.Drawing.Point(91, 76);
            this.nomPrenomTextBox.Name = "nomPrenomTextBox";
            this.nomPrenomTextBox.ReadOnly = true;
            this.nomPrenomTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomPrenomTextBox.TabIndex = 44;
            // 
            // noClientTextBox1
            // 
            this.noClientTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_InviteBindingSource, "NoClient", true));
            this.noClientTextBox1.Location = new System.Drawing.Point(91, 102);
            this.noClientTextBox1.Name = "noClientTextBox1";
            this.noClientTextBox1.ReadOnly = true;
            this.noClientTextBox1.Size = new System.Drawing.Size(100, 20);
            this.noClientTextBox1.TabIndex = 46;
            // 
            // cboInvite
            // 
            this.cboInvite.DataSource = this.p01_InviteBindingSource;
            this.cboInvite.DisplayMember = "NomPrenom";
            this.cboInvite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInvite.FormattingEnabled = true;
            this.cboInvite.Location = new System.Drawing.Point(91, 19);
            this.cboInvite.Name = "cboInvite";
            this.cboInvite.Size = new System.Drawing.Size(100, 21);
            this.cboInvite.TabIndex = 39;
            this.cboInvite.ValueMember = "NoInvite";
            // 
            // btnSupprimeInvite
            // 
            this.btnSupprimeInvite.Location = new System.Drawing.Point(29, 160);
            this.btnSupprimeInvite.Name = "btnSupprimeInvite";
            this.btnSupprimeInvite.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimeInvite.TabIndex = 41;
            this.btnSupprimeInvite.Text = "Supprimer";
            this.btnSupprimeInvite.UseVisualStyleBackColor = true;
            this.btnSupprimeInvite.Click += new System.EventHandler(this.btnSupprimeInvite_Click);
            // 
            // btnModifInvite
            // 
            this.btnModifInvite.Location = new System.Drawing.Point(110, 160);
            this.btnModifInvite.Name = "btnModifInvite";
            this.btnModifInvite.Size = new System.Drawing.Size(75, 23);
            this.btnModifInvite.TabIndex = 40;
            this.btnModifInvite.Text = "Modifier";
            this.btnModifInvite.UseVisualStyleBackColor = true;
            this.btnModifInvite.Click += new System.EventHandler(this.btnModifInvite_Click);
            // 
            // btnAjoutInvite
            // 
            this.btnAjoutInvite.Location = new System.Drawing.Point(29, 131);
            this.btnAjoutInvite.Name = "btnAjoutInvite";
            this.btnAjoutInvite.Size = new System.Drawing.Size(156, 23);
            this.btnAjoutInvite.TabIndex = 39;
            this.btnAjoutInvite.Text = "Ajouter";
            this.btnAjoutInvite.UseVisualStyleBackColor = true;
            this.btnAjoutInvite.Click += new System.EventHandler(this.btnAjoutInvite_Click);
            // 
            // p01_InviteTableAdapter
            // 
            this.p01_InviteTableAdapter.ClearBeforeFill = true;
            // 
            // lblBonjour
            // 
            this.lblBonjour.AutoSize = true;
            this.lblBonjour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonjour.Location = new System.Drawing.Point(336, 241);
            this.lblBonjour.Name = "lblBonjour";
            this.lblBonjour.Size = new System.Drawing.Size(57, 20);
            this.lblBonjour.TabIndex = 40;
            this.lblBonjour.Text = "label1";
            // 
            // nosEtNomsClientsTableAdapter
            // 
            this.nosEtNomsClientsTableAdapter.ClearBeforeFill = true;
            // 
            // p01_TypeChambreTableAdapter
            // 
            this.p01_TypeChambreTableAdapter.ClearBeforeFill = true;
            // 
            // frmPrepose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 362);
            this.Controls.Add(this.lblBonjour);
            this.Controls.Add(this.gbInfoInvite);
            this.Controls.Add(this.gbInfoChambre);
            this.Controls.Add(this.gbInfoClient);
            this.Controls.Add(this.btnDeconnexion);
            this.Controls.Add(this.btnQuitter);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrepose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prepose";
            this.Load += new System.EventHandler(this.frmPrepose_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56AnkitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_ClientBindingSource)).EndInit();
            this.gbInfoClient.ResumeLayout(false);
            this.gbInfoClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nosEtNomsClientsBindingSource)).EndInit();
            this.gbInfoChambre.ResumeLayout(false);
            this.gbInfoChambre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p01_TypeChambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_ChambreBindingSource)).EndInit();
            this.gbInfoInvite.ResumeLayout(false);
            this.gbInfoInvite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p01_InviteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Button btnQuitter;
        private BDB56AnkitDataSet bDB56AnkitDataSet;
        private System.Windows.Forms.BindingSource p01_ClientBindingSource;
        private BDB56AnkitDataSetTableAdapters.P01_ClientTableAdapter p01_ClientTableAdapter;
        private BDB56AnkitDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cboClients;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox noClientTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox villeTextBox;
        private System.Windows.Forms.TextBox paysTextBox;
        private System.Windows.Forms.TextBox adresseTextBox;
        private System.Windows.Forms.TextBox codePostalTextBox;
        private System.Windows.Forms.DateTimePicker dateInscriptionDateTimePicker;
        private System.Windows.Forms.GroupBox gbInfoClient;
        private System.Windows.Forms.GroupBox gbInfoChambre;
        private System.Windows.Forms.Button btnAjouterReservation;
        private System.Windows.Forms.BindingSource p01_ChambreBindingSource;
        private BDB56AnkitDataSetTableAdapters.P01_ChambreTableAdapter p01_ChambreTableAdapter;
        private System.Windows.Forms.ComboBox cboChambre;
        private System.Windows.Forms.GroupBox gbInfoInvite;
        private System.Windows.Forms.Button btnSupprimeInvite;
        private System.Windows.Forms.Button btnModifInvite;
        private System.Windows.Forms.Button btnAjoutInvite;
        private System.Windows.Forms.TextBox noChambreTextBox;
        private System.Windows.Forms.TextBox emplacementTextBox;
        private System.Windows.Forms.TextBox decorationsTextBox;
        private System.Windows.Forms.BindingSource p01_InviteBindingSource;
        private BDB56AnkitDataSetTableAdapters.P01_InviteTableAdapter p01_InviteTableAdapter;
        private System.Windows.Forms.TextBox noInviteTextBox;
        private System.Windows.Forms.TextBox nomPrenomTextBox;
        private System.Windows.Forms.TextBox noClientTextBox1;
        private System.Windows.Forms.ComboBox cboInvite;
        private System.Windows.Forms.Label lblBonjour;
        private System.Windows.Forms.BindingSource nosEtNomsClientsBindingSource;
        private BDB56AnkitDataSetTableAdapters.nosEtNomsClientsTableAdapter nosEtNomsClientsTableAdapter;
        private System.Windows.Forms.ComboBox nosEtNomsClientsComboBox;
        private System.Windows.Forms.BindingSource p01_TypeChambreBindingSource;
        private BDB56AnkitDataSetTableAdapters.P01_TypeChambreTableAdapter p01_TypeChambreTableAdapter;
        private System.Windows.Forms.ComboBox p01_TypeChambreComboBox;
    }
}