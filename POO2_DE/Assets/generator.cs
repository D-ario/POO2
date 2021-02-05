using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour
{
    class Equipement
    {
        public string categorie;

        public virtual void AfficherInfos()
        {
            Debug.Log(" Equipement : Cat�gorie = " + categorie);
        }
    }

    class Offensifs : Equipement
    {
        public string nom;
        public int attack;
        public int defence;
        private int durability;

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
            Debug.Log(" Equipement : Cat�gorie = " + categorie + "; " + "Nom = " + nom + "; " + "Attack = " + attack + "; " + "Defense = " + defence + "; " + "Durability = " + durability) ;
        }
    }

    class D�fensifs : Equipement
    {
        public string nom;
        public int attack;
        public int defence;
        private int durability;

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
            Debug.Log(" Equipement : Cat�gorie = " + categorie + "; " + "Nom = " + nom + "; " + "Attack = " + attack + "; " + "Defense = " + defence + "; " + "Durability = " + durability);
        }
    }

    class Ressources
    {
        protected string _categorie;

        public Ressources(string categorie)
        {
            _categorie = categorie;
        }
    }

    class Bonus : Ressources
    {
        public string _nom;
        public int _attack;
        public int _defence;

        public Bonus(string categorie, string nom, int attack, int defence) : base(categorie)
        {
            _nom = nom;
            _attack = attack;
            _defence = defence;
            Debug.Log(" Ressources : Cat�gorie = " + categorie + "; " + "Nom = " + nom + "; " + "Attack = " + attack + "; " + "Defence = " + defence);
        }
    }

    class Malus : Ressources
    {
        public string _nom;
        public int _attack;
        public int _defence;

        public Malus(string categorie, string nom, int attack, int defence) : base(categorie)
        {
            _nom = nom;
            _attack = attack;
            _defence = defence;
            Debug.Log(" Ressources : Cat�gorie = " + categorie + "; " + "Nom = " + nom + "; " + "Attack = " + attack + "; " + "Defence = " + defence);
        }
    }

    //Generate stat
    public void generateEquip()
    {
        //setup class
        Equipement equipement = new Equipement();
        Offensifs offensifs = new Offensifs();
        D�fensifs d�fensifs = new D�fensifs();

        for(int i = 0; i<3;  i++)
        {
            //setup cat
            var GeneratorCat = GetComponent<RandomCategoryItem>();
            string categorieEquipe = GeneratorCat.GetRandomCatE();

            //setup name
            var GeneratorName = GetComponent<RandomNameItem>();
            string NameOff = GeneratorName.GetRandomCatO();
            string NameDef = GeneratorName.GetRandomCatD();

            if (categorieEquipe == "Offensif")
            {
                offensifs.categorie = categorieEquipe;
                offensifs.nom = NameOff;
                offensifs.attack = Random.Range(0, 25);
                offensifs.defence = Random.Range(0, 10);
                offensifs.Durability = Random.Range(1, 100);
                offensifs.AfficherInfos();
            }
            if (categorieEquipe == "Defensif")
            {
                d�fensifs.categorie = categorieEquipe;
                d�fensifs.nom = NameDef;
                d�fensifs.attack = Random.Range(0, 25);
                d�fensifs.defence = Random.Range(0, 10);
                d�fensifs.Durability = Random.Range(1, 100);
                d�fensifs.AfficherInfos();
            }
        }
    }

    public void generateRessource()
    {
        for (int i = 0; i < 3; i++)
        {
            //setup cat
            var GenratorCat = GetComponent<RandomCategoryItem>();
            string categorieRessources = GenratorCat.GetRandomCatR();

            //setup name
            var GeneratorName = GetComponent<RandomNameItem>();
            string NameBo = GeneratorName.GetRandomCatB();
            string NameMa = GeneratorName.GetRandomCatM();

            if (categorieRessources == "Bonus")
            {
                Bonus bonus = new Bonus(categorieRessources, NameBo, Random.Range(0, 25), Random.Range(0, 10));
            }
            if (categorieRessources == "Malus")
            {
                Malus malus = new Malus(categorieRessources, NameMa, Random.Range(-25, -1), Random.Range(-10, -1));
            }
        }
    }
}
