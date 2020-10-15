namespace Projet01
{
    partial class frmTypeChambre
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
            System.Windows.Forms.Label noTypeChambreLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label prixHautLabel;
            System.Windows.Forms.Label prixBasLabel;
            System.Windows.Forms.Label prixMoyenLabel;
            this.bDB56AnkitDataSet = new Projet01.BDB56AnkitDataSet();
            this.p01_TypeChambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p01_TypeChambreTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.P01_TypeChambreTableAdapter();
            this.tableAdapterManager = new Projet01.BDB56AnkitDataSetTableAdapters.TableAdapterManager();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.prixMoyenTextBox = new System.Windows.Forms.TextBox();
            this.prixBasTextBox = new System.Windows.Forms.TextBox();
            this.prixHautTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.noTypeChambreTextBox = new System.Windows.Forms.TextBox();
            noTypeChambreLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            prixHautLabel = new System.Windows.Forms.Label();
            prixBasLabel = new System.Windows.Forms.Label();
            prixMoyenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56AnkitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_TypeChambreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // noTypeChambreLabel
            // 
            noTypeChambreLabel.AutoSize = true;
            noTypeChambreLabel.Location = new System.Drawing.Point(12, 46);
            noTypeChambreLabel.Name = "noTypeChambreLabel";
            noTypeChambreLabel.Size = new System.Drawing.Size(96, 13);
            noTypeChambreLabel.TabIndex = 1;
            noTypeChambreLabel.Text = "No Type Chambre:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(12, 72);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Description:";
            // 
            // prixHautLabel
            // 
            prixHautLabel.AutoSize = true;
            prixHautLabel.Location = new System.Drawing.Point(12, 98);
            prixHautLabel.Name = "prixHautLabel";
            prixHautLabel.Size = new System.Drawing.Size(53, 13);
            prixHautLabel.TabIndex = 5;
            prixHautLabel.Text = "Prix Haut:";
            // 
            // prixBasLabel
            // 
            prixBasLabel.AutoSize = true;
            prixBasLabel.Location = new System.Drawing.Point(12, 124);
            prixBasLabel.Name = "prixBasLabel";
            prixBasLabel.Size = new System.Drawing.Size(48, 13);
            prixBasLabel.TabIndex = 7;
            prixBasLabel.Text = "Prix Bas:";
            // 
            // prixMoyenLabel
            // 
            prixMoyenLabel.AutoSize = true;
            prixMoyenLabel.Location = new System.Drawing.Point(12, 150);
            prixMoyenLabel.Name = "prixMoyenLabel";
            prixMoyenLabel.Size = new System.Drawing.Size(62, 13);
            prixMoyenLabel.TabIndex = 9;
            prixMoyenLabel.Text = "Prix Moyen:";
            // 
            // bDB56AnkitDataSet
            // 
            this.bDB56AnkitDataSet.DataSetName = "BDB56AnkitDataSet";
            this.bDB56AnkitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p01_TypeChambreBindingSource
            // 
            this.p01_TypeChambreBindingSource.DataMember = "P01_TypeChambre";
            this.p01_TypeChambreBindingSource.DataSource = this.bDB56AnkitDataSet;
            // 
            // p01_TypeChambreTableAdapter
            // 
            this.p01_TypeChambreTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.P01_AssistantSoinTableAdapter = null;
            this.tableAdapterManager.P01_AssistantTableAdapter = null;
            this.tableAdapterManager.P01_ChambreTableAdapter = null;
            this.tableAdapterManager.P01_ClientTableAdapter = null;
            this.tableAdapterManager.P01_InviteTableAdapter = null;
            this.tableAdapterManager.P01_PlanifSoinTableAdapter = null;
            this.tableAdapterManager.P01_ReservationChambreTableAdapter = null;
            this.tableAdapterManager.P01_SoinTableAdapter = null;
            this.tableAdapterManager.P01_TypeChambreTableAdapter = this.p01_TypeChambreTableAdapter;
            this.tableAdapterManager.P01_TypeSoinTableAdapter = null;
            this.tableAdapterManager.P01_TypeUtilisateurTableAdapter = null;
            this.tableAdapterManager.P01_UtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet01.BDB56AnkitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(12, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(57, 20);
            this.lblTitre.TabIndex = 28;
            this.lblTitre.Text = "label1";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(114, 206);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 56);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(12, 206);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(89, 56);
            this.btnConfirmer.TabIndex = 4;
            this.btnConfirmer.Text = "button1";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // prixMoyenTextBox
            // 
            this.prixMoyenTextBox.Location = new System.Drawing.Point(114, 147);
            this.prixMoyenTextBox.Name = "prixMoyenTextBox";
            this.prixMoyenTextBox.Size = new System.Drawing.Size(100, 20);
            this.prixMoyenTextBox.TabIndex = 3;
            this.prixMoyenTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prixHautTextBox_KeyPress);
            // 
            // prixBasTextBox
            // 
            this.prixBasTextBox.Location = new System.Drawing.Point(114, 121);
            this.prixBasTextBox.Name = "prixBasTextBox";
            this.prixBasTextBox.Size = new System.Drawing.Size(100, 20);
            this.prixBasTextBox.TabIndex = 2;
            this.prixBasTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prixHautTextBox_KeyPress);
            // 
            // prixHautTextBox
            // 
            this.prixHautTextBox.Location = new System.Drawing.Point(114, 95);
            this.prixHautTextBox.Name = "prixHautTextBox";
            this.prixHautTextBox.Size = new System.Drawing.Size(100, 20);
            this.prixHautTextBox.TabIndex = 1;
            this.prixHautTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prixHautTextBox_KeyPress);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(114, 69);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextBox.TabIndex = 0;
            // 
            // noTypeChambreTextBox
            // 
            this.noTypeChambreTextBox.Enabled = false;
            this.noTypeChambreTextBox.Location = new System.Drawing.Point(114, 43);
            this.noTypeChambreTextBox.Name = "noTypeChambreTextBox";
            this.noTypeChambreTextBox.ReadOnly = true;
            this.noTypeChambreTextBox.Size = new System.Drawing.Size(100, 20);
            this.noTypeChambreTextBox.TabIndex = 10;
            // 
            // frmTypeChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 274);
            this.Controls.Add(this.noTypeChambreTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.prixHautTextBox);
            this.Controls.Add(this.prixBasTextBox);
            this.Controls.Add(this.prixMoyenTextBox);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(noTypeChambreLabel);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(prixHautLabel);
            this.Controls.Add(prixBasLabel);
            this.Controls.Add(prixMoyenLabel);
            this.Name = "frmTypeChambre";
            this.Text = "frmTypeChambre";
            this.Load += new System.EventHandler(this.frmTypeChambre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56AnkitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_TypeChambreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDB56AnkitDataSet bDB56AnkitDataSet;
        private System.Windows.Forms.BindingSource p01_TypeChambreBindingSource;
        private BDB56AnkitDataSetTableAdapters.P01_TypeChambreTableAdapter p01_TypeChambreTableAdapter;
        private BDB56AnkitDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.TextBox prixMoyenTextBox;
        private System.Windows.Forms.TextBox prixBasTextBox;
        private System.Windows.Forms.TextBox prixHautTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox noTypeChambreTextBox;
    }
}