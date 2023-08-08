using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowDetail : MonoBehaviour
{
    public TMP_Text DetailText = null;
    public RectTransform DetailTextRect = null;
    public bool isClicked = false;

    public void ShowDetailInfo()
    {
        if (!isClicked)
        {
            DetailText = GameObject.FindGameObjectWithTag("Respawn").GetComponent<TMP_Text>();

            DetailTextRect = GameObject.FindGameObjectWithTag("Respawn").GetComponent<RectTransform>();

            DetailText.text = "";
            DetailText.text += "[Version] : <i>v0.51.1</i>\n";

            Vector2 textSize = DetailText.GetPreferredValues();
            DetailTextRect.sizeDelta = new Vector2(textSize.x, textSize.y);
            
            isClicked = true;
        }
        else
        {
            DetailText.text = "[<color=#ff0000ff>Tip</color>] : Cilck buttons";

            DetailTextRect = GameObject.FindGameObjectWithTag("Respawn").GetComponent<RectTransform>();

            Vector2 textSize = DetailText.GetPreferredValues();
            DetailTextRect.sizeDelta = new Vector2(textSize.x, textSize.y);

            isClicked = false;
        }
        
    }
}
