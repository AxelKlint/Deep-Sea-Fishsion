using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class krrobClaw : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Load()
    {
        SceneManager.LoadScene(3);
    } 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {


            Invoke("Load", 2); // G�r s� att "gameover" scenen v�ntar i 2 sek innan den b�rjar efter man tagen av crob - Edwin
        }
    }

}