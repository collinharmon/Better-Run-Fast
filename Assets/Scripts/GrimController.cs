using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrimController : MonoBehaviour {
	float speed = 5f;
	public static bool occured;
	public static bool occured2;
	public static bool occured3;
	public static bool occured4;
	// Use this for initialization
	void Start () {
		speed = 5f;
	    occured = false;
	    occured2 = false;
	    occured3 = false;
		occured4 = false;
	}
	
	// Update is called once per frame
	void Update () {
		/*if(TimeScore.scoreCount-PlayerController.starGrab > 30 && occured == false){
			speed+=.0222f;
			//occured = true;
		}*/
		if(TimeScore.scoreCount-PlayerController.starGrab < 30){
			occured = false;
			occured2 = false;
			occured3 = false;
			occured4 = false;
			speed = 5f;
		}
		if(TimeScore.scoreCount-PlayerController.starGrab > 31 && occured == false){
			speed+=1.8f;
			occured = true;
		}
		if(TimeScore.scoreCount-PlayerController.starGrab > 39 && occured2 == false){
			speed+=2.2f;
			occured2 = true;
		}
		if(TimeScore.scoreCount-PlayerController.starGrab > 50 && occured3 == false){
			speed=0f;
			occured3 = true;
		}
		if(TimeScore.scoreCount-PlayerController.starGrab > 69 && occured4 == false){
			speed=12f;
			occured4 = true;
		}
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (speed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
	}
	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "Player"){
			Destroy(col.gameObject);
		}
	}
}
