using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class switchScene : MonoBehaviour {

	// Use this for initialization
	public void NextScene() {
		SceneManager.LoadScene("Pilseta");
		
	}
	public void Pause() {
		SceneManager.LoadScene("start");
	}
	

}
