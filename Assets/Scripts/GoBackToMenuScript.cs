using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackToMenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void GoBackToMenu() {

		Debug.Log ("hit button!");
		SceneManager.LoadScene ("MainMenu");
	}
}