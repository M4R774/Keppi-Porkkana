using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantVelocityWithCollision : MonoBehaviour
{
    private Rigidbody _rb;
    private Vector3 _velocity;

    // Use this for initialization
    void Start()
    {
        _rb = this.GetComponent<Rigidbody>();

        _velocity = new Vector3(0f, 0f, 3f);
        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(_velocity), 0.15F);
        _rb.AddForce(_velocity, ForceMode.VelocityChange);
    }

    void OnCollisionEnter(Collision collision){
        ReflectProjectile(_rb, collision.contacts[0].normal);
    }

    private void ReflectProjectile(Rigidbody rb, Vector3 reflectVector)
    {    
        _velocity = Vector3.Reflect(_velocity, reflectVector);
        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(_velocity), 0.15F);
        _rb.velocity = _velocity;
    }


    void Update()
    {
        _rb = this.GetComponent<Rigidbody>();
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(_rb.velocity), 0.15F);
    }

}