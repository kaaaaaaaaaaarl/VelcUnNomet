using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objecti : MonoBehaviour {
	public Canvas kanva;
	// Use this for initialization
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;

	[HideInInspector]
	public Vector2 atkrKoord;
	[HideInInspector]
	public Vector2 atraKoord;
	[HideInInspector]
	public Vector2 bussKoord;

	public AudioSource skanasavots;
	public AudioClip[] skanaKoAtskanot;
	[HideInInspector]
	public bool vaiIastaVieta = false;
	public GameObject pedejaisVilk = null;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
