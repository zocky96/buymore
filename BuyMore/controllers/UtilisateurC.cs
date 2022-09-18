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
    class UtilisateurC
    {
        public static void searchUser(String word, BunifuDataGridView table)
        {
            UtilisateurV.searchUser(word, table);
        }
        public static int login(String username,String password)
        {
            MySqlDataReader result = UtilisateurV.login(username, password);
            int rep = -100;
            String nom_complet = null,nom=null,prenom=null,poste=null;
            while (result.Read())
            {

                rep = int.Parse(result["reponse"].ToString());
                nom_complet = result["nom_complet"].ToString();
                nom = result["nom"].ToString();
                prenom = result["prenom"].ToString();

            }
            if (rep > 0)
            {
                result = EmployerV.getPoste(nom, prenom);
                while (result.Read())
                {
                    poste = result["poste"].ToString();
                }
                main.poste = poste;
                

                if (poste=="caissier")
                {
                    main.vente.Enabled = true;
                    DashBoard.sale.Enabled = true;
                    main.utilisateur.Enabled = true;
                    DashBoard.user.Enabled = true;
                    main.panier.Enabled = true;
                    
                }
                if (poste== "gestionnaire de stock")
                {
                    DashBoard.article.Enabled = true;
                    DashBoard.fournisseur.Enabled = true;
                    main.article.Enabled = true;
                    main.fournisseur.Enabled = true;
                    main.utilisateur.Enabled = true;
                    DashBoard.user.Enabled = true;
                }
                if(poste=="secretaire")
                {
                    main.employer.Enabled = true;
                    DashBoard.employer.Enabled = true;
                    main.utilisateur.Enabled = true;
                    DashBoard.user.Enabled = true;
                }
                if (poste == "comptable")
                {
                    main.article.Enabled = true;
                    DashBoard.article.Enabled = true;
                    main.payroll.Enabled = true;
                    DashBoard.payroll.Enabled = true;
                    main.utilisateur.Enabled = true;
                    DashBoard.user.Enabled = true;
                }
                if (poste == "manager")
                {
                    main.article.Enabled = true;
                    DashBoard.article.Enabled = true;
                    main.employer.Enabled = true;
                    DashBoard.employer.Enabled = true;
                    main.fournisseur.Enabled = true;
                    DashBoard.fournisseur.Enabled = true;
                    main.vente.Enabled = true;
                    DashBoard.sale.Enabled = true;
                    main.payroll.Enabled = true;
                    DashBoard.payroll.Enabled = true;
                    main.panier.Enabled = true;
                    main.utilisateur.Enabled = true;
                    DashBoard.user.Enabled = true;
                    main.rapport.Enabled = true;
                    main.log_.Enabled = true;
                }
                //if(poste != "caissier" || poste != "gestionnaire de stock" || poste != "secretaire" || poste != "comptable" || poste != "manager")
                //{
                //    main.article.Enabled = false;
                //    DashBoard.article.Enabled = false;
                //    main.employer.Enabled = false;
                //    DashBoard.employer.Enabled = false;
                //    main.fournisseur.Enabled = false;
                //    DashBoard.fournisseur.Enabled = false;
                //    main.vente.Enabled = false;
                //    DashBoard.sale.Enabled = false;
                //    main.payroll.Enabled = false;
                //    DashBoard.payroll.Enabled = false;
                //    main.panier.Enabled = true;
                //    main.utilisateur.Enabled = false;
                //    DashBoard.user.Enabled = false;
                //    main.rapport.Enabled = false;
                //}
                
                
                main.the_name.Text = nom_complet.ToString();
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public static int saveUser(string nom, String prenom, String username, String password, String code_employer, BunifuDataGridView table)
        {
            UtilisateurM user = new UtilisateurM(nom, prenom, username, password,code_employer);
            int rep = UtilisateurV.saveUser(user, table);
            return rep;
        }
        public static int modifyUser(String username, String password, BunifuDataGridView table,String id)
        {
            UtilisateurM user = new UtilisateurM("", "", username, password, "");
            int rep = UtilisateurV.modifyUser(user, table,id);
            return rep;
        }
        public static int ifCodeEmployerExiste(String code)
        {
            int rep = -110;
            rep = UtilisateurV.ifCodeEmployerExiste(code);
            return rep;
        }
        public static int ifUserEmployerExiste(String user)
        {
            int rep = -110;
            rep = UtilisateurV.ifUserEmployerExiste(user);
            return rep;
        }
        public static int deleteUser(BunifuDataGridView table, String id)
        {
            int rep = UtilisateurV.deleteUser(table, id);
            return rep;
        }
        public static void showUser(BunifuDataGridView table)
        {
            UtilisateurV.showUser(table);
        }
    }
}
