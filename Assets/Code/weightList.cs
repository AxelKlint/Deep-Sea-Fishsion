using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* ---------------------------------------------------------------------------------------------------------------------------------
 * Code that quickly lets me get all of the fishes weights, which then allows the fishes respective code to automatically decide speed.
 * Also the sole reason this is in another code is so that it becomes less cluttered.
 * Made by Alexander Dangiola.
 * ---------------------------------------------------------------------------------------------------------------------------------
*/

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
        else if (this.gameObject.name == "gadda(Clone)")
        {
            weight = 4;
        }
        else if (this.gameObject.name == "fitch(Clone)")
        {
            weight = 9;
        }
        else if (this.gameObject.name == "nebu(Clone)")
        {
            weight = 9;
        }
        else if (this.gameObject.name == "radioactiveTuna(Clone)")
        {
            weight = 4;
        }
        else if (this.gameObject.name == "eyeFish(Clone)")
        {
            weight = 8;
        }
        else if (this.gameObject.name == "cookieCutterShark(Clone)")
        {
            weight = 6;
        }
        else if (this.gameObject.name == "sealThing(Clone)")
        {
            weight = 6;
        }
        else if (this.gameObject.name == "calimary(Clone)")
        {
            weight = 8;
        }
        else if (this.gameObject.name == "eelerfish(Clone)")
        {
            weight = 6;
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
