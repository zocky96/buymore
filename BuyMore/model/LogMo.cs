using Bunifu.UI.WinForms;
using BuyMore.db;
using BuyMore.moule;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyMore.model
{
    class LogMo
    {
        public static int saveLog(LogM log)
        {
            int rep = dbConfig.execute_command("insert into log(id,nom,prenom,username,date,heure) values('" + log.getId() + "','" + log.getNom() + "','" + log.getPrenom() + "','" + log.getUser() + "','" + log.getDate() + "','"+ log.getHeure() +"')");
            
            return rep;
        }
        public static List<string> getInfoByUserName(string username)
        {
            List<string> list = new List<string>();
            MySqlDataReader result;
            result = dbConfig.getResultCommand("select * from utilisateur where username='"+username+"'");
            try
            {
                while (result.Read())
                {

                    list.Add(result["code_employer"].ToString());
                    list.Add(result["nom"].ToString());
                    list.Add(result["prenom"].ToString());

                }
            }
            catch
            {

            }

            return list;
        }
        public static void showLog(BunifuDataGridView table)
        {
            MySqlDataReader result;
            table.Rows.Clear();
            result = dbConfig.getResultCommand("select *from log");
            try
            {
                while (result.Read())
                {

                    table.Rows.Add(result["id"], result["nom"], result["prenom"], result["username"], result["date"], result["heure"]);

                }
            }
            catch
            {

            }

        }
    }
}
