﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEmit : MonoBehaviour {
    public RippleEffect ripple;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("press mouse .");
           
            Vector2 pos = new Vector2(Input.mousePosition.x/Screen.width,Input.mousePosition.y/Screen.height);
            ripple.Emit(pos);
        }
	}
}
