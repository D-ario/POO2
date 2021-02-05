using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Equipement : Item
{

    public virtual void AfficherInfos()
    {
        Debug.Log(" Equipement : Catégorie = " + categorie);
    }
}
