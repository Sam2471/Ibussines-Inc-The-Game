using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBaker2 : MonoBehaviour
{
    public GameObject fakebutton;
    public GameObject realbutton;
    public GameObject faketext;
    public GameObject realtext;
    
    public static int bakervalue = 5;

    public int currentcash;
    public static bool turnoffbutton = false;
    public GameObject bakerstats;
   

    void Update()
    {
        currentcash = Globalcash.Countcash;
        
        faketext.GetComponent<Text>().text = "Buy Factory £" + bakervalue;
        realtext.GetComponent<Text>().text = "Buy Factory £" + bakervalue;

        if (GlobalBaker.bakepersec == 5)
        {
            // max upgrades
            fakebutton.SetActive(true);
            realbutton.SetActive(false);
            faketext.GetComponent<Text>().text = " Maxed Out ";
        }

        else if (currentcash >= bakervalue)
        {
            fakebutton.SetActive(false);
            realbutton.SetActive(true);
        }

        else if (currentcash < bakervalue)
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
