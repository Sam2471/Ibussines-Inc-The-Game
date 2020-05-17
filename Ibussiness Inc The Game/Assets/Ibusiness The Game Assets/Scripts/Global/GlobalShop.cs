using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalShop : MonoBehaviour
{
    public GameObject fakebutton;
    public GameObject realbutton;
    public GameObject faketext;
    public GameObject realtext;

    public static int shopvalue = 20;

    public int currentcash;
    public static bool turnoffbutton = false;
    public GameObject shopstats;

    public static int numofshops;
    public static int shoppersec;
    public static int allshops;
    public static int fullsps;


   
    void Update()
    {
        currentcash = Globalcash.Countcash;
        shopstats.GetComponent<Text>().text = "Shops: " + allshops + " @ " + fullsps + " per second";
        faketext.GetComponent<Text>().text = "Buy Shop £" + shopvalue;
        realtext.GetComponent<Text>().text = "Buy Shop £" + shopvalue;

        if (numofshops == 5)
        {
            // max upgrades
            fakebutton.SetActive(true);
            realbutton.SetActive(false);
            faketext.GetComponent<Text>().text = " Maxed Out ";
        }

        else if (currentcash >= shopvalue)
        {
            fakebutton.SetActive(false);
            realbutton.SetActive(true);           
                      
        }

        else if (currentcash < shopvalue)
        {
            fakebutton.SetActive(true);
            realbutton.SetActive(false);
        }

        else if (turnoffbutton == true)
        {
            realbutton.SetActive(false);
            fakebutton.SetActive(true);
            turnoffbutton = false;
        }
    }
}
