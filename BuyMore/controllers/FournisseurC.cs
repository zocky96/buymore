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
    class FournisseurC
    {
        public static void searchFournisseur(String word, BunifuDataGridView table)
        {
            FournisseurV.searchFournisseur(word, table);
        }
        public static int saveFournisseur(String nom, String prenom, String telephone, String adresse, String nom_du_produit, BunifuDataGridView table)
        {
            FournisseurM fournisseur = new FournisseurM(nom,prenom,telephone,adresse,nom_du_produit);
            int rep = FournisseurV.saveFournisseur(fournisseur, table);
            return rep;
        }
        public static int modifyFournisseur(String nom, String prenom, String telephone, String adresse, String nom_du_produit, BunifuDataGridView table, String id)
        {
            FournisseurM fournisseur = new FournisseurM(nom, prenom, telephone, adresse, nom_du_produit);
            int rep = FournisseurV.modifyFournisseur(fournisseur, table, id);
            return rep;
        }
        public static int deleteFournisseur(BunifuDataGridView table, String id)
        {
            int rep = FournisseurV.deleteFournisseur(table, id);
            return rep;
        }
        public static void showFournisseur(BunifuDataGridView table)
        {
            FournisseurV.showFournisseur(table);
        }
    }
}
