using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForCub : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.R))
		{
			GetComponent<Renderer>().material.color = Color.red;
		}
		else if (Input.GetKey(KeyCode.B))
		{
			GetComponent<Renderer>().material.color = Color.blue;
		}
		else if (Input.GetKey(KeyCode.Y))
		{
			GetComponent<Renderer>().material.color = Color.yellow;
		}
		else
		{
			GetComponent<Renderer>().material.color = Color.black;
		}
	}
}
