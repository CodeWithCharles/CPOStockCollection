using CPOStockCollection.Classes;
using System;
using System.Linq;

namespace CPOStockCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Item item1 = new Item("FEHE5F6Z1", "Planche de cèdre");
            Item item2 = new Item("WKAJFZKZO", "Stylos");
            Item item3 = new Item("PA5F6Z8WA", "Etain");
            Item item4 = new Item("WAPORJFNZ", "PCB vierges");
            Item item5 = new Item("FAKEFAKE4", "Article inexistant");

            Entrepot entrepot1 = new Entrepot("Entrepôt 1");
            Entrepot entrepot2 = new Entrepot("Entrepôt 2");

            entrepot1.addItem(item1, 5);
            entrepot1.addItem(item2);

            entrepot2.addItem(item3, 40);
            entrepot2.addItem(item4, 523);

            Console.WriteLine(entrepot1.ToString());
            Console.WriteLine(entrepot2.ToString());

            Console.WriteLine("\nL'item " + item5.getReference() + " existe dans l'entrepôt 1 : " + entrepot1.existItem(item5) + "\n");

            entrepot1.addQt(item1, 6);
            entrepot1.removeItem(item2);
            entrepot2.resetQt(item3);
            entrepot2.removeQt(item4, 3);

            Console.WriteLine(entrepot1);
            Console.WriteLine(entrepot2);
        }

        public static String RandomString(int length)
        {
            Random random = new Random();
            const String chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
