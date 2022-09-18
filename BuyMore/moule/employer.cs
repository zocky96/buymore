using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyMore.model
{
    class employer
    {
        String nom, prenom, nif, sexe, adresse, date_de_naissance, poste;
        public employer(String nom,String prenom,String nif,String sexe,String adresse,String date_de_naissance,String poste)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.nif = nif;
            this.sexe = sexe;
            this.adresse = adresse;
            this.date_de_naissance = date_de_naissance;
            this.poste = poste;
        }
        public String getNom()
        {
            return this.nom;
        }
        public String getPrenom()
        {
            return this.prenom;
        }
        public String getNif()
        {
            return this.nif;
        }
        public String getSexe()
        {
            return this.sexe;
        }
        public String getAdresse()
        {
            return this.adresse;
        }
        public String getDateDeNaissance()
        {
            return this.date_de_naissance;
        }
        public String getPoste()
        {
            return this.poste;
        }
    }
}
