using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Triangles;
    [SerializeField]
    private string[] FMPlanets;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnableTriangles(string planetName)
    {
        for(int i = 0; i < 5; i++)
        {
            if(planetName == FMPlanets[i])
            {
                Triangles[i].SetActive(true);
            }
            else
            {
                Triangles[i].SetActive(false);
            }
        }
    }

    public void ChangePlanet(string newPlanet)
    {
        PlanetTracker pTracker = GameObject.Find("PlanetTracker").GetComponent<PlanetTracker>();
        pTracker.SetCurrentPlanet(newPlanet);
        EnableTriangles(newPlanet);
        pTracker.SetCurrentSectionNum(0);
    }
}
