using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    private float speed = 1;
    void Start()
    {

    }

    void Update()
    {
        var a = Input.GetAxis("Horizontal");
        var b = Input.GetAxis("Vertical");
        var c = Input.GetAxis("Jump");

        var direction = new Vector3(a, c, b);
        transform.position = transform.position + speed * direction * Time.deltaTime;
    }
}

