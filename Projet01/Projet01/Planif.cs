using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            TimePicker.CustomFormat = "HH:mm:ss";
            TimePicker.ShowUpDown = true;
           
            datePicker.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            //DateTime tempsPlanif = datePicker.Value.Date + TimePicker.Value.TimeOfDay;
            DateTime tempsPlanif = datePicker.Value;
            DataRowView Personnes = CbPersonnes.SelectedItem as DataRowView;
            DataRowView Assistants = p01_AssistantComboBox.SelectedItem as DataRowView;
            string strAssistant = Assistants.Row["Prenom"] as string;
            string strNoPersonne = "";
            if (rbClient.Checked == true)
                strNoPersonne = Personnes.Row["No_Nom_client"] as string;
            else
                strNoPersonne = Personnes.Row["Nom_Numero_Invites"] as string;
            strNoPersonne = strNoPersonne.Substring(strNoPersonne.LastIndexOf(',') + 1);
            int NoPersonne = Int32.Parse(strNoPersonne);


            SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
            maConnexion.Open();

            String maRequeteSQL = "select NoAssistant from P01_Assistant where Prenom= '" + strAssistant + "'";
            SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
            Object NoAssistant = maCommande.ExecuteScalar();
            maConnexion.Close();

            if ((tempsPlanif.Hour > 17 || tempsPlanif.Hour < 8) || (tempsPlanif.Hour == 17 && (tempsPlanif.Minute > 0 || tempsPlanif.Second > 0)))
                MessageBox.Show("Veuillez sélectionner une heure de réservation entre 8h et 17h ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {

                //MessageBox.Show("Voici le numero d'assistant  " + resultat, "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);

                maConnexion.Open();
                maRequeteSQL = "insert into P01_PlanifSoin(NoPersonne,NoAssistant,DateHeure,NoSoin) values(" + NoPersonne + "," + Int32.Parse(NoAssistant.ToString()) 
                    + ",'" + tempsPlanif.ToString("yyyy-MM-dd HH:mm:ss") + "'," + NoSoin + ")";
                maCommande = new SqlCommand(maRequeteSQL, maConnexion);
                maCommande.ExecuteScalar();
                maConnexion.Close();

                this.p01_SoinBindingSource.EndEdit();
                this.p01_SoinTableAdapter.Update(this.bDB56AnkitDataSet.P01_Soin);
                MessageBox.Show("La nouvelle planification à été ajoutée avec succès.", "Nouvelle planification enregistré", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
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
