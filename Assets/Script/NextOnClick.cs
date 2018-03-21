using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextOnClick : MonoBehaviour {
	public GameObject panel;
	public static int count;

	//public bool replay;
	public void LoadScene(){
		UnityEngine.SceneManagement.SceneManager.LoadScene (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().buildIndex);
		Time.timeScale = 1;
		count = 0;
		panel.SetActive (false);
	}

	public void BackToMenu(){
	
		UnityEngine.SceneManagement.SceneManager.LoadScene ("Main");
		count = 0;
		Destroy (GameObject.FindWithTag("music"));
	}

	public void NextLevel(int level){

		UnityEngine.SceneManagement.SceneManager.LoadScene (level + 1);
		Time.timeScale = 1;
		count = 0;
	}

	public void PrevLevel(int level){

		UnityEngine.SceneManagement.SceneManager.LoadScene (level - 1);
		Time.timeScale = 1;
		count = 0;
	}

	public void QuitGame(){

		Application.Quit ();
	}
}