using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour {
    public GameObject ball;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //if(true)
        if (ball.GetComponent<Transform>().position.z >= 0.5 && ball.GetComponent<Transform>().position.x >= -0.5 && ball.GetComponent<Transform>().position.x <= 0.5 && ball.GetComponent<Transform>().position.z <= 3)
        {
            Destroy(this.gameObject);
        }
	}
}
