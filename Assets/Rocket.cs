using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    public GameObject Bullet;
    public Vector3 posLeft;
    public Vector3 posRight;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        posLeft = new Vector3(transform.position.x - 0.7f, transform.position.y);
        posRight = new Vector3(transform.position.x + 0.7f, transform.position.y);
        if (Input.GetKey(KeyCode.F))
        {
            if (PlayerController.directionFacing == 2)
            {
                shootLeft();
            }
            else if (PlayerController.directionFacing == 1)
            {
                shootRight();
            }
        }
    }

    void shootLeft()
    {
        //Instantiate(Bullet, posLeft, Quaternion.identity);
        Destroy(Bullet, 4);
    }

    void shootRight()
    {
        //Instantiate(Bullet, posRight, Quaternion.identity);
        Destroy(Bullet, 4);
    }
}


        /*if(Input.GetKey(KeyCode.F))
        {
            GameObject tempBullet;
            tempBullet = Instantiate(Bullet, bulletEmitter.transform.position, bulletEmitter.transform.rotation);

            Rigidbody tempRigidBody;
            tempRigidBody = tempBullet.GetComponent<Rigidbody>();

            tempRigidBody.AddForce(transform.forward * bulletForward);

            Destroy(tempBullet, 5.00f);
        }
        */