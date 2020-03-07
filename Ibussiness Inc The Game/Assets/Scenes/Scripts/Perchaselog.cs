using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perchaselog : MonoBehaviour
{
    public GameObject Autononcookie;

    public void StartAutononcookie()
    {
        Autononcookie.SetActive(true);
        Globalcash.Countcash -= GlobalBaker.bakervalue;
        GlobalBaker.bakervalue *= 2;
        GlobalBaker.turnoffbutton = true;
        GlobalBaker.bakepersec += 1;
        GlobalBaker.numofbakers += 1;
    }
}
