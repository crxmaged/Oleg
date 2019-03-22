using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForSphere : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.G))
		{
			GetComponent<Renderer>().material.color = Color.gray;
		}
		else if (Input.GetKey(KeyCode.W))
		{
			GetComponent<Renderer>().material.color = Color.white;
		}
		else if (Input.GetKey(KeyCode.M))
		{
			GetComponent<Renderer>().material.color = Color.magenta;
		}
		else
		{
			GetComponent<Renderer>().material.color = Color.green;
		}

	}
}
