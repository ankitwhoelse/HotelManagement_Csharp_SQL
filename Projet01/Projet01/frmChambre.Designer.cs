namespace Projet01
{
    partial class frmChambre
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
            System.Windows.Forms.Label noChambreLabel;
            System.Windows.Forms.Label emplacementLabel;
            System.Windows.Forms.Label decorationsLabel;
            System.Windows.Forms.Label noTypeChambreLabel;
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.bDB56AnkitDataSet = new Projet01.BDB56AnkitDataSet();
            this.p01_ChambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p01_ChambreTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.P01_ChambreTableAdapter();
            this.tableAdapterManager = new Projet01.BDB56AnkitDataSetTableAdapters.TableAdapterManager();
            this.lblTitre = new System.Windows.Forms.Label();
            this.decorationsTextBox = new System.Windows.Forms.TextBox();
            this.emplacementTextBox = new System.Windows.Forms.TextBox();
            this.noChambreTextBox = new System.Windows.Forms.TextBox();
            this.p01_TypeChambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p01_TypeChambreTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.P01_TypeChambreTableAdapter();
            this.cboTypeChambre = new System.Windows.Forms.ComboBox();
            noChambreLabel = new System.Windows.Forms.Label();
            emplacementLabel = new System.Windows.Forms.Label();
            decorationsLabel = new System.Windows.Forms.Label();
            noTypeChambreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56AnkitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_ChambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_TypeChambreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // noChambreLabel
            // 
            noChambreLabel.AutoSize = true;
            noChambreLabel.Location = new System.Drawing.Point(12, 49);
            noChambreLabel.Name = "noChambreLabel";
            noChambreLabel.Size = new System.Drawing.Size(69, 13);
            noChambreLabel.TabIndex = 19;
            noChambreLabel.Text = "No Chambre:";
            // 
            // emplacementLabel
            // 
            emplacementLabel.AutoSize = true;
            emplacementLabel.Location = new System.Drawing.Point(12, 75);
            emplacementLabel.Name = "emplacementLabel";
            emplacementLabel.Size = new System.Drawing.Size(74, 13);
            emplacementLabel.TabIndex = 21;
            emplacementLabel.Text = "Emplacement:";
            // 
            // decorationsLabel
            // 
            decorationsLabel.AutoSize = true;
            decorationsLabel.Location = new System.Drawing.Point(12, 101);
            decorationsLabel.Name = "decorationsLabel";
            decorationsLabel.Size = new System.Drawing.Size(67, 13);
            decorationsLabel.TabIndex = 23;
            decorationsLabel.Text = "Decorations:";
            // 
            // noTypeChambreLabel
            // 
            noTypeChambreLabel.AutoSize = true;
            noTypeChambreLabel.Location = new System.Drawing.Point(12, 127);
            noTypeChambreLabel.Name = "noTypeChambreLabel";
            noTypeChambreLabel.Size = new System.Drawing.Size(79, 13);
            noTypeChambreLabel.TabIndex = 25;
            noTypeChambreLabel.Text = "Type Chambre:";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(114, 185);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 56);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(12, 185);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(89, 56);
            this.btnConfirmer.TabIndex = 3;
            this.btnConfirmer.Text = "button1";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // bDB56AnkitDataSet
            // 
            this.bDB56AnkitDataSet.DataSetName = "BDB56AnkitDataSet";
            this.bDB56AnkitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p01_ChambreBindingSource
            // 
            this.p01_ChambreBindingSource.DataMember = "P01_Chambre";
            this.p01_ChambreBindingSource.DataSource = this.bDB56AnkitDataSet;
            // 
            // p01_ChambreTableAdapter
            // 
            this.p01_ChambreTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.assistantsListTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.nosEtNomsClientsTableAdapter = null;
            this.tableAdapterManager.P01_AssistantSoinTableAdapter = null;
            this.tableAdapterManager.P01_AssistantTableAdapter = null;
            this.tableAdapterManager.P01_ChambreTableAdapter = this.p01_ChambreTableAdapter;
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
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(12, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(57, 20);
            this.lblTitre.TabIndex = 27;
            this.lblTitre.Text = "label1";
            // 
            // decorationsTextBox
            // 
            this.decorationsTextBox.Location = new System.Drawing.Point(114, 98);
            this.decorationsTextBox.MaxLength = 30;
            this.decorationsTextBox.Name = "decorationsTextBox";
            this.decorationsTextBox.Size = new System.Drawing.Size(100, 20);
            this.decorationsTextBox.TabIndex = 1;
            // 
            // emplacementTextBox
            // 
            this.emplacementTextBox.Location = new System.Drawing.Point(114, 72);
            this.emplacementTextBox.MaxLength = 30;
            this.emplacementTextBox.Name = "emplacementTextBox";
            this.emplacementTextBox.Size = new System.Drawing.Size(100, 20);
            this.emplacementTextBox.TabIndex = 0;
            // 
            // noChambreTextBox
            // 
            this.noChambreTextBox.Location = new System.Drawing.Point(114, 46);
            this.noChambreTextBox.Name = "noChambreTextBox";
            this.noChambreTextBox.ReadOnly = true;
            this.noChambreTextBox.Size = new System.Drawing.Size(100, 20);
            this.noChambreTextBox.TabIndex = 0;
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
            // cboTypeChambre
            // 
            this.cboTypeChambre.DataSource = this.p01_TypeChambreBindingSource;
            this.cboTypeChambre.DisplayMember = "Description";
            this.cboTypeChambre.FormattingEnabled = true;
            this.cboTypeChambre.Location = new System.Drawing.Point(114, 124);
            this.cboTypeChambre.Name = "cboTypeChambre";
            this.cboTypeChambre.Size = new System.Drawing.Size(100, 21);
            this.cboTypeChambre.TabIndex = 27;
            this.cboTypeChambre.ValueMember = "NoTypeChambre";
            // 
            // frmChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 261);
            this.Controls.Add(this.cboTypeChambre);
            this.Controls.Add(this.noChambreTextBox);
            this.Controls.Add(this.emplacementTextBox);
            this.Controls.Add(this.decorationsTextBox);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(noChambreLabel);
            this.Controls.Add(emplacementLabel);
            this.Controls.Add(decorationsLabel);
            this.Controls.Add(noTypeChambreLabel);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChambre";
            this.Text = "frmChambre";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChambre_FormClosing);
            this.Load += new System.EventHandler(this.frmChambre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56AnkitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_ChambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_TypeChambreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
        private BDB56AnkitDataSet bDB56AnkitDataSet;
        private System.Windows.Forms.BindingSource p01_ChambreBindingSource;
        private BDB56AnkitDataSetTableAdapters.P01_ChambreTableAdapter p01_ChambreTableAdapter;
        private BDB56AnkitDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TextBox decorationsTextBox;
        private System.Windows.Forms.TextBox emplacementTextBox;
        private System.Windows.Forms.TextBox noChambreTextBox;
        private System.Windows.Forms.BindingSource p01_TypeChambreBindingSource;
        private BDB56AnkitDataSetTableAdapters.P01_TypeChambreTableAdapter p01_TypeChambreTableAdapter;
        private System.Windows.Forms.ComboBox cboTypeChambre;
    }
}