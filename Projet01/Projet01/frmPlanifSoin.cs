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
    public partial class frmPlanifSoin : Form
    {
        public dynamic NoSoin;
        public dynamic NoAssistant;
        public dynamic NoPersonne;

        String maChaineDeConnexion = "Data Source=tcp:424sql.cgodin.qc.ca,5433;Initial Catalog=BDB56Ankit;Persist Security Info=True;User ID=B56Ankit;Password=Summit11g";

        public frmPlanifSoin()
        {
            InitializeComponent();
        }
        
        private void frmPlanifSoin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDB56AnkitDataSet.P01_PlanifSoin' table. You can move, or remove it, as needed.
            this.p01_PlanifSoinTableAdapter.Fill(this.bDB56AnkitDataSet.P01_PlanifSoin);
            
            //  Vider tout les textBox
            foreach (TextBox textBox in Controls.OfType<TextBox>())
                textBox.Text = "";


        }


        private void btnConfirmer_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
