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
