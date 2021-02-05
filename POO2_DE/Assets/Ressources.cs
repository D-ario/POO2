using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Ressources : Item
{

    public Ressources(string _categorie, string _nom, int _attack, int _defence)
    {
        categorie = _categorie;
        nom = _nom;
        attack = _attack;
        defence = _defence;
    }
}
