using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trial_script : MonoBehaviour 
{
	Vector3 startPos;

	//public GameObject LEftCube;
	public static float y;
	public Vector3 EndPos;
	public float fracTime=1f;
//	private float spawnTime=1f;


	void Start()
	{
		
		EndPos.x = 0;

		EndPos.z = 1;
		EndPos.y =y ;

	

		startPos = transform.position;
		//InvokeRepeating("Spawn", spawnTime, 0);

	}




	void Update()
	{
		fracTime += 0.01f;
		transform.position = Vector3.Lerp (startPos, EndPos,fracTime);	

	}


}
