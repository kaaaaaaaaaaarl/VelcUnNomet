using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	//Uzglabā ainā esošo kanvu
	public Canvas kanva;
	//GameObject, kas uzglabās velkamos objektus
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
	public GameObject b2;
	public GameObject e46;
	public GameObject cementaMasina;
	public GameObject policija;
	public GameObject traktor1;
	public GameObject traktor2;
	public GameObject udens;
	public GameObject eskavator;

	//Uzglabā velakmo objektu sākotnējās atrašanās vietas koordinātas
	[HideInInspector]
	public Vector2 atkrKoord;
	[HideInInspector]
	public Vector2 atroKoord;
	[HideInInspector]
	public Vector2 bussKoord;
	[HideInInspector]
	public Vector2 b2koord;
	[HideInInspector]
	public Vector2 cementakoord;
	[HideInInspector]
	public Vector2 e46koord;
	[HideInInspector]
	public Vector2 eskavatorskoord;
	[HideInInspector]
	public Vector2 traktor1koord;
	[HideInInspector]
	public Vector2 policijakoord;
	[HideInInspector]
	public Vector2 traktor2koord;
	[HideInInspector]
	public Vector2 Udenskoord;

	//Uzglabās audio avotu, kurā atskaņot attēlu skaņas efektus
	public AudioSource skanasAvots;
	//Masīvs, kas uzglabā visas iespējamās skaņas
	public AudioClip[] skanaKoAtskanot;
	public bool[] vina;
	//Mainīgais piefiksē vai objekts nolikts īstajāvietā (true/false)
	[HideInInspector]
	public bool vaiIstajaVieta = false;
	//Uzglabās pēdējo objektu, kurš pakustināts
	public GameObject pedejaisVIlktais = null;



	// Use this for initialization
	void Start () {
		atkrKoord = atkritumuMasina.GetComponent<RectTransform> ().localPosition;
		atroKoord = atraPalidziba.GetComponent<RectTransform> ().localPosition;
		bussKoord = autobuss.GetComponent<RectTransform> ().localPosition;
		b2koord = b2.GetComponent<RectTransform> ().localPosition;
		cementakoord = cementaMasina.GetComponent<RectTransform> ().localPosition;
		e46koord = e46.GetComponent<RectTransform> ().localPosition;
		eskavatorskoord = eskavator.GetComponent<RectTransform> ().localPosition;
		traktor1koord = traktor1.GetComponent<RectTransform> ().localPosition;
		policijakoord = policija.GetComponent<RectTransform> ().localPosition;
		traktor2koord = traktor2.GetComponent<RectTransform> ().localPosition;
		Udenskoord = udens.GetComponent<RectTransform> ().localPosition;
	}
}
