using UnityEngine;
using System.Collections;

public class scr_CloudSpawn : MonoBehaviour {

    public GameObject clouds;
    public GameObject cloudSpawn;
    public float timer = 25f;
    public float deleteTimer = 180f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer -= Time.deltaTime;
        deleteTimer -= Time.deltaTime;

        if (timer <= 0)
        {
            Instantiate(clouds, cloudSpawn.transform.position, this.transform.rotation);
            timer = 25f;
        }

        if (deleteTimer <= 0)
        {
            Destroy(this);
            deleteTimer = 180f;
        }
	
	}
}
