using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb2d;
    private Vector2 moveInput;

    //Movement

    void Start()
    {

    }

    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
        
        moveInput.Normalize();

        rb2d.velocity = moveInput * moveSpeed;
    }
}



//Health

//Inventory

//Mini Map

//Crafting

//Interact