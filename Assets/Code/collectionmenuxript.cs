using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collectionmenuxript : MonoBehaviour
{

    public void Collection()
    {
        SceneManager.LoadScene(2);
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }
    public void Resume()
    {
        SceneManager.LoadScene(1);
    }
}
