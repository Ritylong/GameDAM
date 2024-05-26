using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    bool ispause = false;
    bool isInfo = false;
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject Info;
    private void Update()
    {
       PauseGameButton(); InfoCharButton();
    }
   

    void PauseGameButton()
    {
       
        if (Input.GetKeyDown(KeyCode.Escape))
        { ispause = !ispause;
            if (ispause)
            {
                PauseGame();
                
            }
            else
            {
                ResumeGame();

            }

        }
    }
    void InfoCharButton()
    {

        if (Input.GetKeyDown(KeyCode.I))
        {
            isInfo = !isInfo;
            if (isInfo)
            {
                InfoOn();

            }
            else
            {
              InfoOff();
            }

        }
    }

    public void InfoOn()
    {
        Info.SetActive(true);
        Time.timeScale = 0f;
    }
    public void InfoOff()
    {
        Info.SetActive(false);
        Time.timeScale = 1f;
    }
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }
}
