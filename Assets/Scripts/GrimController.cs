using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrimController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (5, gameObject.GetComponent<Rigidbody2D>().velocity.y);
	}
	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag == "Player"){
			Destroy(col.gameObject);
		}
	}
}
