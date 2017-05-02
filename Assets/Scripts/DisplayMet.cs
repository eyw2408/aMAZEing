using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class DisplayMet : MonoBehaviour
{

    //public Text metText;
    private float startTime;

	Animator anim;

    // constants
    public static float SEC_PER_MIN = 60.0f;

    // Use this for initialization
    void Start()
    {
        startTime = Time.time;
		anim = this.gameObject.GetComponent<Animator>();
		//Debug.Log (anim);
    }

    // Update is called once per frame
    void Update()
    {
        TimerNew timer = gameObject.GetComponent<TimerNew>();
        int beat = timer.getBeatMod();

        switch (beat)
        {
            case 1:
                //metText.text = "o _ _ _";
				anim.SetBool("beat1", true);
				anim.SetBool ("beat4", false);
				//Debug.Log("beat1");
                break;
            case 2:
                //metText.text = "_ o _ _";
				anim.SetBool("beat1", false);
				anim.SetBool ("beat2", true);
                break;
            case 3:
                //metText.text = "_ _ o _";
				anim.SetBool ("beat2", false);
				anim.SetBool ("beat3", true);
                break;
            case 0:
                //metText.text = "_ _ _ o";
				anim.SetBool ("beat3", false);
				anim.SetBool ("beat4", true);
                break;
            default: break;
        }
    }
}
