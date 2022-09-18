using Bunifu.UI.WinForms;
using BuyMore.controllers;
using BuyMore.db;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyMore.view
{
    class PayrollV
    {
        public static MySqlDataReader getPaiement()
        {

            
            MySqlDataReader result = dbConfig.getResultCommand("select * from paiement");


            
            return result;
        }
        public static void MakePayroll()
        {
            int day = DateTime.Now.Day;
            if (day >= 23)
            {
                string id, poste,fullName=null;
                int montant_short = 0, montant_surplus = 0, reste = 0, paiement = 0, the_reste = 0,salaire =0;
                MySqlDataReader shorte, surplus, paiement_;
                MySqlDataReader result = dbConfig.getResultCommand("select id,poste from employer");
                while (result.Read())
                {
                    id = result["id"].ToString();
                    poste = result["poste"].ToString();
                    shorte = dbConfig.getResultCommand("select montant from shorte where code_employer='" + id + "'");
                    while (shorte.Read())
                    {
                        montant_short += int.Parse(shorte["montant"].ToString());
                        surplus = dbConfig.getResultCommand("select montant from surplus where code_employer='" + id + "'");
                        while(surplus.Read())
                        {
                            
                            montant_surplus += int.Parse(surplus["montant"].ToString());
                            
                        }
                        
                        if (montant_surplus > montant_short)
                        {
                            reste = montant_surplus - montant_short;
                        }
                        else
                        {
                            reste = montant_short - montant_surplus;
                            
                        }
                        paiement_ = dbConfig.getResultCommand("select " + poste + " from paiement where id=1");
                        //MessageBox.Show(poste.ToString());
                        while (paiement_.Read())
                        {
                            salaire = int.Parse(paiement_[poste].ToString());
                           // MessageBox.Show(salaire.ToString());
                        }
                        the_reste = salaire - reste;
                        //MessageBox.Show(salaire.ToString());
                        List<String> liste = new List<string>();
                        liste = Employer_C.getNameAndFirstnameById(id);
                        fullName = liste[0] +" "+ liste[1];
                       // MessageBox.Show(fullName);
                        
                    }
                    //MessageBox.Show(id);
                    int rep = dbConfig.execute_command("insert into payroll(id,employer,salaire,short,surplus) values('" + id + "','" + fullName + "','" + the_reste + "','" + montant_short + "','" + montant_surplus + "')");
                    montant_short = 0;
                    montant_surplus = 0;
                    reste = 0;
                    paiement = 0;
                    the_reste = 0;
                    salaire = 0;
                }
                int repns = dbConfig.execute_command("update payrollset set payroll=1,mois=" + DateTime.Now.Month.ToString());
                repns = dbConfig.execute_command("delete from shorte");
                repns = dbConfig.execute_command("delete from surplus");
            }
            
        }
        public static List<string> payrollSet()
        {
            List<string> liste = new List<string>();
            MySqlDataReader result = dbConfig.getResultCommand("select * from payrollset");
            try
            {
                while(result.Read())
                {
                    liste.Add(result["payroll"].ToString());
                    liste.Add(result["mois"].ToString());
                }
            }
            catch
            {

            }
            return liste;
        }

        public static void showPayroll(BunifuDataGridView table)
        {

            table.Rows.Clear();
            int day = DateTime.Now.Day;
            if (day > 25)
            {
                MySqlDataReader result = dbConfig.getResultCommand("select * from payroll");
                try
                {
                    while (result.Read())
                    {

                        table.Rows.Add(result["id"], result["employer"], result["salaire"], result["short"], result["surplus"]);

                    }
                }
                catch
                {

                }
            }
               

        }
        public static int modifyPaiement(String id,String caissier,String secretaire,String comptable,String manager,String gestionnaire)
        {

            int rep = dbConfig.execute_command("update paiement set caissier='" + caissier + "',secretaire='" + secretaire + "',comptable='" + comptable + "',manager='" + manager + "',gestionnaire='" + gestionnaire + "' where id='" + id + "'");
           
            return rep;
        }
    }
}
