﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {

	public bool IsRecording = true;

	private bool IsPaused = false;
	private float m_FixedDeltaTime;
	
	void Start(){
		m_FixedDeltaTime = Time.fixedDeltaTime;
	}
	// Update is called once per frame
	void Update () {
		if(CrossPlatformInputManager.GetButton("Fire1")){
			IsRecording = false;
		}else{
			IsRecording = true;
		}
		if(CrossPlatformInputManager.GetButtonDown("Pause")){
			SwitchPauseState();
		}
	}

    private void SwitchPauseState()
    {
		if(!IsPaused){
        	Time.timeScale = 0f;
			Time.fixedDeltaTime = 0f;
		}
		else{
			Time.timeScale = 1f;
			Time.fixedDeltaTime = m_FixedDeltaTime;
		}
		IsPaused = !IsPaused;
    }
}
