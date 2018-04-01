using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplaySystem : MonoBehaviour {

	private const int BufferFrames = 100;
	private MyKeyFrame[] KeyFrames = new MyKeyFrame[BufferFrames];
	private Rigidbody m_RigidBody;
	private GameManager m_GameManager;

	// Use this for initialization
	void Start () {
		m_RigidBody = GetComponent<Rigidbody>();
		m_GameManager = GameObject.FindObjectOfType<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
		if(m_GameManager.IsRecording){
			RecordFrames();
		}else{
			PlayBack();
		}
	}

	void RecordFrames(){
		m_RigidBody.isKinematic = false;
		int frame = Time.frameCount % BufferFrames;
		float time = Time.time;
		Debug.Log("ReplaySystem.cs: Recording frame " + frame);

		KeyFrames[frame] = new MyKeyFrame(time, transform.position,transform.rotation);
	}

	void PlayBack(){
		m_RigidBody.isKinematic = true;
		int frame = Time.frameCount % BufferFrames;
		transform.position = KeyFrames[frame].Position;
		transform.rotation = KeyFrames[frame].Rotation;
		Debug.Log("ReplaySystem.cs: Playing frame " + frame);
	}
}

public struct MyKeyFrame{
	public float FrameTime;
	public Vector3 Position;
	public Quaternion Rotation;

	public MyKeyFrame(float time,Vector3 pos,Quaternion rot)
	{
		FrameTime = time;
		Position = pos;
		Rotation = rot;
	}
}