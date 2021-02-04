using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour
{

    class Equipement
    {
        public string categorie;

        public void AfficherInfos()
        {
            Debug.Log(" Equipement : Cat�gorie = " + categorie);
        }
    }

    class Offensifs : Equipement
    {
        public string nom;
        public int attack;
        public int defense;

        public void AfficherInfos()
        {
            Debug.Log(" Equipement : Nom = " + nom);
            Debug.Log(" Equipement : Attack = " + attack);
            Debug.Log(" Equipement : Defense = " + defense);
        }
    }

    class D�fensifs : Equipement
    {
        public string nom;
        public int attack;
        public int defense;

        public void AfficherInfos()
        {
            Debug.Log(" Equipement : Nom = " + nom);
            Debug.Log(" Equipement : Attack = " + attack);
            Debug.Log(" Equipement : Defense = " + defense);
        }
    }

    class Ressources
    {
        public string categorie;

        public void AfficherInfos()
        {
            Debug.Log(" Ressources : Cat�gorie = " + categorie);
        }
    }

    class Bonus : Ressources
    {
        public string nom;
        public int attack;
        public int defense;

        public void AfficherInfos()
        {
            Debug.Log(" Ressources : Nom = " + nom);
            Debug.Log(" Ressources : Attack = " + attack);
            Debug.Log(" Ressources : Defense = " + defense);
        }
    }

    class Malus : Ressources
    {
        public string nom;
        public int attack;
        public int defense;

        public void AfficherInfos()
        {
            Debug.Log(" Ressources : Nom = " + nom);
            Debug.Log(" Ressources : Attack = " + attack);
            Debug.Log(" Ressources : Defense = " + defense);
        }
    }


    public void generateEquip()
    {
        Equipement equipement = new Equipement();
        Offensifs offensifs = new Offensifs();
        D�fensifs d�fensifs = new D�fensifs();

        var GeneratorCat = GetComponent<RandomCategoryItem>();
        string categorieEquipe = GeneratorCat.GetRandomCatE();

        var GeneratorName = GetComponent<RandomNameItem>();
        string NameOff = GeneratorName.GetRandomCatO();
        string NameDef = GeneratorName.GetRandomCatD();

        equipement.categorie = categorieEquipe;
        equipement.AfficherInfos();

        if (categorieEquipe == "Offensif")
        {
            offensifs.nom = NameOff;
            offensifs.attack = Random.Range(0, 25);
            offensifs.defense = Random.Range(0, 10);
            offensifs.AfficherInfos();
        }
        if(categorieEquipe == "Defensif")
        {
            d�fensifs.nom = NameDef;
            d�fensifs.attack = Random.Range(0, 25);
            d�fensifs.defense = Random.Range(0, 10);
            d�fensifs.AfficherInfos();
        }
    }

    public void generateRessource()
    {
        Ressources ressources = new Ressources();
        Bonus bonus = new Bonus();
        Malus malus = new Malus();

        var GenratorCat = GetComponent<RandomCategoryItem>();
        string categorieRessources = GenratorCat.GetRandomCatR();

        var GeneratorName = GetComponent<RandomNameItem>();
        string NameBo = GeneratorName.GetRandomCatB();
        string NameMa = GeneratorName.GetRandomCatM();

        ressources.categorie = categorieRessources;
        ressources.AfficherInfos();

        if(categorieRessources == "Bonus")
        {
            bonus.nom = NameBo;
            bonus.attack = Random.Range(0, 25);
            bonus.defense = Random.Range(0, 10);
            bonus.AfficherInfos();
        }
        if(categorieRessources == "Malus")
        {
            malus.nom = NameMa;
            malus.attack = Random.Range(-25, -1);
            malus.defense = Random.Range(-10, -1);
            malus.AfficherInfos();
        }
    }
}
