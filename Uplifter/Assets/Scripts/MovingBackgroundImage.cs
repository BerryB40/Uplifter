using UnityEngine;
using System.Collections;

public class MovingBackgroundImage : MonoBehaviour {

	private Vector3 newPosition; //Set new position
	
	public float Smooth; //Set camera smooth for lerp
	
	public Vector3 startPos = new Vector3(); //Initialize vector3 for inspector
	
	public Vector3 endPos = new Vector3(); //Initialize vector3 for inspector
	
	// Use this for initialization
	void Start () 
	{
		//set position to starting position
		transform.position = startPos;
	}
	
	
	void Update () 
	{
		//set newposition to end position
		newPosition = endPos;
		
		//transform the camera through a lerp towards the newposition using smooth
		transform.position = Vector3.Lerp (transform.position, newPosition, Time.deltaTime * Smooth);
	}
}
