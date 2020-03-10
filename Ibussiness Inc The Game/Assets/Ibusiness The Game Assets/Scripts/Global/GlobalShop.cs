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

   
    void Update()
    {
        currentcash = Globalcash.Countcash;
        shopstats.GetComponent<Text>().text = "Shops: " + numofshops + " @ " + shoppersec + " per second";
        faketext.GetComponent<Text>().text = "Buy Shop £" + shopvalue;
        realtext.GetComponent<Text>().text = "Buy Shop £" + shopvalue;

        if (currentcash >= shopvalue)
        {
            fakebutton.SetActive(false);
            realbutton.SetActive(true);           
                      
        }

        if (currentcash < shopvalue)
        {
            fakebutton.SetActive(true);
            realbutton.SetActive(false);
        }

        if (turnoffbutton == true)
        {
            realbutton.SetActive(false);
            fakebutton.SetActive(true);
            turnoffbutton = false;
        }
    }
}
