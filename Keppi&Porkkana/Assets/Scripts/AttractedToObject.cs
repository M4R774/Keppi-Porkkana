 using UnityEngine;
 using System.Collections;
 
 public class AttractedToObject : MonoBehaviour
 {
 
         public GameObject attractedTo;
         public float strengthOfAttraction = 5.0f;
     
         void Start ()
         {
         }
     
         void FixedUpdate ()
         {
                 Vector3 direction = attractedTo.transform.position - transform.position;
                 gameObject.GetComponent<Rigidbody>().AddForce (strengthOfAttraction * direction);
         
         }
 }
