using Bunifu.UI.WinForms;
using BuyMore.model;
using BuyMore.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyMore.controllers
{
    class SurplusC
    {
        public static int saveSurplus(string fullName,string montant,string code_employer,string date, BunifuDataGridView table)
        {
            SurplusM sup = new SurplusM(fullName,code_employer,montant);
            int rep = SurplusV.saveSurplus(sup,date,table);
            return rep;
        }
        public static void showSurplus(BunifuDataGridView table)
        {
            SurplusV.showSurplus(table);
        }
    }
}
