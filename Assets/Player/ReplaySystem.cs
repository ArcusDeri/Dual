using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplaySystem : MonoBehaviour {

	private const int BufferFrames = 100;
	private MyKeyFrame[] KeyFrames = new MyKeyFrame[BufferFrames];
	private Rigidbody mRigidBody;

	// Use this for initialization
	void Start () {
		mRigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		RecordFrames();
	}

	void RecordFrames(){
		mRigidBody.isKinematic = false;
		int frame = Time.frameCount % BufferFrames;
		float time = Time.time;
		Debug.Log("Writing to frame " + frame);

		KeyFrames[frame] = new MyKeyFrame(time, transform.position,transform.rotation);
	}

	void PlayBack(){
		mRigidBody.isKinematic = true;
		int frame = Time.frameCount % BufferFrames;
		Debug.Log("Reading frame " + frame);
		transform.position = KeyFrames[frame].Position;
		transform.rotation = KeyFrames[frame].Rotation;
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