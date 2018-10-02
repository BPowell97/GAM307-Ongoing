﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeIEnumerator : MonoBehaviour {

    public GameObject cube;

	// Use this for initialization
	void Start ()
    {
 
    }
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            StopAllCoroutines();
            StartCoroutine(MoveCube());
            Debug.Log("STARTED");
        }
	}

    IEnumerator MoveCube()
    {
        for (int i = 0; i < 300; i++)
        {
            cube.transform.Translate(Vector3.right * Time.deltaTime);
            yield return null;
        }
        yield return new WaitForSeconds(1);
        for (int i = 0; i < 300; i++)
        {
            cube.transform.Translate(Vector3.forward * Time.deltaTime);
            yield return null;
        }
        yield return new WaitForSeconds(1);
        for (int i = 0; i < 300; i++)
        {
            cube.transform.Translate(Vector3.left * Time.deltaTime);
            yield return null;
        }
        yield return new WaitForSeconds(1);
        for (int i = 0; i < 300; i++)
        {
            cube.transform.Translate(Vector3.forward * Time.deltaTime);
            yield return null;
        }
        Debug.Log("FINISHED");
    }

    
}