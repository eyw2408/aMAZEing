﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class DisplayBeats : MonoBehaviour {

    public Text beatsText;
    private float startTime;

    // constants
    public static float SEC_PER_MIN = 60.0f;

    // Use this for initialization
    void Start () {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update () {
        TimerNew timer = gameObject.GetComponent<TimerNew>();
        int beat = timer.getBeat();
        beatsText.text = beat.ToString();
    }
}
