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
        //Gör så att armen roterar visa Z-axeln.
        transform.Rotate(new Vector3(0, 0, speed));
        //Gör så att armen byter håll vid två specifika Z positioner.
        if (transform.rotation.eulerAngles.z >= 90 || transform.rotation.eulerAngles.z <= -10)
        {
            speed *= -1;
        }
    }

}