using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Axel
   //N�r man trycker p� Playgame s� startar spelet.
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    //N�r man trycker p� Quit s� l�mnar man spelet.
    public void QuitGame()
    {
        Application.Quit();
        print("QUIT!");
    }
}
