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
    class ShorteV
    {
        public static int saveShorte(shortM shortt, string date, BunifuDataGridView table)
        {
            dbConfig db = new dbConfig();
            int rep = dbConfig.execute_command("insert into shorte(nom_complet,montant,code_employer,date) values('" + shortt.getFullName() + "','" + shortt.getMontant() + "','" + shortt.getCodeEmployer() + "','" + date + "')");

            showShorte(table);
            return rep;
        }
        public static void showShorte(BunifuDataGridView table)
        {

            table.Rows.Clear();
            MySqlDataReader result = dbConfig.getResultCommand("select *from shorte");
            try
            {
                while (result.Read())
                {

                    table.Rows.Add(result["id"], result["nom_complet"], result["montant"], result["code_employer"], result["date"]);

                }
            }
            catch
            {

            }

        }
    }
}
