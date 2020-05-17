using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Progressbar : MonoBehaviour
{
    public Slider sliderpos;
    public Slider sliderneg;
    public GameObject pos;
    public GameObject neg;
    public GameObject fill;
    public bool green = true;
    public Animator m_Animator;
    // private float targetprogress = 0f;
    //public int sliderprogress;

    //public float fillspeed = 0.5f;
    private void awake()
    {
        sliderpos = gameObject.GetComponent<Slider>();
        sliderneg = gameObject.GetComponent<Slider>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        //m_Animator = gameObject.GetComponent<Animator>();
        //incrementprogress(0.75f);
    }

    // Update is called once per frame
    void Update()
     {
        sliderpos.value = Perchaselog.barcount;
        sliderneg.value = Perchaselog.barcount;

        if (sliderpos.value >= 10)
        {
            pos.SetActive(true);
            neg.SetActive(false);
            //fill.GetComponent<Renderer>().material.color = Color.green;
            //m_Animator.SetBool("green", true);
        }
        else
        {
            pos.SetActive(false);
            neg.SetActive(true);
            //fill.GetComponent<Renderer>().material.color = Color.red;
            //m_Animator.SetBool("green", false);
        }

        


        //if (positive.value < targetprogress)
        //positive.value += fillspeed * Time.deltaTime;
    }

    //public void incrementprogress(float newprogress)
    //{
        //targetprogress = positive.value + newprogress;
    //}
}
