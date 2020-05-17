using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autoclicking : MonoBehaviour
{
    public static bool Creatingnoncookie = false;
    public static int Noncookieincrease1 = 1;
    public int Internalincrease1;
    

   

    void Update()
    {
        Noncookieincrease1 = GlobalBaker.bakepersec;
        
        Internalincrease1 = Noncookieincrease1;
        
        if (Creatingnoncookie == false)
        {
            Creatingnoncookie = true;
            StartCoroutine(Creatingthenoncookie());
        }
    }

    IEnumerator Creatingthenoncookie ()
    {
        Globalnotcookies.Countnotforcookies += Internalincrease1;
        yield return new WaitForSeconds(1);
        Creatingnoncookie = false;
            
    }  

}

