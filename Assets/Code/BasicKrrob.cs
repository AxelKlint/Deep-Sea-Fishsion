using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicKrrob : MonoBehaviour
{
    [SerializeField]
    float KrrobSpeed;  // S� man kan �ndra Krrob speed i Unity - Leo
    int HP = 3;   // S� Krrob har 3 HP
    HookMovement Hooked;
    public bool hookable;
    // Start is called before the first frame update
    void Start()
    {
        Hooked = GetComponent <HookMovement>();  // N�r Krrob blir krokad s� h�mta koden f�r att dra upp den - Leo
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(KrrobSpeed, 0, 0) * Time.deltaTime;   // Krrob r�r sig �t sidan - Leo
    } 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")   // Om kollision med "Wall" - Leo
        {
            KrrobSpeed *= -1;   // �ndrar rikting p� Krrob - Leo 
        }
        if (collision.gameObject.tag == "Player")  // Om kollision med "Player" - Leo
        {
            HP--;   // -1 HP - Leo
            print("Krabbas liv: " + HP);
        }
        if (HP <= 0)   // OM HP �r midre eller lika med 0 - Leo
        {
            hookable = true;   // N�r HP �r 0 s� kan man f�nga krrob - Leo
        }
    }
}
