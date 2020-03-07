using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autoclicking : MonoBehaviour
{
    public bool Creatingnoncookie = false;
    public static int Noncookieincrease = 1;
    public int Internalincrease;

    // Update is called once per frame
    void Update()
    {
        Noncookieincrease = GlobalBaker.bakepersec;
        Internalincrease = Noncookieincrease;
        if (Creatingnoncookie == false)
        {
            Creatingnoncookie = true;
            StartCoroutine(Creatingthenoncookie());
        }
    }

    IEnumerator Creatingthenoncookie ()
    {
        Globalnotcookies.Countnotforcookies += Internalincrease;
        yield return new WaitForSeconds(1);
        Creatingnoncookie = false;
            
    }  

}

