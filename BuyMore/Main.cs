using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using BuyMore.controllers;
using BuyMore.db;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BuyMore
{
    public partial class main : Form
    {
        public static main instance;
        public static Label theSum_;
        public static Label the_name;
        public static Label connect_;
        public static Label disconect;
        public static Label Welcome;
        public static String SearchBar;
        public static String currentPage, poste = null, userName = null;
        public static BunifuDataGridView currentTable;
        public static BunifuButton article, employer, fournisseur, vente, payroll, panier, utilisateur, rapport,log_;
        public main()
        {
            dbConfig.createDataBase();
            int rep = dbConfig.createTables();
            if (rep == 9)
            {
                Dispose();
            }
            else
            {
                InitializeComponent();
                disabledButton();
                instance = this;
                showDashborad();
                SearchBar = null;
                theSum_ = theSum;
                //Welcome = welcome;
                connect_ = connect;
                disconect = deconnecte;
                the_name = name;
                currentPage = "home";
                article = article_;
                employer = employer_;
                fournisseur = fournisseur_;
                vente = vente_;
                payroll = payroll_;
                panier = panier_;
                utilisateur = utilisateur_;
                rapport = rapport_;
                log_ = log;
                List<string> liste = new List<string>();
                liste = PayrollC.payrollSet();
                if (liste[0].Equals("0"))
                {
                    PayrollC.MakePayroll();
                }
                if(liste[0].Equals("1") && int.Parse(liste[1]) > int.Parse(DateTime.Now.Month.ToString()))
                {
                    PayrollC.MakePayroll();
                }
                
            }



        }
        private void showScreen(object Form)
        {
            if (this.container.Controls.Count > 0)
            {
                this.container.Controls.RemoveAt(0);
            }
            Form form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.container.Controls.Add(form);
            form.Show();
        }
        public void showLogin(object Form)
        {

            Form form = Form as Form;
            form.TopLevel = true;

            form.Dock = DockStyle.Fill;
            //this.container.Controls.Add(form);
            form.Show();
        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        public void showDashborad()
        {
            moveSelectedItem(dashboard);
            showScreen(new DashBoard());
        }
        public void showArticle()
        {
            moveSelectedItem(article_);
            showScreen(new Article());
        }
        public void showEmployer()
        {
            moveSelectedItem(employer_);
            showScreen(new Employer());
        }
        public void showFournisseur()
        {
            moveSelectedItem(fournisseur_);
            showScreen(new Fournisseur());
        }
        public void showVente()
        {
            moveSelectedItem(vente_);
            showScreen(new Vente());
        }
        public void showPayroll()
        {
            moveSelectedItem(payroll_);
            showScreen(new Payroll());
        }
        public void showPanier()
        {
            moveSelectedItem(panier_);
            showScreen(new Panier());
        }
        public void showParametre()
        {
            moveSelectedItem(utilisateur_);
            showScreen(new Utilisateur());
        }
        public void showRapport()
        {
            moveSelectedItem(rapport_);
            showScreen(new Rapport());
        }
        public void showLog()
        {
            moveSelectedItem(log);
            showScreen(new Log_());
        }
        private void moveSelectedItem(Control c)
        {
            selected.Height = c.Height;
            selected.Top = c.Top;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Click(object sender, EventArgs e)
        {
            showDashborad();
        }

        private void Article_Click(object sender, EventArgs e)
        {
            showArticle();
        }
        public void disabledButton()
        {

            article_.Enabled = false;
            employer_.Enabled = false;
            fournisseur_.Enabled = false;
            vente_.Enabled = false;
            payroll_.Enabled = false;
            panier_.Enabled = false;
            utilisateur_.Enabled = false;
            rapport_.Enabled = false;
            log.Enabled = false;
        }

        private void Employer_Click(object sender, EventArgs e)
        {
            showEmployer();
        }

        private void Fournisseur_Click(object sender, EventArgs e)
        {
            showFournisseur();
        }

        private void Vente_Click(object sender, EventArgs e)
        {
            showVente();
        }

        private void Payroll_Click(object sender, EventArgs e)
        {
            showPayroll();
        }

        private void Panier_Click(object sender, EventArgs e)
        {
            showPanier();
        }

        private void Parametre_Click(object sender, EventArgs e)
        {
            showParametre();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xxx(object sender, EventArgs e)
        {
            //Employer_C.searchEmployer(search_bar.Text, currentTable);
        }

        private void bbb(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void _search(object sender, EventArgs e)
        {
            if(currentPage == "employer")
            {
                Employer_C.searchEmployer(search_bar.Text, currentTable);
            }
            if(currentPage == "article")
            {
                ArticleC.searchArticle(search_bar.Text, currentTable);
            }
            if (currentPage == "fournisseur")
            {
                FournisseurC.searchFournisseur(search_bar.Text, currentTable);
            }
            if (currentPage == "vente")
            {
                VenteC.searchVente(search_bar.Text, currentTable);
            }
            if (currentPage == "utilisateur" && poste =="manager")
            {
                UtilisateurC.searchUser(search_bar.Text, currentTable);
            }
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void BunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Container_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Log_Click(object sender, EventArgs e)
        {
            showLog();
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Search_bar_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchbar(object sender, EventArgs e)
        {
            //MessageBox.Show(search_bar.Text);
            Employer_C.searchEmployer(search_bar.Text, currentTable);
        }

        private void Rapport__Click(object sender, EventArgs e)
        {
            showRapport();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            connect.Enabled = false;
            showLogin(new Login());
        }

        private void Welcome_Click(object sender, EventArgs e)
        {

        }

        private void Deconnecte_Click(object sender, EventArgs e)
        {
            the_name.Text = "no_log";
            poste = null;
            the_name.Visible = true;
            //main.Welcome.Visible = false;
            main.the_name.Visible = false;
            main.connect_.Visible = true;
            main.disconect.Visible = false;
            disabledButton();
            DashBoard.article.Enabled = false;
            DashBoard.employer.Enabled = false;
            DashBoard.fournisseur.Enabled = false;
            DashBoard.payroll.Enabled = false;
            DashBoard.sale.Enabled = false;
            DashBoard.user.Enabled = false;
            connect.Enabled = true;
            showDashborad();

        }
    }
}


