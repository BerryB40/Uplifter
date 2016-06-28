using UnityEngine;
using System.Collections;

public class scr_BridgeTrigger : MonoBehaviour {

	public HingeJoint2D hinge;

	void Start()
	{
		hinge = GetComponent<HingeJoint2D> ();
	}


	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == ("Player"))
			{
				Destroy (hinge);
			}
		
	}
}
