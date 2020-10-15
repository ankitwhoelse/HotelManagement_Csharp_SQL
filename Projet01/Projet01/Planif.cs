using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet01
{
    public partial class Planif : Form
    {
        public dynamic NoSoin;
        public dynamic NomSoin;
        String maChaineDeConnexion = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=BDB56Ankit;Persist Security Info=True;User ID=B56Ankit;Password=Summit11g";
        public Planif()
        {
            InitializeComponent();
        }

        private void p01_SoinBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.p01_SoinBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56AnkitDataSet);

        }

        private void Planif_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDB56AnkitDataSet.NoEtNomComplet_Client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.noEtNomComplet_ClientTableAdapter.Fill(this.bDB56AnkitDataSet.NoEtNomComplet_Client);
            // TODO: cette ligne de code charge les données dans la table 'bDB56AnkitDataSet.P01_Assistant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.p01_AssistantTableAdapter.Fill(this.bDB56AnkitDataSet.P01_Assistant);
            // TODO: cette ligne de code charge les données dans la table 'bDB56AnkitDataSet.P01_Soin'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.p01_SoinTableAdapter.Fill(this.bDB56AnkitDataSet.P01_Soin);
            this.nom_Numero_InvitesTableAdapter.Fill(this.bDB56AnkitDataSet.Nom_Numero_Invites);
            rbClient.Checked = true;
            tbSoin.Text = NomSoin;
            TimePicker.Format = DateTimePickerFormat.Time;
            TimePicker.ShowUpDown = true;
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            DateTime tempsPlanif = datePicker.Value.Date + TimePicker.Value.TimeOfDay;

            //if(tempsPlanif.Hour)
            MessageBox.Show("Voici le temps sélectionné " + tempsPlanif.Minute, "Temps", MessageBoxButtons.OK, MessageBoxIcon.Information);
            /* SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
             maConnexion.Open();
             String maRequeteSQL = "insert into P01_Soin(NoSoin,Description,Duree,NoTypeSoin,prix) values('" + int.Parse(noSoinTextBox.Text.ToString()) + "','" + descriptionTextBox.Text.ToString() + "','" + int.Parse(dureeTextBox.Text.ToString()) + "','" + int.Parse(noTypeSoinTextBox.Text.ToString()) + "','" + int.Parse(prixTextBox.Text.ToString()) + "')";
             SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
             maCommande.ExecuteScalar();
             maConnexion.Close();

             this.p01_SoinBindingSource.EndEdit();
             this.p01_SoinTableAdapter.Update(this.bDB56AnkitDataSet.P01_Soin);
             MessageBox.Show("Le nouveau type de soin a été ajouté.", "Nouveau type de soin enregistré", MessageBoxButtons.OK, MessageBoxIcon.Information);
             this.Close();*/
        }

        private void rbClient_CheckedChanged(object sender, EventArgs e)
        {
            CbPersonnes.DataSource = this.noEtNomComplet_ClientBindingSource;
            CbPersonnes.DisplayMember = "No_Nom_Client";
        }

        private void rbInvite_CheckedChanged(object sender, EventArgs e)
        {
            CbPersonnes.DataSource = this.nomNumeroInvitesBindingSource;
            CbPersonnes.DisplayMember = "Nom_Numero_Invites";
        }
    }
}
