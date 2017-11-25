using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeScore : MonoBehaviour {

	public Text score;
    public static int scoreCount = 0;
	// Use this for initialization
	void Start () {
		score.text = scoreCount+ "";
	}
	
	// Update is called once per frame
	void Update () {
		scoreCount = (int) Time.timeSinceLevelLoad;
		scoreCount += PlayerController.starGrab;
		//Debug.Log("fuckcsharp:" + Time.timeSinceLevelLoad);
		score.text = scoreCount + "";
	}
}
