namespace Projet01
{
    partial class frmSoin
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
            System.Windows.Forms.Label noSoinLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label dureeLabel;
            System.Windows.Forms.Label noTypeSoinLabel;
            System.Windows.Forms.Label prixLabel;
            this.bDB56AnkitDataSet = new Projet01.BDB56AnkitDataSet();
            this.p01_SoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p01_SoinTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.P01_SoinTableAdapter();
            this.tableAdapterManager = new Projet01.BDB56AnkitDataSetTableAdapters.TableAdapterManager();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.noSoinTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.dureeTextBox = new System.Windows.Forms.TextBox();
            this.noTypeSoinTextBox = new System.Windows.Forms.TextBox();
            this.prixTextBox = new System.Windows.Forms.TextBox();
            noSoinLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            dureeLabel = new System.Windows.Forms.Label();
            noTypeSoinLabel = new System.Windows.Forms.Label();
            prixLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56AnkitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_SoinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // noSoinLabel
            // 
            noSoinLabel.AutoSize = true;
            noSoinLabel.Location = new System.Drawing.Point(12, 51);
            noSoinLabel.Name = "noSoinLabel";
            noSoinLabel.Size = new System.Drawing.Size(48, 13);
            noSoinLabel.TabIndex = 0;
            noSoinLabel.Text = "No Soin:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(12, 77);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // dureeLabel
            // 
            dureeLabel.AutoSize = true;
            dureeLabel.Location = new System.Drawing.Point(12, 103);
            dureeLabel.Name = "dureeLabel";
            dureeLabel.Size = new System.Drawing.Size(39, 13);
            dureeLabel.TabIndex = 4;
            dureeLabel.Text = "Duree:";
            // 
            // noTypeSoinLabel
            // 
            noTypeSoinLabel.AutoSize = true;
            noTypeSoinLabel.Location = new System.Drawing.Point(12, 129);
            noTypeSoinLabel.Name = "noTypeSoinLabel";
            noTypeSoinLabel.Size = new System.Drawing.Size(75, 13);
            noTypeSoinLabel.TabIndex = 6;
            noTypeSoinLabel.Text = "No Type Soin:";
            // 
            // prixLabel
            // 
            prixLabel.AutoSize = true;
            prixLabel.Location = new System.Drawing.Point(12, 155);
            prixLabel.Name = "prixLabel";
            prixLabel.Size = new System.Drawing.Size(27, 13);
            prixLabel.TabIndex = 8;
            prixLabel.Text = "Prix:";
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
            this.tableAdapterManager.P01_AssistantTableAdapter = null;
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
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(13, 13);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(57, 20);
            this.lblTitre.TabIndex = 10;
            this.lblTitre.Text = "label1";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(129, 203);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 56);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(15, 203);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(89, 56);
            this.btnConfirmer.TabIndex = 4;
            this.btnConfirmer.Text = "button1";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // noSoinTextBox
            // 
            this.noSoinTextBox.Location = new System.Drawing.Point(129, 48);
            this.noSoinTextBox.Name = "noSoinTextBox";
            this.noSoinTextBox.Size = new System.Drawing.Size(100, 20);
            this.noSoinTextBox.TabIndex = 17;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(129, 74);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextBox.TabIndex = 0;
            // 
            // dureeTextBox
            // 
            this.dureeTextBox.Location = new System.Drawing.Point(129, 100);
            this.dureeTextBox.Name = "dureeTextBox";
            this.dureeTextBox.Size = new System.Drawing.Size(100, 20);
            this.dureeTextBox.TabIndex = 1;
            // 
            // noTypeSoinTextBox
            // 
            this.noTypeSoinTextBox.Location = new System.Drawing.Point(129, 126);
            this.noTypeSoinTextBox.Name = "noTypeSoinTextBox";
            this.noTypeSoinTextBox.Size = new System.Drawing.Size(100, 20);
            this.noTypeSoinTextBox.TabIndex = 2;
            // 
            // prixTextBox
            // 
            this.prixTextBox.Location = new System.Drawing.Point(129, 152);
            this.prixTextBox.Name = "prixTextBox";
            this.prixTextBox.Size = new System.Drawing.Size(100, 20);
            this.prixTextBox.TabIndex = 3;
            // 
            // frmSoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 271);
            this.Controls.Add(this.prixTextBox);
            this.Controls.Add(this.noTypeSoinTextBox);
            this.Controls.Add(this.dureeTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.noSoinTextBox);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(noSoinLabel);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(dureeLabel);
            this.Controls.Add(noTypeSoinLabel);
            this.Controls.Add(prixLabel);
            this.Name = "frmSoin";
            this.Text = "frmSoin";
            this.Load += new System.EventHandler(this.frmSoin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56AnkitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_SoinBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDB56AnkitDataSet bDB56AnkitDataSet;
        private System.Windows.Forms.BindingSource p01_SoinBindingSource;
        private BDB56AnkitDataSetTableAdapters.P01_SoinTableAdapter p01_SoinTableAdapter;
        private BDB56AnkitDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.TextBox noSoinTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox dureeTextBox;
        private System.Windows.Forms.TextBox noTypeSoinTextBox;
        private System.Windows.Forms.TextBox prixTextBox;
    }
}