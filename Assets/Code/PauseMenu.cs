using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;


    public GameObject pauseMenuUi;
   
    void Update()
    {
        //Axel :)
        //När man trycker ner ESC så kommer pause menyn upp och när du trycker igen så försvinner den.
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    //Den här koden gör så att när du trycker på Resume knappen så resumas spelet.
    public void Resume()
    {
        pauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    //Den här koden gör så att spelet fryser till när pause menyn kommer upp.
    void Pause()
    {
        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    //Den här koden gör så att när du trycker på Exit-To-Main-Menu så lämnar du till main menu.
    public void ExitToMenu()
    {
        SceneManager.LoadScene(0);
        Resume();
    }

    
}
