// SoftwareGuy: Pulled from http://unifycommunity.com/wiki/index.php?title=Custom_Mouse_Pointer

using UnityEngine;
using System.Collections;

public class mousePointer : MonoBehaviour
{
    public Texture2D cursorImage;

    private int cursorWidth = 32;
    private int cursorHeight = 32;

    void Start()
    {
        Screen.showCursor = false;
    }


    void OnGUI()
    {
        GUI.DrawTexture(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, cursorWidth, cursorHeight), cursorImage);
    }
}