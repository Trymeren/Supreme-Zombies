using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody rb;
    private Vector3 moveInput;

    //Movement

    void Start()
    {

    }

    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.z = Input.GetAxisRaw("Vertical");
        
        moveInput.Normalize();

        rb.velocity = moveInput * moveSpeed;
    }
}



//Health

//Inventory

//Mini Map

//Crafting

//Interact