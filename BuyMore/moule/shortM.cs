using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyMore.model
{
    class shortM
    {
        
            String nom_complet, code_employer,montant;
            public shortM(String nom_complet, String code_employer, string montant)
            {
                this.nom_complet = nom_complet;
                this.code_employer = code_employer;
                this.montant = montant;

            }
            public String getFullName()
            {
                return this.nom_complet;
            }
            public String getCodeEmployer()
            {
                return this.code_employer;
            }
            public String getMontant()
            {
                return this.montant;
            }
        }
    
}
