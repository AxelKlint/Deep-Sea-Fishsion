using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Score : MonoBehaviour
{
    public static int playscore; //
    public Text scoretext; // Fixar scoretexten - Edwin
    int score;

    // Start is called before the first frame update
    void Start()
    {
        scoretext = GetComponentInChildren<Text>(); // g�r s� att scoreexten �kar - Edwin
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = "Fishpoints " + (score + playscore).ToString(); // Fixar scoretexten - Edwin
    }
}
