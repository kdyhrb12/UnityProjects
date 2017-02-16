using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    //We wont be using forces in this script, thus FixedUpdate is not neccesary
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(new Vector3(-45, -45, -45) * Time.deltaTime);
	}
}
