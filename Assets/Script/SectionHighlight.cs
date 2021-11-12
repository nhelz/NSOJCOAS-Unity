using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionHighlight : MonoBehaviour
{
    public GameObject HighlightBox;
    [SerializeField]
    bool highlighted = false;

    // Start is called before the first frame update
    void Start()
    {
        //ToggleHighlight(highlighted);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleHighlight(bool on)
    {
        HighlightBox.SetActive(on);
    }
}
