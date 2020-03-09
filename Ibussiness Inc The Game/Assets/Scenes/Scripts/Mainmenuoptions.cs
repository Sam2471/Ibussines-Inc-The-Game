using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenuoptions : MonoBehaviour
{
    public static bool isloading = false;

    public void Newgame()
    {
        SceneManager.LoadScene("Mainscene");
    }

    public void Loadgame()
    {
        isloading = true;
        SceneManager.LoadScene("Mainscene");
    }
}
