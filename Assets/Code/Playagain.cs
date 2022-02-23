using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Playagain : MonoBehaviour
{
    //Axel
    //Byter till spelscenen.
    public void PlayAgain()
    {
        SceneManager.LoadScene(1);
    }
    //Byter till meny scenen.
    public void ExitToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
