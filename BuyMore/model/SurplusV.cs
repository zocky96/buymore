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
    class SurplusV
    {
        public static int saveSurplus(SurplusM surplus,string date, BunifuDataGridView table)
        {
            dbConfig db = new dbConfig();
            int rep = dbConfig.execute_command("insert into surplus(nom_complet,montant,code_employer,date) values('" + surplus.getFullName() + "','" + surplus.getMontant() + "','" + surplus.getCodeEmployer() + "','" + date + "')");

            showSurplus(table);
            return rep;
        }
        public static void showSurplus(BunifuDataGridView table)
        {

            table.Rows.Clear();
            MySqlDataReader result = dbConfig.getResultCommand("select *from surplus");
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
