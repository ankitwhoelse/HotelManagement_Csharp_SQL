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
    public partial class frmRapport : Form
    {
        public int NoRapport;
        public dynamic NoPersonne;
        
        public frmRapport()
        {
            InitializeComponent();
        }

        private void frmRapport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.rapportSoinsAssistant' table. You can move, or remove it, as needed.
            this.rapportSoinsAssistantTableAdapter.Fill(this.bDB56AnkitDataSet.rapportSoinsAssistant);
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.soinDateAssistant' table. You can move, or remove it, as needed.
            this.soinDateAssistantTableAdapter.Fill(this.bDB56AnkitDataSet.soinDateAssistant);
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.dateSoinAssistant' table. You can move, or remove it, as needed.
            this.dateSoinAssistantTableAdapter.Fill(this.bDB56AnkitDataSet.dateSoinAssistant);
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.assistantsList' table. You can move, or remove it, as needed.
            this.assistantsListTableAdapter.Fill(this.bDB56AnkitDataSet.assistantsList);
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.personnesPlanif' table. You can move, or remove it, as needed.
            this.personnesPlanifTableAdapter.Fill(this.bDB56AnkitDataSet.personnesPlanif);
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.rapportSoinsClientInvite' table. You can move, or remove it, as needed.
            this.rapportSoinsClientInviteTableAdapter.Fill(this.bDB56AnkitDataSet.rapportSoinsClientInvite);

            switch (NoRapport)
            {
                case 1: // soins offert a une personne
                    gbRapport1.Visible = true;

                    lblTitre.Text = "Rapport 1: Rapport des soins offerts\naux clients et aux invités";
                    this.Text = "Rapport 01";
                    break;

                case 2: // reservation chambre
                    gbRapport1.Visible = false;

                    lblTitre.Text = "Rapport B: Rapport des réservations de chambres";
                    this.Text = "Rapport 02";
                    break;

                case 3: // rapport soins journaliers des assistants
                    gbRapport1.Visible = false;

                    lblTitre.Text = "Rapport III: Rapport des soins journaliers\ndes assistants";
                    this.Text = "Rapport 03";
                    break;

                default:    MessageBox.Show("this aint right", "bug rapport");
                    break;
            }

        }

        // Formatage money
        private void totalSoldeTextBox_TextChanged(object sender, EventArgs e)
        {
            string format = totalSoldeTextBox.Text;
            if (format == string.Empty)
                format = "N/A";
            else if (format != "N/A" && format.Substring(0, 1) != "$")
            {
                double montant = Convert.ToDouble(format);
                format = string.Format("{0:C}", montant);
            }

            totalSoldeTextBox.Text = format;
        }
    }
}
