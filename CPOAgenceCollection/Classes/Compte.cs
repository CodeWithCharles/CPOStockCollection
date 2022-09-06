using System;
using System.Collections.Generic;
using System.Text;

namespace CPOAgenceCollection.Classes
{
    class Compte
    {
        #region Attributs
        private int numero;
        private Double solde;
        private String nom;
        private String prenom;
        #endregion

        #region Fonctions
        public int getNumero()
        {
            return this.numero;
        }

        public Double getSolde()
        {
            return this.getSolde();
        }

        public String getTitulaire()
        {
            return this.nom + " " + this.prenom;
        }

        public override String ToString()
        {
            return "N° compte : " + this.numero + "\n" + this.getTitulaire() + "\nSolde : " + this.solde.ToString() + "euros";
        }
        #endregion

        #region Méthodes
        public Compte(int numero, String nom, String prenom)
        {
            this.numero = numero;
            this.solde = 0;
            this.nom = nom;
            this.prenom = prenom;
        }

        public Compte(int numero, Double solde, String nom, String prenom)
        {
            this.numero = numero;
            this.solde = solde;
            this.nom = nom;
            this.prenom = prenom;
        }

        public void reduceSolde(Double amount)
        {
            this.solde = this.solde - amount;
        }

        public void addSolde(Double amount)
        {
            this.solde = this.solde + amount;
        }
        #endregion
    }
}
