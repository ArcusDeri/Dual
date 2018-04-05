using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {

	public bool IsRecording = true;
	public Vector3 PositionBeforeReplay;

	private bool IsPaused = false;
	private float m_FixedDeltaTime;
	private Player m_Player;
	
	void Start(){
		m_FixedDeltaTime = Time.fixedDeltaTime;
		m_Player = GameManager.FindObjectOfType<Player>();
	}
	// Update is called once per frame
	void Update () {
		if(CrossPlatformInputManager.GetButton("Fire1")){
			IsRecording = false;
		}else{
			IsRecording = true;
		}
		if(CrossPlatformInputManager.GetButtonUp("Fire1"))
			m_Player.ResetBallPositionAfterReplay(PositionBeforeReplay);
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
