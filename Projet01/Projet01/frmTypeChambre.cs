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
    public partial class frmTypeChambre : Form
    {
        public dynamic NoTypeChambre;
        public bool booAjout;

        String maChaineDeConnexion = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=BDB56Ankit;Persist Security Info=True;User ID=B56Ankit;Password=Summit11g";

        public frmTypeChambre()
        {
            InitializeComponent();
        }

        private void frmTypeChambre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_TypeChambre' table. You can move, or remove it, as needed.
            this.p01_TypeChambreTableAdapter.Fill(this.bDB56AnkitDataSet.P01_TypeChambre);
            
            //  Vider tout les textBox
            foreach (TextBox textBox in Controls.OfType<TextBox>())
                textBox.Text = "";

            if (booAjout)
            {
                // Creer un id unique
                using (SqlConnection con = new SqlConnection(maChaineDeConnexion))
                {
                    con.Open();
                    String requete = "SELECT ISNULL(MAX(NoTypeChambre), 0) FROM P01_TypeChambre";
                    SqlCommand com = new SqlCommand(requete, con);

                    // this and chambre always returning 1 :(

                    dynamic resultat = com.ExecuteScalar();
                    resultat++;

                    noTypeChambreTextBox.Text = resultat.ToString();
                    NoTypeChambre = resultat;

                    con.Close();
                }

                lblTitre.Text = "Ajouter un type de chambre";
                btnConfirmer.Text = "Ajouter";
                this.Text = "Ajouter un type de chambre";
            }
            else if (!booAjout)
            {
                // Remplir automatiquement les champs
                noTypeChambreTextBox.Text = NoTypeChambre;

                using (SqlConnection con = new SqlConnection(maChaineDeConnexion))
                {
                    con.Open();
                    string requete = "SELECT * FROM P01_TypeChambre WHERE NoTypeChambre = " + NoTypeChambre;
                    SqlCommand com = new SqlCommand(requete, con);

                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        descriptionTextBox.Text = dr[1].ToString();
                        prixHautTextBox.Text = dr[2].ToString();
                        prixBasTextBox.Text = dr[3].ToString();
                        prixMoyenTextBox.Text = dr[3].ToString();
                    }

                    con.Close();
                }

                lblTitre.Text = "Modifier un type de chambre";
                btnConfirmer.Text = "Modifier";
                this.Text = "Modifier un type de chambre";
            }
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<TextBox>().Any(tBox => string.IsNullOrEmpty(tBox.Text)))
                MessageBox.Show("Veuillez remplir toutes les cases.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (booAjout)
                {           // Ajout 
                    // Creer une nouvelle chambre en memoire
                    BDB56AnkitDataSet.P01_TypeChambreRow unType = bDB56AnkitDataSet.P01_TypeChambre.NewP01_TypeChambreRow();

                    // Ajout des donnees
                    unType.NoTypeChambre = (short) (NoTypeChambre);
                    unType.Description = descriptionTextBox.Text;
                    unType.PrixHaut = decimal.Parse(prixHautTextBox.Text);
                    unType.PrixBas = decimal.Parse(prixBasTextBox.Text);
                    unType.PrixMoyen = decimal.Parse(prixMoyenTextBox.Text);

                    // Ajout dans BD
                    bDB56AnkitDataSet.P01_TypeChambre.AddP01_TypeChambreRow(unType);
                    this.p01_TypeChambreBindingSource.EndEdit();
                    this.p01_TypeChambreTableAdapter.Update(this.bDB56AnkitDataSet.P01_TypeChambre);
                    MessageBox.Show("Le nouveau type de chambre a été ajouté.", "Nouveau type de chambre enregistré", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (!booAjout)
                {           // Modif
                    using (SqlConnection con = new SqlConnection(maChaineDeConnexion))
                    {
                        con.Open();
                        string requete = "UPDATE P01_TypeChambre SET Description = '" + descriptionTextBox.Text + "', PrixHaut = " + decimal.Parse(prixHautTextBox.Text) +
                            ", PrixMoyen = " + decimal.Parse(prixMoyenTextBox.Text) + ", PrixBas = " + decimal.Parse(prixBasTextBox.Text) + " WHERE NoTypeChambre = " + NoTypeChambre;
                        SqlCommand comm = new SqlCommand(requete, con);
                        comm.ExecuteNonQuery();

                        con.Close();
                    }
                    this.p01_TypeChambreBindingSource.EndEdit();
                    this.p01_TypeChambreTableAdapter.Update(this.bDB56AnkitDataSet.P01_TypeChambre);
                    MessageBox.Show("Le type de chambre a été modifié.", "Type de chambre modifié", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /*
         *  Assurer que les valeurs du PrixBas, PrixMoyen et PrixHaut sont numeriques.
         */
        private void prixHautTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifier que la touche appuye n'est pas CTRL ou une touche non numerique
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void frmTypeChambre_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Controls.OfType<TextBox>().Any(tBox => string.IsNullOrEmpty(tBox.Text)))
            {
                DialogResult resulat = MessageBox.Show("Etes vous certain d'annuler " + (booAjout ? "l'ajout?" : "la modification?"), "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

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
