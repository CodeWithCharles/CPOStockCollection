using System;
using System.Collections.Generic;
using System.Text;

namespace CPOStockCollection.Classes
{
    public class Item
    {
        #region Attributs
        private String reference;
        private String nom;
        #endregion

        #region Fonctions
        public String getNom()
        {
            return this.nom;
        }

        public String getReference()
        {
            return this.reference;
        }

        public override string ToString()
        {
            return this.reference + " -> " + this.nom;
        }
        #endregion

        #region Méthodes
        public Item(String nom)
        {
            this.nom = nom;
            this.reference = Program.RandomString(9);
        }

        public Item(String reference, String nom)
        {
            this.reference = reference;
            this.nom = nom;
        }
        #endregion
    }
}
