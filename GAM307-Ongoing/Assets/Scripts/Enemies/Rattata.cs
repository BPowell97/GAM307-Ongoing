using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rattata : Enemy {

	// Use this for initialization
	void Start ()
    {
        Initialise();
	}


    void Initialise()
    {
        health = 400;
        scoreValue = 75;
        speed = 15;

        attack = 15;
        defence = 5;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
