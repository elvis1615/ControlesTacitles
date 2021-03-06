﻿using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Panel : MonoBehaviour, IPointerUpHandler, IPointerDownHandler, IDragHandler
{
    public GameObject g;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnPointerDown(PointerEventData data)
    {
        g.GetComponent<Transform>().position = data.pressPosition;
        g.SetActive(true);
        g.GetComponent<Joystick>().OnPointerDown(data);
    }

    public void OnPointerUp(PointerEventData data)
    {
        g.GetComponent<Joystick>().OnPointerUp(data);
        g.SetActive(false);
        
        
    }
    
    public void OnDrag(PointerEventData data) {
        g.GetComponent<Joystick>().OnDrag(data);
    }
}
