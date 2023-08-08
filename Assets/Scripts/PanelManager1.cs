using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager1 : MonoBehaviour
{
    public GameObject InspectorPanel = null;

    public GameObject SettingsPanel = null;

    private bool isKeypad01down = false;
    private bool isKeypad02down = false;

    void Start()
    {
        InspectorPanel.SetActive(false);
        SettingsPanel.SetActive(false);
    }

    void Update()
    {             
        if(Input.GetKeyDown(KeyCode.Keypad1))
        {
            if (!isKeypad01down)
            {
                InspectorPanel.SetActive(true);
                isKeypad01down = true;
            }
            else
            {
                InspectorPanel.SetActive(false);
                isKeypad01down = false;
            }
        }


        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            if (!isKeypad02down)
            {
                SettingsPanel.SetActive(true);
                isKeypad02down = true;
            }
            else
            {
                SettingsPanel.SetActive(false);
                isKeypad02down = false;
            }
        }

        if (Input.GetKey(KeyCode.K))
        {
            InspectorPanel.SetActive(false);
            SettingsPanel.SetActive(false);
        }
    }
}
