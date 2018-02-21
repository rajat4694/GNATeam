using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour 
{
	
	public GameObject rightspawn, leftspawn,camera,player;
	private CharacterController controller;
	private float verticalVelocity;
	private float gravity=15f;
	private float jumpForce=6f;
	private Vector3 moveVector;


	void Start()
	{
		controller = GetComponent<CharacterController> ();
	}

	void Update()
	{

		if (controller.isGrounded)
		{
			verticalVelocity = -gravity * Time.deltaTime;
			if (Input.GetKeyDown (KeyCode.Space)) 
			{
				verticalVelocity = jumpForce;	
			}
		} 

		else 
		{
			verticalVelocity -= gravity * Time.deltaTime;
		}
			
			moveVector = new Vector3 (0, verticalVelocity, 0);
			controller.Move (moveVector * Time.deltaTime);
		}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name=="collider" || player.transform.position.y < -5.0f) 
		{
			
			camera.GetComponent<CameraSript> ().enabled = false;
			leftspawn.GetComponent<leftspawn> ().enabled = false;
			rightspawn.GetComponent<rightspawn> ().enabled = false;
			camera.GetComponent<setActiveScript> ().enabled = false;
			jumpForce = 0;
			SceneManager.LoadScene ("End Scene");

		}
//			else if (col.gameObject.name=="LEftCube") 
//			{
////				leftspawn.GetComponent<leftspawn> ().LEftCube.transform.position = this.transform.position;
////				rightspawn.GetComponent<rightspawn> ().LEftCube.transform.position = this.transform.position;
//				
//			}
	}



}
