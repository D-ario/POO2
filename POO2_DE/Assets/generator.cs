using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour
{

    //Generate stat
    public void generateEquip()
    {

        for(int i = 0; i<3;  i++)
        {
            //setup class
            Offensifs offensifs = new Offensifs();
            Defensifs defensifs = new Defensifs();

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
                //offensifs.AfficherInfos();

                Inventaire.Instance.IT.Add(offensifs);
            }
            if (categorieEquipe == "Defensif")
            {
                defensifs.categorie = categorieEquipe;
                defensifs.nom = NameDef;
                defensifs.attack = Random.Range(0, 25);
                defensifs.defence = Random.Range(0, 10);
                defensifs.Durability = Random.Range(1, 100);
                //defensifs.AfficherInfos();

                Inventaire.Instance.IT.Add(defensifs);
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
                Inventaire.Instance.IT.Add(bonus);
            }
            if (categorieRessources == "Malus")
            {
                Malus malus = new Malus(categorieRessources, NameMa, Random.Range(-25, -1), Random.Range(-10, -1));
                Inventaire.Instance.IT.Add(malus);
            }
        }
    }

    public void show()
    {
        Inventaire.Instance.ShowStat();
    }
}