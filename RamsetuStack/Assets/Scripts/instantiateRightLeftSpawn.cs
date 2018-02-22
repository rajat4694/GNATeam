using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class instantiateRightLeftSpawn : MonoBehaviour {

	public GameObject LEftCube;
	private GameObject lefttile;
	public Text S1;           	 
	public GameObject instatiateLeft,instantiateRight;
	public CharacterController cc;
    private float freqValue =1f;
	private int score;
	private static int count=0;
	public static string f1;
	private int check;
	public GameObject playerc;

	void Start () 
	{
		trial_script.y = transform.position.y;
		lefttile= Instantiate(LEftCube,transform.position,Quaternion.identity) as GameObject;
	}

	void Update()
	{
		freqValue++;
		check = Random.Range (1, 9);
		if (freqValue % 60 == 0 && check % 2 == 0 && lefttile.transform.position.x == 0f && cc.isGrounded) 
		{
			instantiateOneByRight ();
			count++;
			InvokeRepeating ("OnCollisionEnter", freqValue, freqValue % 60 );

		} 
		else if (freqValue % 60 == 0 && check % 2 != 0 && lefttile.transform.position.x == 0f && cc.isGrounded) 
		{
			instantiateOneByLeft ();
			count++;
		}
	}


	void instantiateOneByLeft()
	{
		trial_script.y =playerc.GetComponent<CharacterController> ().transform.position.y;
		instatiateLeft.transform.position = new Vector3 (instatiateLeft.transform.position.x, playerc.GetComponent<CharacterController> ().transform.position.y, instatiateLeft.transform.position.z);
		lefttile = Instantiate (LEftCube, instatiateLeft.transform.position, Quaternion.identity) as GameObject;
		this.lefttile.transform.position += this.transform.forward * Random.Range (0f, 0.00001f) * Time.deltaTime;
		instatiateLeft.SetActive (false);
		instantiateRight.SetActive (true);

		score = count;
		S1.text = score.ToString ();
		f1 = S1.text;

	}

	void instantiateOneByRight() 
	{
		trial_script.y =playerc.GetComponent<CharacterController> ().transform.position.y;
		instantiateRight.transform.position = new Vector3 (instantiateRight.transform.position.x, playerc.GetComponent<CharacterController> ().transform.position.y, instantiateRight.transform.position.z);
		lefttile = Instantiate (LEftCube,instantiateRight.transform.position, Quaternion.identity) as GameObject;
		this.lefttile.transform.position += this.transform.forward * Random.Range(0f,0.00001f)* Time.deltaTime;
		instatiateLeft.SetActive (true);
		instantiateRight.SetActive (false);

		score = count;
		S1.text = score.ToString ();
		f1 = S1.text;

	}

	void OnCollisionEnter(Collision col)
	{
		//Debug.Log ("aa gaya");
		if (col.gameObject.name=="player") 
		{
			Debug.Log ("aa gaya");
			
		}
	}


}
