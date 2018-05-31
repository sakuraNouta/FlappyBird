using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitted : MonoBehaviour {

    public AudioSource audioSource;

    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bird") {
            if(GM.isActive)
                audioSource.Play();
            GM.isActive = false;
        }
    }
}
