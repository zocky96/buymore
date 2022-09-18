using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyMore.model
{
    class PanierM
    {
        float prix;
        int quantite;
        String nom_du_produit;
        public PanierM(float prix, int quantite, String nom_du_produit)
        {
            this.prix = prix;
            this.quantite = quantite;
            this.nom_du_produit = nom_du_produit;
        }
        public String getNomDuProduit()
        {
            return this.nom_du_produit;
        }
        public float getPrix()
        {
            return this.prix;
        }
        public int getQuantite()
        {
            return this.quantite;
        }
        public void setQuantite(int quantite)
        {
            this.quantite = quantite;
        }
    }
}
