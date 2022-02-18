using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collectionmenuxript : MonoBehaviour
{
    //Axel
    //Gör så att Collection menun öppnas
    public void Collection()
    {
        SceneManager.LoadScene(2);
    }
    //Gör så att man kommer tillbaks till mainmenyn.
    public void Back()
    {
        SceneManager.LoadScene(0);
    }
    //Onödig borttagen
    public void Resume()
    {
        SceneManager.LoadScene(1);
    }
}
