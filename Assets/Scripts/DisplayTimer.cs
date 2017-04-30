using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class DisplayTimer : MonoBehaviour {

    public Text timerText;

    // constants
    public static float SEC_PER_MIN = 60.0f;

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        TimerNew timer = gameObject.GetComponent<TimerNew>();
        string time = timer.getTimeStr();
        timerText.text = time;
    }
}
