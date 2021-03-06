using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SectionTabMenus : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Sections;
    //public GameObject SectionText;
    public EnableContent enableMainPageContent;
    [SerializeField]
    private GameObject SelectedSection;
    [SerializeField]
    private int numberOfTabs;
    // Start is called before the first frame update
    void Start()
    {
        SelectedSection.GetComponent<SectionHighlight>().ToggleHighlight(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnableSections(string planetName)
    {
        SelectedSection.GetComponent<SectionHighlight>().ToggleHighlight(false);
        if (planetName == "Social Media")
        {
            numberOfTabs = 1;
            Sections[0].GetComponentInChildren<Text>().text = "Social Media";
            //EnableContent.SetContent(planetName, sectionName);
        }
        else if(planetName == "Animation")
        {
            numberOfTabs = 4;
            Sections[0].GetComponentInChildren<Text>().text = "Characters";
            Sections[1].GetComponentInChildren<Text>().text = "Animation Sketches";
            Sections[2].GetComponentInChildren<Text>().text = "Behind the Scenes";
            Sections[3].GetComponentInChildren<Text>().text = "Tech Notes";
        }
        else if (planetName == "Fun & Games")
        {
            numberOfTabs = 3;
            Sections[0].GetComponentInChildren<Text>().text = "Videos";
            Sections[1].GetComponentInChildren<Text>().text = "Games";
            Sections[2].GetComponentInChildren<Text>().text = "Fun";
        }
        else if (planetName == "Store")
        {
            numberOfTabs = 2;
            Sections[0].GetComponentInChildren<Text>().text = "Warner Bros. Store";
            Sections[1].GetComponentInChildren<Text>().text = "Soundtrack";
        }
        else if (planetName == "Everything B-Ball")
        {
            numberOfTabs = 4;
            Sections[0].GetComponentInChildren<Text>().text = "NBA";
            Sections[1].GetComponentInChildren<Text>().text = "NCAA";
            Sections[2].GetComponentInChildren<Text>().text = "Player Bios";
            Sections[3].GetComponentInChildren<Text>().text = "Around the World";
        }
        else if (planetName == "Credits")
        {
            numberOfTabs = 1;
            Sections[0].GetComponentInChildren<Text>().text = "Credits";
        }
        
        ActivateSectionHeaders();
        Sections[0].GetComponent<SectionHighlight>().ToggleHighlight(true);
        SelectedSection = Sections[0];
        GameObject.Find("PlanetTracker").GetComponent<PlanetTracker>().SetCurrentSection(SelectedSection.GetComponentInChildren<Text>().text);
    }

    public void UpdateEnabledSections(string planetName)
    {
        SelectedSection.GetComponent<SectionHighlight>().ToggleHighlight(false);
        if (planetName == "Social Media")
        {
            numberOfTabs = 1;
            Sections[0].GetComponentInChildren<Text>().text = "Social Media";
        }
        else if (planetName == "Animation")
        {
            numberOfTabs = 4;
            Sections[0].GetComponentInChildren<Text>().text = "Characters";
            Sections[1].GetComponentInChildren<Text>().text = "Animation Sketches";
            Sections[2].GetComponentInChildren<Text>().text = "Behind the Scenes";
            Sections[3].GetComponentInChildren<Text>().text = "Tech Notes";
        }
        else if (planetName == "Fun & Games")
        {
            numberOfTabs = 3;
            Sections[0].GetComponentInChildren<Text>().text = "Videos";
            Sections[1].GetComponentInChildren<Text>().text = "Games";
            Sections[2].GetComponentInChildren<Text>().text = "Fun";
        }
        else if (planetName == "Store")
        {
            numberOfTabs = 2;
            Sections[0].GetComponentInChildren<Text>().text = "Warner Bros. Store";
            Sections[1].GetComponentInChildren<Text>().text = "Soundtrack";
        }
        else if (planetName == "Everything B-Ball")
        {
            numberOfTabs = 4;
            Sections[0].GetComponentInChildren<Text>().text = "NBA";
            Sections[1].GetComponentInChildren<Text>().text = "NCAA";
            Sections[2].GetComponentInChildren<Text>().text = "Player Bios";
            Sections[3].GetComponentInChildren<Text>().text = "Around the World";
        }
        else if (planetName == "Credits")
        {
            numberOfTabs = 1;
            Sections[0].GetComponentInChildren<Text>().text = "Credits";
        }

        ActivateSectionHeaders();
    }

    private void ActivateSectionHeaders()
    {
        for(int i = 0; i < Sections.Length; i++)
        {
            Sections[i].SetActive(numberOfTabs - 1 >= i);
        }
        
    }

    private void findSelectedNumber()
    {
        for(int i = 0; i < Sections.Length; i++)
        {
            if(Sections[i] == SelectedSection)
            {
                GameObject.Find("PlanetTracker").GetComponent<PlanetTracker>().SetCurrentSectionNum(i);
            }
        }
        
    }

    public void SelectSection(int selectedSection)
    {
        SelectedSection.GetComponent<SectionHighlight>().ToggleHighlight(false);
        SelectedSection = Sections[selectedSection];
        SelectedSection.GetComponent<SectionHighlight>().ToggleHighlight(true);
        GameObject.Find("PlanetTracker").GetComponent<PlanetTracker>().SetCurrentSection(SelectedSection.GetComponentInChildren<Text>().text);
        findSelectedNumber();
        enableMainPageContent.SetContent();
    }

    public void UpdateSelection(int selectedSection)
    {
        SelectedSection.GetComponent<SectionHighlight>().ToggleHighlight(false);
        SelectedSection = Sections[selectedSection];
        SelectedSection.GetComponent<SectionHighlight>().ToggleHighlight(true);
        enableMainPageContent.SetContent();
    }
}
