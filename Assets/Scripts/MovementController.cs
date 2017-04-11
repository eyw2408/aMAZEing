using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {
	Transform tr;
	Rigidbody2D rb;
	Animator anim;
	// Use this for initialization
	void Start () {
		tr = GetComponent<Transform> ();
		rb = GetComponent<Rigidbody2D> ();
		anim = this.gameObject.GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
		float vert = Input.GetAxis("Vertical");
		float horizont = Input.GetAxis("Horizontal");
                int SCALE = 4;

		Vector2 vc2 = new Vector2 (horizont*SCALE,vert*SCALE);

		// vc2.Normalize ();
		rb.AddForce (vc2);
		anim.SetFloat ("moving", Mathf.Abs(vert) + Mathf.Abs(horizont));
	}
}
