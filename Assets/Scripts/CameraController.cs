﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject enemy;
	public float xMin; 
	public float xMax;
	public float yMin;
	public float yMax;

	// Use this for initialization
	void Start () {
		enemy = GameObject.FindGameObjectWithTag("Enemy");
	}
	
	// Update is called once per frame
	void Update () {
		float x = Mathf.Clamp(enemy.transform.position.x, xMin, xMax);
		float y = Mathf.Clamp(enemy.transform.position.y, yMin, yMax);
		gameObject.transform.position = new Vector3(x+7, y, gameObject.transform.position.z);
	}
}
