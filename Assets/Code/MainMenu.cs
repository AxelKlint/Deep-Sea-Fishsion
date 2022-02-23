using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Axel
   //När man trycker på Playgame så startar spelet.
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    //När man trycker på Quit så lämnar man spelet.
    public void QuitGame()
    {
        Application.Quit();
        print("QUIT!");
    }
}
