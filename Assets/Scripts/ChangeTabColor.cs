using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTabColor : MonoBehaviour
{
    public void ActiveTab()
    {
        this.GetComponent<Image>().color = new Color32(250, 77, 224, 255);
    }

    public void DeactiveTabColor()
    {
        this.GetComponent<Image>().color = new Color32(41, 41, 41, 255);
    }
}
