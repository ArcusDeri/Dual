using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {

	public bool IsRecording = true;
	
	// Update is called once per frame
	void Update () {
		if(CrossPlatformInputManager.GetButton("Fire1")){
			IsRecording = false;
		}else{
			IsRecording = true;
		}
	}
}
