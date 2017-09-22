using UnityEngine;
using System.Collections;

[RequireComponent (typeof(CharacterController))]
public class ControllerCollisionTriggerDebug : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// http://docs.unity3d.com/ScriptReference/MonoBehaviour.OnControllerColliderHit.html
	void OnControllerColliderHit(ControllerColliderHit hit) {
		//Debug.Log (gameObject.name + ": collided with " + hit.transform.name);
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
