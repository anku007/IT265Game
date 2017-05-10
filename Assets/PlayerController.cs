using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Rigidbody2D myRigidbody;

    public float movementSpeed;
    public float jumpForce;
    private bool jump;
    public static int directionFacing = 0;

    public Transform fire;
    public GameObject rockets;  

	// Use this for initialization
	void Start () {
        myRigidbody = GetComponent<Rigidbody2D>();

        jump = false;
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Space) && !jump)
        {
            myRigidbody.AddForce(new Vector2(0, jumpForce));
            jump = true;
        }

        float horizontal = Input.GetAxis("Horizontal");

        myRigidbody.velocity = new Vector2(horizontal * movementSpeed, myRigidbody.velocity.y);

        flip();

        if(Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(rockets, fire.position, fire.rotation);
        }
    }

    private void flip()
    {
        if(myRigidbody.velocity.x > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
            directionFacing = 1;
        }
        else if(myRigidbody.velocity.x < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
            directionFacing = 2;
        }
    }

    void OnCollisionEnter2D(Collision2D var)
    {
        if(var.gameObject.name == "Ground")
        {
            jump = false;
        }
        if (var.gameObject.name == "Weapon")
        {
            var.gameObject.SetActive(false);
        }
    }
} 
