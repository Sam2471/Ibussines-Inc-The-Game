using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBaker : MonoBehaviour
{
    public GameObject fakebutton;
    public GameObject realbutton;
    public GameObject faketext;
    public GameObject realtext;
    public int currentcash;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentcash = Globalcash.Countcash;
        if (currentcash >= 50)
        {
            fakebutton.SetActive(false);
            realbutton.SetActive(true);
        } 

    }
}
