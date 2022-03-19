﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class NomesanasVieta : MonoBehaviour, IDropHandler {
	//Uzglabās velkamā objekta un nomešanas lauka z rotāciju,
	// kāarī rotācijas un izmēru pieļaujamo starpību
	private float vietasZrot, velkObjZrot, rotacijasStarpiba, xIzmeruStarp, yIzmeruStarp;
	private Vector2 vietasIzm, velkObjIzm;
	//Norāde uz Objekti skriptu
	public Objekti objektuSkripts;

	//Nostrādās, ja objektu cenšas nomest uz jebkuras nomešanas  vietas
	public void OnDrop(PointerEventData notikums){
		//Pārbauda vai tika vilkts un atlaists vispār kāds objekts
		if (notikums.pointerDrag != null) {
			//Ja nomešanas vietas tags sakrīt ar vilktā objekta tagu
			if (notikums.pointerDrag.tag.Equals (tag)) {
				//Iegūst objekta rotāciju grādos
				vietasZrot = notikums.pointerDrag.GetComponent<RectTransform> ().eulerAngles.z;
				velkObjZrot = GetComponent<RectTransform> ().eulerAngles.z;
				//Aprēkina abu objektu z rotācijas starpību
				rotacijasStarpiba = Mathf.Abs (vietasZrot - velkObjZrot);
				//Līdzīgi kā ar Z rotāciju, jāpiefiksē objektu izmēri pa x un y asīm, kā arī starpība
				vietasIzm = notikums.pointerDrag.GetComponent<RectTransform> ().localScale;
				velkObjIzm = GetComponent<RectTransform> ().localScale;
				xIzmeruStarp = Mathf.Abs (vietasIzm.x - velkObjIzm.x);
				yIzmeruStarp = Mathf.Abs (vietasIzm.y - velkObjIzm.y);


				//Pārbauda vai objektu rotācijas un izmēru starpība ir pieļaujamajās robēžās
				if ((rotacijasStarpiba <= 6 || (rotacijasStarpiba >= 354 && rotacijasStarpiba <= 360))
				   && (xIzmeruStarp <= 0.1 && yIzmeruStarp <= 0.1)) {
					objektuSkripts.vaiIstajaVieta = true;
					//Noliktais objekts smuki iecentrējas nomešanas laukā
					notikums.pointerDrag.GetComponent<RectTransform> ().anchoredPosition 
								= GetComponent<RectTransform> ().anchoredPosition;
					//Rotācijai
					notikums.pointerDrag.GetComponent<RectTransform> ().localRotation
								= GetComponent<RectTransform> ().localRotation;
					//Izsmēram
					notikums.pointerDrag.GetComponent<RectTransform> ().localScale
					= GetComponent<RectTransform> ().localScale;



					//Pārbauda tagu un atskaņo atbilstošo skaņas efektu
					switch (notikums.pointerDrag.tag) {
					case "Atkritumi":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [1]);
						objektuSkripts.vina [0] = true;
						break;

					case "Slimnica":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [2]);
						objektuSkripts.vina [1] = true;
						break;

					case "Skola":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [4]);
						objektuSkripts.vina [2] = true;
						break;

					case "b2":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [3]);
						objektuSkripts.vina [3] = true;
						break;
					case "e46":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [4]);
						objektuSkripts.vina [4] = true;
						break;
					case "cementaMasina":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [5]);
						objektuSkripts.vina [5] = true;
						break;
					case "policija":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [6]);
						objektuSkripts.vina [6] = true;
						break;
					case "traktor1":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [7]);
						objektuSkripts.vina [7] = true;
						break;
					case "traktor2":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [9]);
						objektuSkripts.vina [8] = true;
						break;
					case "udens":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [10]);
						objektuSkripts.vina [9] = true;
						break;
					case "eskavator":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [11]);
						objektuSkripts.vina [10] = true;
						break;


					default:
						Debug.Log ("Nedefinēts tags!");
						break;
					}

				}
			
				//Ja objekts nomests nepareizajā laukā
			} else {
				objektuSkripts.vaiIstajaVieta = false;
				objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanaKoAtskanot [0]);

				//Objektu aizmet uz sākotnējo pozīciju
				switch (notikums.pointerDrag.tag) {
				case "Atkritumi":
					objektuSkripts.atkritumuMasina.GetComponent<RectTransform> ().localPosition 
							= objektuSkripts.atkrKoord;
					break; 

				case "Slimnica":
					objektuSkripts.atraPalidziba.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.atroKoord;
					break;

				case "Skola":
					objektuSkripts.autobuss.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.atroKoord;
					break;

				case "b2":
					objektuSkripts.b2.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.b2koord;
					break;
				case "e46":
					objektuSkripts.e46.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.e46koord;
					break;
				case "cementaMasina":
					objektuSkripts.cementaMasina.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.cementakoord;
					break;
				case "policija":
					objektuSkripts.policija.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.policijakoord;
					break;
				case "traktor1":
					objektuSkripts.traktor1.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.traktor1koord;
					break;
				case "traktor2":
					objektuSkripts.traktor2.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.traktor2koord;
					break;
				case "udens":
					objektuSkripts.udens.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.Udenskoord;
					break;
				case "eskavator":
					objektuSkripts.eskavator.GetComponent<RectTransform> ().localPosition 
					= objektuSkripts.eskavatorskoord;
					break;



				default:
					Debug.Log ("Nedefinēts tags!");
					break;
				}

			}
		}
	}
}

/*
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
	public GameObject eskavator;*/