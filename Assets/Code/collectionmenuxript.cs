using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collectionmenuxript : MonoBehaviour
{
    //Axel
    //G�r s� att Collection menun �ppnas
    public void Collection()
    {
        SceneManager.LoadScene(2);
    }
    //G�r s� att man kommer tillbaks till mainmenyn.
    public void Back()
    {
        SceneManager.LoadScene(0);
    }
    //On�dig borttagen
    public void Resume()
    {
        SceneManager.LoadScene(1);
    }
}
