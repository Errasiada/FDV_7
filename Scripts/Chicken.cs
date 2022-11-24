using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    public Transform player;
    private Vector2 movement;
    public Rigidbody2D rb;

    public float moveSpeed = 8f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        moveCharacter(movement);
    }

    void Update()
    {
        Vector3 direction = player.position - transform.position;
        movement = direction;
        direction.Normalize();
    }

    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
}
