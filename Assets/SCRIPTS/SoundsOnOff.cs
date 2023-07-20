using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;
using UnityEngine.UI;

public class SoundsOnOff : MonoBehaviour
{
    private Toggle toggle;
    public AudioListener audio;
    private void Start()
    {
        toggle = GetComponent<Toggle>();
    }
    public void setSounds()
    {
        if (toggle.isOn == true)
        {
            gameObject.transform.GetChild(1).GetComponent<Text>().text = "Выключить звук";
            audio.enabled = true;
        }
        else 
        {
            gameObject.transform.GetChild(1).GetComponent<Text>().text = "Включить звук";
            audio.enabled = false;
        }
    }
}
