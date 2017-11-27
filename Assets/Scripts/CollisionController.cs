using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour {

	   private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "godie")
        {
			Debug.Log(gameObject.name + " has collided with " + collision.gameObject.name);
			Destroy(this.gameObject);
			PlayerController.starGrab=0;
			GrimController.occured = false;
			GrimController.occured2 = false;
			GrimController.occured3 = false;
			UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
		if(collision.gameObject.tag == "Enemy")
        {
			Debug.Log(gameObject.name + " has collided with " + collision.gameObject.name);
			Destroy(this.gameObject);
			PlayerController.starGrab=0;
			GrimController.occured = false;
			GrimController.occured2 = false;
			GrimController.occured3 = false;
			UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        if(collision.gameObject.tag == "star")
		{
			Debug.Log(gameObject.name + " has collided with " + collision.gameObject.name);
			Destroy(collision.gameObject);
			PlayerController.starGrab+=2;
			//TimeScore.scoreCount+=1;
			//UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
		///////////////////
		  
 
    
 
		
  
             
    }
     


}
