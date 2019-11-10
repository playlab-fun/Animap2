using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Gameplay : MonoBehaviour, ITrackableEventHandler {


	public GameObject Africa;
	public GameObject Mediterranean;
	public GameObject Savannah;
	public GameObject Desert;
	public GameObject Grassland;
	public GameObject Rainforest;

	private TrackableBehaviour mTrackableBehaviour;

	// Use this for initialization
	void Start () {

		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
			newStatus == TrackableBehaviour.Status.TRACKED ||
			newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
		{
					Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");

					if (mTrackableBehaviour.TrackableName == "desert-3") {
						Debug.Log ("desert found!!!!!");

						Africa.SetActive (false);
						Desert.gameObject.SetActive (true);
						Mediterranean.gameObject.SetActive (false);
						Savannah.gameObject.SetActive (false);
						Rainforest.gameObject.SetActive (false);
						Grassland.gameObject.SetActive (false);
					}

					switch (mTrackableBehaviour.TrackableName) {

					case  "desert-3":

						Africa.gameObject.SetActive (false);
						Desert.gameObject.SetActive (true);
						Mediterranean.gameObject.SetActive (false);
						Savannah.gameObject.SetActive (false);
						Rainforest.gameObject.SetActive (false);
						Grassland.gameObject.SetActive (false);

						Debug.Log ("DESERT!!!");
						break;

					case  "mediterranean2":

						break;

					case  "desert-2":

						break;

					case  "savannah2":

						break;

					case  "mediterranean3":

						break;

					case  "tropical":

						break;

					case  "tropical-1":

						break;

					case  "grassland2":

						break;

					case  "desert":

						break;

					case  "savannah-2":

						break;
					}
				
				}

			}
		}

