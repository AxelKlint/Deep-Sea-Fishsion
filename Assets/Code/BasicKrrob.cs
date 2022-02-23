using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicKrrob : MonoBehaviour
{
    [SerializeField]
    float KrrobSpeed;  // Så man kan ändra Krrob speed i Unity - Leo
    int HP = 3;   // Så Krrob har 3 HP
    HookMovement Hooked;
    public bool hookable;
    // Start is called before the first frame update
    void Start()
    {
        Hooked = GetComponent <HookMovement>();  // När Krrob blir krokad så hämta koden för att dra upp den - Leo
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(KrrobSpeed, 0, 0) * Time.deltaTime;   // Krrob rör sig åt sidan - Leo
    } 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")   // Om kollision med "Wall" - Leo
        {
            KrrobSpeed *= -1;   // Ändrar rikting på Krrob - Leo 
        }
        if (collision.gameObject.tag == "Player")  // Om kollision med "Player" - Leo
        {
            HP--;   // -1 HP - Leo
            print("Krabbas liv: " + HP);
        }
        if (HP <= 0)   // OM HP är midre eller lika med 0 - Leo
        {
            hookable = true;   // När HP är 0 så kan man fånga krrob - Leo
        }
    }
}
