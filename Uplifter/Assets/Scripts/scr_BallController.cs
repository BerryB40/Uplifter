using UnityEngine;
using System.Collections;

public class scr_BallController : MonoBehaviour {

    public Rigidbody2D rb;
    public float jump;
    public float moveSpeed;
    public float rotSpeed;
	public float bouncy = 0.3f;
    public bool isGrounded;
    public PhysicsMaterial2D bounce;
    public CircleCollider2D circleCol;

    public GameObject fadeInScript;
    public GameObject spawn1;

    public ImageFadeInFadeOut menuScr;
    public menuScript menuS;


  
	void Start () 
    {
        bounce = GetComponent<PhysicsMaterial2D>();
        circleCol = GetComponent<CircleCollider2D>();

        menuScr = GameObject.FindObjectOfType<ImageFadeInFadeOut>(); //Gets the image fade in and fade out scripts.
        menuS = GameObject.FindObjectOfType<menuScript>(); //Gets the menu script component.
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

        if (Input.GetAxis("LeftStickY") > 0.7)
        { 
            circleCol.sharedMaterial = null; 
        }

        if (Input.GetAxis("LeftStickY") == 0)
        {
			bounce = new PhysicsMaterial2D ("Bounce");
			bounce.bounciness = bouncy;
			circleCol.sharedMaterial = bounce;
        }
     	 
		//if (Input.GetKeyDown (KeyCode.H)) 
		//{
		//	bouncy = 0.8f;
		//}
       
    


        }
    

    void OnCollisionStay2D(Collision2D coll) 
    {
        isGrounded = true;


        if (coll.gameObject.tag == "Wall") 
        {
            isGrounded = false;
        }

        if (coll.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }

   
        
    }
    void OnCollisionExit2D(Collision2D coll)
    {
        isGrounded = false;
    }


    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "OutOfBounds") 
        {
            this.transform.position = spawn1.transform.position;
        }

        if (other.gameObject.tag == "Start")
        {

            menuS.StartGame();
        }

        if (other.gameObject.tag == "Quit")
        {

            menuS.QuitGame();
        }

        if (other.gameObject.tag == "MenuTrigger") 
        {

            Application.Quit();
        }

    }
}
