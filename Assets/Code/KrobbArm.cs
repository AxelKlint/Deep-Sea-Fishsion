using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KrobbArm : MonoBehaviour
{
    //Axel

    // Hastigheten för rotationen 
    public float speed = 1.0f;

    void Update()
    {
        /*// Bestämmer vilken riktning klon ska peka
        Vector3 targetDirection = player.position - transform.position;

        // Den roterar med framesen 
        float singleStep = speed * Time.deltaTime;

        // Gör så att den kan byta håll
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 5.0f);

        // Gör så att den kan byta håll också
        transform.rotation = Quaternion.LookRotation(newDirection, Vector3.forward);*/

        transform.Rotate(new Vector3(0, 0, speed));

        if (transform.rotation.z >= 90 || transform.rotation.z <= -10)
        { 
            speed *= -1f;
        }
    }

}