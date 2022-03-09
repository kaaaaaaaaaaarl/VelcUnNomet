using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dragdrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler {

	private CanvasGroup kanvasGrupa;
	private RectTransform transformGupa;
	public Objecti ObjectiSkrip;
	// Use this for initialization
	void Start () {
		kanvasGrupa = GetComponent<CanvasGroup> ();
		transformGupa = GetComponent<RectTransform>();
	}
	public void OnPointerDown(PointerEventData notikums){
		Debug.Log ("uzspiests");
	}

	public void OnBeginDrag(PointerEventData notikums){
		Debug.Log ("uzsakta vilksana");
		kanvasGrupa.alpha = 0.6f;
		kanvasGrupa.blocksRaycasts = false;
	}
	public void OnDrag(PointerEventData notikums){
		Debug.Log ("uzsakta vilksana");
		transformGupa.anchoredPosition += notikums.delta / ObjectiSkrip.kanva.scaleFactor;

	}
	public void OnEndDrag(PointerEventData notikums){
		Debug.Log ("aaaaaaaaaaaaaaaaaaaaaaaaaaa");
		kanvasGrupa.alpha = 1f;
		if (ObjectiSkrip.vaiIastaVieta == false) {
			kanvasGrupa.blocksRaycasts = true;
		} else {
			ObjectiSkrip.pedejaisVilk = null;
		}
		ObjectiSkrip.vaiIastaVieta = true;
	}

	// Update is called once per frame
}
