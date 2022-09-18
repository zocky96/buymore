using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuTextbox;
using BuyMore.view;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyMore.controllers
{
    class PayrollC
    {
        public static void MakePayroll()
        {
            PayrollV.MakePayroll();
        }
        public static List<string> payrollSet()
        {
            return PayrollV.payrollSet();
        }
        public static void showPayroll(BunifuDataGridView table)
        {
            PayrollV.showPayroll(table);
        }
        public static void getPaiement(BunifuTextBox caissier, BunifuTextBox comptable, BunifuTextBox secretaire, BunifuTextBox gestionnaire, BunifuTextBox manager)
        {
            MySqlDataReader result = PayrollV.getPaiement();
            while (result.Read())
            {
                //table.Rows.Add(result["id"], result["nom_du_produit"], result["prix"], result["quantite"]);
                caissier.Text = result["caissier"].ToString();
                comptable.Text = result["comptable"].ToString();
                secretaire.Text = result["secretaire"].ToString();
                gestionnaire.Text = result["gestionnaire"].ToString();
                manager.Text = result["manager"].ToString();
            }
            
        }
        public static int modifyPaiement(String id, String caissier, String secretaire, String comptable, String manager, String gestionnaire)
        {
            int rep = PayrollV.modifyPaiement(id, caissier, secretaire, comptable, manager, gestionnaire);
            return rep;
        }

    }
}
