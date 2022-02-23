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
        //N�r man trycker ner ESC s� kommer pause menyn upp och n�r du trycker igen s� f�rsvinner den.
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
    //Den h�r koden g�r s� att n�r du trycker p� Resume knappen s� resumas spelet.
    public void Resume()
    {
        pauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    //Den h�r koden g�r s� att spelet fryser till n�r pause menyn kommer upp.
    void Pause()
    {
        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    //Den h�r koden g�r s� att n�r du trycker p� Exit-To-Main-Menu s� l�mnar du till main menu.
    public void ExitToMenu()
    {
        SceneManager.LoadScene(0);
        Resume();
    }

    
}
