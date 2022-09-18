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
    class FournisseurV
    {
        public static int saveFournisseur(FournisseurM fournisseur, BunifuDataGridView table)
        {

            int rep = dbConfig.execute_command("insert into fournisseur(nom,prenom,adresse,telephone,nom_du_produit) values('" + fournisseur.getNom() + "','" + fournisseur.getPrenom() + "','" + fournisseur.getAdresse() + "','" + fournisseur.getTelephone() + "','"+fournisseur.getNomDuProduit()+"')");
            showFournisseur(table);
            return rep;
        }
        public static int modifyFournisseur(FournisseurM fournisseur, BunifuDataGridView table, String id)
        {

            int rep = dbConfig.execute_command("update fournisseur set nom='" + fournisseur.getNom() + "',prenom='" + fournisseur.getPrenom() + "',telephone='" + fournisseur.getTelephone() + "',adresse='" + fournisseur.getAdresse() + "',nom_du_produit='"+fournisseur.getNomDuProduit()+"' where id='" + id + "'");
            showFournisseur(table);
            return rep;
        }
        public static int deleteFournisseur(BunifuDataGridView table, String id)
        {
            int rep = dbConfig.execute_command("delete from fournisseur where id='" + id + "'");
            showFournisseur(table);
            return rep;
        }
        public static void searchFournisseur(String word, BunifuDataGridView table)
        {
            table.Rows.Clear();

            MySqlDataReader result = dbConfig.getResultCommand("select * from fournisseur where id='" + word + "' or nom='" + word + "' or  prenom='" + word + "' or telephone='" + word + "' or nom_du_produit='"+word+"'");
            try
            {
                while (result.Read())
                {

                    table.Rows.Add(result["id"], result["nom"], result["prenom"], result["telephone"], result["adresse"], result["nom_du_produit"]);

                }
            }
            catch
            {

            }




        }
        public static void showFournisseur(BunifuDataGridView table)
        {

            table.Rows.Clear();
            MySqlDataReader result = dbConfig.getResultCommand("select *from fournisseur");
            try
            {
                while (result.Read())
                {

                    table.Rows.Add(result["id"], result["nom"], result["prenom"], result["telephone"], result["adresse"], result["nom_du_produit"]);

                }
            }
            catch
            {

            }

        }
    }
}
