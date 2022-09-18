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
    public partial class Poubelle : Form
    {
        String id_ = null;
        String nom_=null,prenom_=null,nif_=null,adresse_=null,date_x=null,post_=null,sexe_=null;

        private void Restore_e_Click(object sender, EventArgs e)
        {
            date_x = "1996-12-25";
            int rep = Employer_C.restaureEmployer(nom_,prenom_,nif_,sexe_,adresse_,date_x,post_,tableDeletedEmployer,id_);
            if (rep == 0)
            {
                
                MessageBox.Show("Employer restaurer avec succes");
            }
            else
            {
                MessageBox.Show("Erreur lors de la restauration");
            }
        }

        public Poubelle()
        {
            InitializeComponent();
            Employer_C.showDeletedEmployer(tableDeletedEmployer);
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Employer.poubel.Enabled = true;
            Dispose();
        }

        private void Poubelle_Load(object sender, EventArgs e)
        {

        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            Employer.poubel.Enabled = true;
            Dispose();
        }

        private void TableDeletedEmployer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_ = tableDeletedEmployer.CurrentRow.Cells["id"].Value.ToString();
            nom_ = tableDeletedEmployer.CurrentRow.Cells["nom"].Value.ToString();
            prenom_ = tableDeletedEmployer.CurrentRow.Cells["prenom"].Value.ToString(); ;
            nif_ = tableDeletedEmployer.CurrentRow.Cells["nif"].Value.ToString(); 
            sexe_ = tableDeletedEmployer.CurrentRow.Cells["sexe"].Value.ToString();
            adresse_ = tableDeletedEmployer.CurrentRow.Cells["adresse"].Value.ToString();
             date_x = tableDeletedEmployer.CurrentRow.Cells["dn"].Value.ToString();
            post_ = tableDeletedEmployer.CurrentRow.Cells["poste_"].Value.ToString(); 

            
        }
    }
}
