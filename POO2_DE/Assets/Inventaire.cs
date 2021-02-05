using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventaire : MonoBehaviour
{
        private static Inventaire _instance = null;

        public static Inventaire Instance
        {
            get
            {
                return _instance;
            }
        }

    public List<Item> IT = new List<Item>();

    void Awake()
    {
        _instance = this;
    }

    public void ShowStat()
    {
        foreach(Item i in IT)
        Debug.Log(" Equipement : Catégorie = " + i.categorie + "; " + "Nom = " + i.nom + "; " + "Attack = " + i.attack + "; " + "Defense = " + i.defence + "; " + "Durability = " + i.durability);
    }
}
