using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    public float runSpeed;
    public Camera cam;

    Vector2 moveDirection;

    /*void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }*/

    // Update is called once per frame
    void Update()
    {
        // Input
        ProcessInputs();
        //float horizontal = Input.GetAxisRaw("Horizontal");
        //float vertical = Input.GetAxisRaw("Verticel");
    }

    private void FixedUpdate() 
    {
        // Player Movement
        Move();
        //rb.velocity = new Vector2(horizontal * runSpeed /* Time.fixedDeltaTime*/, vertical * runSpeed /* Time.fixedDeltaTime*/);
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;
    }
    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * runSpeed, moveDirection.y * runSpeed);
    }
}
