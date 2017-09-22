using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Distance : MonoBehaviour {
    //public GameObject distCarrier;
    public Transform P1, P2;
    public AudioSource DistanceSource;
    public AudioClip[] distanceTracks;
    public System.Random ran = new System.Random();

    public float if3D;
    public float dist = 0.0f;
    public float distThreshold = 0.0f;
    public float setupMax;
    public float setupMin;

    // Use this for initialization
    void Start () {
        DistanceSource.spatialBlend = if3D;
        DistanceSource.maxDistance = setupMax;
        DistanceSource.minDistance = setupMin;
        DistanceSource.volume = 1.0f;
    }
	
	// Update is called once per frame
	void Update () {
		dist = Vector3.Distance (P1.position, P2.position);

		if (dist > 0) {
			
			//if (dist < 2*distThreshold)
			//{
			//    DistanceSource.clip = distanceTracks[2];
			//    DistanceSource.Play();
			//}
			if (dist < 2 * distThreshold && dist > 1 * distThreshold) {
				DistanceSource.clip = distanceTracks [0];
				DistanceSource.Play ();
				Debug.Log ("Played");
			}
			if (dist <= 1 * distThreshold) {
				DistanceSource.clip = distanceTracks [1];
				DistanceSource.loop = true;
				DistanceSource.PlayOneShot (distanceTracks [1], 1.0f);
				Debug.Log ("Played2");
			}
		}
		//Debug.Log(" not Played");
	}
}
