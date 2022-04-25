using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float Speed = 3.0f;
    private Rigidbody _rigidbody;
    private void Start()
    {
       _rigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    //protected void Move()
    {
        float a = Input.GetAxis("Horizontal");
        float b = Input.GetAxis("Vertical");
       // float c = Input.GetAxis("Jump");

        Vector3 movement = new Vector3(a, 0, b);
        _rigidbody.AddForce(movement * Speed);
    }
}