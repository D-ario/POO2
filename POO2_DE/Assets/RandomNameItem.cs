using UnityEngine;

public class RandomNameItem : MonoBehaviour
{
    string[] NameOffensif = new string[] { "Sagaie", "Arc", "Sarbacane", "Lance", "Fusil", "Matraque ", "Nuke" };
    string[] NameDefensif = new string[] { "Casque", "Gorgerin", "Cuirasse", "Braconnière", "Tassets", "Haubert", "Brigandine", "Surcot",};
    string[] NameBonus = new string[] { "Vitesse", "Force", };
    string[] NameMalus = new string[] { "Attack", "Defence", };

    public string GetRandomCatO()
    {
        int Nameoff = Random.Range(0, NameOffensif.Length);

        string itemNameO = NameOffensif[Nameoff];

        return itemNameO;
    }

    public string GetRandomCatD()
    {
        int Namedef = Random.Range(0, NameDefensif.Length);

        string itemNameD = NameDefensif[Namedef];

        return itemNameD;
    }

    public string GetRandomCatB()
    {
        int NameBo = Random.Range(0, NameBonus.Length);

        string itemNameB = NameBonus[NameBo];

        return itemNameB;
    }

    public string GetRandomCatM()
    {
        int NameMa = Random.Range(0, NameMalus.Length);

        string itemNameM = NameMalus[NameMa];

        return itemNameM;
    }
}
