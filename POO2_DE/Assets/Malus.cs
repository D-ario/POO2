using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Malus : Ressources
{
    public Malus(string categorie, string nom, int attack, int defence) : base(categorie, nom, attack, defence)
    {
        //Debug.Log(" Ressources : Catégorie = " + categorie + "; " + "Nom = " + nom + "; " + "Attack = " + attack + "; " + "Defence = " + defence);
    }
}
