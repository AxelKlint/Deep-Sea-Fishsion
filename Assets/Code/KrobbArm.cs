using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KrobbArm : MonoBehaviour
{
    //Axel

    // Hastigheten f�r rotationen 
    public float speed = 1.0f;

    void Update()
    {
        /*// Best�mmer vilken riktning klon ska peka
        Vector3 targetDirection = player.position - transform.position;

        // Den roterar med framesen 
        float singleStep = speed * Time.deltaTime;

        // G�r s� att den kan byta h�ll
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 5.0f);

        // G�r s� att den kan byta h�ll ocks�
        transform.rotation = Quaternion.LookRotation(newDirection, Vector3.forward);*/

        transform.Rotate(new Vector3(0, 0, speed));

        if (transform.rotation.z >= 90 || transform.rotation.z <= -10)
        { 
            speed *= -1f;
        }
    }

}