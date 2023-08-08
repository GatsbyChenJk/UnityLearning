using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class RadiusControl : MonoBehaviour
{
    public GameObject ControlObj = null;

    public float ChangingRate = 1.0f;

    public float pow = 1.0f;

    public void ChangeRandius()
    {
        ControlObj = GameObject.FindGameObjectWithTag("MainCamera");

        float dS = this.GetComponent<Slider>().value * ChangingRate;
            
        //ControlObj.GetComponent<CameraControllor>().target.transform.localScale = new Vector3(
        //   dS,
        //   dS,
        //   dS);

        //ControlObj.GetComponent<CameraControllor>().Distance = ControlObj.transform.position.normalized * dS;


    }
}
