using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerNew : MonoBehaviour {

    private float startTime;

    public static float SONG_BPM = 125.0f; // note: song is close to 125 beats per minute
    public static float SEC_PER_MIN = 60.0f;
    public static float DELAY = 1.5f; // amount of time before the song starts
    public static int INTRO_BEAT_LIMIT = 48;
    public static int MAIN_BEAT_LIMIT = 248;
    public static int END_LIMIT = 480;


    private int circle = -1;
    private int beat = -1;

    void Start () {
        startTime = Time.time;
    }


    void Update () {

    }

    public int getBeat() {
        float t = Time.time - startTime;
        beat = (int)((t * SONG_BPM / SEC_PER_MIN) - DELAY);
        return beat;
    }

    // get which beat mod 4
    public int getBeatMod() {
        float t = Time.time - startTime;
        beat = (int)((t * SONG_BPM / SEC_PER_MIN) - DELAY);
        Debug.Log(beat % 4);
        return beat % 4;
    }
}
