using Bunifu.UI.WinForms;
using BuyMore.model;
using BuyMore.view;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyMore.controllers
{
    class PanierC
    {
        public static void getArticleSum()
        {
            float prix, somme = 0;
            int quantite;

            MySqlDataReader result = PanierV.getArticleSum();
            while (result.Read())
            {

                prix = float.Parse(result["prix"].ToString());
                quantite = int.Parse(result["quantite"].ToString());
                somme += (prix * quantite);

            }
            
            main.theSum_.Text = somme.ToString() + " $";

        }
        public static void getVenteInCart(BunifuDataGridView table)
        {
            MySqlDataReader result = PanierV.getVenteInCart();
            while (result.Read())
            {

                //(result["id"], result["nom_du_produit"], result["prix"], result["quantite"]);
                VenteC.vendre(result["nom_du_produit"].ToString(),int.Parse(result["quantite"].ToString()), table);

            }
            CleanCart(table);
            showPanier(table);

            MessageBox.Show("nu bon");
        }
        public static void deleteToCart(String id, BunifuDataGridView table)
        {
            PanierV.deleteToCart(id, table);
        }
        public static void showPanier(BunifuDataGridView table)
        {
            PanierV.showPanier(table);
        }
        public static void CleanCart(BunifuDataGridView table)
        {
            PanierV.CleanCart(table);
        }
        public static void addToCart(String nom_du_produit, int quantite)
        {
            VenteM vente = VenteV.getPriceAndQuantite(nom_du_produit);
            float total, prix_db = float.Parse(vente.getPrix().ToString());
            int quantite_db = int.Parse(vente.getQuantite().ToString());

            if (int.Parse(vente.getPrix().ToString()) == -100)
            {
                MessageBox.Show("ce produit n'est pas dans la base de donnee");
            }
            else
            {
                if (quantite > quantite_db)
                {
                    MessageBox.Show("Nous n'avons pas cette quantite de " + nom_du_produit + " en stock");
                }
                else
                {
                    PanierM panier = new PanierM(prix_db, quantite, nom_du_produit);
                    PanierV.addToCart(panier);
                    MessageBox.Show(nom_du_produit + " a ete ajouter au panier");
                }
            }

        }
    }
}
