using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadOnClick : MonoBehaviour {

	// Use this for initialization
	public void LoadScene(int level){
		//level is index in build settings of the level we want to load
		Application.LoadLevel(level);
	}
	public void quitGame(){Application.Quit();}

}
