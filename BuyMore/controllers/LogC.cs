using Bunifu.UI.WinForms;
using BuyMore.model;
using BuyMore.moule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyMore.controllers
{
    class LogC
    {
        public static int saveLog(string id,string nom, string prenom, string user, string date, string heure)
        {
            LogM log = new LogM(id, nom, prenom, user, date, heure);
            int rep = LogMo.saveLog(log);
            return rep;
        }
        public static List<string> getInfoByUserName(string username)
        {
            return LogMo.getInfoByUserName(username);
        }
        public static void showLog(BunifuDataGridView table)
        {
            LogMo.showLog(table);
        }


    }
}
