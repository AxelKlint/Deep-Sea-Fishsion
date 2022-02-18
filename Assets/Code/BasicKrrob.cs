using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicKrrob : MonoBehaviour
{
    [SerializeField]
    float KrrobSpeed;
    int HP = 3;
    HookMovement Hooked;
    public bool hookable;
    // Start is called before the first frame update
    void Start()
    {
        Hooked = GetComponent <HookMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(KrrobSpeed, 0, 0) * Time.deltaTime;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            KrrobSpeed *= -1;
        }
        if (collision.gameObject.tag == "Player")
        {
            HP--;
            print("Krabbas liv: " + HP);
        }
        if (HP <= 0)
        {
            hookable = true;
        }
    }
}
