using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftspawn : MonoBehaviour {

	public GameObject LEftCube;
	private float freq = 1f;
	GameObject lefttile;
	//public GameObject ts; 
	//private float moveSpeed=0.0001f;
	// Use this for initialization
	void Start () 
	{
		trial_script.y = transform.position.y;
	
		lefttile= Instantiate(LEftCube,transform.position,Quaternion.identity) as GameObject;
	}
	

	void Update () 
	{
		freq++;
		if (lefttile.transform.position.x==0f && freq%60==0)
		{
			
			trial_script.y = transform.position.y;

			lefttile = Instantiate (LEftCube, transform.position, Quaternion.identity) as GameObject;
			Debug.Log ("leftspawn" + GetInstanceID ());
			this.lefttile.transform.position += this.transform.forward * Random.Range(0f,0.00001f)* Time.deltaTime;
			//ts.GetComponent<trial_script> ().EndPos.y += 1;
			//trial_script.y =lefttile.transform.position.y;
		}
			
	}

}
