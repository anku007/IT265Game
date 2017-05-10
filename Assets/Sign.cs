using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign : MonoBehaviour {

    public UI ui; 

	// Use this for initialization
	void Start () {
        ui = GameObject.FindWithTag("UI").GetComponent<UI>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            ui.win();
        }
    }
}
