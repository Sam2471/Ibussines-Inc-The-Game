using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Progressbar : MonoBehaviour
{
    public Slider slider;
   // private float targetprogress = 0f;
    //public int sliderprogress;

    //public float fillspeed = 0.5f;
    private void awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        //incrementprogress(0.75f);

        
    }

    // Update is called once per frame
    void Update()
     {
        slider.value = Perchaselog.barcount;



        //if (positive.value < targetprogress)
        //positive.value += fillspeed * Time.deltaTime;
    }

    //public void incrementprogress(float newprogress)
    //{
        //targetprogress = positive.value + newprogress;
    //}
}
