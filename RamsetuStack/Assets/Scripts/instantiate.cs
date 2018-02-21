using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class instantiate : MonoBehaviour {

	public Text S1;           	 
	public GameObject instatiateLeft,instantiateRight;
	public CharacterController cc;
    private float freqValue =1f;
	private int score;
	private int count=1;
	public static string f1;
	private int check;
	public GameObject playerc;

	void Update()
	{
		
		freqValue++;
		check = Random.Range (1, 9);
		if ( freqValue% 60 == 0 && check % 2 == 0) 
		{
			instantiateOneByRight ();
			score = count - 2;
			S1.text = score.ToString ();
			f1 = S1.text;
		} 
		else if (freqValue % 60 == 0 && check % 2 != 0)
		{
			instantiateOneByLeft ();
			score = count - 2;
			S1.text = score.ToString ();
			f1 = S1.text;
		}
	}

	void instantiateOneByLeft()
	{
			instatiateLeft.SetActive (false);
			instantiateRight.SetActive (true);
		if (cc.isGrounded)
			instatiateLeft.transform.position = new Vector3 (instatiateLeft.transform.position.x, playerc.GetComponent<CharacterController> ().transform.position.y, instatiateLeft.transform.position.z);
			Debug.Log ("instantiate one by left" + GetInstanceID ());
			//trial_script.y =playerc.GetComponent<CharacterController> ().transform.position.y;
			count++;

	}
	void instantiateOneByRight() 
		{
			instatiateLeft.SetActive (true);
			instantiateRight.SetActive (false);
		if (cc.isGrounded)
			instantiateRight.transform.position = new Vector3 (instantiateRight.transform.position.x, playerc.GetComponent<CharacterController> ().transform.position.y, instantiateRight.transform.position.z);
			Debug.Log ("instantiate one by right" + GetInstanceID ());	
			//trial_script.y =playerc.GetComponent<CharacterController> ().transform.position.y;
		count++;
	
		}	
}
