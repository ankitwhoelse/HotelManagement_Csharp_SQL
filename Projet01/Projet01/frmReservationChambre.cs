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
    public partial class frmReservationChambre : Form
    {
        public dynamic NoChambre;

        public frmReservationChambre()
        {
            InitializeComponent();
        }


        private void frmReservationChambre_Load(object sender, EventArgs e)
        {
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
                if (DateTime.Compare(dateArriveeDateTimePicker.Value, dateDepartDateTimePicker.Value) < 0)
                {           // Ajout    
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
            if (this.Controls.OfType<TextBox>().Any(tBox => string.IsNullOrEmpty(tBox.Text)))
            {
                DialogResult resulat = MessageBox.Show("Etes vous certain d'annuler l'ajout?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resulat == DialogResult.Yes)
                {
                    this.Close();
                }
                else if (resulat == DialogResult.No)
                {
                    return;
                }
            }
        }
        

    }
}
