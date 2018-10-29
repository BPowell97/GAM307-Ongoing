using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kobold : Enemy {

	// Use this for initialization
	void Start ()
    {
        Initialise();
	}


    void Initialise()
    {
        health = 250;
        scoreValue = 100;
        speed = 7;

        attack = 25;
        defence = 20;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
