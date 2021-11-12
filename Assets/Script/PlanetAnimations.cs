using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlanetAnimations : MonoBehaviour
{
    public SectionTabMenus sectionTabMenus;
    public GameObject[] Planets;
    [SerializeField]
    private Vector3[] planetPositions;
    [SerializeField]
    private Vector2[] planetSizes;
    [SerializeField]
    private string currentPlanet;
    [SerializeField]
    private GameObject infront, behind;
    private bool comingFromFullPage = false;
    // Start is called before the first frame update
    void Start()
    {
        currentPlanet = "Social Media";
        GameObject.Find("PlanetTracker").GetComponent<PlanetTracker>().SetCurrentPlanet(currentPlanet);
        sectionTabMenus.EnableSections(currentPlanet);
        planetPositions = new Vector3[5];
        planetSizes = new Vector2[5];
        InitializePositions();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void InitializePositions()
    {
        for(int i = 0; i < Planets.Length; i++)
        {
            planetPositions[i] = Planets[i].GetComponent<RectTransform>().anchoredPosition;
            planetSizes[i] = Planets[i].GetComponent<RectTransform>().sizeDelta;
        }
    }

    public void SwapPlaces(int incrementTo)
    {
        GameObject[] newPlanets = new GameObject[5];
        for (int i = 0; i < Planets.Length; i++)
        {
            int next = i + incrementTo;
            if(next >= 5) { next = 0; }
            else if (next <= -1) { next = 4; }
            Planets[i].GetComponent<RectTransform>().SetPositionAndRotation(planetPositions[next] + transform.position, Quaternion.identity);
            Planets[i].GetComponent<RectTransform>().sizeDelta = planetSizes[next];
            newPlanets[next] = Planets[i];
        }
        Planets = newPlanets;
        for(int i = 0; i < Planets.Length; i++)
        {
            if(i == 2 || i == 3)
            {
                Planets[i].transform.SetParent(behind.transform, false);
            }
            else
            {
                Planets[i].transform.SetParent(infront.transform, false);
            }
        }
        currentPlanet = newPlanets[0].name;
        GameObject.Find("PlanetTracker").GetComponent<PlanetTracker>().SetCurrentPlanet(currentPlanet);
        GameObject.Find("PlanetTracker").GetComponent<PlanetTracker>().SetCurrentSectionNum(0);
        
        //sectionTabMenus.EnableSections(currentPlanet);
    }

    public void UpdateFromFullPage()
    {
        string newCurrentPlanet = GameObject.Find("PlanetTracker").GetComponent<PlanetTracker>().currentPlanet;
        int newCurrent = 0;
        for(int i = 0; i < Planets.Length; i++)
        {
            if(Planets[i].name == newCurrentPlanet)
            {
                newCurrent = i;
            }
        }
        comingFromFullPage = true;
        for (int i = 0; i < newCurrent; i++)
        {
            SwapPlaces(-1);
        }
        comingFromFullPage = false;
    }
}
