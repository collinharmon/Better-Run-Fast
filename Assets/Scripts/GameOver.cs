using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOver : MonoBehaviour {

	public Text finalScore;
	int star;
    //public static int final = 0;
	// Use this for initialization
	void Start () {
		finalScore.text = (TimeScore.scoreCount+PlayerController.starGrab) + "";
		//scoreCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		//star = PlayerController.starGrab;
		finalScore.text = TimeScore.scoreCount + "";
	}
}
