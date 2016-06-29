using UnityEngine;
using System.Collections;

public class menuScript : MonoBehaviour {

    public bool sceneStart = false;

	// Use this for initialization
	void Start () {


	
	}

    //This lets you start the game.
    public void StartGame()
    {
        sceneStart = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Menu() 
    {
        Application.LoadLevel(0);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
