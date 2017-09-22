using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour {

    public PlayerMovement playerMovement;
	// Use this for initialization
	void Start () {
       playerMovement =  GetComponent<PlayerMovement>();
	}
	
	// Update is called once per frame
	void Update () {
        InputCheck();
	}

    void InputCheck()
    {

        /*if (Input.GetKey(KeyCode.D))
        {
            playerMovement.MovePlayer();
        }*/
        if (playerMovement == null) return;
        Debug.Log("is grounded = " + playerMovement.IsGrounded());
        if (playerMovement.IsGrounded())
        {
            playerMovement.SetMoveDirection();
            if (Input.GetKeyDown(KeyCode.Space))
            {
                playerMovement.Jump();
                
            }
        }

        playerMovement.Move();
    }
}
