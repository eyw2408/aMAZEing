using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DistanceToFinish : MonoBehaviour {

    public Text distText;
    public GameObject finishObj;

    private GameObject player;
    private float finishX;
    private float finishY;
    private float maxDist;

    // Use this for initialization
    void Start () {
        finishX = finishObj.transform.position.x;
        finishY = finishObj.transform.position.y;
        player = GameObject.FindGameObjectWithTag("Player");
        maxDist = calcDist();
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

        distText.text = string.Format("{0:p0}", percent);

    }
}
