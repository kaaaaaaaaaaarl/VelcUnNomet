using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timmer : MonoBehaviour {
	public Objekti objektuSkripts;
	
	public float LaiksAtlicis = 0;
	void Update () {

			LaiksAtlicis += Time.deltaTime;

	}
}
