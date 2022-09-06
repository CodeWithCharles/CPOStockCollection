using System;
using System.Collections.Generic;
using System.Text;

namespace CPOStockCollection.Classes
{
    public class Entrepot
    {
        #region Attributs
        private String nomEntrepot;
        private IDictionary<Item, int> stocks;
        #endregion

        #region Fonctions
        public int getCountItemType()
        {
            return this.stocks.Count;
        }

        public int getStockOfItem(Item item)
        {
            return this.stocks[item];
        }

        public Boolean existItem(Item item)
        {
            return this.stocks.ContainsKey(item);
        }

        public Item getItemRef(String reference)
        {
            Item returnItem = null;
            foreach(Item item in this.stocks.Keys)
            {
                if(item.getReference() == reference)
                {
                    returnItem = item;
                    break;
                }
            }
            return returnItem;
        }

        public override String ToString()
        {
            String output = this.nomEntrepot + "\n";
            foreach(KeyValuePair<Item, int> entry in this.stocks)
            {
                output += "\n" + entry.Key.ToString() + " : " + entry.Value;
            }
            return output;
        }
        #endregion

        #region Méthodes
        public Entrepot(String nomEntrepot)
        {
            this.nomEntrepot = nomEntrepot;
            this.stocks = new Dictionary<Item, int>();
        }

        public void addItem(Item item, int qt = 0)
        {
            this.stocks.Add(item, qt);
        }

        public void removeItem(Item item)
        {
            this.stocks.Remove(item);
        }

        public void addQt(Item item, int qt)
        {
            this.stocks[item] += qt;
        }

        public void removeQt(Item item, int qt)
        {
            this.stocks[item] -= qt;
        }

        public void resetQt(Item item)
        {
            this.stocks[item] = 0;
        }
        #endregion
    }
}
