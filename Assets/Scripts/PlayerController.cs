using System.Collections;
using System.Collections.Generic;
using UnityEngine;


	
public class PlayerController : MonoBehaviour {

	public int playerSpeed = 10;
	private bool facingRight = true;
	public int playerJumpPower = 1250;
	private float moveX;
	public bool onGround;
	private double jumpRate = 0.0;
    private double lastJump = 0.0;
	public static int starGrab = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		PlayerMove();
		if (Input.GetKey("r"))
        {
			starGrab = 0;
           UnityEngine.SceneManagement.SceneManager.LoadScene(0);
		   
        }

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
		if(col.gameObject.tag == "ground" && Time.time >= jumpRate+lastJump){
			if(jumpRate == 0) jumpRate+=1.00;
			onGround = true;
			lastJump = Time.time;
		}
		//if(col.gameObject.tag == "Enemy") Destroy
	}
}
