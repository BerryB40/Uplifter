using UnityEngine;
using System.Collections;

public class scr_CameraController : MonoBehaviour
{
    public Transform target;            // What is the camera following
    public float smoothing = 5f;        //Camera Follow speed

    public Vector3 offset;              // Camera offset of player

    void Start()
    {
      
    }

    void FixedUpdate()
    {
        // Create a postion the camera is aiming for based on the offset from the target.
        Vector3 targetCamPos = target.position + offset;

        // Smoothly interpolate between the camera's current position and it's target position.
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);


    }
}