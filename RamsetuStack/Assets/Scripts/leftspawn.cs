using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftspawn : MonoBehaviour {

	public GameObject LEftCube;
	GameObject lefttile;
	//private float moveSpeed=0.0001f;
	// Use this for initialization
	void Start () 
	{
		trial_script.y = transform.position.y;
	
		lefttile= Instantiate(LEftCube,transform.position,Quaternion.identity) as GameObject;
	}
	

	void Update () 
	{

		if (lefttile.transform.position.x==0f)
		{
			
				trial_script.y = transform.position.y;
			lefttile = Instantiate (LEftCube, transform.position, Quaternion.identity) as GameObject;
			this.lefttile.transform.position += this.transform.forward * Random.Range(0f,0.00001f)* Time.deltaTime;

		}
			
	}

}
