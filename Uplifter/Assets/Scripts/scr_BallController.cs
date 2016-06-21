using UnityEngine;
using System.Collections;

public class scr_BallController : MonoBehaviour {

    public Rigidbody2D rb;
    public int jump;
    public int moveSpeed;
    public bool canJump;

	void Start () 
    {
 
	}
	
	
	void Update () 
    {
        canJump = true;

        if (canJump == true) 
        {
            BallMovement();
        }
       
	}

    void BallMovement() 
    {
        if (canJump = true && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jump, ForceMode2D.Force);
        }

        if (Input.GetKey(KeyCode.A)) 
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.tag == "ground")
        {
            Debug.Log("GroundCheck");
            canJump = true;
        }
    }
}
