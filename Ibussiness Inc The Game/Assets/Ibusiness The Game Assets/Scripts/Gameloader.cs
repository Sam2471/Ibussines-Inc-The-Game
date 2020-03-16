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

            savedshops = PlayerPrefs.GetInt("SavedShops");
            GlobalShop.numofshops = savedshops;

            savedvalue = PlayerPrefs.GetInt("SavedValue");
            Savegame.savevalue = savedvalue;

        }
    
    }

    
}
