using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float horizontal;


    public Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer render;
    void Start()
    {
        render = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        bool isMoving = rb.velocity.x != 0;
        anim.SetBool("isMoving", isMoving);
        
        horizontal = (Input.GetAxisRaw("Horizontal"));
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        Flip();
    }

    private void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    private void Flip()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            render.flipX = false;
        }

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            render.flipX = true;
        }
    }
}
