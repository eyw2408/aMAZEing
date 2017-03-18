using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour {

        public bool finished = false;
        public Text ggText;
        
	// Use this for initialization
	void Start () {
		
            Debug.Log("printing :)");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

        void OnTriggerEnter2D(Collider2D other) {
            Debug.Log("enter trigger");
            Debug.Log("you win!");
            finished = true;
            ggText.text = "ggwp";
        }

        void OnTriggerStay2D(Collider2D other) {
            Debug.Log("within trigger");
            finished = true;
        }

        void OnTriggerExit2D(Collider2D other) {
            Debug.Log("exit trigger");
        }
}
