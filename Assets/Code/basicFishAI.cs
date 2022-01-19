using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicFishAI : MonoBehaviour
{
    private float fishPosition;
    float movement;
    private float yMovement;
    private float speed;
    bool lastWasUp;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        speed = weightList.weight;
        fishPosition = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        fishPosition = GameObject.Find(gameObject.name).transform.position.x;
        transform.position += new Vector3(movement, yMovement, 0) * Time.deltaTime;
        if (fishPosition >= 7.9f)
        {
            movement = -1.5f - (speed / 15);  
        }
        if (fishPosition <= -7.9f)
        {
            movement = 1.5f + (speed / 15);
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
    }
}