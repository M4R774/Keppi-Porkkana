using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeschoolLogic : MonoBehaviour
{
    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Child")
        {
            destroy(collision.gameObject);
            RemoveMoney();
        }
    }
    private void RemoveMoney() {
        // TODO Remove money
    }
}
