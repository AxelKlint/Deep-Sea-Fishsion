using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicFishAI : MonoBehaviour
{
    [SerializeField]
    public float fishPosition;
    // Start is called before the first frame update
    void Start()
    {
        fishPosition = GameObject.Find(gameObject.name).transform.position.x;

    }

    // Update is called once per frame
    void Update()
    {
        //if(fishPosition >= 7.9f)
        {
            transform.position += new Vector3(-16, 0, 0) * Time.deltaTime;
        }
        //if (fishPosition <= -7.9f)
        {
            transform.position += new Vector3(16, 0, 0) * Time.deltaTime;
        }
    }
}
