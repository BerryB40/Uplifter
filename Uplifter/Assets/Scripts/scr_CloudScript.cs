using UnityEngine;
using System.Collections;

public class scr_CloudScript : MonoBehaviour {

    public SpriteRenderer render;
    public float cloudSpeed = 0.7f;

	void Start () {
        render = GetComponent<SpriteRenderer>();

        render.color = new Color(1f, 1f, 1f, .35f);
	}
	
	// Update is called once per frame
	void Update () {
      
	}
}
