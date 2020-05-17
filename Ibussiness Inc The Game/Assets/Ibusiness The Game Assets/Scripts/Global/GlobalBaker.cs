using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBaker : MonoBehaviour
{
    public GameObject fakebutton;
    public GameObject realbutton;
    public GameObject faketext;
    public GameObject realtext;
   
    public static int bakervalue = 10;

    public int currentcash;
    public static bool turnoffbutton = false;
    public GameObject bakerstats;
    public static int numofbakers;
    public static int bakepersec;
    public static int allbakers;
    public static int fullbps;

    void Update()
    {
        currentcash = Globalcash.Countcash;
        bakerstats.GetComponent<Text>().text = "Factories: " + allbakers + " @ " + fullbps + " per second";
        faketext.GetComponent<Text>().text = "Buy Factory £" + bakervalue;
        realtext.GetComponent<Text>().text = "Buy Factory £" + bakervalue;

        if (bakepersec == 5)
        {
            // max upgrades
            fakebutton.SetActive(true);
            realbutton.SetActive(false);
            faketext.GetComponent<Text>().text = " Maxed Out ";
        }

        else if (currentcash >= bakervalue)
        {
            // activate
            fakebutton.SetActive(false);
            realbutton.SetActive(true);
        }

        else if (currentcash < bakervalue)
        {
            // not enough cash
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
