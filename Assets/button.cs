using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class button : MonoBehaviour , IPointerDownHandler
{

	// Use this for initialization
	void Start () {
		
	}
	public void OnPointerDown(PointerEventData eventData)
	{
		Bingo();
	}
	void Bingo()
	{
		Debug.Log("ok");
	}
	// Update is called once per frame
	void Update () {
		
	}
}
