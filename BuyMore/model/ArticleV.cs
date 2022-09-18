using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using BuyMore.db;
using BuyMore.model;
using MySql.Data.MySqlClient;

namespace BuyMore.view
{
    class ArticleV
    {
        public static int saveArticle(ArticleM arti, BunifuDataGridView table)
        {
            int rep = dbConfig.execute_command("insert into article(nom_du_produit,prix,quantite,type,fournisseur) values('" + arti.getNom() + "','" + arti.getPrix() + "','" + arti.getQuantite() + "','" + arti.getType() + "','" + arti.getFournisseur() + "')" );
            showArticle(table);
            return rep;
        }
        public static int getArticleQuantite(String id)
        {
            int quantite = 0;
            MySqlDataReader result = dbConfig.getResultCommand("select quantite from article where id=" + id);

            while (result.Read())
            {

                
                    quantite = int.Parse(result["quantite"].ToString());

            }
            return quantite;
        }
        public static MySqlDataReader getArticleSum()
        {
            MySqlDataReader result = dbConfig.getResultCommand("select prix,quantite from article");
            return result;
        }

        public static int modifyArticle(ArticleM article, BunifuDataGridView table, String id)
        {
            
            int rep = dbConfig.execute_command("update article set nom_du_produit='" + article.getNom() + "',prix='" + article.getPrix() + "',quantite='" + article.getQuantite() + "',type='" + article.getType() + "',fournisseur='" + article.getFournisseur() + "' where id=" +id);
            showArticle(table);
            return rep;
        }
        public static int deleteArticle(String id, BunifuDataGridView table)
        {
            int rep = dbConfig.execute_command("delete from article where id=" + id + "");
            showArticle(table);
            return rep;
        }
        public static void setArticleQuantite(float quantite,String nom_du_produit)
        {
            int rep = dbConfig.execute_command("update article set quantite=" + quantite + " where nom_du_produit='" + nom_du_produit + "'");
        }
        public static void searchArticle(String word, BunifuDataGridView table)
        {
            table.Rows.Clear();

            MySqlDataReader result = dbConfig.getResultCommand("select * from article where id='" + word+ "' or nom_du_produit= '"+word+"'");
            try
            {
                while (result.Read())
                {

                    table.Rows.Add(result["id"], result["nom_du_produit"], result["prix"], result["quantite"], result["type"], result["fournisseur"]);

                }
            }
            catch
            {

            }




        }
        public static void showArticle(BunifuDataGridView table)
        {
            MySqlDataReader result;
            table.Rows.Clear();
            if (main.poste == "comptable")
            {
                result = dbConfig.getResultCommand("select *from article where quantite < 10");
            }
            else
            {
               result = dbConfig.getResultCommand("select *from article");
            }
            
            try
            {
                while (result.Read())
                {

                    table.Rows.Add(result["id"], result["nom_du_produit"], result["prix"], result["quantite"], result["type"], result["fournisseur"]);

                }
            }
            catch
            {

            }

        }
    }
}
