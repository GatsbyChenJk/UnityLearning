using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSettingPanel : MonoBehaviour
{
    public GameObject SettingPanel = null;
    public GameObject InfoPanel = null;
    public GameObject Camera = null;

    public void ShowSettings()
    {
        Camera = GameObject.FindGameObjectWithTag("MainCamera");

        SettingPanel = Camera.transform.GetChild(0).transform.GetChild(0) .gameObject;
   
        InfoPanel = Camera.transform.GetChild(0).transform.GetChild(1) .gameObject;

        InfoPanel.SetActive(false);

        SettingPanel.SetActive(true);
    }
}
