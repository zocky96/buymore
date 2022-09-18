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
    public partial class Fournisseur : Form
    {
        String id_ = null;
        public Fournisseur()
        {
            InitializeComponent();
            FournisseurC.showFournisseur(tableFournisseur);
            main.currentPage = "fournisseur";
            main.currentTable = tableFournisseur;
        }

        private void Fournisseur_Load(object sender, EventArgs e)
        {

        }

        private void BunifuTextBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void clearField()
        {
            nom_f.Text = "";
            prenom_f.Text = "";
            telephone_f.Text = "";
            adresse_f.Text = "";
            nom_produit.Text = "";
        }
        private void Save_e_Click(object sender, EventArgs e)
        {
            String nom,prenom,telephone,adresse,nom_du_produit;
            nom = nom_f.Text;
            prenom = prenom_f.Text;
            telephone = telephone_f.Text;
            adresse = adresse_f.Text;
            nom_du_produit = nom_produit.Text;
            int rep = FournisseurC.saveFournisseur(nom, prenom, telephone, adresse, nom_du_produit, tableFournisseur);
            if (rep == 0)
            {
                clearField();
                MessageBox.Show("Fournisseur enregistrer avec succes");
            }
            else
            {
                MessageBox.Show("Erreur lors de l'enregistrement");
            }
        }

        private void TableFournisseur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_ = tableFournisseur.CurrentRow.Cells["id"].Value.ToString();
            nom_f.Text = tableFournisseur.CurrentRow.Cells["nom"].Value.ToString();
            prenom_f.Text = tableFournisseur.CurrentRow.Cells["prenom"].Value.ToString();
            adresse_f.Text = tableFournisseur.CurrentRow.Cells["adresse_"].Value.ToString();
            telephone_f.Text = tableFournisseur.CurrentRow.Cells["telephone"].Value.ToString();
            nom_produit.Text = tableFournisseur.CurrentRow.Cells["product_name"].Value.ToString();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            String nom, prenom, telephone, adresse, nom_du_produit;
            nom = nom_f.Text;
            prenom = prenom_f.Text;
            telephone = telephone_f.Text;
            adresse = adresse_f.Text;
            nom_du_produit = nom_produit.Text;
            int rep = FournisseurC.modifyFournisseur(nom,prenom,telephone,adresse,nom_du_produit,tableFournisseur,id_);
            if (rep == 0)
            {
                clearField();
                MessageBox.Show("Fournisseur modifier avec succes");
            }
            else
            {
                MessageBox.Show("Erreur lors de la modification");
            }
        }

        private void Suprimer_Click(object sender, EventArgs e)
        {
            int rep = FournisseurC.deleteFournisseur(tableFournisseur,id_);
            if (rep == 0)
            {
                clearField();
                MessageBox.Show("Fournisseur suprimmer avec succes");
            }
            else
            {
                MessageBox.Show("Erreur lors de la supression");
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            FournisseurC.showFournisseur(tableFournisseur);
        }
    }
}
