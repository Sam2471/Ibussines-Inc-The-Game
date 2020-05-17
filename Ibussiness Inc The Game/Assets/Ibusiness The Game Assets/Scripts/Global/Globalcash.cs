using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Globalcash : MonoBehaviour
{
    public static int Countcash;
    public GameObject Displaycash;
    public int Internalcash;

    void Update()
    {
        Internalcash = Countcash;
        Displaycash.GetComponent<Text>().text = "Cash: £" + Internalcash;
    }

}
