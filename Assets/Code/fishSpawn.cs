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
    GameObject crab;
    public static bool summonFish1;
    public static bool summonFish2;
    public static bool summonFish3;
    public static bool summonCrab;
    public static bool doneSpawning;

    // Start is called before the first frame update
    void Start()
    {
        summonFish1 = false;
        summonFish2 = false;
        summonFish3 = false;
        summonCrab = false;
        doneSpawning = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (summonFish1 == true && doneSpawning == false)
        {
            Instantiate(fish1, new Vector2(-10.5f, 0), Quaternion.identity);
            Instantiate(fish2, new Vector2(10.5f, -2), Quaternion.identity);
            Instantiate(fish3, new Vector2(-10.5f, -5), Quaternion.identity);
            Instantiate(fish4, new Vector2(10.5f, -10), Quaternion.identity);
            doneSpawning = true;
        }
    }
}
