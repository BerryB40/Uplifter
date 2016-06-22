using UnityEngine;
using System.Collections;

public class scr_BallController : MonoBehaviour {

    public Rigidbody2D rb;
    public float jump;
    public float moveSpeed;
    public float rotSpeed;
    public bool isGrounded;
    public PhysicMaterial bounce;
    public CircleCollider2D circleCol;
 


  
	void Start () 
    {
        bounce = GetComponent<PhysicMaterial>();
        circleCol = GetComponent<CircleCollider2D>();
	}
	
	
	void Update () 
    {
           BallMovement();
  
	}

    void BallMovement()
    { //------------------------- Keyboard Movement------------------
        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
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

        //------------------------------- Xbox Movement ------------------------

         if (isGrounded == true && Input.GetButtonDown("A")) 
         {
             rb.AddForce(Vector2.up * jump, ForceMode2D.Force);
         }


        if (Input.GetAxis("LeftStickX") > 0)
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
            transform.Rotate(Vector3.forward * -rotSpeed);
        }

        if (Input.GetAxis("LeftStickX") < 0)
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
            transform.Rotate(Vector3.forward * rotSpeed);
        }
        //--------------------- To stop the ball bouncing ----------------------

        if (Input.GetAxis("LeftStickY") > 0.8)
        { 
			Debug.Log ("Down");
            circleCol.sharedMaterial = null; 
        }

        if (Input.GetAxis("LeftStickY") == 0)
        {
            PhysicsMaterial2D bouncy = new PhysicsMaterial2D();
            bouncy.bounciness = .3f;
            circleCol.sharedMaterial = bouncy;
        }
     
       
    


        }
    

    void OnCollisionStay2D(Collision2D coll) 
    {
        isGrounded = true;


        if (coll.gameObject.tag == "wall") 
        {
            isGrounded = false;
        }

       /* if (coll.gameObject.tag == "ground")
        {
            isGrounded = true;
        }
        */
    }
    void OnCollisionExit2D(Collision2D coll)
    {
        isGrounded = false;
    }
}
