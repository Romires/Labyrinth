using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    [SerializeField] private float speed; 
    void Start()
    {
        
    }

    void Update()
    {
       Walk(speed);
    }

    public void Walk (float m)
    {
        var a = Input.GetAxis("Horizontal");
        var b = Input.GetAxis("Vertical");
        var c = Input.GetAxis("Jump");

        var direction = new Vector3(a, c, b);
        transform.position = transform.position + m * direction * Time.deltaTime;
    }
}
