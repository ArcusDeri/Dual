using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("Input H: " + CrossPlatformInputManager.GetAxis("Horizontal"));
		Debug.Log("Input V: " + CrossPlatformInputManager.GetAxis("Vertical"));
	}
}