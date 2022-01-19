using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookMovement : MonoBehaviour
{
    [SerializeField]   //Så man kan ändra keybinds i unity, så man kan röra kroken till höger - Leo
    KeyCode Right;

    [SerializeField]   //Så man kan ändra keybinds i unity, så man kan röra kroken till vänster - Leo
    KeyCode Left;

    [SerializeField, Range(1, 10)]   //Så man kan bestämma hur snabbt kroken rör sig i Unity - Leo
    float MovementSpeed;

    [SerializeField]   //Så man kan bestämma hur snabbt kroken sjunker i Unity - Leo
    float SinkSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, SinkSpeed, 0) * Time.deltaTime; //Kroken sjunker - Leo 

        if (Input.GetKey(Left))
        {
            transform.position -= new Vector3(MovementSpeed, 0, 0) * Time.deltaTime;   //Kroken rör sig till vänster - Leo
        }
        if (Input.GetKey(Right))
        {
            transform.position += new Vector3(MovementSpeed, 0, 0) * Time.deltaTime;   //Kroken rör sig till höger - Leo
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Fish")  //Om kroken träffar en fisk - Leo
        {
            collision.transform.parent = gameObject.transform;  //Gör fisken till en child av kroken, den slutar alltså röra sig - Leo 
            collision.gameObject.GetComponent<basicFishAI>().enabled = false;  //Stänger av fiskens rörelser - Leo
            SinkSpeed *= -5;  //Kroken ändrar rikting - Leo
        }
    }
}
