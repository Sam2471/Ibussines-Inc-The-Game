using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenuoptions : MonoBehaviour
{
    public static bool isloading = false;
    

    public void Newgame()
    {
       PlayerPrefs.SetInt("Savednoncookies", 0);
       PlayerPrefs.SetInt("SavedCash", 0);
       PlayerPrefs.SetInt("SavedBakers", 0);
       PlayerPrefs.SetInt("SavedShops", 0);
       PlayerPrefs.SetInt("SavedValue", 10);
        PlayerPrefs.SetInt("Baker", 0);
        PlayerPrefs.SetInt("Shop", 0);
        Globalnotcookies.Countnotforcookies = 0;
        Globalcash.Countcash = 0;

        GlobalBaker.bakepersec = 0;
        GlobalBaker2.bakepersec = 0;
        GlobalBaker.numofbakers = 0;
        GlobalBaker2.numofbakers = 0;
        GlobalBaker.bakervalue = 10;
        GlobalBaker2.bakervalue = 5;
        GlobalBaker.allbakers = 0;
        GlobalBaker.fullbps = 0;

        GlobalShop.shoppersec = 0;
        GlobalShop2.shoppersec = 0;
        GlobalShop.numofshops = 0;
        GlobalShop2.numofshops = 0;
        GlobalShop.shopvalue = 20;
        GlobalShop2.shopvalue = 10;
        GlobalShop.allshops = 0;
        GlobalShop.fullsps = 0;

        Gameloader.savedvalue = 10;

        SceneManager.LoadScene("Mainscene");
    }

    public void Loadgame()
    {
        isloading = true;
        SceneManager.LoadScene("Mainscene");

        
    }

    public void Exitgame()
    {
        Application.Quit();
    }

    public void Returntomenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
