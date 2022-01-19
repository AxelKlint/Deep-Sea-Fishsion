using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weightList : MonoBehaviour
{
    [SerializeField]
    public static int testWeight;
    public static int weight;
    //10 weight is the lightest and 1 is the heaviest
    // Start is called before the first frame update
    void Start()
    {
        if (this.gameObject.name == "goldFish(Clone)")
        {
            weight = 8;
        }
        else if (this.gameObject.name == "xSmallFish")
        {
            weight = 10;
        }
        else if (this.gameObject.name == "xSmallFish2")
        {
            weight = 9;
        }
        else if (this.gameObject.name == "Krrabb")
        {
            weight = 1;
        }
        else
        {
            weight = 5;
        }

    }

    // Update is called once per frame
    void Update()
    {
        weight = testWeight;
    }
}
