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
    [SerializeField, Range(1, 10)]   //S� man kan best�mma hur snabbt kroken sjunker i Unity - Leo
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
            transform.position -= new Vector3(MovementSpeed, 0, 0) * Time.deltaTime;   //Kroken r�r sig till v�nster - Leo
        }
        if (Input.GetKey(Right))
        {
            transform.position += new Vector3(MovementSpeed, 0, 0) * Time.deltaTime;   //Kroken r�r sig till h�ger - Leo
        }
    }
}
