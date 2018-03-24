using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController : MonoBehaviour {
	public SpriteRenderer sr;
	private Transform tr;
	// Use this for initialization
	void Start () {
		tr = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		int layerNum = Mathf.RoundToInt(tr.position.z);
		sr.sortingLayerName = "L" + layerNum.ToString ();
	}
}
