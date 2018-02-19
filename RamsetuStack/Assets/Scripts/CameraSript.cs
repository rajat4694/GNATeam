using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSript : MonoBehaviour {
	public GameObject player;

    void FixedUpdate ()
	{
		transform.position =player.transform.TransformPoint (new Vector3 (0f, 1.5f, -1));
	}

}
