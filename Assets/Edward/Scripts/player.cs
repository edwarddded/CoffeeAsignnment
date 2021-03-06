﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class player : MonoBehaviour
{
    float movementspeed = 8f;
    Rigidbody2D rb2d;
    float movement = 0f;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        //ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
         movement = Input.GetAxis("Horizontal")* movementspeed;
         animator.SetFloat("Speed", Mathf.Abs(movement));
    }
    void FixedUpdate()
    {
        Vector2 velocity = rb2d.velocity;
        velocity.x = movement;
        rb2d.velocity = velocity;
    }
}
