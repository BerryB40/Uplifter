using UnityEngine;
using System.Collections;

public class scr_LevelCheck : MonoBehaviour {

    public scr_BallController ballController;
    public bool level1;
    public bool level2;
	
	void Start () 
    {
        ballController = GetComponent<scr_BallController>();
        level1 = false;
        level2 = false;
	
	}
	
	
	void Update () {
	
	}
}
