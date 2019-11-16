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
        _rb.AddRelativeForce(_velocity, ForceMode.VelocityChange);
    }


    void FixedUpdate()
    {
        _rb = this.GetComponent<Rigidbody>();
        if (_rb.velocity != Vector3.zero) {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(_rb.velocity), 0.15F);
        }
    }

}