using UnityEngine;

public class RandomCategoryItem : MonoBehaviour
{
    string[] CatEquipement = new string[] { "Offensif", "Defensif" };
    string[] CatRessources = new string[] { "Bonus", "Malus" };

    public string GetRandomCatE()
    {
        int catEquip = Random.Range(0, CatEquipement.Length);

        string itemCatE = CatEquipement[catEquip];

        return itemCatE;
    }

    public string GetRandomCatR()
    {
        int catRes = Random.Range(0, CatRessources.Length);

        string itemCatR = CatRessources[catRes];

        return itemCatR;
    }
}
