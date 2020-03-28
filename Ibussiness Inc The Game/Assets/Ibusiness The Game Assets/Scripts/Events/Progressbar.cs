using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Progressbar : MonoBehaviour
{
    public Slider positive;
    private float targetprogress = 0f;

    public float fillspeed = 0.5f;
    private void awake()
    {
        positive = gameObject.GetComponent<Slider>();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        incrementprogress(0.75f);
    }

    // Update is called once per frame
    void Update()
    {
        if (positive.value < targetprogress)
            positive.value += fillspeed * Time.deltaTime;
    }

    public void incrementprogress(float newprogress)
    {
        targetprogress = positive.value + newprogress;
    }
}
