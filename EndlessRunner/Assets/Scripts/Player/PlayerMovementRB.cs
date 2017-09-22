using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementRB : MonoBehaviour {

    private Rigidbody rb;
    private Vector3 moveDir;
    public float moveSpeed = 3f;
    public float jumpPower = 4f;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        moveDir = transform.forward;
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector3( moveSpeed, rb.velocity.y, rb.velocity.z);

        if (Input.GetKeyDown(KeyCode.Space))
            Jump();
	}

    public void Jump()
    {
        rb.AddForce(rb.velocity.x, 100f * jumpPower, rb.velocity.z);
    }
}
