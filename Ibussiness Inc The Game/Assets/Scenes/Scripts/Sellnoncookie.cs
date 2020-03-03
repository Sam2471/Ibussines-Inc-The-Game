using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sellnoncookie : MonoBehaviour
{
    public GameObject textBox;
    public GameObject statusBox;

    public void Clickonbutton()
    {
        if (Globalnotcookies.Countnotforcookies == 0)
        {
            statusBox.GetComponent<Text>().text = "Not enough noncookies to sell";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }

        else
        {
            Globalnotcookies.Countnotforcookies -= 1;
            Globalcash.Countcash += 1;
        }


    }

}
