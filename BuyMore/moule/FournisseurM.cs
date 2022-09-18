using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyMore.model
{
    class FournisseurM
    {
        String nom, prenom, telephone, adresse, nom_du_produit;
        public FournisseurM(String nom, String prenom, String telephone, String adresse, String nom_du_produit)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.telephone = telephone;
            this.adresse = adresse;
            this.nom_du_produit = nom_du_produit;
        }
        public String getNom()
        {
            return this.nom;
        }
        public String getPrenom()
        {
            return this.prenom;
        }
        public String getTelephone()
        {
            return this.telephone;
        }
        public String getAdresse()
        {
            return this.adresse;
        }
        public String getNomDuProduit()
        {
            return this.nom_du_produit;
        }
    }
}
