using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Countdown: MonoBehaviour {

    public float targetTime = 60.0f;

    void Update(){

        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            timerEnded();
        }
    }

    void timerEnded()
    {
        Debug.Log("End");
    }
}