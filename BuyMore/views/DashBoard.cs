using Bunifu.UI.WinForms.BunifuButton;
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
    public partial class DashBoard : Form
    {
        public static DashBoard instance;
        public static BunifuButton article,employer,fournisseur,payroll,sale,user;
        public DashBoard()
        {
            InitializeComponent();
            instance = this;
            disabledButton();
            article = run_article;
            employer = run_employer;
            fournisseur = run_fournisseur;
            payroll = run_payroll;
            sale = run_sale;
            user = run_user;
            if (main.poste == "caissier")
            {
                main.vente.Enabled = true;
                DashBoard.sale.Enabled = true;
                main.utilisateur.Enabled = true;
                DashBoard.user.Enabled = true;
                main.panier.Enabled = true;

            }
            if (main.poste == "gestionnaire de stock")
            {
                DashBoard.article.Enabled = true;
                DashBoard.fournisseur.Enabled = true;
                main.article.Enabled = true;
                main.fournisseur.Enabled = true;
                main.utilisateur.Enabled = true;
                DashBoard.user.Enabled = true;
            }
            if (main.poste == "secretaire")
            {
                main.employer.Enabled = true;
                DashBoard.employer.Enabled = true;
                main.utilisateur.Enabled = true;
                DashBoard.user.Enabled = true;
            }
            if (main.poste == "comptable")
            {
                main.article.Enabled = true;
                DashBoard.article.Enabled = true;
                main.payroll.Enabled = true;
                DashBoard.payroll.Enabled = true;
                main.utilisateur.Enabled = true;
                DashBoard.user.Enabled = true;
            }
            if (main.poste == "manager")
            {
                main.article.Enabled = true;
                DashBoard.article.Enabled = true;
                main.employer.Enabled = true;
                DashBoard.employer.Enabled = true;
                main.fournisseur.Enabled = true;
                DashBoard.fournisseur.Enabled = true;
                main.vente.Enabled = true;
                DashBoard.sale.Enabled = true;
                main.payroll.Enabled = true;
                DashBoard.payroll.Enabled = true;
                main.panier.Enabled = true;
                main.utilisateur.Enabled = true;
                DashBoard.user.Enabled = true;
                main.rapport.Enabled = true;
                main.log_.Enabled = true;
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Run_article_Click(object sender, EventArgs e)
        {
            main.instance.showArticle();
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            main.instance.showEmployer();
        }

        private void BunifuButton2_Click(object sender, EventArgs e)
        {
            main.instance.showFournisseur();
        }

        private void Run_sale_Click(object sender, EventArgs e)
        {
            main.instance.showVente();
        }

        private void BunifuButton4_Click(object sender, EventArgs e)
        {
            main.instance.showPayroll();
        }

        private void BunifuButton3_Click(object sender, EventArgs e)
        {
            main.instance.showParametre();
        }
        public void disabledButton()
        {

            run_article.Enabled = false;
            run_employer.Enabled = false;
            run_fournisseur.Enabled = false;
            run_payroll.Enabled = false;
            run_sale.Enabled = false;
            run_user.Enabled = false;
            //utilisateur_.Enabled = false;
            //rapport_.Enabled = false;
        }
        private void DashBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
