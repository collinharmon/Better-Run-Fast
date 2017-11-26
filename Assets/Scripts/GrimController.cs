using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrimController : MonoBehaviour {
	float speed = 5f;
	bool occured = false;
	bool occured2 = false;
	// Use this for initialization
	void Start () {
		speed = 5f;
	}
	
	// Update is called once per frame
	void Update () {
		/*if(TimeScore.scoreCount-PlayerController.starGrab > 30 && occured == false){
			speed+=.0222f;
			//occured = true;
		}*/
		if(TimeScore.scoreCount-PlayerController.starGrab < 30){
			speed = 5f;
		}
		if(TimeScore.scoreCount-PlayerController.starGrab > 30 && occured == false){
			speed+=1.8f;
			occured = true;
		}
		if(TimeScore.scoreCount-PlayerController.starGrab > 39 && occured2 == false){
			speed+=2.2f;
			occured2 = true;
		}
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (speed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
	}
	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "Player"){
			Destroy(col.gameObject);
		}
	}
}
