using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour {

        public bool finished = false;
        public Text ggText;
        public Text failedText;
        
	// Use this for initialization
	void Start () {
		
            //Debug.Log("printing :)");
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time >= 223) {
            failedText.text = "Not an aMAZEing run";
        }
		
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
