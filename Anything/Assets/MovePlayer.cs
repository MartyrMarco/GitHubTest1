using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {
    private Rigidbody rb;
    public float speed;
    public GameObject cam;
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	void FixedUpdate ()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        movement = cam.transform.TransformDirection(movement);
        movement.y = 0.0f;
        rb.AddForce(movement * speed);
	}
} 