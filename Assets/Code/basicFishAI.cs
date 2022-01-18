using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicFishAI : MonoBehaviour
{
    private float fishPosition;
    float movement;
    float random;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = Time.deltaTime;
        fishPosition = GameObject.Find(gameObject.name).transform.position.x;
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime;
        if (fishPosition >= 7.9f)
        {
            movement = -1.5f;  
        }
        if (fishPosition <= -7.9f)
        {
            movement = 1.5f;
        }
    }
}