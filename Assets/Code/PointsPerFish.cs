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
        if (collision.transform.tag == "xSmall") //Fixar så att man får 2 poäng om man dödar en fisk i storleken xSmall - Edwin
        {
            Score.playscore += 2;
        }
        if (collision.transform.tag == "Small") //Fixar så att man får 4 poäng om man dödar en fisk i storleken Small - Edwin
        {
            Score.playscore += 4;
        }
        if (collision.transform.tag == "Medium") //Fixar så att man får 6 poäng om man dödar en fisk i storleken Medium - Edwin
        {
            Score.playscore += 6;
        }
        if (collision.transform.tag == "Large") //Fixar så att man får 8 poäng om man dödar en fisk i storleken Large - Edwin
        {
            Score.playscore += 8;

        }
        if (collision.transform.tag == "xLarge") //Fixar så att man får 10 poäng om man dödar en fisk i storleken xLarge - Edwin
        {
            Score.playscore += 10;

        }
    }
}
