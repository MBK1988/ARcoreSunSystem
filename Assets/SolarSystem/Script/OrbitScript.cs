using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitScript : MonoBehaviour
{


    public Rigidbody rb;
    public GameObject sun;
    public Transform centerSun;
    public Vector3 axis = Vector3.up;
    public Vector3 desiredPosition;
    public float radius = 2.0f;
    public float radiusSpeed = 0.5f;
    public float rotationSpeed = 80.0f;

    // Use this for initialization
    void Start ()
    {
        //sun = GameObject.FindGameObjectWithTag("Sun");
        centerSun = sun.transform;
        transform.position = (transform.position - centerSun.position).normalized * radius + centerSun.position;
        

    }

    // Update is called once per frame
    void Update ()
    {

        transform.RotateAround(centerSun.position, axis, rotationSpeed * Time.deltaTime);
        desiredPosition = (transform.position - centerSun.position).normalized * radius + centerSun.position;
        transform.position = Vector3.MoveTowards(transform.position, desiredPosition, Time.deltaTime * radiusSpeed);


    }


    private void FixedUpdate()
    {



    }
}
