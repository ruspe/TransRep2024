using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProgressionManager : MonoBehaviour
{
    /*
    I'm going to put in three variables
    one for which day we're on
    one for how many times the player has chosen to isolate
    and one for how many times the player has chosen to go out
     */
    private int dayCnt = 0;
    private int insideCnt = 0;
    private int outsideCnt = 0;
    public const int lastDay = 4;
    
    public void advanceSleep()
    {
        dayCnt++;
        insideCnt++;
        if (dayCnt == lastDay)
        {
            endGame();
        }
        else
        {
            SceneManager.LoadScene(sceneName: "Room");
        }
    }
    public void advanceOutside()
    {
        dayCnt++;
        outsideCnt++;
        if(dayCnt==lastDay)
        {
            endGame();
        }
        else
        {
            SceneManager.LoadScene(sceneName: "Outside" + outsideCnt);
        }
    }
    private void endGame()
    {
        if()
    }
}
