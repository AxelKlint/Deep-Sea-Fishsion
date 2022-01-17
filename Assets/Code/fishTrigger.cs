using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Another code written at 2 in the morning dont mind me - Kind regards, Alexander
 * -----------------------------------------------------------------------------------------------
 * So this code will turn on and off the bools in fishSpawn.cs depending on how deep the player is.
 * -----------------------------------------------------------------------------------------------
*/

public class fishTrigger : MonoBehaviour
{
    public static int depth;
    float timer;
    int loopPreventer;
    // Start is called before the first frame update
    void Start()
    {
        depth = 0;
        timer = 0;
        loopPreventer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (depth == 0 && loopPreventer == 0) 
        {
            fishSpawn.summonFish1 = true;
            fishSpawn.summonFish2 = false;
            fishSpawn.summonFish3 = false;
            fishSpawn.summonCrab = false;
            loopPreventer += 1;
        }
        if (depth == 1 && loopPreventer == 1)
        {
            fishSpawn.summonFish2 = true;
            fishSpawn.summonFish1 = false;
            fishSpawn.doneSpawning = false;
            loopPreventer += 1;
        }
        if (depth == 2 && loopPreventer == 2)
        {
            fishSpawn.summonFish2 = true;
            fishSpawn.summonFish3 = true;
            fishSpawn.doneSpawning = false;
            loopPreventer += 1;

        }
        if (depth == 3 && loopPreventer == 3)
        {
            fishSpawn.summonFish3 = false;
            fishSpawn.doneSpawning = false;
            fishSpawn.summonCrab = true;
            loopPreventer += 1;

        }
        if (depth == 4 && loopPreventer == 4)
        {
            //this code will only be used when the player is going back up again, and will be used to turn of the spawners.
            loopPreventer += 1;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //adding a timer here so that the player doesnt infinitely trigger this event while coliding
        if (collision.gameObject.tag == "Player" && timer >= 2) 
        {
            depth += 1;
            timer = 0;
        }

    }
}
