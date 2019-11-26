using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ChangeToVRMode : MonoBehaviour
{
    private bool isInVRMode = false;

    public void Start()
    {
        
    }

    public void ChangeToVR()
    {
        if(isInVRMode)
        {
            MixedRealityController.Instance.SetMode(MixedRealityController.Mode.VIEWER_VR);
        } else
        {
            MixedRealityController.Instance.SetMode(MixedRealityController.Mode.HANDHELD_AR);
        }
      

        isInVRMode = !isInVRMode;
    }
}
