using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perchaselog : MonoBehaviour
{
    public GameObject Autononcookie;
    public GameObject Autosell;

    public void StartAutononcookie()
    {
        Autononcookie.SetActive(true);
        Globalcash.Countcash -= GlobalBaker.bakervalue;
        GlobalBaker.bakervalue *= 2;
        GlobalBaker.turnoffbutton = true;
        GlobalBaker.bakepersec += 1;
        GlobalBaker.numofbakers += 1;
    }
    public void StartAutosell()
    {
        Autosell.SetActive(true);
        Globalcash.Countcash -= GlobalShop.shopvalue;
        GlobalShop.shopvalue *= 2;
        GlobalShop.turnoffbutton = true;
        GlobalShop.shoppersec += 1;
        GlobalShop.numofshops += 1;
    }
}
