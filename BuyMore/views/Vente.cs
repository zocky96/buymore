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
    public partial class Vente : Form
    {
        String id_ = null,nom_du_produit=null;
        public Vente()
        {
            InitializeComponent();
            VenteC.showVente(tableVente);
            VenteC.getArticleSum();
            main.currentPage = "vente";
            main.currentTable = tableVente;
        }

        private void Nom_v_TextChanged(object sender, EventArgs e)
        {

        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            String nom;
            int quantite;
            
            nom = nom_v.Text;
            try
            {
                quantite = int.Parse(quantite_v.Text);
                VenteC.vendre(nom, quantite, tableVente);
            }
            catch
            {
                MessageBox.Show("ce champ ne peut prend que des chiffres");
            }
            
            

        }

        private void TableVente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_ = tableVente.CurrentRow.Cells["id"].Value.ToString();
            nom_du_produit = tableVente.CurrentRow.Cells["product_name"].Value.ToString();
        }

        private void Panier_Click(object sender, EventArgs e)
        {
            String nom;
            int quantite;
            nom = nom_v.Text;
            
            try
            {
                quantite = int.Parse(quantite_v.Text);
                PanierC.addToCart(nom, quantite);
            }
            catch
            {
                MessageBox.Show("ce champ ne peut prend que des chiffres");
            }
        }

        private void Vente_Load(object sender, EventArgs e)
        {

        }

        private void BunifuButton2_Click(object sender, EventArgs e)
        {
            VenteC.cancelVente(id_, nom_du_produit, tableVente);
        }
    }
}
