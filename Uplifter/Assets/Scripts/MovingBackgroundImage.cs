using UnityEngine;
using System.Collections;

public class MovingBackgroundImage : MonoBehaviour {

	private Vector3 newPosition; //Set new position
    public float deleteTimer;
    public Vector3 curPos;
	public float Smooth; //Set camera smooth for lerp
	public Vector3 startPos = new Vector3(); //Initialize vector3 for inspector
	public Vector3 endPos = new Vector3(); //Initialize vector3 for inspector
    public MovingBackgroundImage cloudMove;
	
	// Use this for initialization
	void Start () 
	{
        cloudMove = GetComponent<MovingBackgroundImage>();
      
		//set position to starting position
		//transform.position = startPos;
        transform.position = this.transform.position;

	}
	
	
	void Update () 
	{
		//set newposition to end position
		newPosition = endPos;
        deleteTimer -= Time.deltaTime;
		//transform the camera through a lerp towards the newposition using smooth
		transform.position = Vector3.Lerp (transform.position, newPosition, Time.deltaTime * Smooth);

        deleteTimer -= Time.deltaTime;

        if (deleteTimer <= 0)
        {
            Destroy(this);
            deleteTimer = 180f;
        } 
	}
}
