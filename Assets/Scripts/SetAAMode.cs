using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetAAMode : MonoBehaviour
{

    public GameObject Camera = null;

    public string AAMode;

    public TMP_Text ModeInfo;

    public void SetMode()
    {
        ModeInfo = transform.GetChild(0).GetComponent<TMP_Text>();

        Camera = GameObject.FindGameObjectWithTag("MainCamera");

        AAMode = ModeInfo.text;

        switch(AAMode)
        {
            case "Disabled":
                Camera.GetComponent<Camera>().allowMSAA = false;
                Camera.GetComponent<Camera>().allowHDR = false;
                break;
            case "FXAA":
                Camera.GetComponent<Camera>().allowMSAA = true;
                break;
            case "SMAA":
                Camera.GetComponent<Camera>().allowHDR = true;
                break;
        }
    }


}
