﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public HealthBar runBar;

    public int maxRun = 100;
    public int currentRun;

    public float runSpeed;
    public Camera cam;

    Vector2 moveDirection;

    void Start()
    {
        currentRun = maxRun;
        runBar.SetMaxHealth(maxRun);
    }

    // Update is called once per frame
    void Update()
    {
        
        // Input
        
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;
        //ProcessInputs();
    }

    private void FixedUpdate() 
    {

        // Player Movement
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            rb.velocity = new Vector2(moveDirection.x * runSpeed * 1.2f, moveDirection.y * runSpeed * 1.2f);
            TakeDamage(1);
        }
        else
        {
            rb.velocity = new Vector2(moveDirection.x * runSpeed, moveDirection.y * runSpeed);
            TakeDamage(-1);
        }
        //Move();
    }

    void TakeDamage(int damage)
    {
        currentRun -= damage;

        runBar.SetHealth(currentRun);
    }
}
