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
    public partial class frmChambre : Form
    {
        public dynamic NoChambre;
        public bool booAjout;

        String maChaineDeConnexion = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=BDB56Ankit;Persist Security Info=True;User ID=B56Ankit;Password=Summit11g";

        public frmChambre()
        {
            InitializeComponent();
        }
        
        private void frmChambre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_TypeChambre' table. You can move, or remove it, as needed.
            this.p01_TypeChambreTableAdapter.Fill(this.bDB56AnkitDataSet.P01_TypeChambre);
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_Chambre' table. You can move, or remove it, as needed.
            this.p01_ChambreTableAdapter.Fill(this.bDB56AnkitDataSet.P01_Chambre);

            //  Vider tout les textBox
            foreach (TextBox textBox in Controls.OfType<TextBox>())
                textBox.Text = "";

            if (booAjout)
            {
                using (SqlConnection con = new SqlConnection(maChaineDeConnexion))
                {
                    con.Open();
                    String requete = "SELECT ISNULL(MAX(NoChambre),0) FROM P01_Chambre";
                    SqlCommand com = new SqlCommand(requete, con);

                    dynamic resultat = com.ExecuteScalar();
                    resultat++;

                    noChambreTextBox.Text = resultat.ToString();
                    NoChambre = resultat;

                    con.Close();
                }

                lblTitre.Text = "Ajouter une chambre";
                btnConfirmer.Text = "Ajouter";
                this.Text = "Ajouter une chambre";
            }
            else if (!booAjout)
            {
                // Remplir automatiquement les champs
                noChambreTextBox.Text = NoChambre;

                using (SqlConnection con = new SqlConnection(maChaineDeConnexion))
                {
                    con.Open();
                    string requete = "SELECT * FROM P01_Chambre WHERE NoChambre = " + NoChambre;
                    SqlCommand com = new SqlCommand(requete, con);

                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        emplacementTextBox.Text = dr[1].ToString();
                        decorationsTextBox.Text = dr[2].ToString();
                        cboTypeChambre.SelectedValue = dr[3].ToString();
                    }

                    con.Close();
                }

                lblTitre.Text = "Modifier une chambre";
                btnConfirmer.Text = "Modifier";
                this.Text = "Modifier une chambre";
            }

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<TextBox>().Any(tBox => string.IsNullOrEmpty(tBox.Text)))
            {
                DialogResult resulat = MessageBox.Show("Etes vous certain d'annuler " + (booAjout ? "l'ajout?" : "la modification?"), "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

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

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<TextBox>().Any(tBox => string.IsNullOrEmpty(tBox.Text)))
                MessageBox.Show("Veuillez remplir toutes les cases.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (booAjout)
                {           // Ajout 
                    // Creer une nouvelle chambre en memoire
                    BDB56AnkitDataSet.P01_ChambreRow uneChambre = bDB56AnkitDataSet.P01_Chambre.NewP01_ChambreRow();

                    // Ajout des donnees
                    uneChambre.NoChambre = (short)(NoChambre);
                    uneChambre.Emplacement = emplacementTextBox.Text;
                    uneChambre.Decorations = decorationsTextBox.Text;
                    uneChambre.NoTypeChambre = (short)int.Parse(cboTypeChambre.SelectedValue.ToString());

                    // Ajout dans BD
                    bDB56AnkitDataSet.P01_Chambre.AddP01_ChambreRow(uneChambre);
                    this.p01_ChambreBindingSource.EndEdit();
                    this.p01_ChambreTableAdapter.Update(this.bDB56AnkitDataSet.P01_Chambre);
                    MessageBox.Show("La nouvelle chambre a été ajoutée.", "Nouvelle chambre enregistrée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (!booAjout)
                {           // Modif
                    using (SqlConnection con = new SqlConnection(maChaineDeConnexion))
                    {
                        con.Open();
                        string requete = "UPDATE P01_Chambres SET Emplacement = '" + emplacementTextBox.Text + "', Decorations = '" + decorationsTextBox.Text
                                            + "', NoTypeChambre = " + cboTypeChambre.SelectedValue.ToString() + " WHERE NoChambre = " + NoChambre;
                        SqlCommand comm = new SqlCommand(requete, con);
                        comm.ExecuteNonQuery();

                        con.Close();
                    }
                    this.p01_ChambreBindingSource.EndEdit();
                    this.p01_ChambreTableAdapter.Update(this.bDB56AnkitDataSet.P01_Chambre);
                    MessageBox.Show("La chambre a été modifiée.", "Chambre modifiée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            
        }

        private void p01_TypeChambreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
