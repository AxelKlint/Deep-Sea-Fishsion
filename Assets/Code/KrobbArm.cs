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
        //G�r s� att armen roterar visa Z-axeln.
        transform.Rotate(new Vector3(0, 0, speed));
        //G�r s� att armen byter h�ll vid tv� specifika Z positioner.
        if (transform.rotation.eulerAngles.z >= 90 || transform.rotation.eulerAngles.z <= -10)
        {
            speed *= -1;
        }
    }

}