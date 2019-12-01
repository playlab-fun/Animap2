using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ChangeToVRMode : MonoBehaviour
{
    private bool isInVRMode = false;

    public GameObject target;

    public GameObject desertText;
    public GameObject drySavannaText;
    public GameObject grasslandText;
    public GameObject mediteranneanText;
    public GameObject moistSavannaText;
    public GameObject rainforestText;

    public void ChangeToVR()
    {
        isInVRMode = !isInVRMode;

        if (!isInVRMode)
        {
            MixedRealityController.Instance.SetMode(MixedRealityController.Mode.HANDHELD_AR);
            target.SetActive(true); 
        } else
        {
            MixedRealityController.Instance.SetMode(MixedRealityController.Mode.VIEWER_VR);
            target.SetActive(false);
            TurnOffAllText();
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
