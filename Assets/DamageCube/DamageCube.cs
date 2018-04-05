using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCube : MonoBehaviour {

	private Player m_Player;
	private MessageBox MessageBox;

	// Use this for initialization
	void Start () {
		m_Player = GameObject.FindObjectOfType<Player>();
		MessageBox = GameObject.FindObjectOfType<MessageBox>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider coll){
		m_Player.MoveToOrigin();
		MessageBox.SetMessage("Ouch! Try to avoid orange fields.",2);
	}
}
