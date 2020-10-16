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
    public partial class frmConnexion : Form
    {

        String maChaineDeConnexion = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=BDB56Ankit;User ID=B56Ankit;Password=Summit11g";
        public dynamic NoUtilisateur;

        public frmConnexion()
        {
            InitializeComponent();
        }

        frmAdmin frmA = new frmAdmin();
        frmPrepose frmP = new frmPrepose();

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string strUser = tbUser.Text;
            string strPassword = tbPassword.Text;
            dynamic NoType;

            SqlConnection maConnexion = new SqlConnection(maChaineDeConnexion);
            maConnexion.Open();

            String requeteConn = "SELECT NoUtilisateur FROM P01_Utilisateur WHERE NomUtilisateur = @user AND MotDePasse = @mdp";
            String requeteType = "SELECT NoType FROM P01_Utilisateur WHERE NomUtilisateur = @user AND MotDePasse = @mdp";

            SqlCommand maCommande = new SqlCommand(requeteConn, maConnexion);
            SqlParameter paramUser = new SqlParameter("@user", strUser);
            SqlParameter paramMDP = new SqlParameter("@mdp", strPassword);
            maCommande.Parameters.Add(paramUser);   maCommande.Parameters.Add(paramMDP);

            SqlCommand maCommande2 = new SqlCommand(requeteType, maConnexion);
            SqlParameter paramUser2 = new SqlParameter("@user", strUser);
            SqlParameter paramMDP2 = new SqlParameter("@mdp", strPassword);
            maCommande2.Parameters.Add(paramUser2); maCommande2.Parameters.Add(paramMDP2);

            NoUtilisateur = maCommande.ExecuteScalar();
            NoType = maCommande2.ExecuteScalar();

            maConnexion.Close();

            if (NoUtilisateur == null)
                MessageBox.Show("Connexion echoue", "Connexion echoue", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                this.Hide();

                if (NoType == 1)
                {
                    frmA.NoUtilisateur = NoUtilisateur;
                    frmA.ShowDialog();
                }
                else if (NoType == 2)
                {
                    frmP.NoUtilisateur = NoUtilisateur;
                    frmP.ShowDialog();
                }
                
            }
            
        }
        
    }
}
