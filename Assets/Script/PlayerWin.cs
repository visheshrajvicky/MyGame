using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerWin : MonoBehaviour {
	public Text message1;
	public int playernum;
	public GameObject panel;
	public GameObject resume;
	//public GameObject slider;
	public Image Fill;
	public Slider TimeSlider;
	//public GameObject replay;
	//public AudioClip sound;
	private static int playercount1;
	void Start () {
		//GetComponent<Transform>().position = sound;
		message1.text = "";
		
	}
	void Update(){

		playercount1 = PlayerScript.playercount;

		TimeSlider.value -= (Time.deltaTime * 0.2f);
		if (TimeSlider.value < 5) {

			Fill.color = Color.red;
		}

		if (playercount1 == playernum) {
			//TimeSlider.value -= timeSlice;
			panel.SetActive (true);
			//slider.SetActive (false);
			resume.SetActive (false);
			//Vector3 pos = replay.transform.position;
			//pos.x = 0f;
			//replay.transform.position = pos;
			//replay.transform.position = new Vector3(0,0,0);
			message1.text = "WoW! You Won";
			//playercount1 = 0;
		} 
		else if (TimeSlider.value == 0f) {
			panel.SetActive (true);
			//slider.SetActive (false);
			resume.SetActive (false);
			message1.text = "Ohh! You Lose";
		}

	}
		

}
