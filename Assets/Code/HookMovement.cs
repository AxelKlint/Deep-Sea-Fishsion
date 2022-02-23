using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookMovement : MonoBehaviour
{
    [SerializeField]   //Så man kan ändra keybinds i unity, så man kan röra kroken till höger - Leo
    KeyCode Right;

    [SerializeField]   //Så man kan ändra keybinds i unity, så man kan röra kroken till vänster - Leo
    KeyCode Left;

    [SerializeField]   //Så man kan ändra keybinds i unity, så man kan röra kroken till höger med en annan knapp - Leo
    KeyCode RightArrow;

    [SerializeField]   //Så man kan ändra keybinds i unity, så man kan röra kroken till vänster med en annan knapp - Leo
    KeyCode LeftArrow;

    [SerializeField]   //Så man kan ändra keybinds i unity, så man kan sänka farten på kroken - Leo
    KeyCode SlowDown;

    [SerializeField]   //Så man kan ändra keybinds i unity, så man kan sänka farten på kroken med en annan knapp - Leo
    KeyCode SlowDownArrow;

    [SerializeField]   //Så man kan ändra keybinds i unity, så man kan öka farten på kroken - Leo
    KeyCode SpeedUp;

    [SerializeField]   //Så man kan ändra keybinds i unity, så man kan öka farten på kroken - Leo
    KeyCode SpeedUpArrow;

    [SerializeField, Range(1, 10)]   //Så man kan bestämma hur snabbt kroken rör sig i Unity - Leo
    float MovementSpeed;

    [SerializeField]   //Så man kan bestämma hur snabbt kroken sjunker i Unity - Leo
    float SinkSpeed;

    public static bool hasFish = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 0)  //Om kroken kommer över Y 0 - Leo
        {
            Destroy(transform.GetChild(0).gameObject);
            hasFish = false;
            SinkSpeed = 3;
            transform.position = new Vector2(0, 0);
        }
        transform.position -= new Vector3(0, SinkSpeed, 0) * Time.deltaTime; //Kroken sjunker - Leo 
        

        if (Input.GetKey(Left) || Input.GetKey(LeftArrow))
        {
            transform.position -= new Vector3(MovementSpeed, 0, 0) * Time.deltaTime;   //Kroken rör sig till vänster - Leo
        }
        if (Input.GetKey(Right) || Input.GetKey(RightArrow))
        {
            transform.position += new Vector3(MovementSpeed, 0, 0) * Time.deltaTime;   //Kroken rör sig till höger - Leo
        }
        if (Input.GetKey(SlowDown) || Input.GetKey(SlowDownArrow))
        {
            transform.position += new Vector3(0, 1.75f, 0) * Time.deltaTime;   //Kroken rör sig till höger med en annan knapp(pilarna) - Leo
        }
        if (Input.GetKey(SpeedUp) || Input.GetKey(SpeedUpArrow))   
        {
            transform.position -= new Vector3(0, 5, 0) * Time.deltaTime;   //Kroken rör sig till höger med en annan knapp(pilarna) - Leo
        }
    }

  

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "xSmall" && hasFish == false || collision.gameObject.tag == "Small" && hasFish == false || collision.gameObject.tag == "Medium" && hasFish == false || collision.gameObject.tag == "Large" && hasFish == false)  //Om kroken träffar en fisk - Leo
        {
            collision.transform.parent = gameObject.transform;  //Gör fisken till en child av kroken, den slutar alltså röra sig - Leo 
            if (collision.gameObject.GetComponent<basicFishAI>() != null)
            {
                    collision.gameObject.GetComponent<basicFishAI>().enabled = false;  //Stänger av fiskens rörelser - Leo
            }
           
            else if (collision.gameObject.GetComponent<followingAI>() != null)
            {
                collision.gameObject.GetComponent<followingAI>().enabled = false;  //Stänger av fiskens rörelser - Alex

            }
                
            collision.transform.localPosition = new Vector3 (0, -5.1f, 0);
            SinkSpeed = -5;  //Kroken ändrar rikting - Leo
            hasFish = true;
        }

        if (collision.gameObject.tag == "xLarge" && hasFish == false)  //Om kroken träffar en extra stor fisk - Leo
        {      
            
            if (collision.gameObject.GetComponent<BasicKrrob>().hookable)
            {
                collision.gameObject.GetComponent<BasicKrrob>().enabled = false;  //Stänger av fiskens rörelser - Leo
                collision.transform.parent = gameObject.transform;  //Gör fisken till en child av kroken, den slutar alltså röra sig - Leo 
                SinkSpeed = -8;  //Kroken ändrar rikting - Leo
                hasFish = true;
            }
            else
            {
                StartCoroutine(StunHook());
            }
            
            
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
        SinkSpeed = 3;
    }
}
