using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    [SerializeField]
    private AudioSource sfxAudio;
    [SerializeField]
    private AudioSource musicAudio;

    public AudioClip[] sfxClips;
    public AudioClip[] musicClips;

    

	// Use this for initialization
	void Start () {

        //TODO make this safer
        if(sfxAudio == null)
            sfxAudio = transform.GetChild(0).GetComponent<AudioSource>();
        if(musicAudio == null)
            musicAudio = transform.GetChild(1).GetComponent<AudioSource>();
    }

    public void PlayCoinCollect()
    {
        //TODO make this refer to dictionary
        sfxAudio.PlayOneShot(sfxClips[0]);
    }

    public void PlayDeath()
    {
        sfxAudio.PlayOneShot(sfxClips[1]);
    }
}
