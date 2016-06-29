using UnityEngine;
using System.Collections;

public class scr_Jukebox : MonoBehaviour {

	// Use this for initialization
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
