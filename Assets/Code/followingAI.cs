using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* ---------------------------------------------------------------------------------------------------------------------------------
 * Code that makes the some fish follow the player if they are nearby. 
 * Made by Alexander Dangiola.
 * ---------------------------------------------------------------------------------------------------------------------------------
*/
public class followingAI : MonoBehaviour
{
    private float fishPosition;
    private float fishPositionY;
    float movement;
    private float yMovement;
    private float speed;
    bool lastWasUp;
    private float timer;
    private int rand;
    public static bool running;
    public static float playerPosY;
    public static float playerPosX;
    // Start is called before the first frame update
    void Start()
    {
        speed = weightList.weight +0.05f; //Gathers the weight from the Weight List so different speeds can be automated.
        fishPosition = transform.position.x; //Gets fish X coordinate.
        fishPositionY = transform.position.y; //Gets fishs Y coordinate.
        //running = false;

    }
    //vector3.distance(fisk.pos, krok.pos) < 5
    // Update is called once per frame
    void Update()
    {

        
        timer += Time.deltaTime;
        fishPosition = GameObject.Find(gameObject.name).transform.position.x;
        transform.position += new Vector3(movement, yMovement, 0) * Time.deltaTime;
        playerPosY = GameObject.FindGameObjectWithTag("Player").transform.position.y;
        playerPosX = GameObject.FindGameObjectWithTag("Player").transform.position.x;
        if (fishPosition >= playerPosX && HookMovement.hasFish == false && playerPosX <= 0)
        {
            movement = playerPosX - (speed / 20) * 1.1f;
            gameObject.transform.localScale = new Vector3(-1, 1, 0);
        }
        else if (fishPosition <= playerPosX && HookMovement.hasFish == false && playerPosX >= 0)
        {
            movement = playerPosX + (speed / 20) * 0.9f;
            gameObject.transform.localScale = new Vector3(1, 1, 0);
        }
        if (HookMovement.hasFish == true)
        {
            if (transform.position.x >= 0)
            {
                movement = 1.2f + (speed / 15);
                gameObject.transform.localScale = new Vector3(1, 1, 0);
                running = true;
            }
            else if (transform.position.x <= 0)
            {
                movement = -1.2f - (speed / 15);
                gameObject.transform.localScale = new Vector3(-1, 1, 0);
                running = true;
            }
            else if (transform.position.x == 0)
            {
                rand = Random.Range(1, 2);
                if (rand == 1)
                {
                    movement = 1.2f + (speed / 15);
                    gameObject.transform.localScale = new Vector3(1, 1, 0);
                    running = true;
                }
                else
                {
                    movement = -1.2f - (speed / 15);
                    gameObject.transform.localScale = new Vector3(-1, 1, 0);
                    running = true;
                }
            }
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.tag == "Small" || collision.gameObject.tag == "xSmall" || collision.gameObject.tag == "Medium" || collision.gameObject.tag == "Large" || collision.gameObject.tag == "xLarge")
        {
            transform.position += new Vector3(0, Random.Range(-3f, 3f), 0);
        }
    }
}