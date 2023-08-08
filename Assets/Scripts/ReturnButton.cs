using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnButton : MonoBehaviour
{
    public GameObject SettingPanel = null;
    public GameObject InfoPanel = null;
    public GameObject Camera = null;

    public void ShowInspectors()
    {
        Camera = GameObject.FindGameObjectWithTag("MainCamera");

        SettingPanel = Camera.transform.GetChild(0).transform.GetChild(0).gameObject;

        InfoPanel = Camera.transform.GetChild(0).transform.GetChild(1).gameObject;

        SettingPanel.SetActive(false);

        InfoPanel.SetActive(true);
    }
}
