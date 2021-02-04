# -*- coding: UTF-8 -*-
"""Listes : methodes et indicage."""
# fichier : GestionDeListe.py
# auteur : ENI Ecole
# programme principal -----------------------------------------------
liste = [17, 38, 10, 25, 72]
print(" Liste initiale ".center(50, '-'))
print(liste, '\n\n')

print(" Liste triée par ordre croissant  ".center(50, '-'))
liste.sort()
print(liste, '\n\n')

print(" Ajout de la valeur 12 ".center(50, '-'))
liste.append(12)
liste.sort()
print(liste, '\n\n')

print(" Indice de 17 ".center(50, '-'))
print(liste.index(17), '\n\n')

print(" Retrait de 38 ".center(50, '-'))
liste.remove(38)
print(liste, '\n\n')

print(" Sous-liste du 2ème au 3ème élément ".center(50, '-'))
print(liste[1:3])
