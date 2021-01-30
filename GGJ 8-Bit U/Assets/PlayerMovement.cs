using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rd;

    // Update is called once per frame
    void Update()
    {
        // Input
        Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate() 
    {
        // Player Movement

    }

}
