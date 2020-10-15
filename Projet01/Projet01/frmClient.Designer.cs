namespace Projet01
{
    partial class frmClient
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.noClientTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.villeTextBox = new System.Windows.Forms.TextBox();
            this.paysTextBox = new System.Windows.Forms.TextBox();
            this.adresseTextBox = new System.Windows.Forms.TextBox();
            this.codePostalTextBox = new System.Windows.Forms.TextBox();
            this.dateInscriptionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bDB56AnkitDataSet = new Projet01.BDB56AnkitDataSet();
            this.p01_ClientTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.P01_ClientTableAdapter();
            this.tableAdapterManager = new Projet01.BDB56AnkitDataSetTableAdapters.TableAdapterManager();
            this.p01_ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            noClientLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            villeLabel = new System.Windows.Forms.Label();
            paysLabel = new System.Windows.Forms.Label();
            adresseLabel = new System.Windows.Forms.Label();
            codePostalLabel = new System.Windows.Forms.Label();
            dateInscriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56AnkitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_ClientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // noClientLabel
            // 
            noClientLabel.AutoSize = true;
            noClientLabel.Location = new System.Drawing.Point(18, 51);
            noClientLabel.Name = "noClientLabel";
            noClientLabel.Size = new System.Drawing.Size(53, 13);
            noClientLabel.TabIndex = 24;
            noClientLabel.Text = "No Client:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(18, 77);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(32, 13);
            nomLabel.TabIndex = 26;
            nomLabel.Text = "Nom:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(18, 103);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(46, 13);
            prenomLabel.TabIndex = 28;
            prenomLabel.Text = "Prenom:";
            // 
            // villeLabel
            // 
            villeLabel.AutoSize = true;
            villeLabel.Location = new System.Drawing.Point(18, 129);
            villeLabel.Name = "villeLabel";
            villeLabel.Size = new System.Drawing.Size(29, 13);
            villeLabel.TabIndex = 30;
            villeLabel.Text = "Ville:";
            // 
            // paysLabel
            // 
            paysLabel.AutoSize = true;
            paysLabel.Location = new System.Drawing.Point(18, 155);
            paysLabel.Name = "paysLabel";
            paysLabel.Size = new System.Drawing.Size(33, 13);
            paysLabel.TabIndex = 32;
            paysLabel.Text = "Pays:";
            // 
            // adresseLabel
            // 
            adresseLabel.AutoSize = true;
            adresseLabel.Location = new System.Drawing.Point(18, 181);
            adresseLabel.Name = "adresseLabel";
            adresseLabel.Size = new System.Drawing.Size(48, 13);
            adresseLabel.TabIndex = 34;
            adresseLabel.Text = "Adresse:";
            // 
            // codePostalLabel
            // 
            codePostalLabel.AutoSize = true;
            codePostalLabel.Location = new System.Drawing.Point(18, 207);
            codePostalLabel.Name = "codePostalLabel";
            codePostalLabel.Size = new System.Drawing.Size(67, 13);
            codePostalLabel.TabIndex = 36;
            codePostalLabel.Text = "Code Postal:";
            // 
            // dateInscriptionLabel
            // 
            dateInscriptionLabel.AutoSize = true;
            dateInscriptionLabel.Location = new System.Drawing.Point(18, 234);
            dateInscriptionLabel.Name = "dateInscriptionLabel";
            dateInscriptionLabel.Size = new System.Drawing.Size(84, 13);
            dateInscriptionLabel.TabIndex = 38;
            dateInscriptionLabel.Text = "Date Inscription:";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(12, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(57, 20);
            this.lblTitre.TabIndex = 23;
            this.lblTitre.Text = "label5";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(208, 292);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 56);
            this.btnAnnuler.TabIndex = 8;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(108, 292);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(89, 56);
            this.btnConfirmer.TabIndex = 7;
            this.btnConfirmer.Text = "button1";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // noClientTextBox
            // 
            this.noClientTextBox.Location = new System.Drawing.Point(108, 48);
            this.noClientTextBox.Name = "noClientTextBox";
            this.noClientTextBox.ReadOnly = true;
            this.noClientTextBox.Size = new System.Drawing.Size(200, 20);
            this.noClientTextBox.TabIndex = 0;
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(108, 74);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomTextBox.TabIndex = 0;
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.Location = new System.Drawing.Point(108, 100);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(200, 20);
            this.prenomTextBox.TabIndex = 1;
            // 
            // villeTextBox
            // 
            this.villeTextBox.Location = new System.Drawing.Point(108, 126);
            this.villeTextBox.Name = "villeTextBox";
            this.villeTextBox.Size = new System.Drawing.Size(200, 20);
            this.villeTextBox.TabIndex = 2;
            // 
            // paysTextBox
            // 
            this.paysTextBox.Location = new System.Drawing.Point(108, 152);
            this.paysTextBox.Name = "paysTextBox";
            this.paysTextBox.Size = new System.Drawing.Size(200, 20);
            this.paysTextBox.TabIndex = 3;
            // 
            // adresseTextBox
            // 
            this.adresseTextBox.Location = new System.Drawing.Point(108, 178);
            this.adresseTextBox.Name = "adresseTextBox";
            this.adresseTextBox.Size = new System.Drawing.Size(200, 20);
            this.adresseTextBox.TabIndex = 4;
            // 
            // codePostalTextBox
            // 
            this.codePostalTextBox.Location = new System.Drawing.Point(108, 204);
            this.codePostalTextBox.Name = "codePostalTextBox";
            this.codePostalTextBox.Size = new System.Drawing.Size(200, 20);
            this.codePostalTextBox.TabIndex = 5;
            // 
            // dateInscriptionDateTimePicker
            // 
            this.dateInscriptionDateTimePicker.Enabled = false;
            this.dateInscriptionDateTimePicker.Location = new System.Drawing.Point(108, 230);
            this.dateInscriptionDateTimePicker.Name = "dateInscriptionDateTimePicker";
            this.dateInscriptionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateInscriptionDateTimePicker.TabIndex = 6;
            this.dateInscriptionDateTimePicker.Value = new System.DateTime(2020, 9, 29, 22, 8, 31, 0);
            // 
            // bDB56AnkitDataSet
            // 
            this.bDB56AnkitDataSet.DataSetName = "BDB56AnkitDataSet";
            this.bDB56AnkitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p01_ClientTableAdapter
            // 
            this.p01_ClientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
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
            // p01_ClientBindingSource
            // 
            this.p01_ClientBindingSource.DataMember = "P01_Client";
            this.p01_ClientBindingSource.DataSource = this.bDB56AnkitDataSet;
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 368);
            this.Controls.Add(noClientLabel);
            this.Controls.Add(this.noClientTextBox);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.prenomTextBox);
            this.Controls.Add(villeLabel);
            this.Controls.Add(this.villeTextBox);
            this.Controls.Add(paysLabel);
            this.Controls.Add(this.paysTextBox);
            this.Controls.Add(adresseLabel);
            this.Controls.Add(this.adresseTextBox);
            this.Controls.Add(codePostalLabel);
            this.Controls.Add(this.codePostalTextBox);
            this.Controls.Add(dateInscriptionLabel);
            this.Controls.Add(this.dateInscriptionDateTimePicker);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Name = "frmClient";
            this.Text = "frmClient";
            this.Load += new System.EventHandler(this.frmClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56AnkitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_ClientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.TextBox noClientTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox villeTextBox;
        private System.Windows.Forms.TextBox paysTextBox;
        private System.Windows.Forms.TextBox adresseTextBox;
        private System.Windows.Forms.TextBox codePostalTextBox;
        private System.Windows.Forms.DateTimePicker dateInscriptionDateTimePicker;
        private BDB56AnkitDataSet bDB56AnkitDataSet;
        private BDB56AnkitDataSetTableAdapters.P01_ClientTableAdapter p01_ClientTableAdapter;
        private BDB56AnkitDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource p01_ClientBindingSource;
    }
}