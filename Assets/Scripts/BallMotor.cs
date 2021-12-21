using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMotor : MonoBehaviour
{
    [SerializeField] private float ballForce = 200f;
    
    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        var xInput = Input.GetAxis("Horizontal");
        var zInput = Input.GetAxis("Vertical");
        var direction = new Vector3(xInput, 0, zInput);
        
        if(xInput != 0 || zInput != 0)
            _rb.AddForce(direction * ballForce * Time.deltaTime, ForceMode.VelocityChange);
    }
}
