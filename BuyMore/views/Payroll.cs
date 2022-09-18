using Bunifu.UI.WinForms.BunifuButton;
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
    public partial class Payroll : Form
    {
        
        public static BunifuButton surpluss,shorttt,paie;
        public Payroll()
        {
            InitializeComponent();
            surpluss = surplus;
            shorttt = shortt;
            paie = paiement;
            PayrollC.MakePayroll();
            PayrollC.showPayroll(tablePayroll);
             
        }

        private void Xxx_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(vv.Value.ToString());
            //MessageBox.Show(date2.Text.ToString());

        }

        private void BunifuButton3_Click(object sender, EventArgs e)
        {
            //poubelle.Enabled = false;
            main.instance.showLogin(new Paiement());
            paiement.Enabled = false;

        }

        private void BunifuButton2_Click(object sender, EventArgs e)
        {
            main.instance.showLogin(new Surplus());
            surplus.Enabled = false;
        }

        private void Payroll_Load(object sender, EventArgs e)
        {

        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            main.instance.showLogin(new Short());
            shortt.Enabled = false;
        }
    }
    }

