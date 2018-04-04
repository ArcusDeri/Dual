using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class SelfieStick : MonoBehaviour {

	public float PanSpeed = 2f;

	private Player m_Player;
	private Vector3 StickRotation;

	// Use this for initialization
	void Start () {
		m_Player = GameObject.FindObjectOfType<Player>();
		StickRotation = transform.rotation.eulerAngles;
	}
	
	// Update is called once per frame
	void Update () {
		StickRotation.y += -1 * CrossPlatformInputManager.GetAxis("RHorizontal") * PanSpeed;
		StickRotation.z += CrossPlatformInputManager.GetAxis("RVertical") * PanSpeed;
		transform.position = m_Player.transform.position;
		transform.rotation = Quaternion.Euler(StickRotation);
	}
}
