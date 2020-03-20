using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameloader : MonoBehaviour
{
    public static int savednoncookies;
    public static int savedcash;
    public static int savedbakers;
    public static int savedshops;
    public static int savedvalue;
    public static int savedb;
    public static int saveds;
  


    void Start()
    {
        if (Mainmenuoptions.isloading == true)
        {
            savednoncookies = PlayerPrefs.GetInt("Savednoncookies");
            Globalnotcookies.Countnotforcookies = savednoncookies;

            savedcash = PlayerPrefs.GetInt("SavedCash");
            Globalcash.Countcash = savedcash;

            savedbakers = PlayerPrefs.GetInt("SavedBakers");
            GlobalBaker.bakepersec = savedbakers;
            Autoclicking.Noncookieincrease1 = savedbakers;
            Autoclicking.Creatingnoncookie = false;

            savedshops = PlayerPrefs.GetInt("SavedShops");
            GlobalShop.numofshops = savedshops;
            AutoSell.cashincrease = savedshops;
            AutoSell.Creatingcash = false;

            savedvalue = PlayerPrefs.GetInt("SavedValue");
            Savegame.savevalue = savedvalue;

            savedb = PlayerPrefs.GetInt("Baker");
            Perchaselog.baker = savedb;

            saveds = PlayerPrefs.GetInt("Shop");
            Perchaselog.shop = saveds;

            

        }
    
    }

    
}
