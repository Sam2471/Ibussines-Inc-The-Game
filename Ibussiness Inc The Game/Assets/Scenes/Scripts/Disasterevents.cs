using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disasterevents : MonoBehaviour
{
    public GameObject statusbox;
    public float noncookiecheck;
    public int genchance;
    public bool disasteractive = false;
    public int noncookieloss;



    void Update()
    {
        noncookiecheck = Globalnotcookies.Countnotforcookies / 10;
        if (disasteractive == false)
        {
            StartCoroutine(startdisaster());
        }
    }

    IEnumerator startdisaster()
    {
        disasteractive = true;
        genchance = Random.Range(1, 20);
        if (noncookiecheck >= genchance)
        {
            noncookieloss = Mathf.RoundToInt(Globalnotcookies.Countnotforcookies * 0.25f);
            statusbox.GetComponent<Text>().text = "You lost " + noncookieloss + "noncookies due to Covid-19";
            Globalnotcookies.Countnotforcookies -= noncookieloss;
            yield return new WaitForSeconds(3);
            statusbox.GetComponent<Animation>().Play("StatusAnim");
            yield return new WaitForSeconds(1);
            statusbox.SetActive(false);
            statusbox.SetActive(true);
        }
        yield return new WaitForSeconds(10);
        disasteractive = false;
    } 
}
