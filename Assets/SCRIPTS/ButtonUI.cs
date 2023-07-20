using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonUI : MonoBehaviour
{
    public RawImage rawImage;
    public Texture image;
    public void setNewText(string words)
    {
        gameObject.GetComponentInChildren<Text>().text = words;
    }
    public void disableButton()
    {
        gameObject.SetActive(false);
    }
    public void setNewImage()
    {
        rawImage.texture = image;
    }
}
