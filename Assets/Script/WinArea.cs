using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinArea : MonoBehaviour {

	public GameObject Player;
	public GameObject plane;
	public Text message1;

	void Update()
	{
		
		if (Player.transform.position == plane.transform.position) 
		{
			message1.text = "Win the Game";
		}
	}
}
