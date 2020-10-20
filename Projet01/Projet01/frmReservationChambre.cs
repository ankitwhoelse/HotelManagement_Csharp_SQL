using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet01
{
    public partial class frmReservationChambre : Form
    {
        public dynamic NoChambre;

        String maChaineDeConnexion = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=BDB56Ankit;Persist Security Info=True;User ID=B56Ankit;Password=Summit11g";

        public frmReservationChambre()
        {
            InitializeComponent();
        }


        private void frmReservationChambre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.nosEtNomsClients' table. You can move, or remove it, as needed.
            this.nosEtNomsClientsTableAdapter.Fill(this.bDB56AnkitDataSet.nosEtNomsClients);
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_ReservationChambre' table. You can move, or remove it, as needed.
            this.p01_ReservationChambreTableAdapter.Fill(this.bDB56AnkitDataSet.P01_ReservationChambre);
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_Client' table. You can move, or remove it, as needed.
            this.p01_ClientTableAdapter.Fill(this.bDB56AnkitDataSet.P01_Client);
            
            //  Vider tout les textBox
            foreach (TextBox textBox in Controls.OfType<TextBox>())
                textBox.Text = "";

            noChambreTextBox.Text = NoChambre;

            lblTitre.Text = "Ajouter une réservation de chambre";
            btnConfirmer.Text = "Ajouter une réservation";
            this.Text = "Ajouter une réservation de chambre";
        }


        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<TextBox>().Any(tBox => string.IsNullOrEmpty(tBox.Text)))
                MessageBox.Show("Veuillez remplir toutes les cases.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                //Vérification si la chambre n'est pas donné à une autre personne à la mm date/heure
                SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
                maConnexion.Open();

                String maRequeteSQL = "select DateArrivee, DateDepart from P01_ReservationChambre where NoChambre= '" + NoChambre + "'";
                SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
                SqlDataReader Dates = maCommande.ExecuteReader();
                bool booDispo = true;
                if (Dates.HasRows)
                {
                    while (Dates.Read())
                    {
                        if ((DateTime)Dates["DateDepart"] > dateArriveeDateTimePicker.Value)
                            booDispo = false;

                    }
                    Dates.Close();
                    maConnexion.Close();
                }
                if (booDispo == false)
                {
                    MessageBox.Show(" Cette chambre n'est pas disponible à la date selectionnée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dateArriveeDateTimePicker.Value.Day.ToString() == dateDepartDateTimePicker.Value.Day.ToString())
                {
                    MessageBox.Show(" La durée du séjour doit être au moins d'une nuit", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               else if (DateTime.Compare(dateArriveeDateTimePicker.Value, dateDepartDateTimePicker.Value) < 0)
                {          // Ajout    
                    // Creer une nouvelle reservation en memoire
                    BDB56AnkitDataSet.P01_ReservationChambreRow uneReservation = bDB56AnkitDataSet.P01_ReservationChambre.NewP01_ReservationChambreRow();

                    // Ajout des donnees
                    uneReservation.NoChambre = (short)int.Parse(NoChambre);
                    uneReservation.NoClient = (short)int.Parse(cboClient.SelectedValue.ToString());
                    uneReservation.DateArrivee = dateArriveeDateTimePicker.Value;
                    uneReservation.DateDepart = dateDepartDateTimePicker.Value;
                    uneReservation.NbPersonnes = (short)nbPersonnesNumericUpDown.Value;

                    bDB56AnkitDataSet.P01_ReservationChambre.AddP01_ReservationChambreRow(uneReservation);
                    this.p01_ReservationChambreBindingSource.EndEdit();
                    this.p01_ReservationChambreTableAdapter.Update(this.bDB56AnkitDataSet.P01_ReservationChambre);
                    MessageBox.Show("La nouvelle réservation a été ajouté.", "Nouvelle réservation ajoutée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else     // Date depart precede la date d'arrive
                    MessageBox.Show("Veuillez assurer que la date de départ suit la date d'arrivée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReservationChambre_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Controls.OfType<TextBox>().Any(tBox => string.IsNullOrEmpty(tBox.Text)))
            {
                DialogResult resulat = MessageBox.Show("Etes vous certain d'annuler l'ajout?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resulat == DialogResult.Yes)
                {

                }
                else if (resulat == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
