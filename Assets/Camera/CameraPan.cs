using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class CameraPan : MonoBehaviour {

	private Player m_Player;

	// Use this for initialization
	void Start () {
		m_Player = GameObject.FindObjectOfType<Player>();
	}
	
	void LateUpdate () {
		gameObject.transform.LookAt(m_Player.transform);
	}
}
