using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class vomainiVidi : MonoBehaviour, IDropHandler {

	// Use this for initialization
	private float vietasZrot, velkObjZot, rotacijasStarpiba, xIzmeruStarp, yIzmeruStarp;
	public Objecti ObjektuSkriptz;
	private Vector2 vietasIzm, velkObj;

	public void OnDrop(PointerEventData notikums){
		if (notikums.pointerDrag != null) {
			if (notikums.pointerDrag.tag.Equals (tag)) {
				vietasIzm = notikums.pointerDrag.GetComponent<RectTransform> ().eulerAngles.z;
				velkObjZot = GetComponent<RectTransform> ().eulerAngles.z;
				rotacijasStarpiba = Mathf.Abs (vietasZrot - velkObjZot);
				vietasIzm = notikums.pointerDrag.GetComponent<RectTransform> ().localScale;
				velkObj = Mathf.Abs (vietasIzm);

			}
		}
	}
}
