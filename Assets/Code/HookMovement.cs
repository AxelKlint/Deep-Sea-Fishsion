using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookMovement : MonoBehaviour
{
    [SerializeField]   //S� man kan �ndra keybinds i unity, s� man kan r�ra kroken till h�ger - Leo
    KeyCode Right;

    [SerializeField]   //S� man kan �ndra keybinds i unity, s� man kan r�ra kroken till v�nster - Leo
    KeyCode Left;

    [SerializeField, Range(1, 10)]   //S� man kan best�mma hur snabbt kroken r�r sig i Unity - Leo
    float MovementSpeed;

    [SerializeField]   //S� man kan best�mma hur snabbt kroken sjunker i Unity - Leo
    float SinkSpeed;

    public static bool hasFish = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 0)  //Om kroken kommer �ver Y 0 - Leo
        {
            hasFish = false;
            Destroy(transform.GetChild(0));
            SinkSpeed = 1;
        }
        transform.position -= new Vector3(0, SinkSpeed, 0) * Time.deltaTime; //Kroken sjunker - Leo 

        if (Input.GetKey(Left))
        {
            transform.position -= new Vector3(MovementSpeed, 0, 0) * Time.deltaTime;   //Kroken r�r sig till v�nster - Leo
        }
        if (Input.GetKey(Right))
        {
            transform.position += new Vector3(MovementSpeed, 0, 0) * Time.deltaTime;   //Kroken r�r sig till h�ger - Leo
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "xSmall" || collision.gameObject.tag == "Small" || collision.gameObject.tag == "Medium" || collision.gameObject.tag == "Large" && hasFish == false)  //Om kroken tr�ffar en extra liten fisk - Leo
        {
            collision.transform.parent = gameObject.transform;  //G�r fisken till en child av kroken, den slutar allts� r�ra sig - Leo 
            collision.gameObject.GetComponent<basicFishAI>().enabled = false;  //St�nger av fiskens r�relser - Leo
            SinkSpeed *= -5;  //Kroken �ndrar rikting - Leo
            hasFish = true;
        }

        if (collision.gameObject.tag == "xLarge")  //Om kroken tr�ffar en extra stor fisk - Leo
        {
            ///Koden f�r krob ska vara h�r
            collision.transform.parent = gameObject.transform;  //G�r fisken till en child av kroken, den slutar allts� r�ra sig - Leo 
            collision.gameObject.GetComponent<basicFishAI>().enabled = false;  //St�nger av fiskens r�relser - Leo
            SinkSpeed *= -5;  //Kroken �ndrar rikting - Leo
        }
    }
}
