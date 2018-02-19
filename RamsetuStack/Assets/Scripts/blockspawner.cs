using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockspawner : MonoBehaviour {

	public GameObject blockprefab;
	// Use this for initialization
	void Start () {
		foreach (Transform child in transform) {
			GameObject block = Instantiate (blockprefab, child.transform.position, Quaternion.identity) as GameObject;
			block.transform.parent = transform;
			block.transform.parent = child;
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
