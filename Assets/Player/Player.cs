using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;

public class Player : MonoBehaviour {

	public Vector3 Origin = new Vector3(0,2,0);

	private Rigidbody m_Rigidbody;

	// Use this for initialization
	void Start () {
		m_Rigidbody = gameObject.GetComponent<Rigidbody>();
		MoveToOrigin();
		//print("player start");
	}
	
	// Update is called once per frame
	void Update () {
		// Debug.Log("Input H: " + CrossPlatformInputManager.GetAxis("Horizontal"));
		// Debug.Log("Input V: " + CrossPlatformInputManager.GetAxis("Vertical"));
	}
	public void ResetBallPositionAfterReplay(Vector3 position,Vector3 velocity,Vector3 angularVelocity){
		transform.position = position;
		m_Rigidbody.velocity = velocity;
		m_Rigidbody.angularVelocity = angularVelocity;
	}
	public void MoveToOrigin(){
		gameObject.transform.position = Origin;
		m_Rigidbody.velocity = new Vector3(0,0,0);
		m_Rigidbody.angularVelocity = new Vector3(0,0,0);
	}
}