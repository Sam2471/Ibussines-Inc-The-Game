using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainbuttonclick : MonoBehaviour
{
    public GameObject textBox;

    public void Clickonbutton()
    {
        Globalnotcookies.Countnotforcookies += 1;
    }


}
