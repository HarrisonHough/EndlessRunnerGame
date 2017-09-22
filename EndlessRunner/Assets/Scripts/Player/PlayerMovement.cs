using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    CharacterController controller;
    public float moveSpeed = 1f;
    public float jumpSpeed = 4f;
    public float gravity = 20.0F;
    private Vector3 moveDirection;
    private Rigidbody rb;
    public LayerMask mask;

	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
        moveDirection = new Vector3(0,0,0);
        rb = GetComponent<Rigidbody>();
	}

    public void SetMoveDirection()
    {
        moveDirection = transform.forward * moveSpeed;
        //Debug.Log("Set move dir = " + moveDirection);
    }
    public void Move()
    {
        //Debug.Log("Moving char = " + moveDirection);
        moveDirection.y -= gravity * Time.deltaTime;
        //moveDirection.y = rb.velocity.y;
        controller.Move(moveDirection);
        //rb.AddForce(-transform.up * gravity);
    } 

    public void Jump()
    {
        moveDirection.y += jumpSpeed;
    }

    public bool IsGrounded()
    {
        return controller.isGrounded;
    }

    private void Update()
    {
        Debug.Log("drawing ray");
        Debug.DrawRay(transform.position, transform.up * 1.0f, Color.red);
    }

    public void OnCollisionEnter(Collision collision)
    {
        RaycastHit hit;
        //moveDirection.y = 0;
        if (Physics.Raycast(transform.position, transform.up, out hit, 1.0f, mask))
        {
            Debug.Log("Player Hit Head, move down");
            moveDirection.y = 0;
        }
    }
}
