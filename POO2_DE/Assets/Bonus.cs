using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Bonus : Ressources
{
    public Bonus(string categorie, string nom, int attack, int defence) : base(categorie, nom, attack, defence)
    {
        //Debug.Log(" Ressources : Cat�gorie = " + categorie + "; " + "Nom = " + nom + "; " + "Attack = " + attack + "; " + "Defence = " + defence);
    }
}