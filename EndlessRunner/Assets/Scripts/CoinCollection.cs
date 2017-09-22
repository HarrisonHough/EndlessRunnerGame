using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollection : MonoBehaviour {

    SoundManager soundControl;
	// Use this for initialization
	void Start () {
        soundControl = FindObjectOfType<SoundManager>();
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            CoinCollected(other.gameObject);
        }
    }

    void CoinCollected(GameObject coin)
    {
        //add to score

        //play sound
        soundControl.PlayCoinCollect();
        //destroy coin
        Destroy(coin);
    }
}
