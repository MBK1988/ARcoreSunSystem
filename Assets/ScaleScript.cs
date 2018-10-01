using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleScript : MonoBehaviour
{

    private readonly Vector3 _ScaleSpeed = new Vector3(0.0001f, 0.0001f, 0.0001f);

    // Use this for initialization
    void Start()
    {
// start something here
    }

    // Update is called once per frame
    void Update()
    {

        // If there are two touches on the device...
        if (Input.touchCount == 2)
        {
            // Store both touches.
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            // Find the position in the previous frame of each touch.
            Vector3 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector3 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            // Find the magnitude of the vector (the distance) between the touches in each frame.
            var prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            var touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

            // Find the difference in the distances between each frame.
            var deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

            // ... change the canvas size based on the change in distance between the touches.
            transform.localScale -= deltaMagnitudeDiff * _ScaleSpeed;

            if (transform.localScale.y < 0.001f)
            {
                transform.localScale = new Vector3(0.001f,0.001f,0.001f);
            }

            if (transform.localScale.y > 3.00f)
            {
                transform.localScale = new Vector3(3f, 3f, 3f);
            }


        }



    }
}
