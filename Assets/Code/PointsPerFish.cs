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
        if (collision.transform.tag == "xSmall") //Fixar s� att man f�r 2 po�ng om man d�dar en fisk i storleken xSmall - Edwin
        {
            Score.playscore += 2;
        }
        if (collision.transform.tag == "Small") //Fixar s� att man f�r 4 po�ng om man d�dar en fisk i storleken Small - Edwin
        {
            Score.playscore += 4;
        }
        if (collision.transform.tag == "Medium") //Fixar s� att man f�r 6 po�ng om man d�dar en fisk i storleken Medium - Edwin
        {
            Score.playscore += 6;
        }
        if (collision.transform.tag == "Large") //Fixar s� att man f�r 8 po�ng om man d�dar en fisk i storleken Large - Edwin
        {
            Score.playscore += 8;

        }
        if (collision.transform.tag == "xLarge") //Fixar s� att man f�r 10 po�ng om man d�dar en fisk i storleken xLarge - Edwin
        {
            Score.playscore += 10;

        }
    }
}
