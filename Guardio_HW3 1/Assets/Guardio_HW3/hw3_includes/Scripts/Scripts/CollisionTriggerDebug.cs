using UnityEngine;
using System.Collections;

public class CollisionTriggerDebug : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// http://docs.unity3d.com/ScriptReference/Collider.html 
	// These are messages passed from a Collider to the GameObject when these events occur:

	//http://docs.unity3d.com/ScriptReference/Collider.OnCollisionEnter.html
	void OnCollisionEnter(Collision collisionInfo) {
		Debug.Log (gameObject.name + ": collided with " + collisionInfo.transform.name);
	}

	//http://docs.unity3d.com/ScriptReference/Collider.OnCollisionStay.html
	void OnCollisionStay(Collision collisionInfo) {
		
	}

	//http://docs.unity3d.com/ScriptReference/Collider.OnCollisionExit.html
	void OnCollisionExit(Collision collisionInfo) {
		Debug.Log (gameObject.name + ": no longer in contact with " + collisionInfo.transform.name);
		
	}

	//http://docs.unity3d.com/ScriptReference/Collider.OnTriggerEnter.html
	void OnTriggerEnter(Collider other) {
		Debug.Log (gameObject.name + ": entered trigger with name " + other.transform.name);
	}

	//http://docs.unity3d.com/ScriptReference/Collider.OnTriggerStay.html
	void OnTriggerStay(Collider other) {

	}

	//http://docs.unity3d.com/ScriptReference/Collider.OnTriggerExit.html
	void OnTriggerExit(Collider other) {
		Debug.Log (gameObject.name + ": exited trigger with name " + other.transform.name);
	}
}
