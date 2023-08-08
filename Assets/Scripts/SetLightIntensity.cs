using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetLightIntensity : MonoBehaviour
{
    public GameObject Light = null;

    public Slider LightSlider = null;

    public void LightIntensitySet()
    {
        Light = GameObject.FindGameObjectWithTag("Light");

        LightSlider = this.GetComponent<Slider>();

        Light.GetComponent<Light>().intensity = LightSlider.value;
    }
}
