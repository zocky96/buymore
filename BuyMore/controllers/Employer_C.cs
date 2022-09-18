using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using BuyMore.model;
using BuyMore.view;
using MySql.Data.MySqlClient;

namespace BuyMore.controllers
{
    class Employer_C
    {
        public Employer_C()
        {

        }
        public static void getAllCaissier(ComboBox caissier)
        {
            MySqlDataReader result = EmployerV.getAllCaissier();
            while(result.Read())
            {
                caissier.Items.Add(result["nom_complet"].ToString());
            }
        }
        public static int deleteEmployer(String id,BunifuDataGridView table)
        {
            int rep = EmployerV.deleteEmployer(id, table);
            return rep;
        }
        public static int ifCodeEmployerExiste(String code)
        {
            int rep = -110;
            rep = EmployerV.ifCodeEmployerExiste(code);
            return rep;
        }
        public static List<String> getNameAndFirstnameById(String id)
        {
            List<String> liste=new List<string>();
            liste = EmployerV.getNameAndFirstnameById(id);
            
            return liste;
        }
        public static int restaureEmployer(String nom, String prenom, String nif, String sexe, String adresse, String date_de_naissance, String poste, BunifuDataGridView table,String id)
        {
            employer emplo = new employer(nom, prenom, nif, sexe, adresse, date_de_naissance, poste);
            int rep = EmployerV.restaureEmployer(id,emplo,table);
            return rep;
        }
        public static int saveEmployer(String nom, String prenom, String nif, String sexe, String adresse, String date_de_naissance, String poste, BunifuDataGridView table)
        {
            employer emplo = new employer(nom, prenom, nif, sexe, adresse, date_de_naissance, poste);
            int rep = EmployerV.saveEmployer(emplo,table);
            return rep;
        }
        public static int deletedEmployer(String nom, String prenom, String nif, String sexe, String adresse, String date_de_naissance, String poste, BunifuDataGridView table)
        {
            employer emplo = new employer(nom, prenom, nif, sexe, adresse, date_de_naissance, poste);
            int rep = EmployerV.deletedEmployer(emplo, table);
            return rep;
        }
        public static void searchEmployer(String word, BunifuDataGridView table)
        {
            EmployerV.searchEmployer(word, table);
            
        }
        public static int modifyEmployer(String nom, String prenom, String nif, String sexe, String adresse, String date_de_naissance, String poste, BunifuDataGridView table,String id)
        {
            employer emplo = new employer(nom, prenom, nif, sexe, adresse, date_de_naissance, poste);
            int rep = EmployerV.modifyEmployer(emplo, table, id);
            return rep;
        }
        public static void showEmployer(BunifuDataGridView table)
        {
            
            EmployerV.showEmployer(table);
        }
        public static void showDeletedEmployer(BunifuDataGridView table)
        {

            EmployerV.showDeletedEmployer(table);
        }
    }
}
