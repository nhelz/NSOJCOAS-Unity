using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MatchTheMonstarsGame : MonoBehaviour
{

    [SerializeField]
    private int currentRound = 1;
    [SerializeField]
    private Sprite[] Nerdlucks;
    public GameObject CurrentNerdluck;
    public GameObject winScreen;
    public GameObject playScreen;
    public GameObject loseScreen;
    public GameObject victoryScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void tryChoose(string color)
    {
        string colorRound = color + currentRound;
        //Debug.Log("Got: " + colorRound);
        switch (colorRound)
        {
            case "Orange1":
                winRound();
                break;
            case "Green2":
                winRound();
                break;
            case "Purple3":
                winRound();
                break;
            case "Red4":
                winRound();
                break;
            case "Blue5":
                endGame();
                break;
            default:
                loseRound();
                break;
        }
    }

    private void winRound()
    {
        playScreen.SetActive(false);
        if(currentRound == 5)
        {
            Debug.Log("Win!");
        }
        else
        {
            winScreen.SetActive(true);
        }
    }

    private void loseRound()
    {
        playScreen.SetActive(false);
        loseScreen.SetActive(true);
    }

    public void retry()
    {
        loseScreen.SetActive(false);
        playScreen.SetActive(true);
    }

    private void endGame()
    {
        playScreen.SetActive(false);
        victoryScreen.SetActive(true);
    }

    public void nextRound()
    {
        
        CurrentNerdluck.GetComponent<Image>().sprite = Nerdlucks[currentRound];
        currentRound++;
        playScreen.SetActive(true);
        winScreen.SetActive(false);
    }

    public void CloseGame()
    {
        currentRound = 1;
        CurrentNerdluck.GetComponent<Image>().sprite = Nerdlucks[0];
        gameObject.SetActive(false);
    }
}
