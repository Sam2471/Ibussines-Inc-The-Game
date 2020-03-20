using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSell : MonoBehaviour
{
    public static bool Creatingcash = false;
    public static int cashincrease = 1;
    public int Internalincrease;


    void Update()
    {
        cashincrease = GlobalShop.shoppersec +  GlobalShop2.shoppersec;
        Internalincrease = cashincrease;
        if (Creatingcash == false)
        {
            Creatingcash = true;
            StartCoroutine(Creatingthecash());
        }
    }

    IEnumerator Creatingthecash ()
    {
        if (Globalnotcookies.Countnotforcookies < Internalincrease)
        {
            Creatingcash = false;
        }
        else
        {

            
            Globalcash.Countcash += Internalincrease;
            Globalnotcookies.Countnotforcookies -= Internalincrease; 
            yield return new WaitForSeconds(1);
            Creatingcash = false;
        }
    }  

}

