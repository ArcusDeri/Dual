using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;

public class Player : MonoBehaviour {

	public Vector3 Origin = new Vector3(0,2,0);
	public Vector3 PositionBeforeReplay;
	public Vector3 VelocityBeforeReplay;
	public Vector3 AngularVelocityBeforeReplay;
	public bool WillReturnBeforeReplay = false;

	private Rigidbody m_Rigidbody;

	// Use this for initialization
	void Start () {
		m_Rigidbody = gameObject.GetComponent<Rigidbody>();
		MoveToOrigin();
	}
	
	// Update is called once per frame
	void Update () {
		// Debug.Log("Input H: " + CrossPlatformInputManager.GetAxis("Horizontal"));
		// Debug.Log("Input V: " + CrossPlatformInputManager.GetAxis("Vertical"));
	}
	public void ResetBallPositionAfterReplay(){
		transform.position = PositionBeforeReplay;
		m_Rigidbody.velocity = VelocityBeforeReplay;
		m_Rigidbody.angularVelocity = AngularVelocityBeforeReplay;
		WillReturnBeforeReplay = false;
	}
	public void MoveToOrigin(){
		gameObject.transform.position = Origin;
		m_Rigidbody.velocity = new Vector3(0,0,0);
		m_Rigidbody.angularVelocity = new Vector3(0,0,0);
	}
}