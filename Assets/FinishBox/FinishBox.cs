using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishBox : MonoBehaviour {

	private Player m_Player;
	private MessageBox m_MessageBox;

	void Start(){
		m_Player = GameObject.FindObjectOfType<Player>();
		m_MessageBox = GameObject.FindObjectOfType<MessageBox>();
	}
	void OnTriggerEnter(Collider coll){
		m_Player.MoveToOrigin();
		m_MessageBox.SetMessage("Well done! You won!",10);
	}
}
