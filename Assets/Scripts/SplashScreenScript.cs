using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreenScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

		StartCoroutine ("ProceedToMainScreen");
	}

	// Update is called once per frame
	void Update () {

	}

	IEnumerator ProceedToMainScreen() {

		yield return new WaitForSeconds (3.0f);
		SceneManager.LoadScene ("MainMenu");
	}
}
