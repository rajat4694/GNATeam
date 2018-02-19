using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setActiveScript : MonoBehaviour {

	public Text S1;           	 
	public GameObject instatiateLeft,instantiateRight;
	public bool isActiveFlag;
	private float freqValue =1f;
	private int score;
	private int count=1;
	public static string f1;

	void Update()
	{
		
		freqValue++;
		if (freqValue % 60 == 0) 
		{
			
			instantiateOneByOne ();
			Debug.Log ("count " + count);
			score=count-2;
			S1.text = score.ToString ();
			f1 = S1.text;


		}
	
	}

	void instantiateOneByOne()
	{
		
		if (isActiveFlag == true) 
		{
			instatiateLeft.SetActive (false);
			instantiateRight.SetActive (true);
			isActiveFlag = false;
			instatiateLeft.transform.position = new Vector3 (instatiateLeft.transform.position.x, instatiateLeft.transform.position.y + 2f, instatiateLeft.transform.position.z);

			count++;

			Debug.Log ("total Score" + score);
		} 
		else 
		{
			instatiateLeft.SetActive (true);
			instantiateRight.SetActive (false);
			isActiveFlag = true;
			instantiateRight.transform.position = new Vector3 (instantiateRight.transform.position.x, instantiateRight.transform.position.y + 2f, instantiateRight.transform.position.z);

			count++;
			Debug.Log ("total Score" + score);
		}	
	}
}
