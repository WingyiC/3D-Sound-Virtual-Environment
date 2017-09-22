using UnityEngine;
using System.Collections;

public class TriggerZoneExample : MonoBehaviour {

	public GameObject planeIndicator, parkFence, stranger, nWall, sWall, eWall, wWall1, wWall2, wall1, wall2, wall3, wall4, wall5, product1 ,product2 ,product3;
	public AudioSource carSource, fenceCollision, strangerAudio, pain, wallCollision;
    public AudioClip[] strangers;
    public System.Random ran = new System.Random();
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//http://docs.unity3d.com/ScriptReference/Collider.OnTriggerEnter.html
	void OnTriggerEnter(Collider other) {
		CharacterController controller = other.gameObject.GetComponent<CharacterController>();
		if (controller != null) {
			
			if (planeIndicator != null) {
				carSource.Play ();
				pain.Play ();
			}

			if (parkFence != null) {
				fenceCollision.Play ();
				pain.Play ();
			}

            if (stranger != null) {
                int index = ran.Next(0, 4);
                strangerAudio.clip = strangers[index];
                strangerAudio.Play();
            }

			if (nWall !=null || sWall !=null || eWall !=null || wWall1 !=null || wWall2 !=null 
				|| wall1 !=null || wall2 !=null || wall3 !=null || wall4 !=null || wall5 !=null 
				|| product1 !=null || product2 !=null || product3!=null) {
					wallCollision.Play ();

			}
            Debug.Log (gameObject.name + ": entered trigger with name " + other.transform.name);
		}

	}
	
	//http://docs.unity3d.com/ScriptReference/Collider.OnTriggerStay.html
	void OnTriggerStay(Collider other) {
		
	}
	
	//http://docs.unity3d.com/ScriptReference/Collider.OnTriggerExit.html
	void OnTriggerExit(Collider other) {
		
		Debug.Log (gameObject.name + ": exited trigger with name " + other.transform.name);
	}


}
