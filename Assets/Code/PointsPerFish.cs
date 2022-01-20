using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsPerFish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "xSmall")
        {
            Score.playscore += 2;
        }
        if (collision.transform.tag == "Small" )
        {
            Score.playscore += 4;
        }
        if (collision.transform.tag == "Medium" )
        {
            Score.playscore += 6;
        }
        if (collision.transform.tag == "Large" )
        {
            Score.playscore += 8;
        }
        if (collision.transform.tag == "xLarge" )
        {
            Score.playscore += 10;
        }
    }
}
