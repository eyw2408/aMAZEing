using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class DisplayMet : MonoBehaviour
{

    public Text metText;
    private float startTime;

    // constants
    public static float SEC_PER_MIN = 60.0f;

    // Use this for initialization
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        TimerNew timer = gameObject.GetComponent<TimerNew>();
        int beat = timer.getBeatMod();

        switch (beat)
        {
            case 1:
                metText.text = "o _ _ _";
                break;
            case 2:
                metText.text = "_ o _ _";
                break;
            case 3:
                metText.text = "_ _ o _";
                break;
            case 0:
                metText.text = "_ _ _ o";
                break;
            default: break;
        }
    }
}
