using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ImageFadeInFadeOut : MonoBehaviour {

    public Image title;
    public Image fadeScreen;

    float timer = 3.0f;

    public GameObject fadeScreenGameObject;

    public bool fadeisComplete = false;

  

    public float fadeSpeed = 0.2f;
    public float fadeTime = 0.25f;

    Color colorFadeOut;
    Color colorFadeIn;

    public menuScript menu;

    IEnumerator WaitScene()
    {
        Debug.Log("Wait for seconds");
        yield return new WaitForSeconds(3);
        Debug.Log("Wait Complete");
    }

	// Use this for initialization
	void Start () {



        menu = GameObject.FindObjectOfType<menuScript>();

        //This is the color used to fade in/out an image.

        //title.color = new Color(255f, 255f, 255f, Mathf.Lerp(255f, 255f, Time.deltaTime * 3f));
        colorFadeOut = new Color(0f, 0f, 0f, Time.deltaTime * 3f);
        fadeScreen.CrossFadeColor(colorFadeOut, fadeTime, true, true);

        Destroy(fadeScreenGameObject, 2);
        
        
    
        
        

       
	
	}

  void FadeInEffect()
    {
      
    }

    
	
	// Update is called once per frame
	void Update () {

        if (menu.sceneStart) 
        {
            colorFadeIn = new Color(0f, 0f, 0f, 1f);

            timer -= Time.deltaTime;

            

            

            title.CrossFadeColor(colorFadeIn, fadeSpeed, true, true);

            if (timer <= 0)
            {
                Application.LoadLevel("testScene");
            }

            //Cross fade color allows you to fade color based on the time set on the float.
            //This lets you fade out the image.
            //title.CrossFadeColor(colorFadeOut, fadeTime, true, true);
            //Have the image title screen fade out and allow the controller to move the ball.
            // title.color = new Color(0, 0, 0, 255);
        }

        
          

	}
}
