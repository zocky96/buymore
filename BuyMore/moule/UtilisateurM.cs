using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyMore.model
{
    class UtilisateurM
    {
        private string nom, prenom, username, password, code_employer;
        public UtilisateurM(string nom,String prenom,String username,String password,String code_employer)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.username = username;
            this.password = password;
            this.code_employer = code_employer;
        }
        public String getNom()
        {
            return this.nom;
        }
        public String getCodeEmployer()
        {
            return this.code_employer;
        }
        public String getPrenom()
        {
            return this.prenom;
        }
        public String getUsername()
        {
            return this.username;
        }
        public String getPassword()
        {
            return this.password;
        }


    }
}
