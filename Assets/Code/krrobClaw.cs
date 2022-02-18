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
        //Laddar scene 3
        SceneManager.LoadScene(3);
    } 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            //Edwin
            Invoke("Load", 2); // Gör så att "gameover" scenen väntar i 2 sek innan den börjar efter man tagen av crob - Edwin
        }
    }

}