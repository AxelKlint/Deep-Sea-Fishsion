using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicFishAI : MonoBehaviour
{
    private float fishPosition;
    int movement;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        fishPosition = GameObject.Find(gameObject.name).transform.position.x;
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime;

        if (fishPosition >= 7.9f)
        {
            movement = -1;
        }
        if (fishPosition <= -7.9f)
        {
            movement = 1;
        }
    }
}
