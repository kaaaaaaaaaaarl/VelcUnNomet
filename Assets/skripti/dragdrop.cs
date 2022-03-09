using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dragdrop : MonoBehaviour, MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler {

	private CanvasGroup kanvasGrupa;
	private RectTransform transformGupa;
	public Object jaunsSkripka;
	// Use this for initialization
	void Start () {
		kanvasGrupa = GetComponent<CanvasGroup> ();
		transformGupa = GetComponent<RectTransform>();
	}
	public void onPointerDown(PointerEventData notikums){
		Debug.Log ("uzspiests");
	}

	public void onBeginDrag(PointerEventData notikums){
		Debug.Log ("uzsakta vilksana");
		kanvasGrupa.alpha = 0.6f;
		kanvasGrupa.blocksRaycasts = false;
	}
	public void onDrag(PointerEventData notikums){
		Debug.Log ("uzsakta vilksana");
		transformGupa.anchoredPosition += notikums.delta / objektuSkripts.kanva.scaleFactor;

	}
	public void OnEndDrag(PointerEventData notikums){
		Debug.Log ("aaaaaaaaaaaaaaaaaaaaaaaaaaa");
	}

	// Update is called once per frame
}
