using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/* This code is written by a stressed teenager called Alex at 2 in the morning please don't judge it too badly thanks.
 * -------------------------------------------------------------------------------------------------------------------------------
 * With this code my goal is to create one fish spawner that spawns in fish depending on layer, which is controlled by a command that runs 
 * upon the player reaching a certain depth, one for each level. Upon said command, they should spawn in all of the fish that are coded into that
 * area. 
 * -------------------------------------------------------------------------------------------------------------------------------
*/
public class fishSpawn : MonoBehaviour
{
    [SerializeField]
    GameObject fish1;
    [SerializeField]
    GameObject fish2;
    [SerializeField]
    GameObject fish3;
    [SerializeField]
    GameObject fish4;
    [SerializeField]
    GameObject fish5;
    [SerializeField]
    GameObject fish6;
    [SerializeField]
    GameObject fish7;
    [SerializeField]
    GameObject fish8;
    [SerializeField]
    GameObject fish9;
    [SerializeField]
    GameObject fish10;
    [SerializeField]
    GameObject crab;
    public static bool summonFish1;
    public static bool summonFish2;
    public static bool summonFish3;
    public static bool summonCrab;
    public static bool doneSpawning;
    private static int rand;
    private static float xSpawn;
    int loopPreventer;
    public static float yPosition;
    // Start is called before the first frame update
    void Start()
    {
        summonFish1 = true;
        summonFish2 = false;
        summonFish3 = false;
        summonCrab = false;
        doneSpawning = false;
        loopPreventer = 0;

    }

    // Update is called once per frame
    void Update()
    {
        yPosition = GameObject.FindGameObjectWithTag("Player").transform.position.y;
        if (yPosition <= -16 && loopPreventer == 0)
        {
            summonFish2 = true;
            summonFish1 = false;
            doneSpawning = false;
            loopPreventer += 1;
        }
        if (yPosition <= -40 && loopPreventer == 1)
        {
            summonFish3 = true;
            summonFish2 = false;
            doneSpawning = false;
            loopPreventer += 1;
        }
        if (yPosition <= -70 && loopPreventer == 2)
        {
            summonCrab = true;
            summonFish3 = false;
            doneSpawning = false;
            loopPreventer += 1;
        }
        else
        {
            //nothing
        }
        rand = Random.Range(0, 3);
        if (rand == 1)
        {
            xSpawn = Random.Range(-10.5f, -12);
        }
        else
        {
            xSpawn = Random.Range(10.5f, 12);
        }
        if (summonFish1 == true && doneSpawning == false)
        {
            Instantiate(fish1, new Vector2(xSpawn + Random.Range(-0.5f, 0.5f), Random.Range(-7, -20)), Quaternion.identity);
            Instantiate(fish1, new Vector2(xSpawn + Random.Range(-0.5f, 0.5f), Random.Range(-7, -20)), Quaternion.identity);
            Instantiate(fish1, new Vector2(xSpawn + Random.Range(-0.5f, 0.5f), Random.Range(-7, -20)), Quaternion.identity);
            Instantiate(fish2, new Vector2(xSpawn + Random.Range(-0.5f, 0.5f), Random.Range(-7, -20)), Quaternion.identity);
            Instantiate(fish3, new Vector2(xSpawn + Random.Range(-0.5f, 0.5f), Random.Range(-7, -20)), Quaternion.identity);
            Instantiate(fish2, new Vector2(xSpawn + Random.Range(-0.5f, 0.5f), Random.Range(-7, -20)), Quaternion.identity);
            Instantiate(fish3, new Vector2(xSpawn + Random.Range(-0.5f, 0.5f), Random.Range(-7, -20)), Quaternion.identity);
            Instantiate(fish2, new Vector2(xSpawn + Random.Range(-0.5f, 0.5f), Random.Range(-7, -20)), Quaternion.identity);
            Instantiate(fish3, new Vector2(xSpawn + Random.Range(-0.5f, 0.5f), Random.Range(-7, -20)), Quaternion.identity);
            doneSpawning = true;
        }
        else if (summonFish2 == true && doneSpawning == false)
        {
            Instantiate(fish4, new Vector2(xSpawn, Random.Range(-20, -45)), Quaternion.identity);
            Instantiate(fish5, new Vector2(xSpawn, Random.Range(-20, -45)), Quaternion.identity);
            Instantiate(fish6, new Vector2(xSpawn, Random.Range(-20, -45)), Quaternion.identity);
            Instantiate(fish7, new Vector2(xSpawn, Random.Range(-20, -45)), Quaternion.identity);
            Instantiate(fish4, new Vector2(xSpawn, Random.Range(-20, -45)), Quaternion.identity);
            Instantiate(fish5, new Vector2(xSpawn, Random.Range(-20, -45)), Quaternion.identity);
            Instantiate(fish6, new Vector2(xSpawn, Random.Range(-20, -45)), Quaternion.identity);
            Instantiate(fish7, new Vector2(xSpawn, Random.Range(-20, -45)), Quaternion.identity);
            doneSpawning = true;
        }
        else if (summonFish3 == true && doneSpawning == false)
        {
            Instantiate(fish8, new Vector2(xSpawn, Random.Range(-45, -75)), Quaternion.identity);
            Instantiate(fish9, new Vector2(xSpawn, Random.Range(-45, -75)), Quaternion.identity);
            Instantiate(fish10, new Vector2(xSpawn, Random.Range(-45, -75)), Quaternion.identity);
            Instantiate(fish8, new Vector2(xSpawn, Random.Range(-45, -75)), Quaternion.identity);
            Instantiate(fish9, new Vector2(xSpawn, Random.Range(-45, -75)), Quaternion.identity);
            Instantiate(fish10, new Vector2(xSpawn, Random.Range(-45, -75)), Quaternion.identity);
            doneSpawning = true;
        }
        else if (summonCrab == true && doneSpawning == false)
        {
            Instantiate(crab, new Vector2(0, -82), Quaternion.identity);
            doneSpawning = true;
        }


    }
}