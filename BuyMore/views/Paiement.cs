using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuyMore.controllers;

namespace BuyMore
{
    public partial class Paiement : Form
    {
        public Paiement()
        {
            InitializeComponent();
            PayrollC.getPaiement(caissier,comptable,secretaire,Gestionnaire,manager);
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Dispose();
            Payroll.paie.Enabled = true;
        }

        private void Paiement_Load(object sender, EventArgs e)
        {

        }

        private void Save_paiement_Click(object sender, EventArgs e)
        {
            int rep = PayrollC.modifyPaiement("1", caissier.Text, secretaire.Text, comptable.Text, manager.Text, Gestionnaire.Text);
            if (rep==0)
            {
                MessageBox.Show("paiement modifier avec succes");
            }
            else
            {
                MessageBox.Show("erreur lors de la modification");
            }
        }
    }
}
