using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Perchaselog : MonoBehaviour
{
    public GameObject Autononcookie;
    public GameObject Autosell;
    public GameObject Pathway1;
    public GameObject Pathway2;
    public AudioSource Up1;
    public AudioSource Up2;

    public static int barcount = 5;
    
    public static bool havebaker = false;
    public static bool haveshop = false;
    public static int baker = 0;
    public static int shop = 0;

    public void Start()
    {
        Up1 = GetComponent<AudioSource>();
        Up2 = GetComponent<AudioSource>();
    }

    public void Update()
    {
        if (havebaker == true)
        {
            if (baker > 0)
            {

            }
            else
            {
                baker += 1;
            }
                
        }

        if (haveshop == true)
        {
            if (shop > 0)
            {

            }
            else
            {
                shop += 1;
            }
        }

        if (baker == 1)
        {
            Autononcookie.SetActive(true);
        }

        if (shop == 1)
        {
            Autosell.SetActive(true);
        }
    }

    public void StartAutononcookie1()
    {
        //Pathway2.SetActive(false);
        Autononcookie.SetActive(true);
        
        Up1.Play();
        Globalcash.Countcash -= GlobalBaker.bakervalue;
        GlobalBaker.bakervalue *= 3;
        GlobalBaker2.bakervalue *= 2;
        GlobalBaker.turnoffbutton = true;
        GlobalBaker.bakepersec += 1;
        GlobalBaker.numofbakers += 1;
        GlobalBaker.allbakers += 1;
        GlobalBaker.fullbps += 1;
        barcount += 1;
        havebaker = true;
        
    }
    public void StartAutononcookie2()
    {
        //Pathway1.SetActive(false);
        Autononcookie.SetActive(true);
        Up2.Play();
        Globalcash.Countcash -= GlobalBaker2.bakervalue;
        GlobalBaker.bakervalue *= 3;
        GlobalBaker2.bakervalue *= 2;
        GlobalBaker2.turnoffbutton = true;
        GlobalBaker2.numofbakers += 1;
        GlobalBaker2.bakepersec += 1;
        GlobalBaker.allbakers += 1;
        GlobalBaker.fullbps += 1;
        barcount -= 1;
        havebaker = true;
    }
    public void StartAutosell1()
    {
        Autosell.SetActive(true);
        Up1.Play();
        Globalcash.Countcash -= GlobalShop.shopvalue;
        GlobalShop.shopvalue *= 3;
        GlobalShop2.shopvalue *= 2;
        GlobalShop.turnoffbutton = true;
        GlobalShop.shoppersec += 1;
        GlobalShop.numofshops += 1;
        GlobalShop.allshops += 1;
        GlobalShop.fullsps += 1;
        barcount += 1;
        haveshop = true;
    }
    public void StartAutosell2()
    {
        Autosell.SetActive(true);
        Up2.Play();
        Globalcash.Countcash -= GlobalShop2.shopvalue;
        GlobalShop.shopvalue *= 3;
        GlobalShop2.shopvalue *= 2;
        GlobalShop2.turnoffbutton = true;
        GlobalShop2.shoppersec += 1;
        GlobalShop2.numofshops += 1;
        GlobalShop.allshops += 1;
        GlobalShop.fullsps += 1;
        barcount -= 1;
        haveshop = true;

    }
}
