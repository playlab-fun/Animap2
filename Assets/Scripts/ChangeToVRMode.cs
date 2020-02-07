using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ChangeToVRMode : MonoBehaviour
{
    public bool isInVRMode = false;

    public GameObject desertText;
    public GameObject drySavannaText;
    public GameObject grasslandText;
    public GameObject mediteranneanText;
    public GameObject moistSavannaText;
    public GameObject rainforestText;

    public void ChangeToVR()
    {
        Debug.Log("CHANGE TO VR");
        isInVRMode = !isInVRMode;

        if (!isInVRMode)
        {
            MixedRealityController.Instance.SetMode(MixedRealityController.Mode.HANDHELD_AR);
        } else
        {
            MixedRealityController.Instance.SetMode(MixedRealityController.Mode.VIEWER_VR);
            TurnOffAllText();
            Debug.Log("Turning off text");
        }
    }

    private void TurnOffAllText()
    {
        desertText.SetActive(false);
        drySavannaText.SetActive(false);
        grasslandText.SetActive(false);
        mediteranneanText.SetActive(false);
        moistSavannaText.SetActive(false);
        rainforestText.SetActive(false);
    }
}
