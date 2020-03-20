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
        bakerstats.GetComponent<Text>().text = "NonBaker: " + allbakers + " @ " + fullbps + " per second";
        faketext.GetComponent<Text>().text = "Buy NoncookieBaker £" + bakervalue;
        realtext.GetComponent<Text>().text = "Buy NoncookieBaker £" + bakervalue;

        if (currentcash >= bakervalue)
        {
            fakebutton.SetActive(false);
            realbutton.SetActive(true);
        }

        if (currentcash < bakervalue)
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
