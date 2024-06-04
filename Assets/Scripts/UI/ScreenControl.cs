using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScreenControl: MonoBehaviour
{
    
    HealthPlayer HealthPlayer;
    private void Start()
    {
        HealthPlayer = FindObjectOfType<HealthPlayer>();
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadGame()
    {
        int Mapcurrent = SceneManager.GetActiveScene().buildIndex;
        int NextMap = Mapcurrent + 1;
        SceneManager.LoadScene(NextMap);
        HealthPlayer.Mana = 100;
    }
 
    public void ResetScreen()
    {
        FindAnyObjectByType<UIControl>().playerDead = false;
        HealthPlayer.Coin = 0;
        HealthPlayer.Mana = 100;
        int Mapcurrent = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(Mapcurrent);
        


    }

}
