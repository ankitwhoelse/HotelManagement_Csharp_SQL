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
    public partial class frmTypeSoin : Form
    {
        public bool booAjout;
        public dynamic NoTypeSoin;

        String maChaineDeConnexion = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=BDB56Ankit;Persist Security Info=True;User ID=B56Ankit;Password=Summit11g";

        public frmTypeSoin()
        {
            InitializeComponent();
        }
        

        private void frmTypeSoin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_TypeSoin' table. You can move, or remove it, as needed.
            this.p01_TypeSoinTableAdapter.Fill(this.bDB56AnkitDataSet.P01_TypeSoin);

            //  Vider tout les textBox
            foreach (TextBox textBox in Controls.OfType<TextBox>())
                textBox.Text = "";

            if (booAjout)
            {
                int noTypeSoinMax = 0;
                using (SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion))
                {
                    maConnexion.Open();
                    // Création du Id
                    String maRequeteSQL = "select max(NoTypeSoin) from P01_TypeSoin ";
                    SqlCommand maCommande = new SqlCommand(maRequeteSQL, maConnexion);
                    Object resultat = maCommande.ExecuteScalar();

                    if (resultat.ToString() != "")
                        noTypeSoinMax = Convert.ToInt32(resultat);

                    noTypeSoinMax = noTypeSoinMax + 1;
                    noTypeSoinTextBox.Text = noTypeSoinMax.ToString();
                    maConnexion.Close();
                }
                lblTitre.Text = "Ajouter un type de soin";
                btnConfirmer.Text = "Ajouter";
                this.Text = "Ajouter type de soin";
            }
            else if (!booAjout)
            {
                // Remplir automatiquement les champs
                noTypeSoinTextBox.Text = NoTypeSoin;

                using (SqlConnection con = new SqlConnection(maChaineDeConnexion))
                {
                    con.Open();
                    string requete = "SELECT * FROM P01_TypeSoin WHERE NoTypeSoin = " + NoTypeSoin;
                    SqlCommand com = new SqlCommand(requete, con);

                    SqlDataReader dr = com.ExecuteReader();
                    while (dr.Read())
                    {
                        descriptionTextBox.Text = dr[1].ToString();
                    }

                    con.Close();
                }

                lblTitre.Text = "Modifier un type de soin";
                btnConfirmer.Text = "Modifier";
                this.Text = "Modifier un type de soin";
            }
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (descriptionTextBox.Text == "")
                MessageBox.Show("Veuillez remplir la description.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (booAjout)
                {           // Ajout 
                    // Creer un nouveau type en memoire
                    BDB56AnkitDataSet.P01_TypeSoinRow unType = bDB56AnkitDataSet.P01_TypeSoin.NewP01_TypeSoinRow();

                    // Ajout des donnees
                    unType.NoTypeSoin = (short)int.Parse(noTypeSoinTextBox.Text);
                    unType.Description = descriptionTextBox.Text;

                    // Ajout dans BD
                    bDB56AnkitDataSet.P01_TypeSoin.AddP01_TypeSoinRow(unType);
                    this.p01_TypeSoinBindingSource.EndEdit();
                    this.p01_TypeSoinTableAdapter.Update(this.bDB56AnkitDataSet.P01_TypeSoin);
                    MessageBox.Show("Le nouveau type de soin a été ajouté.", "Nouveau type de soin enregistré", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (!booAjout)
                {           // Modification
                    using (SqlConnection con = new SqlConnection(maChaineDeConnexion))
                    {
                        con.Open();
                        string requete = "UPDATE P01_TypeSoin SET Description = '" + descriptionTextBox.Text + "' WHERE NoTypeSoin = " + NoTypeSoin;
                        SqlCommand comm = new SqlCommand(requete, con);
                        comm.ExecuteNonQuery();

                        con.Close();
                    }
                    MessageBox.Show("Le type de soin a été modifié.", "Type de soin modifié", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
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
