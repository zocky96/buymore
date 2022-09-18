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
    public partial class Panier : Form
    {
        String id_, nomProduit_;
        public Panier()
        {
            InitializeComponent();
            PanierC.showPanier(tablePanier);
            PanierC.getArticleSum();
        }

        private void Panier_Load(object sender, EventArgs e)
        {

        }

        private void BunifuButton3_Click(object sender, EventArgs e)
        {
            PanierC.CleanCart(tablePanier);
            MessageBox.Show("Le pamier est vide");
        }

        private void TablePanier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_ = tablePanier.CurrentRow.Cells["id"].Value.ToString();
            nomProduit_ = tablePanier.CurrentRow.Cells["product_name"].Value.ToString();
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            PanierC.getVenteInCart(tablePanier);
        }

        private void BunifuButton2_Click(object sender, EventArgs e)
        {
            PanierC.deleteToCart(id_, tablePanier);
            MessageBox.Show(nomProduit_ + " a ete retire du panier");
        }
    }
}
