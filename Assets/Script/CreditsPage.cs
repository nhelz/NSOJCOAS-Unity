using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsPage : MonoBehaviour
{
    public GameObject mainPage;
    public GameObject fullPage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchCreditsPage(bool toFull)
    {
        if (toFull)
        {
            mainPage.SetActive(false);
            fullPage.SetActive(true);
        }
        else
        {
            mainPage.SetActive(true);
            fullPage.SetActive(false);
        }
    }
}
