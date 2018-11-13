using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SkeletonWarrior : Enemy {

    NavMeshAgent navAgent;
    public GameObject target;

	// Use this for initialization
	void Start ()
    {
        Initialise();
        navAgent = GetComponent<NavMeshAgent>();
        navAgent.SetDestination(target.transform.position);
       
    }


    void Initialise()
    {
        health = 100;
        scoreValue = 50;
        speed = 10;

        attack = 20;
        defence = 10;

        healthUI.text = "Health: " + health.ToString();
        healthBar.transform.localScale = Vector3.one;
        healthBarSections = ((float)health / 100) / 100;
    }

    // Update is called once per frame
    void Update ()
    {
		navAgent.SetDestination(target.transform.position);
    }
}
