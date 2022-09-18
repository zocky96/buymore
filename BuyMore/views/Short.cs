using BuyMore.controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyMore
{
    public partial class Short : Form
    {
        public Short()
        {
            InitializeComponent();
            ShorteC.showShorte(tableShorte);
            Employer_C.getAllCaissier(caissier);
            caissier.Text = "caissier";
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Dispose();
            Payroll.shorttt.Enabled = true;
        }

        private void Short_Load(object sender, EventArgs e)
        {

        }
        private void clearFields()
        {
            montant.Text = "";
            code.Text = "";
            caissier.Text = "caissier";
        }
        private void Save_Click(object sender, EventArgs e)
        {
            string montant_, code_, caissier_, datee, year, month, day;
            montant_ = montant.Text;
            code_ = code.Text;
            caissier_ = caissier.Text;

            year = DateTime.Now.Year.ToString();
            month = DateTime.Now.Month.ToString();
            day = DateTime.Now.Day.ToString();
            datee = year + "/" + month + "/" + day;
            int repp = Employer_C.ifCodeEmployerExiste(code_);
            if (repp == 1)
            {
                int rep = ShorteC.saveShorte(caissier_, montant_, code_, datee, tableShorte);
                if (rep == 0)
                {
                    clearFields();
                    MessageBox.Show("Enregistrer avec succes");
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'enregistrement");
                }
            }
            else
            {
                MessageBox.Show("Le code saisi n'est pas celui d'un caissier");
            }

        }
    }
}
