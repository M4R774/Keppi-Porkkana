using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickController : MonoBehaviour
{
    public float maxDistance; 
    public LayerMask layerMask;

    private Vector3 mouse_pos;
    private Vector3 target_pos;
    private bool stick_should_be_down;
    private float target_height; 

    // FixedUpdate is called once physics per frame
    void FixedUpdate() {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, maxDistance, layerMask)){
            transform.position.Set(hit.point.x, 2, hit.point.z);
        }
    }


    void Update() {
        if (true) { // TODO: Button is pressed, cooldown is up, enough money jne. 

        }
        else {
            // Report to player, why putting stick down is not possible
        }
    }


    void StickShouldBeDown() {
        if (true) { 

        }
    }
}
