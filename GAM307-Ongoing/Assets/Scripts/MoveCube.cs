﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour {

    public float speed = 10f;
    public MoveCube moveCube;
	// Use this for initialization
	void Start () {

        int rnd = Random.Range(0, 360);
        transform.Rotate(new Vector3(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)));
	}
	
	// Update is called once per frame
	void Update () {
        
        //transform.Translate(new Vector3(0, 0, Time.deltaTime * speed));
        if(Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
}
