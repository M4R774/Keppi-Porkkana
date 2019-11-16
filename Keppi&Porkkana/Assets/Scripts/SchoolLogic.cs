using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchoolLogic : MonoBehaviour
{
    private ScoreCounter scoreCounter;
    void Start() {
         scoreCounter = GameObject.FindGameObjectWithTag("ScoreAmount").GetComponent<ScoreCounter>();
    }
    
    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Child")
        {
            Destroy(collision.gameObject);
            AddMoney();
        }
    }
    private void AddMoney() {
        if(scoreCounter != null)
        {
            scoreCounter.IncreaseScore(1);
        }
    }
}
