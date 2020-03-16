using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perchaselog : MonoBehaviour
{
    public GameObject Autononcookie;
    public GameObject Autosell;
    public GameObject Pathway1;
    public GameObject Pathway2;

    public void StartAutononcookie1()
    {
        Pathway2.SetActive(false);
        Autononcookie.SetActive(true);
        Globalcash.Countcash -= GlobalBaker.bakervalue;
        GlobalBaker.bakervalue *= 3;
        GlobalBaker.turnoffbutton = true;
        GlobalBaker.bakepersec += 1;
        GlobalBaker.numofbakers += 1;
        
    }
    public void StartAutononcookie2()
    {
        Pathway1.SetActive(false);
        Autononcookie.SetActive(true);
        Globalcash.Countcash -= GlobalBaker2.bakervalue;
        GlobalBaker2.bakervalue *= 2;
        GlobalBaker2.turnoffbutton = true;
        GlobalBaker2.bakepersec += 1;
        GlobalBaker2.numofbakers += 1;
        
    }
    public void StartAutosell()
    {
        Autosell.SetActive(true);
        Globalcash.Countcash -= GlobalShop.shopvalue;
        GlobalShop.shopvalue *= 3;
        GlobalShop.turnoffbutton = true;
        GlobalShop.shoppersec += 1;
        GlobalShop.numofshops += 1;
    }
}
