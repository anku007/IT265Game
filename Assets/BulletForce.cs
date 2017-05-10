using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletForce : MonoBehaviour {

    public int speed;
    public bool left1 = false;
    public bool right1 = false;
    public Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
		if(PlayerController.directionFacing == 1)
        {
            left1 = true;
        }
        if (PlayerController.directionFacing == 2)
        {
            right1 = true;
        }
    }
	
	// Update is called once per frame
	void Update () {
		if (left1 == true)
        {
            rb.AddForce(Vector3.back * 100);
        }
        if (right1 == true)
        {
            rb.AddForce(Vector3.forward * 100);
        }
    }
}
