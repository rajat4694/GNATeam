using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightspawn : MonoBehaviour {
	
 	public GameObject LEftCube;
	private GameObject lefttile;

	void Start () 
	{
		trial_script.y = transform.position.y;
		lefttile= Instantiate(LEftCube,transform.position,Quaternion.identity) as GameObject;
	}
	// Update is called once per frame
	void Update () 
	{
		if (lefttile.transform.position.x == 0f)
		{
			trial_script.y = transform.position.y;
			lefttile = Instantiate (LEftCube, transform.position, Quaternion.identity) as GameObject;
			this.lefttile.transform.position += this.transform.forward * Random.Range(0f,0.00001f)* Time.deltaTime;
		}

	}


}
