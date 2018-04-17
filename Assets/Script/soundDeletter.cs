using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class soundDeletter : MonoBehaviour {

	// Use this for initialization
	void Update () {
        if(SceneManager.GetActiveScene().name == "Editor")
        {
            gameObject.GetComponent<AudioSource>().enabled = false;
        }
        else
        {
            gameObject.GetComponent<AudioSource>().enabled = true;
        }
	}
}
