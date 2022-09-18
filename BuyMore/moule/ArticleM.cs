using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyMore.model
{
    class ArticleM
    {
        String nom,type,fournisseur;
        float prix;
        int quantite;
        public ArticleM(String nom, float prix, int quantite, String type, String fournisseur)
        {
            this.nom = nom;
            this.prix = prix;
            this.quantite = quantite;
            this.type = type;
            this.fournisseur = fournisseur;
        }
        public String getNom()
        {
            return this.nom;
        }
        public float getPrix()
        {
            return this.prix;
        }
        public int getQuantite()
        {
            return this.quantite;
        }
        public String getType()
        {
            return this.type;
        }
        public String getFournisseur()
        {
            return this.fournisseur;
        }
    }
}
