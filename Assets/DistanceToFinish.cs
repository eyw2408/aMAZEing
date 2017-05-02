using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DistanceToFinish : MonoBehaviour {

    //public Text distText;
    public GameObject finishObj;

    private GameObject player;
    private float finishX;
    private float finishY;
    private float maxDist;
	Animator anim;

    // Use this for initialization
    void Start () {
        finishX = finishObj.transform.position.x;
        finishY = finishObj.transform.position.y;
        player = GameObject.FindGameObjectWithTag("Player");
        maxDist = calcDist();
		anim = this.gameObject.GetComponent<Animator>();
    }

    float calcDist ()
    {
        float x = player.transform.position.x;
        float y = player.transform.position.y;
        float dist = ((x - finishX) * (x - finishX) + (y - finishY) * (y - finishY));
        return dist;
    }

    // Update is called once per frame
    void Update () {

        float dist = calcDist();
        float percent = (maxDist - dist) / maxDist;
        Debug.Log(percent);
		Debug.Log (anim.GetBool ("cold"));
		if (percent >= 0 && percent <= 0.33 && anim.GetBool ("med") == true) {
			anim.SetBool ("med_to_cold", true);
			anim.SetBool ("hot_to_med", false);
			anim.SetBool ("cold_to_med", false);
			anim.SetBool ("med_to_hot", false);
			anim.SetBool ("cold", true);
			anim.SetBool ("med", false);
		} else if (percent >= 0.33 && percent <= 0.67 && anim.GetBool("cold") == true) {
			Debug.Log ("here");
			anim.SetBool ("med_to_cold", false);
			anim.SetBool ("hot_to_med", false);
			anim.SetBool ("cold_to_med", true);
			anim.SetBool ("med_to_hot", false);
			anim.SetBool ("med", true);
			anim.SetBool ("cold", false);
		} else if (percent >= 0.67 && percent <= 1 && anim.GetBool("med") == true) {
			anim.SetBool ("med_to_cold", false);
			anim.SetBool ("hot_to_med", false);
			anim.SetBool ("cold_to_med", false);
			anim.SetBool ("med_to_hot", true);
			anim.SetBool ("hot", true);
			anim.SetBool ("med", false);
		} else if (percent >= 0.33 && percent <= 0.67 && anim.GetBool("hot") == true) {
			anim.SetBool ("med_to_cold", false);
			anim.SetBool ("hot_to_med", true);
			anim.SetBool ("cold_to_med", false);
			anim.SetBool ("med_to_hot", false);
			anim.SetBool ("med", true);
			anim.SetBool ("hot", false);
		} 

        //distText.text = string.Format("{0:p0}", percent);

    }
}
