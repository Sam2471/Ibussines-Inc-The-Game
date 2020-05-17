using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainbuttonclick : MonoBehaviour
{
    public GameObject textBox;
    public static int noncookiemmultip = 1;

    public void Clickonbutton()
    {
        Globalnotcookies.Countnotforcookies += noncookiemmultip;
    }


}
