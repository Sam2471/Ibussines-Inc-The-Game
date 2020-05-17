using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Globalnotcookies : MonoBehaviour
{
    public static int Countnotforcookies;
    public GameObject Displaynotforcookies;
    public int Internalnotcookie;

    void Update()
    {
        Internalnotcookie = Countnotforcookies;
        Displaynotforcookies.GetComponent<Text>().text = "Products: " + Internalnotcookie;
    }


}
 