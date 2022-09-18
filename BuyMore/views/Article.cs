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
    public partial class Article : Form
    {
        String id_ = null;
        public Article()
        {
            InitializeComponent();
            ArticleC.showAticle(articleTable);
            main.currentTable = articleTable;
            main.currentPage = "article";
        }

        private void BunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_ = articleTable.CurrentRow.Cells["id"].Value.ToString();
            nom_a.Text = articleTable.CurrentRow.Cells["nom"].Value.ToString();
            prix_a.Text = articleTable.CurrentRow.Cells["prix"].Value.ToString();
            quantite_a.Text = articleTable.CurrentRow.Cells["quantite"].Value.ToString();
            type_a.Text = articleTable.CurrentRow.Cells["type"].Value.ToString();
            fournisseur_a.Text = articleTable.CurrentRow.Cells["fournisseur"].Value.ToString();
        }

        private void Article_Load(object sender, EventArgs e)
        {

        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            String nom, fournisseur, type;
            int quantite;
            float prix;
            nom = nom_a.Text;
            try
            {
                prix = int.Parse(prix_a.Text);
                quantite = int.Parse(quantite_a.Text);
                type = type_a.Text;
                fournisseur = fournisseur_a.Text;
                int rep = ArticleC.saveArticle(nom, prix, quantite, type, fournisseur, articleTable);
                if (rep == 0)
                {
                    clearField();
                    MessageBox.Show("Article enregistrer avec succes");
                }
                else
                {
                    MessageBox.Show("erreur lors de l'enregistrement");
                }
            }
            catch
            {
                MessageBox.Show("Ce champ peut prendre que des chiffres");
            }
            
            
        }
        private void clearField()
        {
            nom_a.Text = "";
            prix_a.Text = "";
            quantite_a.Text = "";
            type_a.Text = "";
            fournisseur_a.Text = "";
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            String nom, fournisseur, type;
            int quantite;
            float prix;
            nom = nom_a.Text;
            try
            {
                prix = int.Parse(prix_a.Text);
                quantite = int.Parse(quantite_a.Text);
                type = type_a.Text;
                fournisseur = fournisseur_a.Text;
                int rep = ArticleC.modifyArticle(nom, prix, quantite, type, fournisseur, articleTable, id_);
                if (rep == 0)
                {
                    clearField();
                    MessageBox.Show("Article modifier avec succes");
                }
                else
                {
                    MessageBox.Show("erreur lors de modification");
                }
            }
            catch
            {
                MessageBox.Show("Ce champ peut prendre que des chiffres");
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            ArticleC.showAticle(articleTable);
        }

        private void Suprimer_Click(object sender, EventArgs e)
        {
            int rep = ArticleC.deleteArticle(id_,articleTable);
            if (rep == 0)
            {
                clearField();
                MessageBox.Show("Article suprimer avec succes");
            }
            else
            {
                MessageBox.Show("erreur lors de supression");
            }
        }
    }
}
