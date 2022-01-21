using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicKrrob : MonoBehaviour
{
    [SerializeField]
    float KrrobSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
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
    }
}
