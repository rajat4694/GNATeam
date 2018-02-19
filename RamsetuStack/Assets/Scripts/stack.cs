using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stack : MonoBehaviour {

	private GameObject[] TheStack;
	private int scorecount;
	private int stackindex;
	private const float boundsize = 3.5f;
	private const float stackmovspeed = 5.0f;
	private const float error = 0.1f;
	private float tiletrans=0.0f;
	private float speed=2.5f;
	private bool ismovingX=true;
	private float secondaryposition;
	private Vector3	desiredposition;
	private Vector3 lasttileposition;
	// Use this for initialization
	void Start () 
	{
		TheStack = new GameObject[transform.childCount];
		for (int i = 0; i < transform.childCount; i++)
				TheStack [i] = transform.GetChild (i).gameObject;
		stackindex = transform.childCount - 1;
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
			
		
		if (Input.GetMouseButtonDown(0)) {
			if (placetile ()) {
				spawntile ();
				scorecount++;
			} else
				endgame ();
		}
		movetile ();
		//Move Stack
		transform.position=Vector3.Lerp(transform.position,desiredposition,stackmovspeed*Time.deltaTime);
		Debug.Log ("position right" + transform.position);

	}
	private void spawntile()
	{
		lasttileposition = TheStack [stackindex].transform.localPosition;
		Debug.Log ("stackindex_first" + stackindex);
		stackindex--;
		Debug.Log ("stackindex_minus" + stackindex);
		if (stackindex<0) 
		{
			Debug.Log ("stackindex_compare" + stackindex);
			stackindex = transform.childCount - 1;
			Debug.Log ("stackindex" + stackindex);
			desiredposition = Vector3.down * scorecount;
			Debug.Log ("desiredpos" + desiredposition);

			
		}
		TheStack [stackindex].transform.localPosition = new Vector3 (0, scorecount, 0);
		Debug.Log ("Thestack LocalPos" +TheStack [stackindex].transform.localPosition);
	}

	private void movetile()
	{
		tiletrans += Time.deltaTime * speed;
		if (ismovingX) {
			TheStack [stackindex].transform.localPosition = new Vector3 (Mathf.Sin (tiletrans * boundsize), scorecount, secondaryposition);
			Debug.Log ("thestacklocalposmovetile" + TheStack [stackindex].transform.localPosition);
		} else {
			TheStack [stackindex].transform.localPosition = new Vector3 (Mathf.Sin (tiletrans * boundsize), scorecount, secondaryposition);
			Debug.Log ("Elsethestacklocalposmovetile" + TheStack [stackindex].transform.localPosition);
		}
		}


	private bool placetile()
	{
		Transform t = TheStack [stackindex].transform;
		if (ismovingX) 
		{
			float delta = lasttileposition.x - t.position.x;
			if (Mathf.Abs(delta)>error) 
			{
				
			}

			
		}
		Debug.Log ("locslposition T for x:" + t.localPosition.x);
		Debug.Log ("locslposition T for z:" + t.localPosition.z);
		secondaryposition = (ismovingX)
			? t.localPosition.x
			: t.localPosition.z;
		ismovingX = !ismovingX;

		return true;
	}
	private void endgame()
	{
	
	}


}
