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
    public partial class frmClient : Form
    {
        public bool booAjout;
        public dynamic NoClient;

        String maChaineDeConnexion = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=BDB56Ankit;Persist Security Info=True;User ID=B56Ankit;Password=Summit11g";

        public frmClient()
        {
            InitializeComponent();
        }
        
        private void frmClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_Client' table. You can move, or remove it, as needed.
            this.p01_ClientTableAdapter.Fill(this.bDB56AnkitDataSet.P01_Client);

            //  Vider tout les textBox
            foreach (TextBox textBox in Controls.OfType<TextBox>())
                textBox.Text = "";

            if (booAjout)   // AJOUT
            {
                // Rechercher le plus gros numero client dans la DataTable contrat
                decimal noClientMax = 0;
                foreach (BDB56AnkitDataSet.P01_ClientRow uneLigne in bDB56AnkitDataSet.P01_Client.Rows)
                    if (uneLigne.NoClient > noClientMax)
                        noClientMax = uneLigne.NoClient;
                noClientMax += 10;
                noClientTextBox.Text = noClientMax.ToString();

                // Date d'aujourd'hui
                dateInscriptionDateTimePicker.Value = DateTime.Today;
                
                lblTitre.Text = "Ajouter un client";
                btnConfirmer.Text = "Ajouter";
                this.Text = "Ajouter un client";
            }
            else if (!booAjout) // MODIF
            {
                // Remplir automatiquement des champs
                noClientTextBox.Text = NoClient;

                using (SqlConnection con = new SqlConnection(maChaineDeConnexion))
                {
                    con.Open();
                    string requete = "SELECT * FROM P01_Client WHERE NoClient = " + NoClient;
                    SqlCommand com = new SqlCommand(requete, con);

                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        nomTextBox.Text = dr[1].ToString();
                        prenomTextBox.Text = dr[2].ToString();
                        villeTextBox.Text = dr[3].ToString();
                        paysTextBox.Text = dr[4].ToString();
                        adresseTextBox.Text = dr[5].ToString();
                        codePostalTextBox.Text = dr[6].ToString();
                        dateInscriptionDateTimePicker.Text = dr[7].ToString();
                    }

                    con.Close();
                }

                lblTitre.Text = "Modifier un client";
                btnConfirmer.Text = "Modifier";
                this.Text = "Modifier un client";
            }
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (booAjout)
            {           // AJOUT
                // Creer un nouveau client en memoire
                BDB56AnkitDataSet.P01_ClientRow unClient = bDB56AnkitDataSet.P01_Client.NewP01_ClientRow();
                
                // Ajout des donnees
                unClient.NoClient = (short) int.Parse(noClientTextBox.Text);
                unClient.Nom = nomTextBox.Text;
                unClient.Prenom = prenomTextBox.Text;
                unClient.Ville = villeTextBox.Text;
                unClient.Pays = paysTextBox.Text;
                unClient.Adresse = adresseTextBox.Text;
                unClient.CodePostal = codePostalTextBox.Text;
                unClient.DateInscription = dateInscriptionDateTimePicker.Value;

                if (this.Controls.OfType<TextBox>().Any(tBox => string.IsNullOrEmpty(tBox.Text)))
                    MessageBox.Show("Veuillez remplir toutes les cases", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else {
                    bDB56AnkitDataSet.P01_Client.AddP01_ClientRow(unClient);
                    this.p01_ClientBindingSource.EndEdit();
                    this.p01_ClientTableAdapter.Update(this.bDB56AnkitDataSet.P01_Client);
                    MessageBox.Show("Le nouveau client a été ajouté.", "Nouveau client ajouté", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else if (!booAjout)
            {           // MODIFICATION
                using (SqlConnection con = new SqlConnection(maChaineDeConnexion))
                {
                    con.Open();
                    string requete = "UPDATE P01_Client SET Nom = '" +nomTextBox.Text + "', Prenom = '" + prenomTextBox.Text + "', Ville = '" + villeTextBox.Text + 
                        "', Pays = '" + paysTextBox.Text + "', Adresse = '" + adresseTextBox.Text + "', CodePostal = '" + codePostalTextBox.Text +
                        "' WHERE NoClient = " + NoClient;
                    SqlCommand comm = new SqlCommand(requete, con);
                    comm.ExecuteNonQuery();

                    con.Close();
                }
                MessageBox.Show("Le client a été modifié.", "Client modifié", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<TextBox>().Any(tBox => string.IsNullOrEmpty(tBox.Text)))
            {
                DialogResult resulat = MessageBox.Show("Etes vous certain d'annuler " + (booAjout ? "l'ajout?" : "la modification?"), "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resulat == DialogResult.Yes)
                    this.Close();
                else if (resulat == DialogResult.No)
                {
                    return;
                }
            }
        }
    }
}
