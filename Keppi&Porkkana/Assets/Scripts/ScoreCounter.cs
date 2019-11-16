using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreCounter : MonoBehaviour
{
    // Start is called before the first frame update

    Text scoreAmount;
    private int scoreValue;
    void Start()
    {
        scoreValue = 0;
        scoreAmount = GetComponent<Text>();  
    }

    public int GetScoreValue()
    {
        return scoreValue;
    }

    public void IncreaseScore(int increaseAmount)
    {
        this.scoreValue += increaseAmount;
        scoreAmount.text = this.scoreValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
