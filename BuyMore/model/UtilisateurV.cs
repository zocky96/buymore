using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunifu.UI.WinForms;
using BuyMore.db;
using BuyMore.model;
using MySql.Data.MySqlClient;

namespace BuyMore.view
{
    class UtilisateurV
    {
        public static int saveUser(UtilisateurM user, BunifuDataGridView table)
        {
            
            int rep = dbConfig.execute_command("insert into utilisateur(nom,prenom,username,password,code_employer) values('" + user.getNom()+"','"+user.getPrenom()+"','"+user.getUsername()+"','"+user.getPassword()+"','"+user.getCodeEmployer() + "')");
            showUser(table);
            return rep;
        }
        public static int ifCodeEmployerExiste(String code)
        {
            int rep = -110;
            MySqlDataReader result = dbConfig.getResultCommand("select count(*) as reponse from utilisateur where code_employer='"+code+"'");
            while(result.Read())
            {
                rep = int.Parse(result["reponse"].ToString());
            }
            return rep;
        }
        
        public static int ifUserEmployerExiste(String user)
        {
            int rep = -110;
            MySqlDataReader result = dbConfig.getResultCommand("select count(*) as reponse from utilisateur where username='" + user + "'");
            while (result.Read())
            {
                rep = int.Parse(result["reponse"].ToString());
            }
            return rep;
        }
        public static int modifyUser(UtilisateurM user, BunifuDataGridView table,String id)
        {

            int rep = dbConfig.execute_command("update utilisateur set username='"+user.getUsername()+"',password='"+user.getPassword()+ "' where id='" + id+"'");
            showUser(table);
            return rep;
        }
        public static int deleteUser(BunifuDataGridView table, String id)
        {
            int rep = dbConfig.execute_command("delete from utilisateur where id='"+id+"'");
            showUser(table);
            return rep;
        }
        public static MySqlDataReader login(String username,String password)
        {
            MySqlDataReader result = dbConfig.getResultCommand("select count(*) as reponse,concat(nom,' ',prenom) as nom_complet,nom,prenom from utilisateur where username='" + username+ "' and password='"+password+"'");
            return result;
        }
        public static void searchUser(String word, BunifuDataGridView table)
        {
            table.Rows.Clear();

            MySqlDataReader result = dbConfig.getResultCommand("select * from utilisateur where id='" + word + "' or username= '" + word + "'");
            try
            {
                while (result.Read())
                {

                    table.Rows.Add(result["id"], result["nom"], result["prenom"], result["username"], result["password"]);

                }
            }
            catch
            {

            }




        }
        public static void showUser(BunifuDataGridView table)
        {

            table.Rows.Clear();
            if (main.poste.Equals("manager"))
            {
                MySqlDataReader result = dbConfig.getResultCommand("select *from utilisateur");
                try
                {
                    while (result.Read())
                    {

                        table.Rows.Add(result["id"], result["nom"], result["prenom"], result["username"], result["password"]);

                    }
                }
                catch
                {

                }
            }
            else
            {
                MySqlDataReader result = dbConfig.getResultCommand("select *from utilisateur where username='" + main.userName + "'");
                try
                {
                    while (result.Read())
                    {

                        table.Rows.Add(result["id"], result["nom"], result["prenom"], result["username"], result["password"]);

                    }
                }
                catch
                {

                }
            }
            

        }
    }
}
