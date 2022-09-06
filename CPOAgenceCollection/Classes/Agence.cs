using System;
using System.Collections.Generic;
using System.Text;

namespace CPOAgenceCollection.Classes
{
    class Agence
    {
        #region Attributs
        private String nom;
        private List<Compte> comptes;
        #endregion

        #region Fonctions
        public int getNbCompte()
        {
            return this.comptes.Count;
        }

        public Boolean containsNumCompte(int numCompte)
        {
            Boolean exist = false;
            foreach(Compte compte in this.comptes)
            {
                if(compte.getNumero() == numCompte)
                {
                    exist = true;
                    break;
                }
            }
            return exist;
        }

        public Boolean containsCompte(Compte compte)
        {
            return this.comptes.Contains(compte);
        }

        public Compte getCompte(int numero)
        {
            Compte compteTrouve = null;
            foreach(Compte compte in this.comptes)
            {
                if(compte.getNumero() == numero)
                {
                    compteTrouve = compte;
                    break;
                }
            }
            return compteTrouve;
        }

        public String getNom()
        {
            return this.nom;
        }

        public List<Compte> getComptes()
        {
            return this.comptes;
        }
        #endregion

        #region Méthodes
        public Agence(String nom)
        {
            this.nom = nom;
            this.comptes = new List<Compte>();
        }

        public void setNom(String nom)
        {
            this.nom = nom;
        }

        public void addCompte(Compte compte)
        {
            this.comptes.Add(compte);
        }
        #endregion
    }
}
