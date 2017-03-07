using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    // UI text fields
    public Text timerText;
    public Text beatsText;
    public Text circlesText;

    public static float SONG_BPM = 125.0f; // note: song is close to 125 beats per minute
    public static float SEC_PER_MIN = 60.0f;
    public static float DELAY = 1.5f; // amount of time before the song starts
    public static float TIME_LIMIT = 20.0f;

    private float startTime;

	// Use this for initialization
	void Start () {
        startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {

        // timer code
        float t = Time.time - startTime;
        string minutes = ((int)(t / SEC_PER_MIN)).ToString();
        string seconds = (t % SEC_PER_MIN).ToString("f2");
        timerText.text = minutes + ":" + seconds;

        // beat counter code
        int beats = (int)((t * SONG_BPM / SEC_PER_MIN) - DELAY);
        beatsText.text = beats.ToString();

        // circles code (1, 2, 3, 4 metronome)
        int circle = (beats - 1) % 4;
        switch(circle) {
            case 0:
                circlesText.text = "o _ _ _";
                break;
            case 1:
                circlesText.text = "_ o _ _";
                break;
            case 2:
                circlesText.text = "_ _ o _";
                break;
            case 3:
                circlesText.text = "_ _ _ o";
                break;
            default: break;
        }

        // user ran out of time - deal with that here
        if (t > TIME_LIMIT)
            finish();
        
	}

    public void finish() {
        timerText.color = Color.red;
    }
}
