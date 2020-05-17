using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalShop2 : MonoBehaviour
{
    public GameObject fakebutton;
    public GameObject realbutton;
    public GameObject faketext;
    public GameObject realtext;

    public static int shopvalue = 10;

    public int currentcash;
    public static bool turnoffbutton = false;
    public GameObject shopstats;

    

   
    void Update()
    {
        currentcash = Globalcash.Countcash;
        
        faketext.GetComponent<Text>().text = "Buy Shop £" + shopvalue;
        realtext.GetComponent<Text>().text = "Buy Shop £" + shopvalue;

        if (GlobalShop.numofshops == 5)
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
