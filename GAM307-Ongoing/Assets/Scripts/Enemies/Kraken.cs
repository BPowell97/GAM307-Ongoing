using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kraken : Enemy {


	// Use this for initialization
	void Start ()
    {
        Initialise();
	}


    void Initialise()
    {
        health = 450;
        scoreValue = 125;
        speed = 3;

        attack = 40;
        defence = 40;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
