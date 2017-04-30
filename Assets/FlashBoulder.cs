using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashBoulder : MonoBehaviour {

    private TimerNew timer;
    private GameObject[] boulders;
	// Use this for initialization
	void Start () {
        timer = gameObject.GetComponent<TimerNew>();
        boulders = GameObject.FindGameObjectsWithTag("Boulders");
    }
	
	// Update is called once per frame
	void Update () {
        int beatMod = timer.getBeatMod();
        if (beatMod == 0) {
            foreach (GameObject boulder in boulders)
            {
                boulder.SetActive(false);
            }
        }
        else if (beatMod == 3)
        {
            foreach (GameObject boulder in boulders)
            {
                boulder.SetActive(true);
            }
        }
    }
}
