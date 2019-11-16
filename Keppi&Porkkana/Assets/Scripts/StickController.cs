using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickController : MonoBehaviour
{
    public float stick_up_height;
    public float stick_down_height;
    public float stick_down_time;
    public float maxDistance; 
    public LayerMask layerMask;
    private float stick_target_height; 
    private float stick_lowered_until;


    // FixedUpdate is called once physics per frame
    void FixedUpdate() {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, maxDistance, layerMask)) {
            Vector3 target = hit.point;
            target.y = stick_target_height;
            GetComponent<Rigidbody>().AddForce((target - transform.position) * 100);
            // TODO: Height
        }
    }


    void Update() {
        if (Input.GetMouseButtonDown(0) && StickLoweringIsAvailable()) { 
            stick_lowered_until = Time.time + stick_down_time;
        }
        else {
            // TODO: Report to player, why putting stick down is not possible
        }
        DetermineStickHeight();
    }


    void DetermineStickHeight() {
        if (stick_lowered_until < Time.time) { 
            stick_target_height = stick_up_height; 
        }
        else {
            stick_target_height = stick_down_height; 
        }
    }


    bool StickLoweringIsAvailable() {
        return true;
    }
}
