using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyMore.moule
{
    class LogM
    {
        string id,nom, prenom, user, date, heure;
        
        public LogM(string id, string nom, string prenom, string user, string date, string heure)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.user = user;
            this.date = date;
            this.heure = heure;
        }
        public string getId()
        {
            return this.id;
        }
        public string getNom()
        {
            return this.nom;
        }
        public string getPrenom()
        {
            return this.prenom;
        }
        public string getUser()
        {
            return this.user;
        }
        public string getDate()
        {
            return this.date;
        }
        public string getHeure()
        {
            return this.heure;
        }
    }
}
