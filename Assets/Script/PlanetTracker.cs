using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetTracker : MonoBehaviour
{
    private bool onMainPage;
    public GameObject fullPage;
    public SectionTabMenus fullPageSectionTabMenus;
    public GameObject mainPage;
    public SectionTabMenus mainPageSectionTabMenus;
    public GameObject creditsPage;
    public GameObject fullPageContent;
    public GameObject mainPageContent;
    public string currentPlanet;
    public string currentSection;
    public int currentSectionNum;
    // Start is called before the first frame update
    void Start()
    {
        ToggleMainPage();
        SetCurrentPlanet("Social Media");
        UpdateSections();
        mainPageSectionTabMenus.EnableSections(currentPlanet);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetCurrentPlanet(string Planet)
    {
        currentPlanet = Planet;
        UpdateSections();
    }

    public void SetCurrentSection(string Section)
    {
        currentSection = Section;
    }

    public void SetCurrentSectionNum(int num)
    {
        currentSectionNum = num;
    }

    private void UpdateSections()
    {
        mainPageSectionTabMenus.EnableSections(currentPlanet);
    }


    public void ToggleFullPage()
    {
        onMainPage = false;
        fullPage.SetActive(true);
        fullPageContent.SetActive(true);
        mainPage.SetActive(false);
        mainPageContent.SetActive(false);
        fullPage.GetComponent<FullMenu>().EnableTriangles(currentPlanet);
    }

    public void ToggleMainPage()
    {
        onMainPage = true;
        mainPage.SetActive(true);
        mainPageContent.SetActive(true);
        fullPage.SetActive(false);
        fullPageContent.SetActive(false);
        creditsPage.SetActive(false);
    }

    public void ToggleCreditsPage()
    {
        fullPage.SetActive(false);
        mainPage.SetActive(false);
        creditsPage.SetActive(true);
    }

}
