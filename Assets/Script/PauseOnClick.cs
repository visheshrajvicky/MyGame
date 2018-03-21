using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseOnClick : MonoBehaviour {
	public GameObject panel;
	public GameObject resume;
	//public GameObject PuaseButton;
	//public GameObject slider;
	public bool pause;
	// Use this for initialization
	void Start () {
		pause = false;
	}

	public void onPause(){

		pause = !pause;
		if (!pause) {
			Time.timeScale = 1;
			panel.SetActive(false);
			//PuaseButton.SetActive (true);
			//slider.SetActive (true);
		} else if (pause) {
			Time.timeScale = 0;
			//PuaseButton.SetActive (false);
			panel.SetActive(true);
			//slider.SetActive (false);
			//print("df");
			resume.SetActive (true);
		}
	}
}
