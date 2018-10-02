using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekTwo : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        //StartCoroutine(TestText());    // Other way to call StartCoroutine: StartCoroutine("TestText");
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Do Something BEFORE the Coroutine");
            StartCoroutine(TestText());
            Debug.Log("Do Something AFTER the Coroutine");
        }
	}

    IEnumerator TestText()
    {
        Debug.Log("Frame 0");
        yield return null;
        Debug.Log("Frame 1");
        yield return null;
        Debug.Log("Frame 2");
        yield return null;
        Debug.Log("Frame 3");
    }
}
