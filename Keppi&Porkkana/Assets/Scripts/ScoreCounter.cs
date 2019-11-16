using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreCounter : MonoBehaviour
{
    // Start is called before the first frame update

    Text scoreAmount;
    private int frames;
    void Start()
    {
        scoreAmount = GetComponent<Text>();  
    }

    // Update is called once per frame
    void Update()
    {
        frames++;
        if(frames % 10 == 0)
        {
            int scoreValue = Int32.Parse(scoreAmount.text);
            scoreAmount.text = (scoreValue + 1).ToString();
        }
    }
}
