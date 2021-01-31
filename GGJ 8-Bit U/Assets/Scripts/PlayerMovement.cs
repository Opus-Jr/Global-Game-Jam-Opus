using System.Collections;
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
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            for (int r = currentRun; r > 0; r--)  {
                rb.velocity = new Vector2(moveDirection.x * runSpeed * 2.5f, moveDirection.y * runSpeed * 2.5f);
                TakeDamage(1);
            } }
        else{
            
            TakeDamage(-1);
        }
        rb.velocity = new Vector2(moveDirection.x * runSpeed, moveDirection.y * runSpeed);
        //Move();
    }

    void TakeDamage(int damage)
    {
        currentRun -= damage;

        runBar.SetHealth(currentRun);
    }
}
