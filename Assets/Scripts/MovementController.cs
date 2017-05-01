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
            if (Time.time <= 23.5) {    
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE, Mathf.Sin(radians) * SCALE); 
            } else if (Time.time < 27.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE * 4, Mathf.Sin(radians) * SCALE * 4); 
            } else if (Time.time < 31.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE, Mathf.Sin(radians) * SCALE);
            }else if (Time.time < 35.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE * 4, Mathf.Sin(radians) * SCALE * 4); 
            } else if (Time.time < 39.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE, Mathf.Sin(radians) * SCALE);
            }else if (Time.time < 43.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE * 4, Mathf.Sin(radians) * SCALE * 4); 
            } else if (Time.time < 47.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE, Mathf.Sin(radians) * SCALE);
            }else if (Time.time < 51.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE * 4, Mathf.Sin(radians) * SCALE * 4);
            } else if (Time.time < 55.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE, Mathf.Sin(radians) * SCALE);
            }else if (Time.time < 59.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE * 4, Mathf.Sin(radians) * SCALE * 4); 
            } else if (Time.time < 63.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE, Mathf.Sin(radians) * SCALE);
            }else if (Time.time < 67.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE * 4, Mathf.Sin(radians) * SCALE * 4);
            } else if (Time.time < 71.5) {
               vc2 = new Vector2(Mathf.Cos(radians) * SCALE, Mathf.Sin(radians) * SCALE);
            }else if (Time.time < 75.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE * 4, Mathf.Sin(radians) * SCALE * 4);
            } else if (Time.time < 79.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE, Mathf.Sin(radians) * SCALE);
            }else if (Time.time < 83.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE * 4, Mathf.Sin(radians) * SCALE * 4);
            } else if (Time.time < 87.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE, Mathf.Sin(radians) * SCALE);
            }else if (Time.time < 91.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE * 4, Mathf.Sin(radians) * SCALE * 4);
            } else if (Time.time < 95.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE, Mathf.Sin(radians) * SCALE);
            }else if (Time.time < 99.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE * 4, Mathf.Sin(radians) * SCALE * 4);
            } else if (Time.time < 103.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE, Mathf.Sin(radians) * SCALE);
            }else if (Time.time < 107.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE * 4, Mathf.Sin(radians) * SCALE * 4);
            } else if (Time.time < 111.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE, Mathf.Sin(radians) * SCALE);
            }else if (Time.time < 115.5) {
               vc2 = new Vector2(Mathf.Cos(radians) * SCALE * 4, Mathf.Sin(radians) * SCALE * 4);
            } else if (Time.time < 119.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE, Mathf.Sin(radians) * SCALE);
            }else if (Time.time < 123.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE * 4, Mathf.Sin(radians) * SCALE * 4); 
            } else if (Time.time < 127.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE, Mathf.Sin(radians) * SCALE);
            }else if (Time.time < 131.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE * 4, Mathf.Sin(radians) * SCALE * 4);
            } else if (Time.time < 135.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE, Mathf.Sin(radians) * SCALE);
            } else if (Time.time < 139.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE * 4, Mathf.Sin(radians) * SCALE * 4);
            } else if (Time.time < 143.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE, Mathf.Sin(radians) * SCALE);
            }else if (Time.time < 147.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE * 4, Mathf.Sin(radians) * SCALE * 4);
            } else if (Time.time < 151.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE, Mathf.Sin(radians) * SCALE);
            }else if (Time.time < 155.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE * 4, Mathf.Sin(radians) * SCALE * 4);
            } else if (Time.time < 159.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE, Mathf.Sin(radians) * SCALE);
            }else if (Time.time < 163.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE * 4, Mathf.Sin(radians) * SCALE * 4);
            } else if (Time.time < 167.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE, Mathf.Sin(radians) * SCALE);
            } else if (Time.time < 171.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE * 4, Mathf.Sin(radians) * SCALE * 4); 
            } else if (Time.time < 175.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE, Mathf.Sin(radians) * SCALE);
            }else if (Time.time < 179.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE * 4, Mathf.Sin(radians) * SCALE * 4);
            } else if (Time.time < 183.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE, Mathf.Sin(radians) * SCALE);
            }else if (Time.time < 187.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE * 4, Mathf.Sin(radians) * SCALE * 4); 
            } else if (Time.time < 191.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE, Mathf.Sin(radians) * SCALE);
            }else if (Time.time < 195.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE * 4, Mathf.Sin(radians) * SCALE * 4);
            } else if (Time.time < 199.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE, Mathf.Sin(radians) * SCALE);
            }else if (Time.time < 203.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE * 4, Mathf.Sin(radians) * SCALE * 4);
            } else if (Time.time < 207.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE, Mathf.Sin(radians) * SCALE);
            }else if (Time.time < 211.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE * 4, Mathf.Sin(radians) * SCALE * 4); 
            } else if (Time.time < 215.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE, Mathf.Sin(radians) * SCALE);
            }else if (Time.time < 219.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE * 4, Mathf.Sin(radians) * SCALE * 4); 
            } else if (Time.time < 223.5) {
                vc2 = new Vector2(Mathf.Cos(radians) * SCALE, Mathf.Sin(radians) * SCALE);
            }
            rb.AddForce(vc2);
            anim.SetFloat("moving", Mathf.Abs(vert) + Mathf.Abs(horizont));
        }

        rb.AddTorque(-turnconst * Input.GetAxis("Horizontal"));



    }
}
