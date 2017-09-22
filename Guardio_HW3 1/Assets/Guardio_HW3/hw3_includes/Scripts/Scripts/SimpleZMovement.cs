using UnityEngine;
using System.Collections;

public class SimpleZMovement : MonoBehaviour {

	public float zMovementRate = 3.0f; //how fast the capsule moves (per second)
	public float zMovementRange = 5.0f; //how far the capsule moves in world units (before returning)

	Vector3 startingLocalPosition;

	//normally would use a single variable, this is for illustrative purposes
	//these are public so you can see them in the Editor
	public bool isGoing = false;
	public bool isReturning = false;

	// Use this for initialization
	void Start () {
		startingLocalPosition = transform.localPosition;
		isGoing = true;
		isReturning = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 localPositionUpdate = transform.localPosition;
		if (isGoing)
		{
			//we multiple by deltaTime so movement rate doesn't fluctuate depending on frame rate
			localPositionUpdate.z += zMovementRate * Time.deltaTime;
			//if we have exceeded our movement range, stop there and start moving in the other direction
			if (localPositionUpdate.z - startingLocalPosition.z > zMovementRange) {
				localPositionUpdate.z = startingLocalPosition.z + zMovementRange;
				isGoing = false;
				isReturning = true;
			}

		}
		else if (isReturning)
		{
			//we multiple by deltaTime so movement rate doesn't fluctuate depending on frame rate
			localPositionUpdate.z -= zMovementRate * Time.deltaTime;
			//if we have exceeded our original starting point, stop there and start moving in the other direction
			if (localPositionUpdate.z < startingLocalPosition.z) {
				localPositionUpdate.z = startingLocalPosition.z;
				isGoing = true;
				isReturning = false;
			}
		}
		//update our local position after movement has been applied
		transform.localPosition = localPositionUpdate;

	}
}
