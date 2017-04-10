using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleOfView : MonoBehaviour {

	//public GameObject circle;
	private float time;
	// Use this for initialization
	void Start () {
		//circle.GameObject.find("CircleOfView");
		time = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time <= 41) {	
			if (transform.localScale.x >= 2 && transform.localScale.y >= 2) {
				transform.localScale -= new Vector3(0.01F, 0.01F, 0);
			}
		} else if ((Time.time > 101 && Time.time < 139) || (Time.time > 200)) {
			if (transform.localScale.x >= 2 && transform.localScale.y >= 2) {
				transform.localScale -= new Vector3(0.1F, 0.1F, 0);
			}
		} else {
			if (transform.localScale.x <10 && transform.localScale.y < 10) {
				transform.localScale += new Vector3(0.1F, 0.1F, 0);
			} 
		}
		Debug.Log("Time: " + Time.time);
		
	}
}
