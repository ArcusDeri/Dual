using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageBox : MonoBehaviour {

	private Text m_Text;

	// Use this for initialization
	void Start () {
		m_Text = gameObject.GetComponent<Text>();
		Clear();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Clear(){
		print("Clearing the message");
		m_Text.text = "";
	}

	public void SetMessage(string message,float timeToHide = 1){
		m_Text.text = message;
		Invoke("Clear", timeToHide);
	}
}
