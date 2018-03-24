using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterController : MonoBehaviour {
	public float speed = 2.0f;
	Vector3 velExtra = new Vector3(0,0,0);
	Transform tr;

	// Use this for initialization
	void Start () {
		tr = GetComponent<Transform> ();	
	}
	
	// Update is called once per frame
	void Update () {
		float vh = Input.GetAxis("Horizontal");
		float vv = Input.GetAxis("Vertical");
		// Compute velocity
		Vector3 velocity = speed * (new Vector3(vh,0,vv)).normalized;
		// Integrate new position
		tr.position = tr.position + (velocity+velExtra)*Time.deltaTime;
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log ("OnTriggerEnter");
		velExtra = 2.0f * speed * (transform.position - other.transform.position).normalized;
		velExtra.y = 0;
	}

	void OnTriggerExit(Collider other) {
		Debug.Log ("OnTriggerExit");
		velExtra.Set (0, 0, 0);
	}
}
