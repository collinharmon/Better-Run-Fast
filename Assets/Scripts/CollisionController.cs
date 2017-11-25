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
			UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
		if(collision.gameObject.tag == "Enemy")
        {
			Debug.Log(gameObject.name + " has collided with " + collision.gameObject.name);
			Destroy(this.gameObject);
			UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }
}
