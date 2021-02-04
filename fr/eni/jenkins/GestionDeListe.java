package fr.eni.jenkins;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class GestionDeListe {

	public static void main(String[] args) {
		// Listes : methodes et indicage.
		// fichier : GestionDeListe.java
		// auteur : ENI Ecole
		// programme principal -----------------------------------------------
		List<Integer> liste = new ArrayList<>();
		liste.add(17);
		liste.add(38);
		liste.add(10);
		liste.add(25);
		liste.add(72);
		System.out.println("----------------- Liste initiale -----------------");
		System.out.println(liste);
		System.out.println("\n");

		System.out.println("-------- Liste triée par ordre croissant --------");
		Collections.sort(liste);
		System.out.println(liste);
		System.out.println("\n");

		System.out.println("------------- Ajout de la valeur 12 -------------");
		liste.add(12);
		Collections.sort(liste);
		System.out.println(liste);
		System.out.println("\n");

		System.out.println("------------------ Indice de 17 ------------------");
		System.out.println(liste.indexOf(17));
		System.out.println("\n");

		System.out.println("----------------- Retrait de 38 -----------------");
		Integer val = 38;
		liste.remove(val);
		System.out.println(liste);
		System.out.println("\n");

		System.out.println("------- Sous-liste du 2ème au 3ème élément -------");

		System.out.println(liste.subList(1, 3));
	}
}
