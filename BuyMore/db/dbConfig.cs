using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace BuyMore.db
{
    class dbConfig
    {
        public dbConfig()
        {

        }
        public static List<string> showConfig()
        {
            string user, passwd, host,port;
            List<string> list = new List<string>();

            SQLiteDataReader result = getResultCommandSQLite("select *from db_config");
            try
            {
                while (result.Read())
                {

                    user = result["username"].ToString();
                    passwd = result["password"].ToString();
                    host = result["host"].ToString();
                    port = result["port"].ToString();
                    list.Add(user);
                    list.Add(passwd);
                    list.Add(host);
                    list.Add(port);

                }
            }
            catch
            {

            }
            return list;
        }
        public static SQLiteConnection connectionSQLite()
        {
            string cs = @"URI=file:" + Application.StartupPath + "\\config.db";
            SQLiteConnection conn = new SQLiteConnection(cs);
            try
            {
                conn.Open();
            }
            catch
            {
                MessageBox.Show("\nServeur injoiniable, verfifier l'adresse du serveur ou\n autoriser l'access au serveur mysql");
                conn = null;
            }

            return conn;
        }
        public static void executeCommandSQLite(String cmd)
        {

            try
            {
                SQLiteConnection conn = connectionSQLite();
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = (cmd);
                command.ExecuteNonQuery();
                conn.Close();

            }
            catch
            {


            }
        }
        public static SQLiteDataReader getResultCommandSQLite(String cmd)
        {
            SQLiteDataReader reader = null;
            SQLiteConnection conn = connectionSQLite();
            try
            {
                SQLiteCommand command = conn.CreateCommand();
                command.CommandText = cmd;
                reader = command.ExecuteReader();
                return reader;
            }
            catch
            {
            }
            return reader;

        }

        private static MySqlConnection connectionConfig()
        {
            List<string> list = new List<string>();
            list = showConfig();
            string link = "Server="+list[2]+";port="+list[3]+";User="+list[0]+";Password="+list[1];
            MySqlConnection conn = new MySqlConnection(link);
            try
            {
                conn.Open();
            }
            catch
            {
               
                
            }

            return conn;
        }
        public static MySqlConnection connection()
        {
            List<string> list = new List<string>();
            list = showConfig();
           
            string link = "Server=" + list[2] + ";port="+list[3]+";User=" + list[0] + ";Password=" + list[1] + ";Database=buymore";
            MySqlConnection conn = new MySqlConnection(link);
            try
            {
                conn.Open();
            }
            catch
            {
                MessageBox.Show("\nServeur injoiniable, verfifier l'adresse du serveur ou\n autoriser l'access au serveur mysql");
                conn = null;
            }
            
            return conn;
        }
        public static MySqlDataReader getResultCommand(String cmd)
        {
            MySqlDataReader reader=null;
            MySqlConnection conn = connection();
            try
            {
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = cmd;
                reader = command.ExecuteReader();
                return reader;
            }
            catch {
            }
            return reader;
           
        }
        public static void executeCommand(String cmd)
        {
           
            try
            {
                MySqlConnection conn = connectionConfig();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = (cmd);
                command.ExecuteNonQuery();
                conn.Close();
                
            }
            catch
            {

              
            }
        }
        public static int execute_command(String cmd)
        {
            int retu = 0;
            MySqlConnection conn = connection();
            if (conn == null)
            {
                
                return 9;
            }
            else
            {
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = (cmd);

                try
                {
                    command.ExecuteNonQuery();
                    conn.Close();
                    retu = 0;
                    return retu;
                }
                catch
                {
                    retu = 1;
                    return retu;
                }
            }

            return retu;

        }
        public static void createDataBase()
        {
            executeCommand("create database BuyMore");
        }

        public static int createTables()
        {
            int rep = execute_command("create table employer(id int primary key auto_increment,nom varchar(255),prenom varchar(255),nif varchar(70),sexe varchar(70),adresse varchar(255),date_de_naissance date,poste enum('caissier','gestionnaire de stock','comptable','secretaire','directeur','sysadmin','manager'))");
            
            if (rep == 0)
            {
                execute_command("insert into employer(nom,prenom,nif,sexe,poste,adresse,date_de_naissance) values('Desir','Renaldo','007-100-199484','masculin','manager','56,Fort St Michel','1996/12/25')");
            }
            rep = execute_command("create table employer_suprimer(id int primary key auto_increment,nom varchar(255),prenom varchar(255),nif varchar(70),sexe varchar(70),adresse varchar(255),date_de_naissance date,poste enum('caissier','gestionnaire de stock','comptable','secretaire','directeur','sysadmin','manager'))");
           
            rep = execute_command("create table utilisateur(id int primary key auto_increment,nom varchar(70),prenom varchar(70),username varchar(100),code_employer varchar(70),password varchar(100),constraint fk_id_employer foreign key(id) references employer(id))");
            if (rep == 0)
            {
                execute_command("insert into utilisateur(nom,prenom,username,password,code_employer) values('Desir','Renaldo','zock','7110eda4d09e062aa5e4a390b0a572ac0d2c0220','1')");
            }
            rep = execute_command("create table article (id int primary key auto_increment,nom_du_produit varchar(100),prix float,quantite int,type varchar(70),fournisseur varchar(80))");
            rep = execute_command("create table fournisseur (id int primary key auto_increment,nom varchar(255),prenom varchar(100),adresse varchar(100),nom_du_produit varchar(100),telephone varchar(100))");
            rep = execute_command("create table vente (id int primary key auto_increment,nom_du_produit varchar(100),prix float,quantite int,total float,date date,signature_autorise varchar(150))");
           // rep = execute_command("create table vente (id int primary key auto_increment,nom_du_produit varchar(100))");
            rep = execute_command("create table panier (id int primary key auto_increment,nom_du_produit varchar(100),prix float,quantite int,date date)");
            rep = execute_command("create table paiement (id int primary key,caissier float,secretaire float,comptable float,manager float,gestionnaire float)");
            rep = execute_command("create table surplus (id int primary key auto_increment,nom_complet varchar(100),montant float,code_employer int,date date)");
            rep = execute_command("create table shorte (id int primary key auto_increment,nom_complet varchar(100),montant float,code_employer int,date date)");
            if (rep==0)
            {
                execute_command("insert into paiement(id,caissier,secretaire,comptable,manager,gestionnaire) values(1,0,0,0,0,0)");
            }
            rep = execute_command("create table log (id int,nom varchar(100),prenom varchar(100),username varchar(50),date date,heure varchar(10))");
            rep = execute_command("create table payroll (id int,employer varchar(100),salaire varchar(100),short int,surplus int)");
            rep = execute_command("create table payrollset (payroll int,mois int)");
            if (rep == 0)
            {
                execute_command("insert into payrollset(payroll,mois) values(0,"+DateTime.Now.Month.ToString()+")");
            }
            return rep;
        }
    }
}
