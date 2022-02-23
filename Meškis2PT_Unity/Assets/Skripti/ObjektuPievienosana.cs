using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjektuPievienosana : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler {

	private RectTransform transformacijuLogs;
	public Canvas kanva;

	void Start(){
		transformacijuLogs = GetComponent<RectTransform> ();
	}

	public void OnPointerDown(PointerEventData notikums){
		Debug.Log ("Kreisais klikškis uz pārvietojamā objekta!");
	}

	public void OnDrag(PointerEventData notikums){
		Debug.Log ("Objekts tiek pārvietots!");
		transformacijuLogs.anchoredPosition += notikums.delta / kanva.scaleFactor;	
	}

	public void OnEndDrag(PointerEventData notikums){
		Debug.Log ("Pabeigta objekta pārvietošana!");
	}

	public void OnBeginDrag(PointerEventData notikums){
		Debug.Log ("Uzsākta objekta pārvietošana!");
	}
}
