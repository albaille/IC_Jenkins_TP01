using System;
using System.Collections.Generic;

namespace IC_Jenkins_TP01_C_
{
    public class GestionDeListe
    {
        public static void Affiche(List<int> liste){
            Console.Write("[");
            int i;
            for (i = 0; i < liste.Count - 1; i++)
            {
                Console.Write(liste[i] + ", ");
            }
            Console.Write(liste[i] + "]\n\n");
        }
        public static void Main()
        {
            // Listes : methodes et indicage.
		// fichier : GestionDeListe.java
		// auteur : ENI Ecole
		// programme principal -----------------------------------------------
		List<int> liste = new List<int>();
        liste.Add(17);
		liste.Add(38);
		liste.Add(10);
		liste.Add(25);
		liste.Add(72);
		Console.WriteLine("----------------- Liste initiale -----------------");
		Affiche(liste);

		Console.WriteLine("-------- Liste triée par ordre croissant --------");
		liste.Sort();
		Affiche(liste);

		Console.WriteLine("------------- Ajout de la valeur 12 -------------");
		liste.Add(12);
		liste.Sort();
		Affiche(liste);

		Console.WriteLine("------------------ Indice de 17 ------------------");
		Console.WriteLine(liste.IndexOf(17));
		Console.WriteLine("\n");

		Console.WriteLine("----------------- Retrait de 38 -----------------");
		liste.Remove(38);
		Affiche(liste);

		Console.WriteLine("------- Sous-liste du 2ème au 3ème élément -------");
		List<int> subList = liste.GetRange(1,2);
        Affiche(subList);
        }
    }
}