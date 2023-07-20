using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

enum Cameras
{
    MenuCamera = 0,
    GameCamera = 1
}
public class UserInterface : MonoBehaviour
{
    public Camera[] cams;
    private string text = "Введите текст";
    private void Start()
    {
        ChangeCamera(Cameras.GameCamera);
    }
    private void OnGUI()
    {
        GUIStyle styleBox = new GUIStyle(GUI.skin.box)
        {
            fontSize = 50
        };
        GUI.Box(new Rect(10, 10, 350, 400), "Панель меню", styleBox);

        text = GUI.TextField(new Rect(Screen.width - 250, 30, 200, 40), text, 25);
        //text = GUI.TextArea(new Rect(Screen.width - 250, 30, 200, 40), text, 25);


        GUIStyle styleButton = new GUIStyle(GUI.skin.button)
        {
            fontSize = 25
        };
        if (GUI.Button(new Rect(20, 70, 310, 70), "Камера #1", styleButton))
        {
            ChangeCamera(Cameras.MenuCamera);
        }
        if (GUI.Button(new Rect(20, 170, 310, 70), "Камера #2", styleButton))
        {
            ChangeCamera(Cameras.GameCamera);
        }
    }
    void ChangeCamera(Cameras cameras)
    {
        for(int i = 0; i < cams.Length; i++)
        {
            if(i == (int)cameras)
            {
                cams[i].enabled = true;
            }
            else { cams[i].enabled = false; }
            
        }
    }
}
