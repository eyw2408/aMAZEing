using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {
	Transform tr;
	Rigidbody2D rb;
	Animator anim;

    public float turnconst;
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
        
        int SCALE = 2;

        if (vert != 0)
        {
            if (vert < 0)
                SCALE *= -1;
            
            float degrees = (rb.rotation % 360) + 90;
            float radians = degrees / 180 * Mathf.PI;
            Debug.Log("degrees " + degrees);

            Vector2 vc2 = new Vector2(Mathf.Cos(radians) * SCALE, Mathf.Sin(radians) * SCALE);

            // vc2.Normalize ();
            rb.AddForce(vc2);
            anim.SetFloat("moving", Mathf.Abs(vert) + Mathf.Abs(horizont));
        }

        rb.AddTorque(-turnconst * Input.GetAxis("Horizontal"));



    }
}
