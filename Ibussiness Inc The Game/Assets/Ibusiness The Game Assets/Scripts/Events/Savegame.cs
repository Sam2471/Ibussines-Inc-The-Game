using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Savegame : MonoBehaviour
{
    public int savegamecash;
    public static int  savevalue = 10;
    public GameObject saveButton;
    public GameObject savetext;
   
    void Update()
    {
        savetext.GetComponent<Text>().text = "Cost: £" + savevalue;
        savegamecash = Globalcash.Countcash;
        if (savegamecash >= savevalue)
        {
            saveButton.GetComponent<Button>().interactable = true;
        }

        else
        {
            saveButton.GetComponent<Button>().interactable = false;
        }
    }

    public void Savethegame()
    {
        Globalcash.Countcash -= savevalue;
        PlayerPrefs.SetInt("Savednoncookies", Globalnotcookies.Countnotforcookies);
        PlayerPrefs.SetInt("SavedCash", Globalcash.Countcash);
        PlayerPrefs.SetInt("SavedBakers", GlobalBaker.bakepersec);
        PlayerPrefs.SetInt("SavedShops", GlobalShop.numofshops);
        savevalue *= 2;
        PlayerPrefs.SetInt("SavedValue", savevalue);
        PlayerPrefs.SetInt("Baker", Perchaselog.shop);
        PlayerPrefs.SetInt("Shop", Perchaselog.baker);
        PlayerPrefs.SetInt("bar", Perchaselog.barcount);

    }

}
