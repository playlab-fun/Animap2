using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreenScript : MonoBehaviour {

	void Start () {

		StartCoroutine ("ProceedToMainScreen");
	}

	IEnumerator ProceedToMainScreen() {

		yield return new WaitForSeconds (3.0f);
		SceneManager.LoadScene ("ARScene");
	}
}
