using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicFishAI : MonoBehaviour
{
    private float fishPosition;
    float movement;
    public float yMovement;
    float yPosition;
    bool lastWasUp;
    float timer;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        yMovement = 0;
        yPosition = GameObject.Find(name).transform.position.y;
        speed = weightList.weight / 5;

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        fishPosition = GameObject.Find(gameObject.name).transform.position.x;
        transform.position += new Vector3(movement, yMovement, 0) * Time.deltaTime;
        if (fishPosition >= 7.9f)
        {
            movement = -1.5f + (speed / 10);  
        }
        if (fishPosition <= -7.9f)
        {
            movement = 1.5f - (speed / 10);
        }
        if (yMovement == 0 && lastWasUp == true && timer >= 0.1f)
        {
            yMovement += -0.5f;
            lastWasUp = true;
            print("up");
            timer = 0;
        }
        if (yMovement == 0  && lastWasUp == false && timer >= 0.1f)
        {
            yMovement += 0.5f;
            print("down");
            timer = 0;
        }
        if (yMovement == 0.5f && timer >= 0.1f)
        {
            yMovement = 0;
            lastWasUp = true;
            print("mid1");
            timer = 0;
        }
        if (yMovement == -0.5f && timer >= 0.1f)
        {
            yMovement = 0;
            print("mid2");
            lastWasUp = false;
            timer = 0;

        }
    }
}