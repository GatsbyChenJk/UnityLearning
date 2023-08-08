using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ShowSectors : MonoBehaviour
{
    public int SectorIndex;
    public TMP_Text SectorInfo;
    public GameObject Sector;
    public RectTransform InfoTextSize;
    public RectTransform InfoBackgroundSize = null;
    public RectTransform CanvasRect = null;
    public GameObject SectorCamera = null;

    public List<string> AllInfo;

    public void ShowSectorInfo()
    {       
        SectorCamera = GameObject.FindGameObjectWithTag("MainCamera");
        //CanvasRect = SectorCamera.transform.GetChild(0).GetComponent<RectTransform>();
        //if (CanvasRect.rotation == Quaternion.Euler(0, 0, 0))
        //{           
        //    CanvasRect.rotation *= Quaternion.Lerp(Quaternion.Euler(0, 0, 0), Quaternion.Euler(0, 30, 0), 0.9f);
        //}

        SectorInfo = GameObject.FindGameObjectWithTag("Respawn").GetComponent<TMP_Text>();
        InfoTextSize = GameObject.FindGameObjectWithTag("Respawn").GetComponent<RectTransform>();
        SectorIndex = transform.GetComponent<ShowInvertory>().typeIndex;
        SectorInfo.text = "";
        switch(SectorIndex)
        {
            case 0:               
                Sector = GameObject.FindGameObjectWithTag("S1");
                SectorCamera.GetComponent<CameraControllor>().target = Sector.transform;
                SectorInfo.text += "Radius : [" + Sector.GetComponent<CapsuleCollider>().radius.ToString() + "] \n"; 
                SectorInfo.text += "Name : [" + Sector.GetComponent<MeshRenderer>().name + "]" + "\n";
                break;
            case 1:
                Sector = GameObject.FindGameObjectWithTag("S2");
                SectorCamera.GetComponent<CameraControllor>().target = Sector.transform;
                SectorInfo.text += "Radius : [" + Sector.GetComponent<CapsuleCollider>().radius.ToString() + "] \n";
                SectorInfo.text += "Name : [" + Sector.GetComponent<MeshRenderer>().name + "]" + "\n";
                break;
            case 2:
                Sector = GameObject.FindGameObjectWithTag("S3");
                SectorCamera.GetComponent<CameraControllor>().target = Sector.transform;
                SectorInfo.text += "Radius : [" + Sector.GetComponent<CapsuleCollider>().radius.ToString() + "] \n";
                SectorInfo.text += "Name : [" + Sector.GetComponent<MeshRenderer>().name + "]" + "\n";
                break;
            case 3:
                Sector = GameObject.FindGameObjectWithTag("S4");
                SectorCamera.GetComponent<CameraControllor>().target = Sector.transform;
                SectorInfo.text += "Radius : [" + Sector.GetComponent<CapsuleCollider>().radius.ToString() + "] \n";
                SectorInfo.text += "Name : [" + Sector.GetComponent<MeshRenderer>().name + "]" + "\n";
                break;
        }

        //根据字体大小调整文本框大小
        Vector2 textSize = SectorInfo.GetPreferredValues();
        InfoTextSize.sizeDelta = new Vector2(textSize.x, textSize.y);

    }

    public void ShowAllInfo()
    {
        
        AllInfo.Clear();

        SectorInfo = GameObject.FindGameObjectWithTag("Respawn").GetComponent<TMP_Text>();
        InfoTextSize = GameObject.FindGameObjectWithTag("Respawn").GetComponent<RectTransform>();

        Sector = GameObject.FindGameObjectWithTag("S1");
        AllInfo.Add("Height :[" + Sector.GetComponent<CapsuleCollider>().height.ToString() + "]\n" 
                  + "Position :[" + Sector.GetComponent<Transform>().position.ToString() + "]\n"
                  + "Name :["+ Sector.transform.name + "]");

        Sector = GameObject.FindGameObjectWithTag("S2");
        AllInfo.Add("Height :[" + Sector.GetComponent<CapsuleCollider>().height.ToString() + "]\n"
                  + "Position :[" + Sector.GetComponent<Transform>().position.ToString() + "]\n"
                  + "Name :[" + Sector.transform.name + "]");

        Sector = GameObject.FindGameObjectWithTag("S3");
        AllInfo.Add("Height :[" + Sector.GetComponent<CapsuleCollider>().height.ToString() + "]\n"
                  + "Position :[" + Sector.GetComponent<Transform>().position.ToString() + "]\n"
                  + "Name :[" + Sector.transform.name + "]");

        Sector = GameObject.FindGameObjectWithTag("S4");
        AllInfo.Add("Height :[" + Sector.GetComponent<CapsuleCollider>().height.ToString() + "]\n"
                  + "Position :[" + Sector.GetComponent<Transform>().position.ToString() + "]\n"
                  + "Name :[" + Sector.transform.name + "]");

        SectorInfo.text = "";

        foreach (var text in AllInfo)
        {
            SectorInfo.text += text + "\n";
        }

        //根据字体大小调整文本框大小
        Vector2 textSize = SectorInfo.GetPreferredValues();
        InfoTextSize.sizeDelta = new Vector2(textSize.x, textSize.y);

        //根据文本框大小调整背景板大小，并且使其不超出画布范围
        InfoBackgroundSize = GameObject.Find("InfoBackground").GetComponent<RectTransform>();
        CanvasRect = GameObject.Find("Canvas").GetComponent<RectTransform>();
        InfoBackgroundSize.sizeDelta = new Vector2(textSize.x, textSize.y);
        float BackgroundXAxis = Mathf.Clamp(InfoBackgroundSize.sizeDelta.x, 0, CanvasRect.sizeDelta.x);
        float BackgroundYAxis = Mathf.Clamp(InfoBackgroundSize.sizeDelta.y, 0, CanvasRect.sizeDelta.y);
        InfoBackgroundSize.sizeDelta = new Vector2(BackgroundXAxis, BackgroundYAxis);

    }
}
