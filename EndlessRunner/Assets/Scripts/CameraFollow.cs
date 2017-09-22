﻿using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
        if (player == null) return;
        transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
	}
}
