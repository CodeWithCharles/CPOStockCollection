using CPOAgenceCollection.Classes;
using System;
using System.Collections.Generic;

namespace CPOAgenceCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Agence agence = new Agence("Chat");

            Compte compte1 = new Compte(507706189, 123.7, "POULAIN", "Charles");
            Compte compte2 = new Compte(808120910, 9872.2, "LE RAZAVET", "Caroline");
            Compte compte3 = new Compte(195739565, "DENET", "Isabelle");
            Compte compteDummy = new Compte(1626047081, "DUFLAN", "Marc");

            agence.addCompte(compte1);
            agence.addCompte(compte2);
            agence.addCompte(compte3);

            Console.WriteLine("Agence : " + agence.getNom());
            foreach(Compte compte in agence.getComptes())
            {
                Console.WriteLine("\n" + compte.ToString());
            }

            Console.WriteLine("\nL'agence contient elle le compte " + compteDummy.ToString() + " ? : " + agence.containsCompte(compteDummy));
            Console.WriteLine("\nL'agence contient elle le compte " + compte1.ToString() + " ? : " + agence.containsCompte(compte1));

            Console.WriteLine("\nL'agence contient elle le compte de N°" + compteDummy.getNumero() + " ? : " + agence.containsNumCompte(compteDummy.getNumero()));
            Console.WriteLine("\nL'agence contient elle le compte de N°" + compte1.getNumero() + " ? : " + agence.containsNumCompte(compte1.getNumero()));

            Console.WriteLine("\nInformations du compte N°" + compte3.getNumero() + " :\n" + agence.getCompte(compte3.getNumero()).ToString());
        }
    }
}
