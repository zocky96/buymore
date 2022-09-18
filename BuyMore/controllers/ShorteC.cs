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
    class ShorteC
    {
        public static int saveShorte(string fullName, string montant, string code_employer, string date, BunifuDataGridView table)
        {
            shortM sho = new shortM(fullName, code_employer, montant);
            int rep = ShorteV.saveShorte(sho, date, table);
            return rep;
        }
        public static void showShorte(BunifuDataGridView table)
        {
            ShorteV.showShorte(table);
        }
    }
}
