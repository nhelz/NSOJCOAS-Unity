using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableContent : MonoBehaviour
{
    [SerializeField]
    string currentSection = "Social Media";
    [SerializeField]
    string currentPlanet = "Social Media";
    [SerializeField]
    GameObject currentSectionContent;
    [SerializeField]
    GameObject currentSubSectionContent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        
    }

    public void SetContent()
    {
        //sets previously selected content visibility to invisible
        currentSectionContent.SetActive(false);
        currentSubSectionContent.SetActive(false);

        currentPlanet = GameObject.Find("PlanetTracker").GetComponent<PlanetTracker>().currentPlanet;
        currentSection = GameObject.Find("PlanetTracker").GetComponent<PlanetTracker>().currentSection;

        currentSectionContent = transform.Find(currentPlanet).gameObject;
        currentSubSectionContent = transform.Find(currentPlanet).transform.Find(currentSection).gameObject;
        
        //sets new content to visible
        currentSectionContent.SetActive(true);
        currentSubSectionContent.SetActive(true);
    }
}
