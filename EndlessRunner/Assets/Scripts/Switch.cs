using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

    [SerializeField]
    private Animator anim;


    private void Reset()
    {
        if (anim == null)
            anim = GetComponent<Animator>();
    }

    // Use this for initialization
    void Start () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            TriggerSwitch();
        }
    }

    void TriggerSwitch()
    {
        Debug.Log("Switch Triggered");

        // Play switch animation or particles
        anim.SetBool("SwitchOn", true);

        // Run function on Trigger

    }
}
