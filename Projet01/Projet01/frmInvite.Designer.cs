namespace Projet01
{
    partial class frmInvite
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
            System.Windows.Forms.Label noInviteLabel;
            System.Windows.Forms.Label nomPrenomLabel;
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.bDB56AnkitDataSet = new Projet01.BDB56AnkitDataSet();
            this.p01_InviteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p01_InviteTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.P01_InviteTableAdapter();
            this.tableAdapterManager = new Projet01.BDB56AnkitDataSetTableAdapters.TableAdapterManager();
            this.noInviteTextBox = new System.Windows.Forms.TextBox();
            this.nomPrenomTextBox = new System.Windows.Forms.TextBox();
            this.nomClientTextBox = new System.Windows.Forms.TextBox();
            noClientLabel = new System.Windows.Forms.Label();
            noInviteLabel = new System.Windows.Forms.Label();
            nomPrenomLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56AnkitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_InviteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // noClientLabel
            // 
            noClientLabel.AutoSize = true;
            noClientLabel.Location = new System.Drawing.Point(9, 115);
            noClientLabel.Name = "noClientLabel";
            noClientLabel.Size = new System.Drawing.Size(61, 13);
            noClientLabel.TabIndex = 22;
            noClientLabel.Text = "Nom Client:";
            // 
            // noInviteLabel
            // 
            noInviteLabel.AutoSize = true;
            noInviteLabel.Location = new System.Drawing.Point(9, 63);
            noInviteLabel.Name = "noInviteLabel";
            noInviteLabel.Size = new System.Drawing.Size(53, 13);
            noInviteLabel.TabIndex = 24;
            noInviteLabel.Text = "No Invite:";
            // 
            // nomPrenomLabel
            // 
            nomPrenomLabel.AutoSize = true;
            nomPrenomLabel.Location = new System.Drawing.Point(9, 89);
            nomPrenomLabel.Name = "nomPrenomLabel";
            nomPrenomLabel.Size = new System.Drawing.Size(71, 13);
            nomPrenomLabel.TabIndex = 26;
            nomPrenomLabel.Text = "Nom Prenom:";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(107, 160);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 56);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(12, 160);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(89, 56);
            this.btnConfirmer.TabIndex = 2;
            this.btnConfirmer.Text = "button1";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(12, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(57, 20);
            this.lblTitre.TabIndex = 18;
            this.lblTitre.Text = "label1";
            // 
            // bDB56AnkitDataSet
            // 
            this.bDB56AnkitDataSet.DataSetName = "BDB56AnkitDataSet";
            this.bDB56AnkitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p01_InviteBindingSource
            // 
            this.p01_InviteBindingSource.DataMember = "P01_Invite";
            this.p01_InviteBindingSource.DataSource = this.bDB56AnkitDataSet;
            // 
            // p01_InviteTableAdapter
            // 
            this.p01_InviteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.P01_AssistantSoinTableAdapter = null;
            this.tableAdapterManager.P01_AssistantTableAdapter = null;
            this.tableAdapterManager.P01_ChambreTableAdapter = null;
            this.tableAdapterManager.P01_ClientTableAdapter = null;
            this.tableAdapterManager.P01_InviteTableAdapter = this.p01_InviteTableAdapter;
            this.tableAdapterManager.P01_PlanifSoinTableAdapter = null;
            this.tableAdapterManager.P01_ReservationChambreTableAdapter = null;
            this.tableAdapterManager.P01_SoinTableAdapter = null;
            this.tableAdapterManager.P01_TypeChambreTableAdapter = null;
            this.tableAdapterManager.P01_TypeSoinTableAdapter = null;
            this.tableAdapterManager.P01_TypeUtilisateurTableAdapter = null;
            this.tableAdapterManager.P01_UtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet01.BDB56AnkitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // noInviteTextBox
            // 
            this.noInviteTextBox.Location = new System.Drawing.Point(107, 56);
            this.noInviteTextBox.Name = "noInviteTextBox";
            this.noInviteTextBox.Size = new System.Drawing.Size(100, 20);
            this.noInviteTextBox.TabIndex = 27;
            // 
            // nomPrenomTextBox
            // 
            this.nomPrenomTextBox.Location = new System.Drawing.Point(107, 82);
            this.nomPrenomTextBox.Name = "nomPrenomTextBox";
            this.nomPrenomTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomPrenomTextBox.TabIndex = 0;
            // 
            // nomClientTextBox
            // 
            this.nomClientTextBox.Location = new System.Drawing.Point(107, 112);
            this.nomClientTextBox.Name = "nomClientTextBox";
            this.nomClientTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomClientTextBox.TabIndex = 1;
            // 
            // frmInvite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 236);
            this.Controls.Add(this.nomClientTextBox);
            this.Controls.Add(this.nomPrenomTextBox);
            this.Controls.Add(this.noInviteTextBox);
            this.Controls.Add(noInviteLabel);
            this.Controls.Add(nomPrenomLabel);
            this.Controls.Add(noClientLabel);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Name = "frmInvite";
            this.Text = "frmInvite";
            this.Load += new System.EventHandler(this.frmInvite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56AnkitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_InviteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Label lblTitre;
        private BDB56AnkitDataSet bDB56AnkitDataSet;
        private System.Windows.Forms.BindingSource p01_InviteBindingSource;
        private BDB56AnkitDataSetTableAdapters.P01_InviteTableAdapter p01_InviteTableAdapter;
        private BDB56AnkitDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox noInviteTextBox;
        private System.Windows.Forms.TextBox nomPrenomTextBox;
        private System.Windows.Forms.TextBox nomClientTextBox;
    }
}