using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disasterevents : MonoBehaviour
{
    public GameObject statusbox;
    public GameObject powerbutton;
    public float noncookiecheck;
    public int genchance;
    public bool disasteractive = false;
    public bool powerupactive = false;
    public int noncookieloss;
    public int divisionfactor = 0;
    public int powerrng = 0;



    void Update()
    {
        if (Perchaselog.barcount >= 10)
        {         
            
            if (Perchaselog.barcount >= 15)
            {
                
                if (powerupactive == false)
                {
                    StartCoroutine(startpowerup2()); 
                }
            }

            else if (powerupactive == false)
            {
                StartCoroutine(startpowerup1());
            }
        }

        if (Perchaselog.barcount < 10)
        {
            divisionfactor = 20;
            if (Perchaselog.barcount < 5)
            {
                divisionfactor = 10;
                if (disasteractive == false)
                {
                    StartCoroutine(startdisaster());
                }
            }

            else if (disasteractive == false)
            {
                StartCoroutine(startdisaster());
            }
        }
        else
        {
            divisionfactor = 1;
        }

        noncookiecheck = Globalnotcookies.Countnotforcookies / divisionfactor;
        
    }

    public void powerupclick()
    {
        powerbutton.SetActive(false);
        Mainbuttonclick.noncookiemmultip = 2;
        Sellnoncookie.cashmultiple = 2;
        StartCoroutine(powerlength());
       

        
    }

    IEnumerator startdisaster()
    {
        disasteractive = true;
        genchance = Random.Range(1, 20);
        if (noncookiecheck >= genchance)
        {
            noncookieloss = Mathf.RoundToInt(Globalnotcookies.Countnotforcookies * 0.25f);
            statusbox.GetComponent<Text>().text = "You lost " + noncookieloss + "noncookies due to your lackluster workforce";
            Globalnotcookies.Countnotforcookies -= noncookieloss;
            yield return new WaitForSeconds(1);
            statusbox.GetComponent<Animation>().Play("StatusAnim");
            yield return new WaitForSeconds(1);
            statusbox.SetActive(false);
            statusbox.SetActive(true);
        }
        yield return new WaitForSeconds(10);
        disasteractive = false;
    }

    IEnumerator startpowerup1()
    {

        powerupactive = true;
        powerrng = Random.Range(3, 6);
        if (powerrng == 5)
        {
            powerbutton.SetActive(true);

        }
        yield return new WaitForSeconds(10);
        powerupactive = false;
    }

    IEnumerator startpowerup2()
    {
        powerupactive = true;
        powerrng = Random.Range(4, 6);
        if (powerrng == 5)
        {
            powerbutton.SetActive(true);

        }
        yield return new WaitForSeconds(10);
        powerupactive = false;
    }

    IEnumerator powerlength()
    {
        yield return new WaitForSeconds(10);
        Mainbuttonclick.noncookiemmultip = 1;
        Sellnoncookie.cashmultiple = 1;
    }
}
