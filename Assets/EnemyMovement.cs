using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	Transform tr;
	Rigidbody2D rb;
	public int SCALE;
	public int TimeInter;
	// Use this for initialization
	float entryTime;
	void Start () {
		tr = GetComponent<Transform> ();
		rb = GetComponent<Rigidbody2D> ();
		entryTime = Time.time;
		//start running
		entryTime = Time.time;
		Vector2 randomVector = new Vector2(Random.value-0.5f, Random.value-0.5f);
		randomVector.Normalize();

		Vector2 vc2 = new Vector2 (randomVector.x*SCALE,randomVector.y*SCALE);
		// vc2.Normalize ();
		rb.AddForce (vc2);
	}

	// Update is called once per frame
	void FixedUpdate () {
		if ((Time.time - entryTime) < TimeInter) {
			return;
		}
		entryTime = Time.time;
		Vector2 randomVector = new Vector2(Random.value, Random.value);
		randomVector.Normalize();

		Vector2 vc2 = new Vector2 (randomVector.x*SCALE-0.5f,randomVector.y*SCALE-0.5f);
		// vc2.Normalize ();
		rb.AddForce (vc2);
	}
}
