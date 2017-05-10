using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    public float moveSpeed;
    public bool moveRight;

    public Transform wallCheck;
    public float wallCheckRad;
    public LayerMask whatWall;
    private bool hitWall;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        hitWall = Physics2D.OverlapCircle(wallCheck.position, wallCheckRad, whatWall);

        if(hitWall)
        {
            moveRight = !moveRight;
        }

		if(moveRight)
        {
            transform.localScale = new Vector2(-6f, 6.5f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
            transform.localScale = new Vector2(6f, 6.5f);
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
	}
}
