using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Offensifs : Equipement
{

    public int Durability
    {
        get
        {
            return durability;
        }

        set
        {
            durability = value;
        }
    }

    public override void AfficherInfos()
    {
        Debug.Log(" Equipement : Catégorie = " + categorie + "; " + "Nom = " + nom + "; " + "Attack = " + attack + "; " + "Defense = " + defence + "; " + "Durability = " + durability);
    }
}
