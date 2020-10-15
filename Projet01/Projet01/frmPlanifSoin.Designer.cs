namespace Projet01
{
    partial class frmPlanifSoin
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
            System.Windows.Forms.Label noPersonneLabel;
            System.Windows.Forms.Label noAssistantLabel;
            System.Windows.Forms.Label dateHeureLabel;
            System.Windows.Forms.Label noSoinLabel;
            this.bDB56AnkitDataSet = new Projet01.BDB56AnkitDataSet();
            this.p01_PlanifSoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p01_PlanifSoinTableAdapter = new Projet01.BDB56AnkitDataSetTableAdapters.P01_PlanifSoinTableAdapter();
            this.tableAdapterManager = new Projet01.BDB56AnkitDataSetTableAdapters.TableAdapterManager();
            this.noPersonneTextBox = new System.Windows.Forms.TextBox();
            this.noAssistantTextBox = new System.Windows.Forms.TextBox();
            this.dateHeureDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.noSoinTextBox = new System.Windows.Forms.TextBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            noPersonneLabel = new System.Windows.Forms.Label();
            noAssistantLabel = new System.Windows.Forms.Label();
            dateHeureLabel = new System.Windows.Forms.Label();
            noSoinLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDB56AnkitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_PlanifSoinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // noPersonneLabel
            // 
            noPersonneLabel.AutoSize = true;
            noPersonneLabel.Location = new System.Drawing.Point(12, 88);
            noPersonneLabel.Name = "noPersonneLabel";
            noPersonneLabel.Size = new System.Drawing.Size(72, 13);
            noPersonneLabel.TabIndex = 1;
            noPersonneLabel.Text = "No Personne:";
            // 
            // noAssistantLabel
            // 
            noAssistantLabel.AutoSize = true;
            noAssistantLabel.Location = new System.Drawing.Point(12, 114);
            noAssistantLabel.Name = "noAssistantLabel";
            noAssistantLabel.Size = new System.Drawing.Size(69, 13);
            noAssistantLabel.TabIndex = 3;
            noAssistantLabel.Text = "No Assistant:";
            // 
            // dateHeureLabel
            // 
            dateHeureLabel.AutoSize = true;
            dateHeureLabel.Location = new System.Drawing.Point(12, 141);
            dateHeureLabel.Name = "dateHeureLabel";
            dateHeureLabel.Size = new System.Drawing.Size(65, 13);
            dateHeureLabel.TabIndex = 5;
            dateHeureLabel.Text = "Date Heure:";
            // 
            // noSoinLabel
            // 
            noSoinLabel.AutoSize = true;
            noSoinLabel.Location = new System.Drawing.Point(12, 166);
            noSoinLabel.Name = "noSoinLabel";
            noSoinLabel.Size = new System.Drawing.Size(48, 13);
            noSoinLabel.TabIndex = 7;
            noSoinLabel.Text = "No Soin:";
            // 
            // bDB56AnkitDataSet
            // 
            this.bDB56AnkitDataSet.DataSetName = "BDB56AnkitDataSet";
            this.bDB56AnkitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p01_PlanifSoinBindingSource
            // 
            this.p01_PlanifSoinBindingSource.DataMember = "P01_PlanifSoin";
            this.p01_PlanifSoinBindingSource.DataSource = this.bDB56AnkitDataSet;
            // 
            // p01_PlanifSoinTableAdapter
            // 
            this.p01_PlanifSoinTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.P01_AssistantSoinTableAdapter = null;
            this.tableAdapterManager.P01_AssistantTableAdapter = null;
            this.tableAdapterManager.P01_ChambreTableAdapter = null;
            this.tableAdapterManager.P01_ClientTableAdapter = null;
            this.tableAdapterManager.P01_InviteTableAdapter = null;
            this.tableAdapterManager.P01_PlanifSoinTableAdapter = this.p01_PlanifSoinTableAdapter;
            this.tableAdapterManager.P01_ReservationChambreTableAdapter = null;
            this.tableAdapterManager.P01_SoinTableAdapter = null;
            this.tableAdapterManager.P01_TypeChambreTableAdapter = null;
            this.tableAdapterManager.P01_TypeSoinTableAdapter = null;
            this.tableAdapterManager.P01_TypeUtilisateurTableAdapter = null;
            this.tableAdapterManager.P01_UtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet01.BDB56AnkitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // noPersonneTextBox
            // 
            this.noPersonneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_PlanifSoinBindingSource, "NoPersonne", true));
            this.noPersonneTextBox.Location = new System.Drawing.Point(90, 85);
            this.noPersonneTextBox.Name = "noPersonneTextBox";
            this.noPersonneTextBox.Size = new System.Drawing.Size(145, 20);
            this.noPersonneTextBox.TabIndex = 2;
            // 
            // noAssistantTextBox
            // 
            this.noAssistantTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_PlanifSoinBindingSource, "NoAssistant", true));
            this.noAssistantTextBox.Location = new System.Drawing.Point(90, 111);
            this.noAssistantTextBox.Name = "noAssistantTextBox";
            this.noAssistantTextBox.Size = new System.Drawing.Size(145, 20);
            this.noAssistantTextBox.TabIndex = 4;
            // 
            // dateHeureDateTimePicker
            // 
            this.dateHeureDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.p01_PlanifSoinBindingSource, "DateHeure", true));
            this.dateHeureDateTimePicker.Location = new System.Drawing.Point(90, 137);
            this.dateHeureDateTimePicker.Name = "dateHeureDateTimePicker";
            this.dateHeureDateTimePicker.Size = new System.Drawing.Size(145, 20);
            this.dateHeureDateTimePicker.TabIndex = 6;
            // 
            // noSoinTextBox
            // 
            this.noSoinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p01_PlanifSoinBindingSource, "NoSoin", true));
            this.noSoinTextBox.Location = new System.Drawing.Point(90, 163);
            this.noSoinTextBox.Name = "noSoinTextBox";
            this.noSoinTextBox.Size = new System.Drawing.Size(145, 20);
            this.noSoinTextBox.TabIndex = 8;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(12, 9);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(47, 20);
            this.lblTitre.TabIndex = 15;
            this.lblTitre.Text = "label";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(135, 200);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 56);
            this.btnAnnuler.TabIndex = 14;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(24, 200);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(89, 56);
            this.btnConfirmer.TabIndex = 13;
            this.btnConfirmer.Text = "button1";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // frmPlanifSoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 268);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(noPersonneLabel);
            this.Controls.Add(this.noPersonneTextBox);
            this.Controls.Add(noAssistantLabel);
            this.Controls.Add(this.noAssistantTextBox);
            this.Controls.Add(dateHeureLabel);
            this.Controls.Add(this.dateHeureDateTimePicker);
            this.Controls.Add(noSoinLabel);
            this.Controls.Add(this.noSoinTextBox);
            this.Name = "frmPlanifSoin";
            this.Text = "frmPlanifSoin";
            this.Load += new System.EventHandler(this.frmPlanifSoin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDB56AnkitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p01_PlanifSoinBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDB56AnkitDataSet bDB56AnkitDataSet;
        private System.Windows.Forms.BindingSource p01_PlanifSoinBindingSource;
        private BDB56AnkitDataSetTableAdapters.P01_PlanifSoinTableAdapter p01_PlanifSoinTableAdapter;
        private BDB56AnkitDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox noPersonneTextBox;
        private System.Windows.Forms.TextBox noAssistantTextBox;
        private System.Windows.Forms.DateTimePicker dateHeureDateTimePicker;
        private System.Windows.Forms.TextBox noSoinTextBox;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
    }
}