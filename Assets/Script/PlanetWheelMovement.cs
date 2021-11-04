using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetWheelMovement : MonoBehaviour
{
    [SerializeField]
    float ScrollDelta;
    [SerializeField]
    bool scrolling;
    [SerializeField]
    bool withinWheelRadius;
    [SerializeField]
    Vector2 screenPosition;
    Vector3 mousePos;

    public Vector2 menuCenter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Input.mousePosition;
        if ((mousePos.x < Screen.width && mousePos.x > 0) && (mousePos.y < Screen.height && mousePos.y > 0))
        {
            screenPosition = new Vector2(mousePos.x, mousePos.y);
            ScrollDelta = Input.GetAxisRaw("Mouse ScrollWheel");
            if(ScrollDelta != 0f)
            {
                Debug.Log("Scrolling!");
            }
        }
        
    }

}
