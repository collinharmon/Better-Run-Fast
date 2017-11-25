using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public int playerSpeed = 10;
	private bool facingRight = true;
	public int playerJumpPower = 1250;
	private float moveX;
	public bool onGround;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		PlayerMove();
	}
	
	void PlayerMove(){
		//controls
		moveX = Input.GetAxis("Horizontal");
		if(Input.GetKey(KeyCode.UpArrow) && onGround ==	 true) Jump();
	
		//animation
		//direction
		if(moveX > 0.0f && !facingRight){
			FlipPlayer();
		}
		else if (moveX < 0.0f && facingRight){
			FlipPlayer();
		}
		//physics
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
		
	}
	void Jump(){
		//jumping code
		GetComponent<Rigidbody2D>().AddForce (Vector2.up * playerJumpPower);
		onGround = false;
	}
	void FlipPlayer(){
		facingRight = !facingRight;
		Vector2 localScale = gameObject.transform.localScale;
		localScale.x *= -1;
		transform.localScale = localScale;
	}
	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "ground"){
			onGround = true;
		}
		//if(col.gameObject.tag == "Enemy") Destroy
	}
}
