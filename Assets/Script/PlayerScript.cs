using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour 

{	public float speed;
	
	public GameObject player;
	public AudioSource audio;
	//public AudioClip sound;

	public static int playercount;

	private Rigidbody rb;
	private float sideSpeed = 2.0f;
void Start()
	{
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
		//music = PlayerWin.sound;

		rb = GetComponent<Rigidbody> ();
		playercount = NextOnClick.count;
	}
	float moveVertical;
	float moveHorizontal;
	
		void FixedUpdate()
	{
		if (Application.isMobilePlatform) {
			moveHorizontal = Input.acceleration.x * sideSpeed*2;
			moveVertical = Input.acceleration.y * sideSpeed*2;

		}	else {
			moveVertical = Input.GetAxis ("Vertical")*sideSpeed;
			moveHorizontal = Input.GetAxis ("Horizontal")*sideSpeed;}
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);//*sideSpeed;

		rb.AddForce (movement*speed);
		

	}

	void OnTriggerEnter(Collider other)
	{	
		
		if (other.gameObject.CompareTag ("Player")) 
		{	
		 	//audio = GetComponent<AudioSource> ();
			//music.Play ();
			audio.Play();
			Destroy (gameObject);
			playercount++;
		}
	
	}


}
