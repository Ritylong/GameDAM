using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    bool ispause = false;
    [SerializeField] GameObject pauseMenu;

    private void Update()
    {
       PauseGameButton();
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
