using UnityEngine;
using System.Collections;

public class CameraPowerSwitch : MonoBehaviour {

	KeyCode key = KeyCode.Escape;
	Camera mainCamera;
	string initialGameObjectName;


	public bool cameraState
	{
		get { return mainCamera.enabled; }
		set { mainCamera.enabled = value; }
	}

	// Use this for initialization
	void Start () {
		mainCamera = Camera.main;
		initialGameObjectName = gameObject.name;
		gameObject.name = initialGameObjectName + " (On)";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (key))
		{
			cameraState = !cameraState;
			if (cameraState)
				gameObject.name = initialGameObjectName + " (On)";
			else
				gameObject.name = initialGameObjectName + " (Off)";
		}
	}
}
