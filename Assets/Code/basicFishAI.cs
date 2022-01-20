using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* ---------------------------------------------------------------------------------------------------------------------------------
 * Code that takes care of the simple fish AI. This will take care of basic movement along X and Y coordinates, along with fishes 
 * turning around when they reach the end of the screen. Also this code will also control the fish escape mechanism that will be used
 * when another fish gets caught.
 * Made by Alexander Dangiola who had to rewrite this code five thousand times.
 * ---------------------------------------------------------------------------------------------------------------------------------
*/
public class basicFishAI : MonoBehaviour
{
    private float fishPosition;
    float movement;
    private float yMovement;
    private float speed;
    bool lastWasUp;
    private float timer;
    private int rand;
    private bool running;
    // Start is called before the first frame update
    void Start()
    {
        speed = weightList.weight; //Gathers the weight from the Weight List so different speeds can be automated.
        fishPosition = transform.position.x; //
        running = false;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        fishPosition = GameObject.Find(gameObject.name).transform.position.x;
        transform.position += new Vector3(movement, yMovement, 0) * Time.deltaTime;
        if (fishPosition >= 8 && running == false)
        {
            movement = -1f - (speed / 15);
            gameObject.transform.localScale = new Vector3(-1, 1, 0);
        }
        if (fishPosition <= -8 && running == false)
        {
            movement = 1f + (speed / 15);
            gameObject.transform.localScale = new Vector3(1, 1, 0);
        }
        if (lastWasUp == true && timer >= 0.25f)
        {
            yMovement = -0.3f - (speed / 20);
            lastWasUp = false;
            timer = 0;
        }
        else if (lastWasUp == false && timer >= 0.25f)
        {
            yMovement = 0.3f + (speed / 20);
            lastWasUp = true;
            timer = 0;
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
}