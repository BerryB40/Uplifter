using UnityEngine;
using System.Collections;

public class ParticleMovement : MonoBehaviour {

    public GameObject targ;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector2.MoveTowards(transform.position, targ.transform.position, 0.3f);
	
	}
}
