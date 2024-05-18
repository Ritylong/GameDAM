using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScreenControl: MonoBehaviour
{

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadGame()
    {
        int Mapcurrent = SceneManager.GetActiveScene().buildIndex;
        int NextMap = Mapcurrent + 1;
        SceneManager.LoadScene(NextMap);
    }
}