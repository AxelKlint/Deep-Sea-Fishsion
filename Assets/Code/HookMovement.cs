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
            Destroy(transform.GetChild(0).gameObject);
            hasFish = false;
            SinkSpeed = 2;
            transform.position = new Vector2(0, 0);
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
        if (collision.gameObject.tag == "xSmall" && hasFish == false || collision.gameObject.tag == "Small" && hasFish == false || collision.gameObject.tag == "Medium" && hasFish == false || collision.gameObject.tag == "Large" && hasFish == false)  //Om kroken tr�ffar en fisk - Leo
        {
            collision.transform.parent = gameObject.transform;  //G�r fisken till en child av kroken, den slutar allts� r�ra sig - Leo 
            if (collision.gameObject.GetComponent<basicFishAI>().enabled == true)
            {
                collision.gameObject.GetComponent<basicFishAI>().enabled = false;  //St�nger av fiskens r�relser - Leo

            }
            else if (collision.gameObject.GetComponent<followingAI>().enabled == true)
            {
                collision.gameObject.GetComponent<followingAI>().enabled = false;  //St�nger av fiskens r�relser - Alex

            }

            collision.transform.localPosition = new Vector3 (0, -5.1f, 0);
            SinkSpeed = -5;  //Kroken �ndrar rikting - Leo
            hasFish = true;
        }

        if (collision.gameObject.tag == "xLarge")  //Om kroken tr�ffar en extra stor fisk - Leo
        {
            collision.transform.parent = gameObject.transform;  //G�r fisken till en child av kroken, den slutar allts� r�ra sig - Leo 
            collision.gameObject.GetComponent<BasicKrrob>().enabled = false;  //St�nger av fiskens r�relser - Leo
            collision.transform.localPosition = new Vector3(0, -5.1f, 0);
            SinkSpeed = -5;  //Kroken �ndrar rikting - Leo
            hasFish = true;
            StartCoroutine(StunHook());
        }

        if (collision.gameObject.tag == "Bottom")
        {
            SinkSpeed = -5;
        }
       
    }

    IEnumerator StunHook()
    {
        
        SinkSpeed = -8;
        yield return  new WaitForSeconds(1.5f);
        SinkSpeed = 1;
    }
}
