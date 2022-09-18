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
    class VenteC
    {
        public static void searchVente(String word, BunifuDataGridView table)
        {
            VenteV.searchVente(word, table);
        }
        public static void showVente(BunifuDataGridView table)
        {
            VenteV.showVente(table);
        }
        public static MySqlDataReader getAllVente(string datee)
        {
            return VenteV.getAllVente(datee);
        }
        public static void cancelVente(String  id,String nomProduit, BunifuDataGridView table)
        {
            VenteM vente = VenteV.getPriceAndQuantite(nomProduit);
            int quantiteVente = VenteV.getQuantite(id);
            int quantiteActicle = vente.getQuantite();
            int new_quantite = quantiteActicle + quantiteVente;
            ArticleV.setArticleQuantite(new_quantite, nomProduit);
            VenteV.deleteVente(id, table);
        }
        public static void getArticleSum()
        {
            float prix, somme = 0;
            int quantite;

            MySqlDataReader result = VenteV.getArticleSum();
            while (result.Read())
            {

                prix = float.Parse(result["prix"].ToString());
                quantite = int.Parse(result["quantite"].ToString());
                somme += (prix * quantite);

            }

            main.theSum_.Text = somme.ToString() + " $";

        }
        public static void vendre(String nom_du_produit,int quantite, BunifuDataGridView table)
        {
            VenteM vente = VenteV.getPriceAndQuantite(nom_du_produit);
            float total,prix_db = float.Parse( vente.getPrix().ToString());
            int quantite_db = int.Parse(vente.getQuantite().ToString());
            MessageBox.Show(quantite_db.ToString());
            if(int.Parse(vente.getPrix().ToString()) == -100)
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
                    total = prix_db * quantite;
                    int newQuantite = quantite_db - quantite;
                    MessageBox.Show(quantite_db.ToString());
                    vente.setQuantite(quantite);
                    ArticleV.setArticleQuantite(newQuantite, vente.getNomDuProduit().ToString());
                    string year, month, day, date_x;
                    year = DateTime.Now.Year.ToString();
                    month = DateTime.Now.Month.ToString();
                    day = DateTime.Now.Day.ToString();
                    date_x = year + "/" + month + "/" + day;
                    
                    VenteV.saveVente(vente, total, date_x, table);
                }
            }
            
        }
    }
}
