using Bunifu.UI.WinForms;
using BuyMore.model;
using BuyMore.view;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyMore.controllers
{
    class ArticleC
    {
        public static void searchArticle(String word, BunifuDataGridView table)
        {
            ArticleV.searchArticle(word, table);
        }
        public static int saveArticle(String nom, float prix, int quantite, String type, String fournisseur, BunifuDataGridView table)
        {
            ArticleM arti = new ArticleM(nom, prix, quantite, type, fournisseur);
            int rep = ArticleV.saveArticle(arti, table);
            getArticleSum();
            return rep;
        }
        public static void getArticleSum()
        {
            float prix,somme=0;
            int quantite;

            MySqlDataReader result = ArticleV.getArticleSum();
            while (result.Read())
            {

                prix = float.Parse(result["prix"].ToString());
                quantite = int.Parse(result["quantite"].ToString());
                somme += (prix * quantite);

            }
            main.theSum_.Text = somme.ToString() +" $";

        }
        public static int deleteArticle(String id, BunifuDataGridView table)
        {
            int rep = ArticleV.deleteArticle(id,table);
            getArticleSum();
            return rep;
        }
        public static int modifyArticle(String nom, float prix, int quantite, String type, String fournisseur, BunifuDataGridView table,String id)
        {
            ArticleM article = new ArticleM(nom, prix,quantite,type,fournisseur);
            int rep = ArticleV.modifyArticle(article, table, id);
            getArticleSum();
            return rep;
        }
        public static void showAticle(BunifuDataGridView table)
        {
            getArticleSum();
            ArticleV.showArticle(table);
            
        }
    }
}
