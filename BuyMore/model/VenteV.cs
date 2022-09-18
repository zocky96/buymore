using BuyMore.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuyMore.db;
using MySql.Data.MySqlClient;
using Bunifu.UI.WinForms;
using System.Windows.Forms;

namespace BuyMore.view
{
    class VenteV
    {
        public static MySqlDataReader getArticleSum()
        {
            MySqlDataReader result = dbConfig.getResultCommand("select prix,quantite from vente");
            return result;
        }
        public static VenteM getPriceAndQuantite(String nom_du_produit)
        {
            int rep, quantite = -100;
            float prix = -100;
            
            MySqlDataReader result = dbConfig.getResultCommand("select prix,quantite from article where nom_du_produit='"+nom_du_produit+"'");
            while (result.Read())
            {
                prix = float.Parse(result["prix"].ToString());
                quantite = int.Parse(result["quantite"].ToString());
            }

            VenteM vente = new VenteM(prix,quantite,nom_du_produit);
            //showArticle(table);
            return vente;
        }
        public static int saveVente(VenteM vente,float total,String date, BunifuDataGridView table)
        {
            int rep = dbConfig.execute_command("insert into vente(nom_du_produit,prix,quantite,total,signature_autorise,date) values('" + vente.getNomDuProduit() + "'," + vente.getPrix() + "," + vente.getQuantite() + "," + total  + ",'"+main.userName+"','"+date+"')");
            showVente(table);
            return rep;
        }
        public static void deleteVente(String id, BunifuDataGridView table)
        {
            int rep = dbConfig.execute_command("delete from vente where id="+id);
            showVente(table);
        }
        public static int getQuantite(String id)
        {
            int quantite = -1000, rep;
            MySqlDataReader result = dbConfig.getResultCommand("select quantite from vente where id="+id);
            while (result.Read())
            {

                quantite = int.Parse(result["quantite"].ToString());

            }
            return quantite;
        }
        public static void searchVente(String word, BunifuDataGridView table)
        {
            table.Rows.Clear();

            MySqlDataReader result = dbConfig.getResultCommand("select * from vente where id='" + word + "' or nom_du_produit= '" + word + "' or date='"+word+ "' or signature_autorise='"+word+"'");
            try
            {
                while (result.Read())
                {

                    table.Rows.Add(result["id"], result["nom_du_produit"], result["prix"], result["quantite"], result["total"], result["date"], result["signature_autorise"]);

                }
            }
            catch
            {

            }




        }
        public static void showVente(BunifuDataGridView table)
        {

            table.Rows.Clear();
            MySqlDataReader result = dbConfig.getResultCommand("select * from vente where signature_autorise='"+main.userName+"'");
            try
            {
                while (result.Read())
                {

                    table.Rows.Add(result["id"], result["nom_du_produit"], result["prix"], result["quantite"], result["total"], result["date"],result["signature_autorise"]);

                }
            }
            catch
            {

            }

        }
        public static MySqlDataReader getAllVente(string datee)
        {
            MySqlDataReader result = dbConfig.getResultCommand("select * from vente where date='"+datee+"'");
            MessageBox.Show("select * from vente where date='" + datee + "'");
            return result;
        }

    }
}
