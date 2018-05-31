using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    public Text Score;
    public GameObject GameOver;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Score.text = "Score:" + GM.score * 1000;
        if (!GM.isActive)
            GameOver.SetActive(true);
	}
}
