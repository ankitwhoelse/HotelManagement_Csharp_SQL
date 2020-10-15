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
    public partial class frmAdmin : Form
    {
        public dynamic NoUtilisateur;
        public dynamic NoClient;
        public dynamic NoInvite;
        public dynamic NoAssistant;
        public dynamic NoSoin;
        public dynamic NoTypeSoin;
        public dynamic NoChambre;
        public dynamic NoTypeChambre;

        private int choixMenu;
        private bool booAjout;

        frmUtilisateur frmU = new frmUtilisateur();
        frmClient frmCl = new frmClient();
        frmInvite frmI = new frmInvite();
        frmAssistant frmAss = new frmAssistant();
        frmSoin frmS = new frmSoin();
        frmTypeSoin frmTyS = new frmTypeSoin(); 
        frmChambre frmCh = new frmChambre();
        frmReservationChambre frmResCh = new frmReservationChambre();
        frmTypeChambre frmTyCh = new frmTypeChambre();


        String maChaineDeConnexion = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=BDB56Ankit;Persist Security Info=True;User ID=B56Ankit;Password=Summit11g";


        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            frmConnexion frmConnexion = new frmConnexion();
            this.Hide();
            frmConnexion.ShowDialog();
        }

        private void p01_UtilisateurBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.p01_UtilisateurBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDB56AnkitDataSet);
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_ReservationChambre' table. You can move, or remove it, as needed.
            this.p01_ReservationChambreTableAdapter1.Fill(this.bDB56AnkitDataSet.P01_ReservationChambre);
           
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_PlanifSoin' table. You can move, or remove it, as needed.
            this.p01_PlanifSoinTableAdapter.Fill(this.bDB56AnkitDataSet.P01_PlanifSoin);
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_TypeSoin' table. You can move, or remove it, as needed.
            this.p01_TypeSoinTableAdapter.Fill(this.bDB56AnkitDataSet.P01_TypeSoin);
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.noTypeEtIdentifiactionUtilisateur' table. You can move, or remove it, as needed.
            this.noTypeEtIdentifiactionUtilisateurTableAdapter.Fill(this.bDB56AnkitDataSet.noTypeEtIdentifiactionUtilisateur);
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_TypeUtilisateur' table. You can move, or remove it, as needed.
            this.p01_TypeUtilisateurTableAdapter.Fill(this.bDB56AnkitDataSet.P01_TypeUtilisateur);
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_TypeChambre' table. You can move, or remove it, as needed.
            this.p01_TypeChambreTableAdapter.Fill(this.bDB56AnkitDataSet.P01_TypeChambre);
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_Invite' table. You can move, or remove it, as needed.
            this.p01_InviteTableAdapter.Fill(this.bDB56AnkitDataSet.P01_Invite);
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_Soin' table. You can move, or remove it, as needed.
            this.p01_SoinTableAdapter.Fill(this.bDB56AnkitDataSet.P01_Soin);
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_Assistant' table. You can move, or remove it, as needed.
            this.p01_AssistantTableAdapter.Fill(this.bDB56AnkitDataSet.P01_Assistant);
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_Chambre' table. You can move, or remove it, as needed.
            this.p01_ChambreTableAdapter.Fill(this.bDB56AnkitDataSet.P01_Chambre);
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_Client' table. You can move, or remove it, as needed.
            this.p01_ClientTableAdapter.Fill(this.bDB56AnkitDataSet.P01_Client);
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_Utilisateur' table. You can move, or remove it, as needed.
            this.p01_UtilisateurTableAdapter.Fill(this.bDB56AnkitDataSet.P01_Utilisateur);

            utilisateursToolStripMenuItem_Click(this, e);
        }


        /*
         *  Ajouter un element
         */
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            booAjout = true;
            this.Hide();

            switch (choixMenu) {
                case 1:
                    frmU.booAjout = booAjout;
                    frmU.ShowDialog();
                    break;
                case 2:
                    frmCl.booAjout = booAjout;
                    frmCl.ShowDialog();
                    break;
                case 3:
                    frmAss.booAjout = booAjout;
                    frmAss.ShowDialog();
                    break;
                case 4:
                    frmS.booAjout = booAjout;
                    frmS.ShowDialog();
                    break;
                case 5:
                    frmCh.booAjout = booAjout;
                    frmCh.ShowDialog();
                    break;
                default:    MessageBox.Show("this aint right", "bug");
                    break;
            }
            
            this.Show();
        }
        

        /*
         *  Modifier les proprietes  
         */
        private void btnModifier_Click(object sender, EventArgs e)
        {
            booAjout = false;
            this.Hide();

            switch (choixMenu)
            {
                case 1:
                    frmU.booAjout = booAjout;
                    NoUtilisateur = cboUtilisateurs.SelectedValue.ToString();
                    frmU.NoUtilisateur = NoUtilisateur;
                    frmU.ShowDialog();
                    break;
                case 2:
                    frmCl.booAjout = booAjout;
                    NoClient = cboClients.SelectedValue.ToString();
                    frmCl.NoClient = NoClient;
                    frmCl.ShowDialog();
                    break;
                case 3:
                    frmAss.booAjout = booAjout;
                    NoAssistant = cboAssistants.SelectedValue.ToString();
                    frmAss.NoAssistant = NoAssistant;
                    frmAss.ShowDialog();
                    break;
                case 4:
                    frmS.booAjout = booAjout;
                    NoSoin = cboSoins.SelectedValue.ToString();
                    frmS.NoSoin = NoSoin;
                    frmS.ShowDialog();
                    break;
                case 5:
                    frmCh.booAjout = booAjout;
                    NoChambre = cboChambres.SelectedValue.ToString();
                    frmCh.NoChambre = NoChambre;
                    frmCh.ShowDialog();
                    break;
                default:
                    MessageBox.Show("this aint right", "bug");
                    break;
            }
            this.Show();
        }

        private void utilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choixMenu = 1;
            lblChoix.Text = "Gestion des utilisateurs";
            lblSelection.Text = "Veuillez selectionnez \nun utilisateur:";
            cboUtilisateurs.Visible = true;
            gbInfoUtilisateur.Visible = true;

            gbReservation.Visible = false;
            gbPlanifSoin.Visible = false;
            gbInfoTypeSoin.Visible = false;
            gbAssistantSoin.Visible = false;
            gbInfoTypeChambre.Visible = false;
            gbInfoInvite.Visible = false;
            cboSoins.Visible = false;
            gbInfoSoins.Visible = false;
            cboChambres.Visible = false;
            gbInfoChambre.Visible = false;
            cboClients.Visible = false;
            gbInfoClient.Visible = false;
            cboAssistants.Visible = false;
            gbInfoAssistants.Visible = false;
        }

        private void clientsEtLeursInvitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choixMenu = 2;
            lblChoix.Text = "Gestion des clients et leurs invites";
            lblSelection.Text = "Veuillez selectionnez \nun utilisateur:";
            cboClients.Visible = true;
            gbInfoClient.Visible = true;
            gbInfoInvite.Visible = true;

            gbReservation.Visible = false;
            gbPlanifSoin.Visible = false;
            gbInfoTypeSoin.Visible = false;
            gbAssistantSoin.Visible = false;
            gbInfoTypeChambre.Visible = false;
            cboSoins.Visible = false;
            gbInfoSoins.Visible = false;
            cboChambres.Visible = false;
            gbInfoChambre.Visible = false;
            cboAssistants.Visible = false;
            gbInfoAssistants.Visible = false;
            cboUtilisateurs.Visible = false;
            gbInfoUtilisateur.Visible = false;
        }

        private void assistantsEtLesSoinsOffertsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choixMenu = 3;
            lblChoix.Text = "Gestion des assistants et leurs soins";
            lblSelection.Text = "Veuillez selectionnez \nun(e) assistant(e).";
            cboAssistants.Visible = true;
            gbInfoAssistants.Visible = true;
            gbAssistantSoin.Visible = true;

            gbReservation.Visible = false;
            gbPlanifSoin.Visible = false;
            gbInfoTypeSoin.Visible = false;
            gbInfoTypeChambre.Visible = false;
            gbInfoInvite.Visible = false;
            cboSoins.Visible = false;
            gbInfoSoins.Visible = false;
            cboChambres.Visible = false;
            gbInfoChambre.Visible = false;
            cboClients.Visible = false;
            gbInfoClient.Visible = false;
            cboUtilisateurs.Visible = false;
            gbInfoUtilisateur.Visible = false;
        }

        private void soinsToolStripMenuItem_Click(object sender, EventArgs e)
        {               // GESTION DES SOINS
            choixMenu = 4;
            lblChoix.Text = "Gestion des soins";
            lblSelection.Text = "Veuillez selectionnez \nun soin.";
            cboSoins.Visible = true;
            gbInfoSoins.Visible = true;
            gbInfoTypeSoin.Visible = true;
            gbPlanifSoin.Visible = true;

            gbReservation.Visible = false;
            gbAssistantSoin.Visible = false;
            gbInfoTypeChambre.Visible = false;
            gbInfoInvite.Visible = false;
            cboClients.Visible = false;
            gbInfoClient.Visible = false;
            cboChambres.Visible = false;
            gbInfoChambre.Visible = false;
            cboAssistants.Visible = false;
            gbInfoAssistants.Visible = false;
            cboUtilisateurs.Visible = false;
            gbInfoUtilisateur.Visible = false;
        }

        private void chambresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            choixMenu = 5;
            lblChoix.Text = "Gestion des chambres";
            lblSelection.Text = "Veuillez selectionnez \nune chambre.";
            cboChambres.Visible = true;
            gbInfoChambre.Visible = true;
            gbInfoTypeChambre.Visible = true;
            gbReservation.Visible = true;

            gbPlanifSoin.Visible = false;
            gbInfoTypeSoin.Visible = false;
            gbAssistantSoin.Visible = false;
            gbInfoInvite.Visible = false;
            cboSoins.Visible = false;
            gbInfoSoins.Visible = false;
            cboClients.Visible = false;
            gbInfoClient.Visible = false;
            cboAssistants.Visible = false;
            gbInfoAssistants.Visible = false;
            cboUtilisateurs.Visible = false;
            gbInfoUtilisateur.Visible = false;
        }
        
        // AJOUTER INVITER
        private void btnAjoutInvite_Click(object sender, EventArgs e)
        {
            NoClient = cboClients.SelectedValue.ToString();
            frmI.NoClient = NoClient;
            frmI.booAjout = true;
            this.Hide();
            frmI.ShowDialog();
            this.Show();
        }

        // MODIFIER INVITER
        private void btnModifInvite_Click(object sender, EventArgs e)
        {
            NoClient = cboClients.SelectedValue.ToString();
            frmI.NoClient = NoClient;
            frmI.booAjout = false;
            NoInvite = cboInvite.SelectedValue.ToString();
            frmI.NoInvite = NoInvite;
            this.Hide();
            frmI.ShowDialog();
            this.Show();
        }

        private void btnSupprimeInvite_Click(object sender, EventArgs e)
        {
            NoInvite = cboInvite.SelectedValue.ToString();
            // Suprimmer invite
            // check reservationChambre et planifSoin avant de delete
        }

        // Ajouter type de chambre
        private void btnAjoutTypeChambre_Click(object sender, EventArgs e)
        {
            frmTyCh.booAjout = true;
            this.Hide();
            frmTyCh.ShowDialog();
            this.Show();
        }

        // Modifier type de chambre
        private void btnModifTypeChambre_Click(object sender, EventArgs e)
        {
            NoTypeChambre = cboTypeChambre.SelectedValue.ToString();
            frmTyCh.NoTypeChambre = NoTypeChambre;
            frmTyCh.booAjout = false;
            this.Hide();
            frmTyCh.ShowDialog();
            this.Show();
        }

        // Supprimer type de chambre
        private void btnSupprTypeChambre_Click(object sender, EventArgs e)
        {
            NoTypeChambre = cboTypeChambre.SelectedValue.ToString();
            // Supprimer type chambre
            // Check chambres, reservationChambres then proceed to delete
        }

        // Reserver une chambre
        private void btnAjouterReservation_Click(object sender, EventArgs e)
        {
            NoChambre = cboChambres.SelectedValue.ToString();
            frmResCh.NoChambre = NoChambre;
            this.Hide();
            frmResCh.ShowDialog();
            this.Show();
        }

        // Anunuler la reservation
        private void btnAnnulerReservation_Click(object sender, EventArgs e)
        {
            NoClient = cboReservation.SelectedValue.ToString();
            NoChambre = noChambreTextBox1.Text;
            using (SqlConnection con = new SqlConnection(maChaineDeConnexion))
            {
                con.Open();
                // add check for DateTime.Now > dateArrive
                // then delete
                string requete = "SELECT DateArrivee FROM P01_ReservationChambre WHERE NoClient = " + NoClient +
                    " AND NoChambre = " + NoChambre;
                SqlCommand comm = new SqlCommand(requete, con);

                dynamic dateArrive = comm.ExecuteScalar();
                if (DateTime.Compare((DateTime)(dateArrive), DateTime.Now) < 0)
                {
                    string requete2 = "DELETE FROM P01_ReservationChambre WHERE NoClient = " + NoClient +
                        " AND NoChambre = " + NoChambre;
                    SqlCommand comm2 = new SqlCommand(requete2, con);
                    comm2.ExecuteNonQuery();

                    MessageBox.Show("La réservation a été anullée.", "Réservation anullée", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.p01_ReservationChambreBindingSource.EndEdit();
                    this.p01_ReservationChambreTableAdapter1.Update(this.bDB56AnkitDataSet.P01_ReservationChambre);

                }
                else
                    MessageBox.Show("La réservation n'a pu etre anullé puisque le séjour a déja commencé.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
        }

        private void cboAssistants_SelectedValueChanged(object sender, EventArgs e)
        {
            cboAssistantSoins.Items.Clear();

            NoAssistant = cboAssistants.SelectedValue.ToString();

            using (SqlConnection con = new SqlConnection(maChaineDeConnexion))
            {
                con.Open();
                string requete = "SELECT NoAssistant, A.NoSoin, Description FROM P01_AssistantSoin A" +
                    " LEFT JOIN P01_Soin S on A.NoSoin=S.NoSoin" + 
                    " WHERE NoAssistant = " + NoAssistant;
                SqlCommand comm = new SqlCommand(requete, con);

                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    cboAssistantSoins.Items.Add(dr[2]);
                }

                con.Close();
            }
        }

        // AJOUTER UN SOIN A UN ASSISTANT
        private void btnAjouterSoin_Click(object sender, EventArgs e)
        {
            NoAssistant = cboAssistants.SelectedValue.ToString();
            string NoSoinPourAssistant = cboSoinsPourAssist.SelectedValue.ToString();

            using (SqlConnection con = new SqlConnection(maChaineDeConnexion))
            {
                con.Open();
                string requete = "SELECT * FROM P01_AssistantSoin WHERE NoAssistant = " + NoAssistant +
                    " AND NoSoin = " + NoSoinPourAssistant;
                SqlCommand comm = new SqlCommand(requete, con);

                dynamic existe = comm.ExecuteScalar();
                if (existe == null)
                {   // Ne possede pas le soin, donc ajout
                    string requete2 = "INSERT INTO P01_AssistantSoin values(" + NoAssistant + ", " + NoSoinPourAssistant + ")";
                    SqlCommand commInsert = new SqlCommand(requete2, con);
                    commInsert.ExecuteScalar();
                    MessageBox.Show("Le soin a été ajouté pour cet assistant.", "Nouveau soin enregistré", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {   // Possede deja le soin
                    MessageBox.Show("Le soin a déja été ajouté pour cet assistant.", "Erreur d'ajout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                con.Close();
            }
        }

        // RETIRER UN SOIN D'UN ASSISTANT
        private void btnSupprimerSoin_Click(object sender, EventArgs e)
        {
            NoAssistant = cboAssistants.SelectedValue.ToString();
            string NoSoinPourAssistant = cboSoinsPourAssist.SelectedValue.ToString();

            using (SqlConnection con = new SqlConnection(maChaineDeConnexion))
            {
                con.Open();
                string requete = "SELECT * FROM P01_AssistantSoin WHERE NoAssistant = " + NoAssistant +
                    " AND NoSoin = " + NoSoinPourAssistant;
                SqlCommand comm = new SqlCommand(requete, con);

                dynamic existe = comm.ExecuteScalar();
                if (existe == null)
                {   // Ne possede pas le soin
                    MessageBox.Show("Cet assistant ne possede pas ce soin.", "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {   // Possede le soin, donc retirement
                    string requete2 = "DELETE FROM P01_AssistantSoin WHERE NoAssistant = " + NoAssistant + " AND NoSoin = " + NoSoinPourAssistant;
                    SqlCommand commInsert = new SqlCommand(requete2, con);
                    commInsert.ExecuteScalar();
                    MessageBox.Show("Le soin a été retiré pour cet assistant.", "Soin retiré", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                con.Close();
            }
        }

        //  Ajout type Soins
        private void btnAjoutTypeSoin_Click(object sender, EventArgs e)
        {
            frmTyS.booAjout = true;
            this.Hide();
            frmTyS.ShowDialog();
            this.Show();
        }

        // Modif type Soins
        private void btnModifTypeSoin_Click(object sender, EventArgs e)
        {
            NoTypeSoin = cboTypeSoin.SelectedValue.ToString();
            frmTyS.NoTypeSoin = NoTypeSoin;
            frmTyS.booAjout = false;
            this.Hide();
            frmTyS.ShowDialog();
            this.Show();
        }

        // Supprimer type Soins
        private void btnSupprimeTypeSoin_Click(object sender, EventArgs e)
        {
            NoTypeSoin = cboTypeSoin.SelectedValue.ToString();

            using (SqlConnection con = new SqlConnection(maChaineDeConnexion))
            {
                con.Open();
                // il faut checker table planifSoin, then assistantSoin, then soin, if all good delete, else error messageBox

                /*
                string requete = "DELETE FROM P01_TypeSoin WHERE NoTypeSoin = " + NoTypeSoin;
                SqlCommand comm = new SqlCommand(requete, con);

                comm.ExecuteNonQuery();
                MessageBox.Show("Le type de soin a été retiré.", "Soin retiré", MessageBoxButtons.OK, MessageBoxIcon.Information);
                */
                con.Close();
            }
        }

        //  Ajouter une planif Soins
        private void btnAjoutPlanifSoin_Click(object sender, EventArgs e)
        {
            Planif planif = new Planif();
            planif.NoSoin = noSoinTextBox.Text.ToString();
            planif.NomSoin = descriptionTextBox.Text.ToString();
            this.Hide();
            planif.ShowDialog();
            this.Show();
        }
        
    }
}
