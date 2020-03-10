using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameloader : MonoBehaviour
{
    public int savednoncookies;
    public int savedcash;
    public int savedbakers;
    public int savedshops;
    public int savedvalue;

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
