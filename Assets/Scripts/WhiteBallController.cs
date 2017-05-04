using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteBallController : MonoBehaviour {

    public float speed;
    public Rigidbody rb;
    Vector3 aaa = new Vector3();
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        aaa = rb.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    //Reseting white ball position if it goes off screen
    void OnTriggerEnter(Collider other)
    {
        rb.position = aaa;
        rb.angularVelocity = new Vector3(0,0,0);

    }
}
