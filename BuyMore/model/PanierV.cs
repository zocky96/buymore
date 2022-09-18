using Bunifu.UI.WinForms;
using BuyMore.db;
using BuyMore.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyMore.view
{
    class PanierV
    {
        public static int addToCart(PanierM panier)
        {
            int rep = dbConfig.execute_command("insert into panier(nom_du_produit,prix,quantite) values('" + panier.getNomDuProduit() + "'," + panier.getPrix() + "," + panier.getQuantite() + ")");
            return rep;
        }
        public static void deleteToCart(String id, BunifuDataGridView table)
        {
            int rep = dbConfig.execute_command("delete from panier where id=" + id);
            showPanier(table);
        }
        public static void CleanCart(BunifuDataGridView table)
        {
            int rep = dbConfig.execute_command("delete from panier");
            showPanier(table);
        }
        public static MySqlDataReader getVenteInCart()
        {
            MySqlDataReader result = dbConfig.getResultCommand("select * from panier");
            return result;
        }
        public static MySqlDataReader getArticleSum()
        {
            MySqlDataReader result = dbConfig.getResultCommand("select prix,quantite from panier");
            return result;
        }
        public static void showPanier(BunifuDataGridView table)
        {

            table.Rows.Clear();
            MySqlDataReader result = dbConfig.getResultCommand("select * from panier");
            try
            {
                while (result.Read())
                {

                    table.Rows.Add(result["id"], result["nom_du_produit"], result["prix"], result["quantite"]);

                }
            }
            catch
            {

            }

        }
    }
}
