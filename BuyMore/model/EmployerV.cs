using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuyMore.model;
using MySql.Data.MySqlClient;
using BuyMore.db;
using Bunifu.UI.WinForms;
using System.Windows.Forms;

namespace BuyMore.view
{
    
    class EmployerV
    {
       
        
        
       
        //private static MySqlConnection connection()
        //{
        //MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=buymore");
        //  conn.Open();
        //   return conn;
        // }
        // private static void execute_command(String cmd)
        //{
        //MySqlConnection conn = dbConfig.connection();
        // MySqlCommand command = conn.CreateCommand();
        // command.CommandText = (cmd);
        // command.ExecuteNonQuery();
        // conn.Close();

        //}
        public static int deleteEmployer(String id, BunifuDataGridView table)
        {
            int rep = dbConfig.execute_command("delete from employer where id="+id+"");
            showEmployer(table);
            return rep;
        }

        public static List<String> getNameAndFirstnameById(String id)
        {
            List<String> liste= new List<string>();
            liste.Clear();
            MySqlDataReader result = dbConfig.getResultCommand("select nom,prenom from employer where id="+id);
            while(result.Read())
            {
                String nom = result["nom"].ToString();
                String prenom = result["prenom"].ToString();
                liste.Add(nom);
                liste.Add(prenom);
            }
            return liste;
        }
        public static MySqlDataReader getAllCaissier()
        {
            MySqlDataReader result = dbConfig.getResultCommand("select concat(nom,' ',prenom) as nom_complet from employer");
            return result;
        }
        public static MySqlDataReader getPoste(String nom,String prenom)
        {
            MySqlDataReader result = dbConfig.getResultCommand("select poste from employer where nom='" + nom + "' and prenom='"+prenom+"'");
            return result;
        }
        public static void searchEmployer(String word, BunifuDataGridView table)
        {
            table.Rows.Clear();
            
            MySqlDataReader result = dbConfig.getResultCommand("select * from employer where id='" + word+ "' or nom='" + word +"' or  prenom='"+word+ "' or nif='"+word+"'");
            try
            {
                while (result.Read())
                {

                    table.Rows.Add(result["id"], result["nom"], result["prenom"], result["sexe"], result["nif"], result["date_de_naissance"], result["adresse"], result["poste"]);

                }
            }
            catch
            {

            }
           
            
            
            
        }
        public static int modifyEmployer(employer empl, BunifuDataGridView table,String id)
        {
            dbConfig db = new dbConfig();
            int rep = dbConfig.execute_command("update employer set nom='"+empl.getNom()+"',prenom='"+empl.getPrenom()+"',nif='"+empl.getNif()+"',sexe='"+empl.getSexe()+"',adresse='"+empl.getAdresse()+"',poste='"+empl.getPoste()+"',date_de_naissance='"+empl.getDateDeNaissance()+"' where id ="+id);
            showEmployer(table);
            return rep;
        }
        public static int restaureEmployer(String id,employer empl, BunifuDataGridView table)
        {
            int rep = dbConfig.execute_command("insert into employer(nom,prenom,nif,sexe,poste,adresse,date_de_naissance) values('" + empl.getNom() + "','" + empl.getPrenom() + "','" + empl.getNif() + "','" + empl.getSexe() + "','" + empl.getPoste() + "','" + empl.getAdresse() + "','" + empl.getDateDeNaissance() + "')");
            rep = dbConfig.execute_command("delete from employer_suprimer where id=" + id + "");
            showDeletedEmployer(table);
            return rep;
        }
        public static int saveEmployer(employer empl, BunifuDataGridView table)
        {
            dbConfig db = new dbConfig();
            int rep = dbConfig.execute_command("insert into employer(nom,prenom,nif,sexe,poste,adresse,date_de_naissance) values('" + empl.getNom()+"','" + empl.getPrenom() + "','" + empl.getNif() + "','" + empl.getSexe() + "','" + empl.getPoste() + "','" + empl.getAdresse() + "','" + empl.getDateDeNaissance() +"')");
           
            showEmployer(table);
            return rep;
        }
        public static int deletedEmployer(employer empl, BunifuDataGridView table)
        {
            dbConfig db = new dbConfig();
            int rep = dbConfig.execute_command("insert into employer_suprimer(nom,prenom,nif,sexe,poste,adresse,date_de_naissance) values('" + empl.getNom() + "','" + empl.getPrenom() + "','" + empl.getNif() + "','" + empl.getSexe() + "','" + empl.getPoste() + "','" + empl.getAdresse() + "','" + empl.getDateDeNaissance() + "')");

            showEmployer(table);
            return rep;
        }
        public static void showEmployer(BunifuDataGridView table)
        {
            
            table.Rows.Clear();
            MySqlDataReader result =  dbConfig.getResultCommand("select *from employer");
            try
            {
                while (result.Read())
                {

                    table.Rows.Add(result["id"], result["nom"], result["prenom"], result["sexe"], result["nif"], result["date_de_naissance"], result["adresse"], result["poste"]);

                }
            }
            catch
            {

            }
            
        }
        public static int ifCodeEmployerExiste(String code)
        {
            int rep = -110;
            MySqlDataReader result = dbConfig.getResultCommand("select count(*) as reponse from employer where id='" + code + "'");
            while (result.Read())
            {
                rep = int.Parse(result["reponse"].ToString());
            }
            return rep;
        }
        public static void showDeletedEmployer(BunifuDataGridView table)
        {

            table.Rows.Clear();
            MySqlDataReader result = dbConfig.getResultCommand("select * from employer_suprimer");
            try
            {
                while (result.Read())
                {

                    table.Rows.Add(result["id"], result["nom"], result["prenom"], result["sexe"], result["nif"], result["date_de_naissance"], result["adresse"], result["poste"]);

                }
            }
            catch
            {

            }

        }
    }
}
