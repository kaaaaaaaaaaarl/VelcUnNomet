using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timmer : MonoBehaviour {
	public Objekti objektuSkripts;
	
	public float LaiksAtlicis = 0;
	public GameObject victory;

	public GameObject star1;
	public GameObject star2;
	public GameObject star3;


	public Text tekst;
	static public int winCount=0;
	public int cheet=0;
	public int show=0;
	bool timmerBool=true;
	void Start(){
		victory.SetActive(false);
		star1.SetActive(false);
		star2.SetActive(false);
		star3.SetActive(false);
		winCount=0;
		show=0;
	}

	public void restart(){
		victory.SetActive(false);
		star1.SetActive(false);
		star2.SetActive(false);
		star3.SetActive(false);
		winCount=0;

	
	}
	void Update () {
		if(timmerBool==true){
			LaiksAtlicis += Time.deltaTime;
		}



		show = winCount;
		//winCount = show;

		if(winCount >=11){
			timmerBool = false;
			victory.SetActive(true);
			if(LaiksAtlicis <= 60){
				star3.SetActive(true);
			}

			if(LaiksAtlicis <= 120){
				star2.SetActive(true);
			}

			if(LaiksAtlicis <= 200){
				star1.SetActive(true);
			}


			tekst.text = "jus izterejat " + Mathf.Round(LaiksAtlicis).ToString() + " sekundes";
		}
	}



}
