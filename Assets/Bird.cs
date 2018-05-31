using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

    Rigidbody2D rg;
    AudioSource audioSource;

    public float upforce = 100f;

	// Use this for initialization
	void Start () {
        rg = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1") && GM.isActive) {

            rg.AddForce(Vector2.up * upforce);
            audioSource.Play();
            //rg.AddForce(new Vector2(0, 100f));

        }
	}
}
