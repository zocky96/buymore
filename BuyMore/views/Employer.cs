using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using BuyMore.controllers;

namespace BuyMore
{
    
    public partial class Employer : Form
    {

        String sexe_;
        String id_ = null;
        public static BunifuDataGridView MyEmployerTable;
        public static BunifuButton poubel;
        public Employer()
        {
            InitializeComponent();
            Employer_C.showEmployer(tableEmployer);
            MyEmployerTable = tableEmployer;
            poubel = poubelle;
            main.currentPage = "employer";
            main.currentTable = tableEmployer;
            poste.Items.Add("caissier");
            poste.Items.Add("gestionnaire de stock");
            poste.Items.Add("comptable");
            poste.Items.Add("secretaire");
            poste.Items.Add("directeur");
        }

        private void BunifuRadioButton2_Click(object sender, EventArgs e)
        {

        }
        private void showEmployer()
        {
            Employer_C.showEmployer(tableEmployer);
        }

        private void Employer_Load(object sender, EventArgs e)
        {

        }

        public void BunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_ = tableEmployer.CurrentRow.Cells["id"].Value.ToString();
            nom_e.Text = tableEmployer.CurrentRow.Cells["nom"].Value.ToString();
            prenom_e.Text = tableEmployer.CurrentRow.Cells["prenom"].Value.ToString();
            nif_e.Text = tableEmployer.CurrentRow.Cells["nif"].Value.ToString();
            poste.Text = tableEmployer.CurrentRow.Cells["poste_"].Value.ToString();
            adresse_e.Text = tableEmployer.CurrentRow.Cells["adresse"].Value.ToString();
        }
        private void clearField()
        {
            nom_e.Text = "";
            prenom_e.Text = "";
            nif_e.Text = "";

            adresse_e.Text = "";
            date_e.Text = "";
            poste.Text = "Poste";
        }
        private void Save_e_Click(object sender, EventArgs e)
        {
            String nom = nom_e.Text;
            String prenom = prenom_e.Text;
            String nif = nif_e.Text;
            
            String adresse = adresse_e.Text;
            String date_x = date_e.Text;
            String post = poste.Text;
            if (sexe_m.Checked==true)
            {
                sexe_ = "masculin";
            }else
            {
                sexe_ = "feminin";
            }
            string year, month, day;
            year = date_e.Value.Year.ToString();
            month = date_e.Value.Month.ToString();
            day = date_e.Value.Day.ToString();
            date_x = year + "/" + month + "/" + day;
            
            
            int rep = Employer_C.saveEmployer(nom, prenom, nif, sexe_, adresse, date_x, post,tableEmployer);
            if (rep == 0)
            {
                clearField();
                MessageBox.Show("Employer enregistrer avec succes");
            }
            else
            {
                MessageBox.Show("Erreur lors de l'enregistrement");
            }
        }

        private void Suprimer_Click(object sender, EventArgs e)
        {
            int rep = Employer_C.deleteEmployer(id_, tableEmployer);
            if(rep == 0)
            {
                MessageBox.Show("Employer suprimer avec succes");
            }
            else
            {
                MessageBox.Show("Selectioner un employer");
            }
            String nom = nom_e.Text;
            String prenom = prenom_e.Text;
            String nif = nif_e.Text;

            String adresse = adresse_e.Text;
            String date_x = date_e.Text;
            String post = poste.Text;
            if (sexe_m.Checked == true)
            {
                sexe_ = "masculin";
            }
            else
            {
                sexe_ = "feminin";
            }
            date_x = "1996-12-25";

            rep = Employer_C.deletedEmployer(nom, prenom, nif, sexe_, adresse, date_x, post, tableEmployer);
            if (rep == 0)
            {
                clearField();
                
            }

        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            String nom = nom_e.Text;
            String prenom = prenom_e.Text;
            String nif = nif_e.Text;
            
            String adresse = adresse_e.Text;
            string year, month, day;
            year = date_e.Value.Year.ToString();
            month = date_e.Value.Month.ToString();
            day = date_e.Value.Day.ToString();
            string date_x = year + "/" + month + "/" + day;
            
            String post = poste.Text;
            if (sexe_m.Checked == true)
            {
                sexe_ = "masculin";
            }
            else
            {
                sexe_ = "feminin";
            }

            int rep = Employer_C.modifyEmployer(nom, prenom, nif, sexe_, adresse, date_x, post,tableEmployer,id_);
            if (rep == 0 && id_ != null)
            {
                MessageBox.Show("Employer modifier avec succes");
            }
            else
            {
                MessageBox.Show("Erreur lors de la modification");
                
            }
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            showEmployer();
        }

        private void Poubelle_Click(object sender, EventArgs e)
            
        {
            poubelle.Enabled = false;
            main.instance.showLogin(new Poubelle());
        }

        private void Poste_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
